using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using System.Collections;

namespace FinalProject.Controllers
{
    public class CartController : Controller
    {
        private ProductContext context { get; set; }
        private ArrayList products { get; set; }

        public CartController (ProductContext context)
        {
            this.context=context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Cart");
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            products.Add(product);
            return View("Home");
        }
    }
}
