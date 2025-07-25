using Microsoft.EntityFrameworkCore;
using PokemonGO.Domain.Entity;
using PokemonGO.Domain.Repositories;
using PokemonGO.Persistance.Data;

namespace PokemonGO.Persistance.Repository;

public class TrainerRepository : GenericRepository<Trainer>, ITrainerRepository
{
    public TrainerRepository(PokemonDB context) : base(context)
    {
    }


}