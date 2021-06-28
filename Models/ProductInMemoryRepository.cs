using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tata_Power_App.Models
{
    public class ProductInMemoryRepository : IStoreRepository
    {
        static List<Product> prdcts = new List<Product>
        {
            new Product
            {
                productId = 1, productName = "Groceries"
            },
            new Product
            {
                productId = 2, productName = "Electronics"
            },
            new Product
            {
                productId = 3, productName = "Mobiles"
            }

        };

        //Implemented methods from interface IStoreRepository
        public IEnumerable<Product> products =>
            prdcts;
    }
}
