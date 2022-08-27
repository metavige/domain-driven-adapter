using MediatR;

// ReSharper disable once CheckNamespace
namespace Domain.Driven;

public interface IDomainEventHandler<in TEvent> : INotificationHandler<TEvent>
    where TEvent : IDomainEvent
{
}

public interface IDomainEventHandler<in TEvent, TDomainData> : INotificationHandler<TEvent>
    where TEvent : IDomainEvent<TDomainData>
{
}