using MediatR;

namespace Domain.Driven;

/// <summary>
/// Query 要求
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface IRequestQuery<out TResponse> : IRequest<TResponse>
{
}