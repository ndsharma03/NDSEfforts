using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository repo;
        
        public HomeController(IStoreRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var products = repo.Products.ToList<Product>(); ;
            ViewBag.Title = " Sport app using MVC";
            return View(products);
        }
    }
}
