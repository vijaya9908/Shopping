using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMobileShopping.BusinessLayer.Interfaces
{
   public  interface ICalculateDiscount
    {
        decimal GetDiscount(decimal SubTotal);
    }
}
