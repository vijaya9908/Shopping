using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMobileShopping.BusinessLayer
{
   public class CartModel
    {
        public List<Product> Products { get; set; }
        public decimal SubTotal { get;set }
        public decimal Tax { get; set }
        public decimal Discount { get; set }
        public decimal Total { get; set }
    }
}
