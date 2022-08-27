using MediatR;

// ReSharper disable once CheckNamespace
namespace Domain.Driven;

/// <summary>
/// <see cref="IRequestCommand"/> 處理器
/// </summary>
/// <typeparam name="TRequestCommand"></typeparam>
public interface IRequestCommandHandler<in TRequestCommand> : IRequestHandler<TRequestCommand>
    where TRequestCommand : IRequestCommand
{
    
}