using MediatR;

namespace Domain.Driven;

/// <summary>
/// Command Request
/// </summary>
public interface IDomainCommand : IRequest {
}

/// <summary>
/// Command Request with Response
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface IDomainCommand<out TResponse> : IRequest<TResponse> {
}