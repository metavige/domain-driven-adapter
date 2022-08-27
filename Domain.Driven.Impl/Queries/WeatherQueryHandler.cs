using DomainDriven;
using MediatR;

namespace Domain.Driven.Impl.Queries;

public class WeatherQueryHandler : DomainQueryHandlerBase<WeatherQuery, IEnumerable<WeatherForecast>>
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    protected override IEnumerable<WeatherForecast> Handle(WeatherQuery request)
    {
        return Enumerable.Range(1, request.Size)
            .Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                }
            );
    }
}