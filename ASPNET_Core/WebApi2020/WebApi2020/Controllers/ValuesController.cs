using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi2020.Controllers
{

    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        // GET api/values
        [HttpGet("emp")]
        public Emp GetEmp([FromQuery] int id)
         {
            throw new ArgumentException(" Invalid Argument");
            //var _id = Convert.ToInt32(id);
            return new Emp { Id = 1, Name = "niranjan" };
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
