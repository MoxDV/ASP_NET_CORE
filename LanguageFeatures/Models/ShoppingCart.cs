using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class ShoppingCart : IEnumerable<Product>
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator() {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }

    public static class MyExtensionMethods {
        public static decimal TotalPrice(this IEnumerable<Product> products) {
            return products.Sum(i => (i?.Price ?? 0m));
        }

        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> products, decimal minPrice) {
            foreach(var _p in products) {
                if ((_p?.Price ?? 0m) >= minPrice)
                    yield return _p;
            }
        }

        public static async Task<long?> GetPageLength() {
            var _client = new HttpClient();
            var _httpMessage = await _client.GetAsync("http://apress.com/");
            // Во время выполнения HTTP-запроса можно было бы делать другую работу.
            return _httpMessage.Content.Headers.ContentLength;
        }
    }
}
