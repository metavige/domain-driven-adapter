using MediatR;

namespace Domain.Driven;

public abstract class RequestQueryHandlerBase<TQuery, TResult> : RequestHandler<TQuery, TResult>,
    IRequestQueryHandler<TQuery, TResult>
    where TQuery : IRequestQuery<TResult>
{
}