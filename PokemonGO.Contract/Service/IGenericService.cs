using PokemonGO.Domain.Entity;

namespace PokemonGO.Contract.Service;

public interface IGenericService<TVM, TEntity> where TEntity :  BaseEntity, new()
{
    Task<TVM> GetByIdAsync(int id);
    Task<IEnumerable<TVM>> GetAllAsync();
    Task<TVM> AddAsync(TVM entity);
    Task<bool> DeleteAsync(int id);
    Task<TVM> UpdateAsync(TVM entity);
}