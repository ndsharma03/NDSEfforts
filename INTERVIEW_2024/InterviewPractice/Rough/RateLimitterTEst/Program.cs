
using Microsoft.AspNetCore.RateLimiting;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.RateLimiting;

namespace RateLimitterTEst
{
  
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<ISingleton, Singleton>();
            builder.Services.AddTransient<ITransient, Transient>();
            builder.Services.AddTransient<ITransientA, TransientA>();
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.Use(async (context, next) =>
            {
                Console.WriteLine("Custom middleware before");
                Console.WriteLine(JsonSerializer.Serialize(context.Request));
                await next(context);
               
                Console.WriteLine("Custom middleware After!");
            });

            app.UseRouting();

             app.MapGet("/", (ISingleton service,ITransient transient , ITransientA transientA) => {
           // app.MapGet("/", (ISingleton service,  ITransientA transientA) => {
                service.SingltonMethod();

                transientA.TransientMethod();
                Console.WriteLine("transientA hashcode :"+ transientA.GetHashCode());
                transient.TransientMethod();
                 Console.WriteLine("transient hashcode :" + transient.GetHashCode());

             });
            app.Run();



            //    // Add services to the container.
            //    builder.Services.AddAuthorization();

            //    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //    builder.Services.AddEndpointsApiExplorer();
            //    builder.Services.AddSwaggerGen();
            //    //************ Rate Lmitter *************
            //    //builder.Services.Configure<MyRateLimitOptions>(
            //    //builder.Configuration.GetSection(MyRateLimitOptions.MyRateLimit));

            //    //****************Fixed Window **************
            //    var myOptions = new MyRateLimitOptions();
            //    var temp = builder.Configuration.GetSection(MyRateLimitOptions.MyRateLimit);
            //    builder.Configuration.GetSection(MyRateLimitOptions.MyRateLimit).Bind(myOptions);
            //    var fixedPolicy = "fixed";

            //    builder.Services.AddRateLimiter(_ => _
            //        .AddFixedWindowLimiter(policyName: fixedPolicy, options =>
            //        {
            //            options.PermitLimit = myOptions.PermitLimit;
            //            options.Window = TimeSpan.FromSeconds(myOptions.Window);
            //            options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
            //            options.QueueLimit = myOptions.QueueLimit;

            //        }


            //        ));

            //    // ******** Concurrency **********
            //    builder.Services.AddRateLimiter(_ => _
            //        .AddConcurrencyLimiter(policyName: "concurrencyPolicy", options =>
            //        {
            //            options.PermitLimit = 1;//myOptions.PermitLimit;
            //            options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
            //            options.QueueLimit = myOptions.QueueLimit;
            //        }));
            //    //***************************************
            //    var app = builder.Build();

            //    // Configure the HTTP request pipeline.
            //    if (app.Environment.IsDevelopment())
            //    {
            //        app.UseSwagger();
            //        app.UseSwaggerUI();
            //    }
            //    app.UseRateLimiter();
            //    app.UseHttpsRedirection();

            //    app.UseAuthorization();

            //    var summaries = new[]
            //    {
            //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            //};

            //    app.MapGet("/weatherforecast", async (HttpContext httpContext) =>
            //    {
            //       await Task.Delay(5000);
            //        var forecast = Enumerable.Range(1, 5).Select(index =>
            //            new WeatherForecast
            //            {
            //                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //                TemperatureC = Random.Shared.Next(-20, 55),
            //                Summary = summaries[Random.Shared.Next(summaries.Length)]
            //            })
            //            .ToArray();
            //        return forecast;
            //    })
            //    .WithName("GetWeatherForecast").RequireRateLimiting("concurrencyPolicy")
            //    .WithOpenApi();

            //    app.Run();
        }
    }
}