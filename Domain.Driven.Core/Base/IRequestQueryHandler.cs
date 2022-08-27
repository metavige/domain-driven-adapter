using MediatR;

// ReSharper disable once CheckNamespace
namespace Domain.Driven;

/// <summary>
/// <see cref="IRequestCommand"/> 處理器
/// </summary>
/// <typeparam name="TRequestQuery"></typeparam>
/// <typeparam name="TResult"></typeparam>
public interface IRequestQueryHandler<in TRequestQuery, TResult> : IRequestHandler<TRequestQuery, TResult>
    where TRequestQuery : IRequestQuery<TResult>
{
    
}