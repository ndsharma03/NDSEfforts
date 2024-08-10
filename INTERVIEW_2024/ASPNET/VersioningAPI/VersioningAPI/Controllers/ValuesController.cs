using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VersioningAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]//Url segment versioning, This controller will not support Query and Header version reader
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class ValuesController : ControllerBase
    {

        [HttpGet("{name}")]
        [MapToApiVersion(2.0)]
        public IActionResult Get(string name)
        {
            return Ok("Hello " + name);
        }

        [HttpGet()]
        [MapToApiVersion(1.0)]
       
        public IActionResult Get()
        {
            return Ok("Hello");
        }
    }
}
