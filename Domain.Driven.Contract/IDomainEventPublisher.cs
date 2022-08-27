namespace Domain.Driven;

public interface IDomainEventPublisher 
{
    public Task Publish(IDomainEvent domainEvent, CancellationToken cancellationToken);

    public Task Publish<TDomainData>(IDomainEvent<TDomainData> domainEvent, CancellationToken cancellationToken);
}