using Microsoft.AspNetCore.Mvc;

namespace Int24Api1.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<IEnumerable<WeatherForecast>> Get(bool get)
        {

            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return BadRequest(); //Ok(new { name = "Niranjan", Address="njfdn"});
        }
       
            [HttpPost("First")]
             public IActionResult PostJson(IEnumerable<int> values) =>
                Ok(new { Consumes = "application/json", Values = values });

        [HttpPost("Second")]
        public IActionResult PostForm([FromForm] IEnumerable<int> values) =>
            Ok(new { Consumes = "application/x-www-form-urlencoded", Values = values });

    }
}