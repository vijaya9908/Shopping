using MyMobileShopping.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class ProductDetails : IProductDetails
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()

           {
            new Product
            {
                Name = "Iphone 11",
                Amount = 78000M
            },
            new Product
            {
                Name = "One Plus",
                Amount = 48000M
            },
            new Product
            {
               Name = "Iphone 12",
                Amount = 98000M
            },
            new Product
            {
                Name = "One Plus pro",
                Amount = 58000M
            },
            };
            return products;

        }
    }
}
