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
                MobileName = "Iphone 11",
                MobilePrice = 78000M
            },
            new Product
            {
                MobileName = "One Plus",
                MobilePrice = 48000M
            },
            };
            return products;

        }
    }
}
