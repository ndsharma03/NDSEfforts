using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VersioningAPI.Controllers

    [Route("api/[controller]")] //==> This controller will support Query string and Header version Reader
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [ApiVersion(1.0)]
        public IActionResult GetName()
        {
            return Ok("My Name is John!");
        }

        [HttpGet]
        [ApiVersion(2.0)]
        public IActionResult GetName(string Name)
        {
            return Ok($"Hello {Name}");
        }
    }
}
