using MyMobileShopping.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMobileShopping.Models
{
    public class CartViewModel
    {
        public List<Product> Products { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
    }
}