using Microsoft.Extensions.DependencyInjection;
using PokemonGO.Application.Service;
using PokemonGO.Contract.Service;

namespace PokemonGO.Application.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddServiceRegistration(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericService<,,,>), typeof(GenericService<,,,>));
        
        return services;
    }
}