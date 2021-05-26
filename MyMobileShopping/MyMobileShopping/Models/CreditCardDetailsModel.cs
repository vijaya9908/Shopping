using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyMobileShopping.Models
{
    public class CreditCardDetailsModel
    {
        public string CardNumber { get; set; }
        public string CVVNumber { get; set; }
        public string ExpiryDate { get; set; }


    }
}