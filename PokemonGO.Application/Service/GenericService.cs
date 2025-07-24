using AutoMapper;
using PokemonGO.Contract.Service;
using PokemonGO.Domain.Entity;
using PokemonGO.Domain.Repositories;

namespace PokemonGO.Application.Service;

public class GenericService<TVM, TEntity> : IGenericService<TVM, TEntity> 
    where TVM : class where TEntity : BaseEntity, new()
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
    
    public async Task<TVM> AddAsync(TVM entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        var entityToAdd = _mapper.Map<TEntity>(entity);
        var addedEntity = await _repository.AddAsync(entityToAdd);
        await _unityOfWork.SaveChangesAsync();
        
        return _mapper.Map<TVM>(addedEntity);
        
    }

    public async Task<TVM> GetByIdAsync(int id)
    {
        var data = await _repository.GetByIdAsync(id);
        if (data == null)
        {
            return null;
        }
        var result = _mapper.Map<TVM>(data);
        return result;
    }

    public async Task<IEnumerable<TVM>> GetAllAsync()
    {
        var data = await _repository.GetAllAsync();
        if (data == null)
        {
            return null;
        }
        var result = _mapper.Map<IEnumerable<TVM>>(data);
        return result;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var data = await _repository.GetByIdAsync(id);
        if (data == null)
        {
            return false;
        }
        await _repository.DeleteAsync(id);
        await _unityOfWork.SaveChangesAsync();
        return true;
    }

    public async Task<TVM> UpdateAsync(TVM entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        var entityToUpdate = _mapper.Map<TEntity>(entity);
        var updatedEntity = await _repository.UpdateAsync(entityToUpdate);
        await _unityOfWork.SaveChangesAsync();
        
        return _mapper.Map<TVM>(updatedEntity);
    }
}