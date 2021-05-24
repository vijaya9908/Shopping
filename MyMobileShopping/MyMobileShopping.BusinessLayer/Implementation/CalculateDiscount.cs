using MyMobileShopping.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class CalculateDiscount : ICalculateDiscount
    {
        public decimal GetDiscount(decimal SubTotal)
        {
            decimal discount = 0;

            if (SubTotal < 10000)
            {
                discount = SubTotal * 20 / 100;
            }
            else if (SubTotal >= 10000 && SubTotal <= 15000)
            {
                discount = SubTotal * 15 / 100;
            }
            else
            {
                discount = SubTotal * 10 / 100;
            }

            return discount;
        }
    }
}
