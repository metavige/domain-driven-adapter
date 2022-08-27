using System.Reflection;
using Domain.Driven;
using MediatR;
using Microsoft.Extensions.DependencyInjection.Extensions;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class DomainDrivenCoreExtension
{
    public static IServiceCollection AddDomainDrivenSupport(this IServiceCollection services, Assembly implementationAssembly)
    { 
        // 使用 MediatR 當作 CQRS 框架
        services.AddMediatR(Assembly.GetExecutingAssembly(), implementationAssembly); 
        
        // 使用一個 Adapter 當 MediatR 的中介者
        services.TryAddTransient<ICqrsAdapter, CqrsAdapter>();
        
        return services;
    }
}