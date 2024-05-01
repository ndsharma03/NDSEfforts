using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiFilters2020.Polymorphism;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using System.Collections;
using System.Linq.Expressions;

namespace WebApiFilters2020.Controllers
{
    [Route("api/[controller]")]
    public class PolymorphicController : Controller
    {
        IMyService service;
        public PolymorphicController(IEnumerable<IMyService> iMySerivces)
        {
            // way 1: service = iMySerivces.ElementAt(1);
            // Way 2: 
            service = iMySerivces.FirstOrDefault(x => x.GetType().Name == "MyService2")
;        }
        

        
        // GET: api/<controller>
        [HttpGet]
        public string Get([FromHeader]string name)
        {
            return service.AppendHello(name);
        }



        /// <summary>
        /// // Test DAta:
        // <Employee>
        //	< Id > 89 </ Id >
        //    < Name > Kaju </ Name >
        //</ Employee >
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        [Route("CheckEmployee")]
        public string CheckModelBindingForEmp([FromBody] Employee e)
        {
            string name = e?.Name; //Note=> in xml element : data format should be correct "name" will not work it needs "Name"
                                   // Not all property of an object requires 
            return name;

        
        }
        
    }
}
