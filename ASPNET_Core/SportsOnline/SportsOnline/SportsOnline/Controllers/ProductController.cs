using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SportsOnline.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsOnline.Controllers
{
    public class ProductController : Controller
    {
        int pageSize = 2;
        IProductRepository productRepository;
        //private readonly IMyClass myclass;

        // public ProductController(IProductRepository productRepository,IMyClass myclass) //Just trying to access MyClass Property.
        public ProductController(IProductRepository productRepository)
         {
            this.productRepository = productRepository;
            //this.myclass = myclass;
            //ViewBag.CustomTitle = "from constructor"; //We can not set ViewBag/ViewData in Constructor.
           
        }


        public ViewResult List(int pageNumber=1)
        {
            // ViewBag.CustomTitle = myclass.Title;
            //return View(productRepository.Products.OrderBy(x => x.ProductID)
            //                .Skip((pageNumber - 1) * pageSize)
            //                .Take(pageSize)
            //    );
            return View(productRepository.Products.OrderBy(x => x.ProductID)
                         .Skip(2)
                         .Take(1)
             );

        }
    }
}
