using Microsoft.AspNetCore.Mvc;

namespace Demo.Profiling.Controllers
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
        public IActionResult Get()
        {
            var listOfWeatherForecast = new List<WeatherForecast>(5);
            var labels = Pyroscope.LabelSet.Empty.BuildUpon().Add("WeatherForecast", "WeatherForecast").Build();

            Pyroscope.LabelsWrapper.Do(labels, () => 
            {
                listOfWeatherForecast.AddRange(Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                }));
            });

            return Ok(listOfWeatherForecast);
        }
    }
}