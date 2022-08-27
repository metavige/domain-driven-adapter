namespace Domain.Driven;

public interface IRequestSender
{
    public Task<TResponse> SendAndGetAsync<TResponse>(IRequestQuery<TResponse> request, CancellationToken cancellationToken);

    public Task SendAsync(IRequestCommand request, CancellationToken cancellationToken);
}