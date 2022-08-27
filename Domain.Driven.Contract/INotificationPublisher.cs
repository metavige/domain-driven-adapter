namespace Domain.Driven;

public interface INotificationPublisher
{
    public Task Publish(IDomainEvent domainEvent, CancellationToken cancellationToken);

    public Task Publish<TDomainData>(IDomainEvent<TDomainData> domainEvent, CancellationToken cancellationToken);
}