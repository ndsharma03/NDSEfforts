using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ITransientService transient;
        private readonly ISingletonService singleton;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,  ISingletonService singleton,ITransientService transient)
        {
            _logger = logger;
            this.transient = transient;
            this.singleton = singleton;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        //[Authorize]
        public IEnumerable<WeatherForecast> Get()
        {
            singleton.Print("Print from Singleton");
          //  transient.Print("Print from trasnsient");
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("/New")]
        public string GetNew()
        {
            transient.Print("transient.Print from new GetMethod");
            return "Hello";
        }
    }
}