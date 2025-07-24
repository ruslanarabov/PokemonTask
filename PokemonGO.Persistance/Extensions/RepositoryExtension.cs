using Microsoft.Extensions.DependencyInjection;
using PokemonGO.Domain.Repositories;
using PokemonGO.Persistance.Repository;

namespace PokemonGO.Persistance.Extensions;

public static class RepositoryExtension
{
    public static IServiceCollection AddRepositoryRegistration(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        //services.AddScoped<IPokemonRepository, PokemonRepository>();
        return services;
    }
}