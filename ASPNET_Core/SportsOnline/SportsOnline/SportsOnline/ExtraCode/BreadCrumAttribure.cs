//The following example assumes that you always derive your controllers from Controller base class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsOnline.Models;

using Microsoft.AspNetCore.Mvc.Filters;

//public class BreadCrumbAttribute : IActionFilter
//{
//    private readonly string _name;

//    public BreadCrumbAttribute(string name)
//    {
//        _name = name;
//    }

//    public void OnActionExecuting(ActionExecutingContext context)
//    {
//        base.OnActionExecuting(context);

//        var controller = context.Controller as Controller;
//        if (controller != null)
//        {
//            controller.ViewBag.BreadcrumbCategory = _name;
//        }
//    }
//}
////Now you should be able to decorate your controller with it.

//[BreadCrumb("MyCategory")]
//class MyController : Controller
//{
//}
