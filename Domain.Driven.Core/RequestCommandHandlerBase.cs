using MediatR;

namespace Domain.Driven;

public abstract class RequestCommandHandlerBase<TCommand> : RequestHandler<TCommand>, IRequestCommandHandler<TCommand>
    where TCommand : IRequestCommand
{
}
