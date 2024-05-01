using ASP_NET_MVC_Introduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Introduction.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie _movie = new Movie() { Id=1, Name = "Red Rose!" };
            return View(_movie);
        }
    }
}