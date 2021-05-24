using MyMobileShopping.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyMobileShopping.Models
{
    public class ProductsViewModel
    {
        public List<Product> Products { get; set; }
    }
}