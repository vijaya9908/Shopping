using MyMobileShopping.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMobileShopping.BusinessLayer.Implementation
{
    public class CalculateTax : ICalculateTax
    {
        public decimal GetTax(decimal subTotal)
        {
            return subTotal * 18 / 100;
        }
    }
}
