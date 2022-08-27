using System.Runtime.CompilerServices;
using Domain.Driven;
using Domain.Driven.Impl.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DomainDriven.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{ 
    private readonly IDomainRequestAdapter _adapter;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IDomainRequestAdapter adapter)
    {
        _logger = logger;
        _adapter = adapter;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await _adapter.SendAndGetAsync(new WeatherQuery(5), CancellationToken.None);
    }
}
