
using Microsoft.AspNetCore.Builder;
using MiddlewareTest.CustomMiddleware;
using MiddlewareTest.Services;

namespace MiddlewareTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<CustomMiddlewareUsingIMiddleware>();

            //Adding scoped service.
            builder.Services.AddScoped<IScopedServiceClass, ScopedServiceClass>();
            
            var app = builder.Build();


            // ********* Braching the request pipeline.
            app.Map("/map1", NewPipelingUsingMap);

            app.Map("/map2", NewPipelineUsingMapWithUse);

            //********** Map When *************
            app.MapWhen(context => context.Request.Query.ContainsKey("q"), CallForMapWhen);

            // ********** antoerh way to create middleware using USE
            //App.UseWhen will re-join the current pipeline. 

            app.UseWhen(context => context.Request.Query.ContainsKey("n"), CallWithUseWhen);

            app.Use(async (context, next) =>
            {
                await Console.Out.WriteLineAsync("***********" + context.Request.Path.Value + "**************");
                Console.WriteLine("before next : Inside default pipeline's Use ");
                await next(context);
                Console.WriteLine("After next : Inside default pipeline's Use ");

            });

            // Note: For conventional middleware don't need to register with DI.just need below instrunction.
            app.UseMiddleware<ConventionCustomMiddleware>();

            //Registration with DI required to use below middleware.
            app.UseMiddleware<CustomMiddlewareUsingIMiddleware>();

            //*****Special case *********
                    //Scoped lifetime services used by middleware constructors aren't shared with other dependency-injected types during each request.
                    //To share a scoped service between middleware and other types, add these services to the InvokeAsync method's signature.
                    //The InvokeAsync method can accept additional parameters that are populated by DI.
                    app.UseMiddleware<ScopedServiceConsumerMiddleware>(); //this middleware calls scoped service in Invoke();

                    app.Use(async (context, next) =>
                    {
                        var scopedserviceInstance = context.RequestServices.GetRequiredService<IScopedServiceClass>(); // calling scoped service.
                        await scopedserviceInstance.DoSomething("From Inline (USE) Middleware.");
                        await next();
                    });
            //--** End Special case **

            //********** Simplest terminator middleware
            app.Run(async context => await context.Response.WriteAsync("Jai Mata Di "));
            app.Run();
        }

        private static void CallWithUseWhen(IApplicationBuilder app)
        {
            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Before going back to original pipeline");
            //    await next(context);
            //    Console.WriteLine("after going back to original pipeline");
            //});
            app.Run(async context=> await context.Response.WriteAsync("EXit from USEWHEN"));
        }


        // MAPPED PIPELINE USING 'USE; AND TERMINATOR MIDDLEWARE 'RUN'
        private static void NewPipelineUsingMapWithUse(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                Console.WriteLine(" Before next in Mapped pipeline");
                await next(context);
                
                await Console.Out.WriteLineAsync("after next in mapped pipline");

            });
            //EXCEPTION IF WE WILL NOT PROVIDE TERMINATOR MIDDLEWARE AS WE HAVE CALLED NEXT IN 'USE'.
           app.Run(async context =>
           {
               await context.Response.WriteAsync("Good bye from Mapped pipeline Use+Run ");
               await Console.Out.WriteLineAsync("Good bye from Mapped pipeline Use+Run");

           }
           );
        }

        private static void NewPipelingUsingMap(IApplicationBuilder app)
        {
            Console.WriteLine("Hello from NewPipelingUsingMap!");
            app.Run(async context => await context.Response.WriteAsync("Hello from Mapped!"));
        }

        private static void CallForMapWhen(IApplicationBuilder app)
        {
            Console.WriteLine("Hello from MapWhen!");
            app.Run(async context => await context.Response.WriteAsync("Hello from MapWhen!"));
        }
        
    }
}