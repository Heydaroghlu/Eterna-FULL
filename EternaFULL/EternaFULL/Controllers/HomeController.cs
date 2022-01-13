using EternaFULL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFULL.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
       

        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }

    }
}
