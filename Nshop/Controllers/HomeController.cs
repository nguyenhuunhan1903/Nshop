using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Nshop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Nshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private NShopContext db = new NShopContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(IEnumerable<Nshop.Models.Products> products)
        {
            products = db.Products;
            return View("Index",products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
         public IActionResult OpenLogin()
        {
            return View("Login");
        }
        public IActionResult OpenSignUp()
        {
            return View("Signup");
        }
        public IActionResult OpenProfile()
        {
            return View("Profile");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
