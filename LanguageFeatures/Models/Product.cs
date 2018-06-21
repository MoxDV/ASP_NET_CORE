using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Category { get; set; } = "Водный спорт";

        public static Product[] GetProducts() {
            return new[] {
                new Product{ Name = "Каяк", Price = 275m, Category = "Гидроцикл" },
                new Product{ Name = "Спасательный жилет", Price = 48.95m },
                null,
                new Product {Name = "Футбольный мяч", Price = 19.50m},
                new Product {Name = "Угловой флаг", Price = 34.95m}
            };
        }
    }
}
