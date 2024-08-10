using FiltersInAspNet.Filters;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FiltersInAspNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(MyActionFilter),Order =3)] // This will create filter instance on each request.
    [TypeFilter(typeof(MyResourceFilter))]
    [CustAction] // Singleton instance.
    [ResultFilter]
    [ServiceFilter(typeof(MyResourceFilter))]// to use filter in service filter, first need to regiser filter via DI.
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee e)
        {
            return Ok(e);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
