using DomainDriven;

namespace Domain.Driven.Impl.Queries;

public class WeatherRequestQuery : IRequestQuery<IEnumerable<WeatherForecast>>
{
    public int Size { get; }

    public WeatherRequestQuery(int size) { Size = size; }
}