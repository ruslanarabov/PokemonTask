using Microsoft.EntityFrameworkCore;
using PokemonGO.Domain.Entity;
using PokemonGO.Domain.Repositories;
using PokemonGO.Persistance.Data;

namespace PokemonGO.Persistance.Repository;

public class GenericRepository <T> : IGenericRepository<T> where T : BaseEntity, new()
{
    protected readonly PokemonDB _context;
    private readonly DbSet<T> _dbSet;
    public GenericRepository(PokemonDB context)
    {
        _context = context;
        _dbSet = context.Set<T>();    
    }
    
    public async Task<T> AddAsync(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
        }
        
        entity.CreatedDate = DateTime.UtcNow;
        entity.UpdatedDate = DateTime.UtcNow;
        entity.IsDeleted = false;

        _dbSet.Add(entity);
        await _context.SaveChangesAsync();
        
        return entity;
    }
    
    public async Task<IQueryable<T>> GetAllAsync()
    {
        var entities = (await _dbSet.ToListAsync()).Where(x => !x.IsDeleted);
        return entities.AsQueryable();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null || entity.IsDeleted)
        {
            throw new KeyNotFoundException($"Entity with ID {id} not found or is deleted.");
        }
        return entity;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null || entity.IsDeleted)
        {
            return false;
        }
        entity.IsDeleted = true;
        _dbSet.Update(entity);
        return true;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
        }

        entity.UpdatedDate = DateTime.UtcNow;
        _dbSet.Update(entity);
        return entity;
    }
}
