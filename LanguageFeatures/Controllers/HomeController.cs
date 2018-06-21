using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            /*var result = new List<string>();
            foreach (var _p in Product.GetProducts())
                result.Add(string.Format("Название: {0}, Цена: {1}, Категория: {2}",
                    _p?.Name ?? "<No name>", _p?.Price ?? 0m, _p?.Category ?? "<No category>"));*/

            /*var _carts = new ShoppingCart { Products = Product.GetProducts() };
            Product[] _arrProd = _carts.Products.ToArray();
            var result = new[] { $"Cart итого: {_carts.TotalPrice():C2}", $"Array total: {_arrProd.TotalPrice():C2}" };*/

            var result = new []{ $"Итого в массиве: {Product.GetProducts().FilterByPrice(20).TotalPrice()}" };

            return View(result);
        }

        public ViewResult About() => View("Index", Product.GetProducts().Select(p => p?.Name));

        public async Task<ViewResult> Contact() =>
            View("Index", new[] { $"Length: { await MyExtensionMethods.GetPageLength() }" });
    }
}