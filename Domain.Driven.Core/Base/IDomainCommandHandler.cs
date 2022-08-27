using MediatR;

// ReSharper disable once CheckNamespace
namespace Domain.Driven;

/// <summary>
/// <see cref="IDomainCommand"/> Handler
/// </summary>
/// <typeparam name="TDomainCommand"></typeparam>
public interface IDomainCommandHandler<in TDomainCommand> : IRequestHandler<TDomainCommand>
    where TDomainCommand : IDomainCommand
{
    
}

/// <summary>
/// <see cref="IDomainCommand{TResponse}"/> Handler
/// </summary>
/// <typeparam name="TDomainCommand"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public interface IDomainCommandHandler<in TDomainCommand, TResponse> : IRequestHandler<TDomainCommand, TResponse>
    where TDomainCommand : IDomainCommand<TResponse>
{
    
}   