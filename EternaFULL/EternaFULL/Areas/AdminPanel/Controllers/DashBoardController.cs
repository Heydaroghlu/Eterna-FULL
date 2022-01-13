using EternaFULL.Areas.AdminPanel.ViewModels;
using EternaFULL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFULL.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
   
    public class DashBoardController : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;
        public DashBoardController(RoleManager<IdentityRole> roleManager,UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AdminLoginViewModel loginVM)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            AppUser user = await _userManager.FindByNameAsync(loginVM.UserName);
            if(user==null)
            {
                ModelState.AddModelError("", "UserName or Passowrd is incorrect!");
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Passowrd is incorrect!");
                return View();
            }
            return RedirectToAction("index", "dashboard");

        }
       /* public async Task<IActionResult> CreateRole()
        {
            IdentityRole role1 = new IdentityRole("Admin");
            IdentityRole role2 = new IdentityRole("Mmeber");
            await _roleManager.CreateAsync(role2);
            await _roleManager.CreateAsync(role1);
            return Ok();
        }
        public async Task<IActionResult> CreateAdmin()
        {
            AppUser appUser = new AppUser
            {
                FullName = "Admin",
                UserName = "Admin"
            };
            var result = await _userManager.CreateAsync(appUser, "Admin123");
            return Ok(result);
        }*/
    }
}
