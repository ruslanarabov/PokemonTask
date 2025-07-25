using PokemonGO.Domain.Entity;

namespace PokemonGO.Contract.Service;

public interface IGenericService<TReadDto, TCreateDto, TUpdateDto, TEntity>
    where TEntity : BaseEntity, new()
{
    Task<TReadDto> GetByIdAsync(int id);
    Task<IEnumerable<TReadDto>> GetAllAsync();
    Task<TReadDto> AddAsync(TCreateDto dto);
    Task<TReadDto> UpdateAsync(int id, TUpdateDto dto);
    Task<bool> DeleteAsync(int id);
}