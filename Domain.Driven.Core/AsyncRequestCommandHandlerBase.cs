using MediatR;

namespace Domain.Driven;

public abstract class AsyncRequestCommandHandlerBase<TDomainCommand> : AsyncRequestHandler<TDomainCommand>,
    IDomainCommandHandler<TDomainCommand>
    where TDomainCommand : IDomainCommand
{
}
