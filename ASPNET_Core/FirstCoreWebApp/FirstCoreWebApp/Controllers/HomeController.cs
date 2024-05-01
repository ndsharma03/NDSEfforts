using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstCoreWebApp.Models;

namespace FirstCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            ViewBag.Name = "Pranamya";
            return View("Test");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ViewResult Employees()
        {
            ViewBag.FromContext = HttpContext.Request.Headers["User-Agent"].ToString();
            ViewBag.First = "Passing data to view from controller via ViewBeg";
            ViewData["Second"] = "Passing data to view via ViewData";
            return View();
        }
    }
}
