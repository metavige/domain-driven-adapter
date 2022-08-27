using MediatR;

namespace Domain.Driven;

public class CqrsAdapter : ICqrsAdapter
{
    private readonly IMediator _mediator;

    public CqrsAdapter(IMediator mediator) { _mediator = mediator; }


    public async Task<TResponse> SendAndGetAsync<TResponse>(
        IRequestQuery<TResponse> request,
        CancellationToken cancellationToken
    )
    {
        return await _mediator.Send(request, cancellationToken);
    }

    public async Task SendAsync(IRequestCommand request, CancellationToken cancellationToken)
    {
        await _mediator.Send(request, cancellationToken);
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