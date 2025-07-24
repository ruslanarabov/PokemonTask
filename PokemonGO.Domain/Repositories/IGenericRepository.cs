using PokemonGO.Domain.Entity;

namespace PokemonGO.Domain.Repositories;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    Task<IQueryable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(int id);
}