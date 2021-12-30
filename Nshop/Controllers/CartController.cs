using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nshop.Controllers
{
    public class CartController : Controller
    {

        
        public IActionResult Index()
        {
            
            return View("CartProduct");
        }

        public IActionResult AddOrder(int id)
        {
            
            return View("CartProduct");
        }
    }
}
