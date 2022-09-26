using Microsoft.AspNetCore.Mvc;

namespace LoadBalancerProject_ScalableService.Controllers;

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

    [HttpGet("{number}")]
    public IEnumerable<int> Get(int number)
    {
        List<int> numberList = new List<int>();

        for (int i = 0; i < number; i++)
        {
            System.Console.WriteLine(i);
            numberList.Add(i);

        }
        return numberList.ToArray();
    }
}
