using MediatR;

namespace Domain.Driven;

public abstract class DomainQueryHandlerBase<TQuery, TResult> : RequestHandler<TQuery, TResult>,
    IRequestQueryHandler<TQuery, TResult>
    where TQuery : IDomainQuery<TResult>
{
}
