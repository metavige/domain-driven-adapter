using MediatR;

// ReSharper disable once CheckNamespace
namespace Domain.Driven;

/// <summary>
/// <see cref="IDomainQuery{TResponse}"/> Handler
/// </summary>
/// <typeparam name="TDomainQuery"></typeparam>
/// <typeparam name="TResult"></typeparam>
public interface IRequestQueryHandler<in TDomainQuery, TResult> : IRequestHandler<TDomainQuery, TResult>
    where TDomainQuery : IDomainQuery<TResult>
{
    
}