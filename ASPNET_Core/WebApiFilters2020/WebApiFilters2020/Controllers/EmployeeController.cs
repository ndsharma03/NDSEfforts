using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiFilters2020.Filters;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiFilters2020.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        [AddHeader("NDS","Niranjan Dev Sharma")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [Route("St")] //We can create multiple GET methods and to differentiate them we need to use [Route()]
        [AcceptVerbs("GET","PATCH")]
        [ShortCircuitingResourceFilter]
        public void ShortCircutingTest()
        {
            Console.WriteLine(" This method will never be called because of filter");
        }
        
        
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return new ObjectResult(new Employee { Id = 100, Name = "Niranjan Sharma", Salary = 500000 });
        }

        // POST method is used to test CustomResourceFilter
        [HttpPost]
        [CustomResourceFilter]
        public void Post([FromBody]Employee emp)
        {
            Console.WriteLine(emp.Id + " " + emp.Name);
        }
        
    }
}
