using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMobileShopping.BusinessLayer.Interfaces
{
    public interface ICalculateSubTotal
    {
        decimal GetSubTotal(List<Product> products);
    }
}
