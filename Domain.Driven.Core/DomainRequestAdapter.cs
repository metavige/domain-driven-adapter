using MediatR;

namespace Domain.Driven;

public class DomainRequestAdapter : IDomainRequestAdapter
{
    private readonly IMediator _mediator;

    public DomainRequestAdapter(IMediator mediator) { _mediator = mediator; }


    public async Task<TResponse> SendAndGetAsync<TResponse>(
        IDomainQuery<TResponse> request,
        CancellationToken cancellationToken
    )
    {
        return await _mediator.Send(request, cancellationToken);
    }

    public async Task<TResponse> SendAndGetAsync<TResponse>(
        IDomainCommand<TResponse> request,
        CancellationToken cancellationToken
    )
    {
        return await _mediator.Send(request, cancellationToken);
    }

    public async Task SendAsync(IDomainCommand domain, CancellationToken cancellationToken)
    {
        await _mediator.Send(domain, cancellationToken);
    }

    public async Task Publish(IDomainEvent domainEvent, CancellationToken cancellationToken) 
    {
        await _mediator.Publish(domainEvent, cancellationToken);
    }

    public async Task Publish<TDomainData>(IDomainEvent<TDomainData> domainEvent, CancellationToken cancellationToken) 
    {
        await _mediator.Publish(domainEvent, cancellationToken);
    }
}