namespace MiddlewareTest.CustomMiddleware
{
    public class ConventionCustomMiddleware
    {
        private readonly RequestDelegate next;

        public ConventionCustomMiddleware(RequestDelegate next)
        {
            Console.WriteLine("CTOR:ConventionCustomMiddleware");
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Enter : ConventionCustomMiddleware");
            await next(context);
            Console.WriteLine("Exit : ConventionCustomMiddleware");
        }
    }
}
