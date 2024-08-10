using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersInAspNet.Filters
{

    /// <summary>
    /// filter using Attribute.
    /// </summary>
    public class CustActionAttribute:ActionFilterAttribute
    {
        public CustActionAttribute()
        {
            Console.WriteLine("%%%%%%%%%%% CustActionAttribute Instance Id" + Guid.NewGuid());
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            
            base.OnActionExecuting(context);
            Console.WriteLine("**************** > Applying CustACtionAttribute <********************");
        }
    }
}
