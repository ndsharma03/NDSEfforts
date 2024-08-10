using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Reflection;

namespace FiltersInAspNet.Filters
{
    public class MyResourceFilter : IResourceFilter
    {
        public MyResourceFilter()
        {
            Console.WriteLine(" %%%%%%%%%%%%%%% MyResourceFilter instance Id:"+Guid.NewGuid());
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {

            //==> NOTE WE CAN'T SET RESPONSE LIKE BELOW: --> System.InvalidOperationException: Headers are read-only, response has already started.
            if (!context.ModelState.IsValid)
            {
                Console.WriteLine("######### OnResourceExecuted #########");
                var emp = new Employee
                {
                    Id = 3,
                    Email = "abc@gmail.com",
                    FirstName = "Testing REsource filer",
                    LastName = "Changing emp object"
                };
                //context.Result =((IConvertToActionResult)( new ActionResult<Employee>(emp))).Convert();
                context.HttpContext.Response.WriteAsJsonAsync < Employee>(emp);

                ////Gocha: BELOW line will write string after validation erroe messages in response.
                //context.HttpContext.Response.WriteAsync("String willl be written in responese!");

            }

            //Below code will not change result.
            //var result = context.Result as OkObjectResult;
            //var eresult = result?.Value as Employee;
            //eresult!.Email = "test@test.com";
            
            //Summary we can't change response from here.
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("######### OnResourceExecuting #########");
        }
    }
}
