using MediatR;

namespace Domain.Driven;

public abstract class AsyncRequestCommandHandlerBase<TCommand> : AsyncRequestHandler<TCommand>,
    IRequestCommandHandler<TCommand>
    where TCommand : IRequestCommand
{
}