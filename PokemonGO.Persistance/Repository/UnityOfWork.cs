using PokemonGO.Domain.Repositories;
using PokemonGO.Persistance.Data;

namespace PokemonGO.Persistance.Repository;

public class UnityOfWork : IUnityOfWork
{
    private readonly PokemonDB _context;

    public UnityOfWork(PokemonDB context)
    {
        _context = context;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
    
}