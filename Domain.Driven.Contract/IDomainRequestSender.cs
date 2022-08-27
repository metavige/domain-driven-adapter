namespace Domain.Driven;

public interface IDomainRequestSender
{
    public Task<TResponse> SendAndGetAsync<TResponse>(IDomainQuery<TResponse> request, CancellationToken cancellationToken);
    
    public Task<TResponse> SendAndGetAsync<TResponse>(IDomainCommand<TResponse> request, CancellationToken cancellationToken);

    public Task SendAsync(IDomainCommand domain, CancellationToken cancellationToken);
}