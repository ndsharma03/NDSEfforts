using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Caching.Distributed;

namespace RedisTest
{

    public class Program
    {
        public static void Main(string[] args)
        {
            string text = "Hello, world!";
            ReadOnlySpan<char> span = text.AsSpan(7, 5); // Represents "world"
     
            span.TryCopyTo(span2);

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
           // builder.Services.AddMemoryCache();
            //######## Redis ###############
            builder.Services.AddStackExchangeRedisCache(option =>
            {
                string connection = builder.Configuration.GetConnectionString("redis")!;
                option.Configuration = connection; //Connection string;
               
            });
            //#############################

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
          
            app.UseAuthorization();

            var summaries = new[]
            {
                    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
                };

            app.MapGet("/weatherforecast", (HttpContext httpContext, IDistributedCache cache) =>
            {
                var strCachedForcast = cache.GetString("Forecast");
             
                if (string.IsNullOrEmpty(strCachedForcast))
                {
                   var cachedForecaste = Enumerable.Range(1, 5).Select(index =>
                       new WeatherForecast
                       {
                           Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                           TemperatureC = Random.Shared.Next(-20, 55),
                           Summary = summaries[Random.Shared.Next(summaries.Length)]
                       })
                       .ToArray();

                     strCachedForcast =  JsonSerializer.Serialize< WeatherForecast[]>(cachedForecaste );
                    cache.SetString("Forecast", strCachedForcast);
                }

              return  JsonSerializer.Deserialize<WeatherForecast[]>(strCachedForcast);
               
            })
            .WithName("GetWeatherForecast")
            .WithOpenApi();

            app.Run();
        }
    }
}