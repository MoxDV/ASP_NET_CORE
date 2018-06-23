using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository _sharedRep = new SimpleRepository();
        public static SimpleRepository SampleRepository => _sharedRep;

        private Dictionary<string, Product> _products = new Dictionary<string, Product>();

        public SimpleRepository() {
            var _prdcts = new[] {
                new Product{ Name = "Каяк", Price = 275m },
                new Product{ Name = "Спасательный жилет", Price = 48.95m },
                new Product{ Name = "Футбоольгый мяч", Price = 19.50m },
                new Product{ Name = "Угловой флаг", Price = 34.95m }
            };
            foreach (var p in _prdcts)
                AddProduct(p);
            _products.Add("Error", null);
        }

        public IEnumerable<Product> Products => _products.Values;

        public void AddProduct(Product product) => _products.Add(product.Name, product);
    }
}
