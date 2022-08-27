using MediatR;

namespace Domain.Driven;

public abstract class DomainCommandHandlerBase<TCommand> : RequestHandler<TCommand>, IDomainCommandHandler<TCommand>
    where TCommand : IDomainCommand
{
}

public abstract class DomainCommandHandlerBase<TCommand, TResponse> : RequestHandler<TCommand, TResponse>, IDomainCommandHandler<TCommand, TResponse>
    where TCommand : IDomainCommand<TResponse>
{
}