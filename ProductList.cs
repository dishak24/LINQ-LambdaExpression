using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    class ProductList
    {
        List<Product> products = new List<Product>()
        {
            new Product { Name = "Laptop", StockQuantity = 50 },
            new Product { Name = "Smartphone", StockQuantity = 20 },
            new Product { Name = "Tablet", StockQuantity = 0 },
            new Product { Name = "Headphones", StockQuantity = 70 }

        };

        public void FindOutOfStockProduct()
        {
            var outOfStockProducts = products
                                     .Where(p => p.StockQuantity == 0)
                                     .Select(p => p.Name)
                                     .ToList();

            Console.WriteLine("Out of Stock Products:");
            foreach (var productName in outOfStockProducts)
            {
                Console.WriteLine(productName);
            }
        }
    }
}
