namespace FiltersInAspNet.Filters
{
    public class FilterSummery_Notes
    {
        /*
         * Summary
 The filter pipeline executes as part of MvcMiddleware after routing has selected an action method.
 The filter pipeline consists of authorization filters, resource filters, action filters, exception filters, and Result filters. Each filter type is grouped into a stage.
 Resource, action, and result filters run twice in the pipeline: an *Executing method on the way in and an *Executed method on the way out.
 Authorization and exception filters only run once as part of the pipeline; they don’t run after a response has been generated.
 Each type of filter has both a sync and an async version. For example, resource filters can implement either the IResourceFilter interface or the IAsyncResourceFilter interface. You should use the synchronous interface unless
your filter needs to use asynchronous method calls.

 You can add filters globally, at the controller level, or at the action level. This is
called the scope of the filter.
 Within a given stage, global-scoped filters run first, then controller-scoped, and
finally, action-scoped.
 You can override the default order by implementing the IOrderedFilter interface. Filters will run from lowest to highest Order and use scope to break ties.
 Authorization filters run first in the pipeline and control access to APIs.
ASP.NET Core includes an [Authorization] attribute that you can apply to
action methods so that only logged-in users can execute the action.
 Resource filters run after authorization filters, and again after a result has been
executed. They can be used to short-circuit the pipeline, so that an action
method is never executed. They can also be used to customize the model binding process for an action method.
 Action filters run after model binding has occurred, just before an action
method executes. They also run after the action method has executed. They can
be used to extract common code out of an action method to prevent duplication. 
 The Controller base class also implements IActionFilter and IAsyncActionFilter. They run at the start and end of the action filter pipeline, regardless of
the ordering or scope of other action filters.
 Exception filters execute after action filters, when an action method has thrown
an exception. They can be used to provide custom error handling specific to
the action executed. 
 Generally, you should handle exceptions at the middleware level, but exception
filters let you customize how you handle exceptions for specific actions or
controllers.
 Result filters run just before and after an IActionResult is executed. You can
use them to control how the action result is executed, or to completely change
the action result that will be executed.
 You can use ServiceFilterAttribute and TypeFilterAttribute to allow
dependency injection in your custom filters. ServiceFilterAttribute requires
that you register your filter and all its dependencies with the DI container,
whereas TypeFilterAttribute only requires that the filter’s dependencies have
been registered
         */
    }
}
