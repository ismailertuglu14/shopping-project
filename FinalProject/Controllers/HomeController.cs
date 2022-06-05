using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext context { get; set; }

        public HomeController(ProductContext context)
        {
            this.context=context;
        }

        public IActionResult Index()
        {
            var products = context.Products.Include(p => p.Category).Include(p=> p.Colour).OrderBy(p => p.ProductName).ToList();
            return View(products);
        }
    }
}