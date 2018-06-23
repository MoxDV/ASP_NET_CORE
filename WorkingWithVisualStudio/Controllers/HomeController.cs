using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVisualStudio.Models;

namespace WorkingWithVisualStudio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(SimpleRepository.SampleRepository.Products.Where(p => p?.Price < 50));
        }
    }
}