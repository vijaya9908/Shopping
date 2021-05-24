using MyMobileShopping.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class CalculateSubTotal : ICalculateSubTotal
    {
        public decimal GetSubTotal(List<Product> products)
        {
            decimal subTotal = 0;

            foreach (Product product in products)
            {

                subTotal = subTotal + product.Amount;

            }
            return subTotal;
        }
    }
}
