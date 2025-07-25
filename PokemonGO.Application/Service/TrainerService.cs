using AutoMapper;
using PokemonGO.Contract.DTOs.Trainer;
using PokemonGO.Contract.Service;
using PokemonGO.Domain.Entity;
using PokemonGO.Domain.Repositories;
namespace PokemonGO.Application.Service;
public class TrainerService : GenericService<TrainerDto, CreateTrainerDto, UpdateTrainerDto, Trainer>, ITrainerService
{
    private readonly IGenericRepository<Trainer> _trainerRepository;
    private readonly IUnityOfWork _unitOfWork;
    public TrainerService(
        IMapper mapper,
        IGenericRepository<Trainer> repository,
        IUnityOfWork unityOfWork
    ) : base(mapper, repository, unityOfWork)
    {
        _trainerRepository = repository;
        _unitOfWork = unityOfWork;
    }

    public async Task<bool> LevelUpAsync(int trainerId, int experience)
    {
        var trainer = await _trainerRepository.GetByIdAsync(trainerId);
        if (trainer == null)
            return false;

        trainer.Experience += experience;

        
        int requiredExp = trainer.Level * 500;
        bool leveledUp = false;
        while (trainer.Experience >= requiredExp)
        {
            trainer.Experience -= requiredExp;
            trainer.Level++;
            leveledUp = true;
            requiredExp = trainer.Level * 500;
        }

        await _trainerRepository.UpdateAsync(trainer);
        await _unitOfWork.SaveChangesAsync();

        return leveledUp;
    }
}