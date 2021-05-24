using MyMobileShopping.BusinessLayer;
using MyMobileShopping.BusinessLayer.Interfaces;
using MyMobileShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMobileShopping.Controllers
{
    
    public class CartController : Controller
    {
        private readonly ICalculateCartFlow calculateCartFlow;
        public CartController(ICalculateCartFlow calculateCartFlow)
        {
            this.calculateCartFlow = calculateCartFlow;
        }
       // GET: Cart
       public ActionResult Index()
        {
            List<Product> products = (List<Product>)Session["CartItems"] ?? new List<Product>();
            CartModel cartModel = calculateCartFlow.Calculate(products);
            CartViewModel cartViewModel = new CartViewModel
            {
                Products = cartModel.Products,
                Discount = cartModel.Discount,
                SubTotal = cartModel.SubTotal,
                Tax = cartModel.Tax,
                Total = cartModel.Total
            };
            return View(cartViewModel);
        }
        [HttpPost]
        public ActionResult AddToCart(Product product)
        {
            List<Product> products = (List<Product>)Session["CartItems"];

            if (products == null)
            {
                products = new List<Product>();
            }

            products.Add(product);
            Session["CartItems"] = products;
            return PartialView("~/Views/Home/_ProductSuccessModal.cshtml", product);
        }

    }
}