using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var _product = new Product {
                ID = 1,
                Name = "Каяк",
                Description = "Лодка для одного человека",
                Category = "Водный спорт",
                Price = 275m
            };
            ViewBag.StockLevel = 2;
            return View(_product);
        }
    }
}