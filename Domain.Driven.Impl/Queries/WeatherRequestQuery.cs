using DomainDriven;

namespace Domain.Driven.Impl.Queries;

public class WeatherQuery : IDomainQuery<IEnumerable<WeatherForecast>>
{
    public int Size { get; }

    public WeatherQuery(int size) { Size = size; }
}