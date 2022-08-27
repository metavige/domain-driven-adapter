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
    private readonly ICqrsAdapter _cqrsAdapter;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, ICqrsAdapter cqrsAdapter)
    {
        _logger = logger;
        _cqrsAdapter = cqrsAdapter;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await _cqrsAdapter.SendAndGetAsync(new WeatherRequestQuery(5), CancellationToken.None);
    }
}
