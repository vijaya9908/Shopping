using MyMobileShopping.BusinessLayer.Implementation;
using MyMobileShopping.BusinessLayer.Interfaces;
using MyMobileShopping.Models;
using System.Web.Mvc;

namespace MyMobileShopping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            ProductDetails productDetails = new ProductDetails();
            ProductsViewModel productViewModel = new ProductsViewModel();
            productViewModel.Products = productDetails.GetProducts();

            return View(productViewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}