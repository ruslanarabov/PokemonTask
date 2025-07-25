using PokemonGO.Contract.DTOs.Trainer;
using PokemonGO.Domain.Entity;

namespace PokemonGO.Contract.Service;

public interface ITrainerService : IGenericService<TrainerDto, CreateTrainerDto, UpdateTrainerDto, Trainer>
{ 
    Task<bool> LevelUpAsync(int trainerId, int experience);
}