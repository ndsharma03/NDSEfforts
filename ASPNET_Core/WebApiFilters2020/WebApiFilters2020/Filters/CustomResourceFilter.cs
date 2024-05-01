using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace WebApiFilters2020.Filters
{

    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class CustomResourceFilterAttribute : Attribute,IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            
        }
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            using (var reader = new StreamReader(context.HttpContext.Request.Body))
            {
                var body = reader.ReadToEnd(); // WE CAN FILTER PASSED PARAMETER HERE.

                
                // Convert string (json to object and change attribute)
            }
            //WE can make this Filter as a Terminator-ShortCircuting request:

            //context.Result=new StatusCodeResult(201) ;
        }
    }
}
