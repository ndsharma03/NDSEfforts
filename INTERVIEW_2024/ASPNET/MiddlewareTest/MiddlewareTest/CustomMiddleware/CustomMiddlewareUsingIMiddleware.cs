namespace MiddlewareTest.CustomMiddleware
{
    public class CustomMiddlewareUsingIMiddleware : IMiddleware
    {
        public CustomMiddlewareUsingIMiddleware()
        {
            Console.WriteLine("CTOR: IMIDDLEWARE CLASS");
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
             Console.WriteLine("Enter:   CustomMiddlewareUsingIMiddleware");
            await next(context);
            Console.WriteLine("Exit: CustomMiddlewareUsingIMiddleware");
        }
    }
}
