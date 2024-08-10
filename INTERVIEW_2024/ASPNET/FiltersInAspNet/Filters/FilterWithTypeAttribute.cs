using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace FiltersInAspNet.Filters
{
    public class RecipeService
    {
        public int recipeId { get; set; }
        public bool DoesRecipeExist(int recipeId)
        {
            return true;
        }
    }
    public class EnsureRecipeExistsFilter : IActionFilter
    {
        private readonly RecipeService _service;
        public EnsureRecipeExistsFilter(RecipeService service)
        {
            _service = service;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var recipeId = (int)context.ActionArguments["id"];
            if (!_service.DoesRecipeExist(recipeId))
            {
                context.Result = new NotFoundResult();
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }

    // below code to use above filter as Attribute, Above filer we can register globally without needing below attribute.
    public class EnsureRecipeExistsAttribute : TypeFilterAttribute
    {
        public EnsureRecipeExistsAttribute()
        : base(typeof(EnsureRecipeExistsFilter)) { }
    }
}
