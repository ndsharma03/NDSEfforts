using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi2020.Controllers
{
    [Route("/Error")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
       public IActionResult ErrorResult()
        {
            var feature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var ex = feature?.Error;
           // var isDev = webHostEnvironment.IsDevelopment();
            var problemDetails = new ProblemDetails
            {
                Status = (int)HttpStatusCode.InternalServerError,
                Instance = feature?.Path,
                Title =  $"{ex.GetType().Name}: {ex.Message}" ,
                Detail =  ex.StackTrace ,
            };

            return StatusCode(problemDetails.Status.Value, problemDetails);
        }
        
    }
}