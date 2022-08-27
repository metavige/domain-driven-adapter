using MediatR;

namespace Domain.Driven;

/// <summary>
/// Domain 事件
/// </summary>
public interface IDomainEvent : INotification
{
}


public interface IDomainEvent<out TDomainData> : IDomainEvent
{
    TDomainData Data { get; }
}