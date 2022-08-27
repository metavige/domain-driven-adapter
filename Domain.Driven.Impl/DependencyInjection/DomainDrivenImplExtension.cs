

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class DomainDrivenImplExtension
{
    public static IServiceCollection AddDomainDrivenImpl(this IServiceCollection services)
    {
        services.AddDomainDrivenSupport(typeof(DomainDrivenImplExtension).Assembly);
        
        return services;
    }
}