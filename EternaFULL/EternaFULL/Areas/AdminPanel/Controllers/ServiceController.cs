using EternaFULL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFULL.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ServiceController : Controller
    {
        DataContext _context;
        public ServiceController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Service service)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            _context.Services.Add(service);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Update(int id)
        {
            Service service = _context.Services.FirstOrDefault(x => x.Id == id);
            return View(service);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Service service)
        {
            Service oldservice = _context.Services.FirstOrDefault(x => x.Id == service.Id);
            if(oldservice==null)
            {
                return View();
            }
            oldservice.Name = service.Name;
            oldservice.Desc = service.Desc;
            oldservice.Icon = service.Icon;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            Service service = _context.Services.FirstOrDefault(x => x.Id == id);
            return View(service);
        }
        [HttpPost]
        public IActionResult Delete(Service service)
        {
            Service service1 = _context.Services.FirstOrDefault(x => x.Id == service.Id);
            _context.Services.Remove(service1);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
