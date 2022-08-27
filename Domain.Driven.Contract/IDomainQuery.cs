using MediatR;

namespace Domain.Driven;

/// <summary>
/// Query request, for ReadOnly Data
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface IDomainQuery<out TResponse> : IRequest<TResponse>
{
}