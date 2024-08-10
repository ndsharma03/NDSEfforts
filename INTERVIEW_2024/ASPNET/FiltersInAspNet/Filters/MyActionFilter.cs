using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersInAspNet.Filters
{
    public class MyActionFilter : IActionFilter
    {
        public MyActionFilter()
        {
            Console.WriteLine("%%%%%%%%%%%%%%% MyActionFilter instance id:" +Guid.NewGuid());
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("######## OnActionExecuted ###########");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("######## OnActionExecuting ###########");

            //Prinintg Dispaly name of ACtion.
            Console.WriteLine("Prinintg Dispaly name of Action");
            Console.WriteLine(context.ActionDescriptor.DisplayName);

            //Prinitng action arguments
            Console.WriteLine("Prinitng action arguments:");
            foreach (var item in context.ActionArguments)
            {
                Console.WriteLine(item.Key +"-"+ item.Value);
            }
            //prinintg route values.
            Console.WriteLine("Prinintg route values :");
            foreach (var rv in context.ActionDescriptor.RouteValues)
            {
                Console.WriteLine(rv.Key + "-" + rv.Value);

            }
            //Prinintg route values from RouteData.
            Console.WriteLine("Prinintg route values from RouteData :");
            var routeData = context.RouteData;
           foreach(var rv in routeData.Values)
            {
                Console.WriteLine(rv.Key + "-" + rv.Value);
            }
            var modelState = context.ModelState;
            var modelKeys = modelState.Keys;
            var modelValues = modelState.Values;
            foreach(var k in modelKeys)
            {
                Console.WriteLine(k);
            }
            foreach (var v in modelValues)
            {
                Console.WriteLine(v);
            }

            //Prinitng Endpoint MetaData
            Console.WriteLine("Prinitng Endpoint MetaData :");
            foreach (var md in context.ActionDescriptor.EndpointMetadata)
            {
                Console.WriteLine(md);
            }
           
            //Printing Properties
            Console.WriteLine("Printing Properties :");
          foreach (var prop in context.ActionDescriptor.Properties)
            {
                Console.WriteLine(prop.Key +"==" +prop.Value);
            }
        }
    }
}
