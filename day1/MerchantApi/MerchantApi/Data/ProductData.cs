using MerchantApi.Models;
using System.Collections.Generic;

namespace MerchantApi.Data
{
    public class ProductData
    {
        public static readonly IDictionary<string, Product> List = new Dictionary<string, Product>
        {
            {"1", new Product { Id= "1", Cost = 1, Revenue = 11, SellPrice = 21 } },
            {"2", new Product { Id= "2", Cost = 2, Revenue = 12, SellPrice = 22 } },
            {"3", new Product { Id= "3", Cost = 3, Revenue = 13, SellPrice = 23 } },
            {"4", new Product { Id= "4", Cost = 4, Revenue = 14, SellPrice = 24 } },
            {"5", new Product { Id= "5", Cost = 5, Revenue = 15, SellPrice = 25 } },
            {"6", new Product { Id= "6", Cost = 6, Revenue = 16, SellPrice = 26 } },
            {"7", new Product { Id= "7", Cost = 7, Revenue = 17, SellPrice = 27 } },
            {"8", new Product { Id= "8", Cost = 8, Revenue = 18, SellPrice = 28 } },
            {"9", new Product { Id= "9", Cost = 9, Revenue = 19, SellPrice = 29 } },
            {"10", new Product { Id= "10", Cost = 10, Revenue = 20, SellPrice = 30 } },
            {"11", new Product { Id= "11", Cost = 11, Revenue = 21, SellPrice = 31 } }
        };
    }
}
