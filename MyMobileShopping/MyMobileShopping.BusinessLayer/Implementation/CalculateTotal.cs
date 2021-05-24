using MyMobileShopping.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class CalculateTotal : ICalculateTotal
    {
        public decimal GetTotal(decimal subtotal, decimal tax, decimal discount)
        {
            return subtotal + tax - discount;
        }
    }
}
