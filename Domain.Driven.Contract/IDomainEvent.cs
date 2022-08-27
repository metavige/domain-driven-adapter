using MediatR;

namespace Domain.Driven;

/// <summary>
/// Domain Event
/// </summary>
public interface IDomainEvent : INotification
{
}


public interface IDomainEvent<out TDomainData> : IDomainEvent
{
    TDomainData Data { get; }
}