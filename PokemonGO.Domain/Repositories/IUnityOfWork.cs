namespace PokemonGO.Domain.Repositories;
public interface IUnityOfWork
{
    Task<int> SaveChangesAsync();
}