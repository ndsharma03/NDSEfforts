using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FiltersInAspNet.Filters
{
    public class ResultFilter:ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("************* Changing the result from result filter");
            var emp = new Employee
            {
                Id = 3,
                Email = "abc@gmail.com",
                FirstName = "Testing REsource filer",
                LastName = "Changing emp object"
            };
            context.Result =((IConvertToActionResult)( new ActionResult<Employee>(emp))).Convert();
            //context.HttpContext.Response.WriteAsJsonAsync<Employee>(emp);
            base.OnResultExecuting(context);
        }
    }
}
