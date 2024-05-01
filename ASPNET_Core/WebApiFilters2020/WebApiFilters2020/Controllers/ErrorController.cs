using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiFilters2020.Controllers
{
    [Route("/Error")]
    public class ErrorController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult ErrorAcrion()
        {
            var feature=HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var err=feature.Error;
            return StatusCode(400, err.Message);
        }
    }
}
