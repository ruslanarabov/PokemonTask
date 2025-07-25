using AutoMapper;
using PokemonGO.Contract.Service;
using PokemonGO.Domain.Entity;
using PokemonGO.Domain.Repositories;

namespace PokemonGO.Application.Service;

public class GenericService<TReadDto, TCreateDto, TUpdateDto, TEntity> 
    : IGenericService<TReadDto, TCreateDto, TUpdateDto, TEntity>
    where TEntity : BaseEntity, new()
{
    protected readonly IGenericRepository<TEntity> _repository;
    protected readonly IMapper _mapper;
    private readonly IUnityOfWork _unityOfWork;

    public GenericService(IMapper mapper, IGenericRepository<TEntity> repository, IUnityOfWork unityOfWork)
    {
        _mapper = mapper;
        _repository = repository;
        _unityOfWork = unityOfWork;
    }

    public async Task<TReadDto> AddAsync(TCreateDto dto)
    {
        if (dto == null) throw new ArgumentNullException(nameof(dto));

        var entity = _mapper.Map<TEntity>(dto);
        var added = await _repository.AddAsync(entity);
        await _unityOfWork.SaveChangesAsync();

        return _mapper.Map<TReadDto>(added);
    }

    public async Task<TReadDto> GetByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return default;

        return _mapper.Map<TReadDto>(entity);
    }

    public async Task<IEnumerable<TReadDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<TReadDto>>(entities);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return false;

        await _repository.DeleteAsync(id);
        await _unityOfWork.SaveChangesAsync();

        return true;
    }

    public async Task<TReadDto> UpdateAsync(int id, TUpdateDto dto)
    {
        if (dto == null) throw new ArgumentNullException(nameof(dto));

        var entityToUpdate = _mapper.Map<TEntity>(dto);
        entityToUpdate.Id = id;

        var updated = await _repository.UpdateAsync(entityToUpdate);
        await _unityOfWork.SaveChangesAsync();

        return _mapper.Map<TReadDto>(updated);
    }
}
