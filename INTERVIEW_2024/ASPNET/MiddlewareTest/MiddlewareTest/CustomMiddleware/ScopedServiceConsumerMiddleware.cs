using MiddlewareTest.Services;
using System.Runtime.CompilerServices;

namespace MiddlewareTest.CustomMiddleware
{
    public class ScopedServiceConsumerMiddleware
    {
        private RequestDelegate next;
        private  IScopedServiceClass ssc;

        //Remember : You can't inject scoped service via constructor injection
        public ScopedServiceConsumerMiddleware(RequestDelegate next)
        {
            
            Console.WriteLine("ScopedServiceConsumerMiddleware instance created!");
            this.next = next;
           
        }

        public async Task InvokeAsync(HttpContext context, IScopedServiceClass ssc) {
            this.ssc = ssc;
            await ssc.DoSomething("From Conventional Middleware.");
            await next(context);
        }
    }
}
