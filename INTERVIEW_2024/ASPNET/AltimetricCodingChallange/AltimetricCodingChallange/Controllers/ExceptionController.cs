using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AltimerticCodeChallenge.Controllers
{
   
    [ApiController]
    public class ExceptionController : ControllerBase
    {
        [Route("/error")]
        [HttpGet]
        public IActionResult Error()
        {
            var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();
            return Problem(
                statusCode: StatusCodes.Status500InternalServerError,
                title: exceptionFeature?.Error?.Message,
                detail: exceptionFeature?.Error?.InnerException?.Message);
        }
    }
}
