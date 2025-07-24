using Microsoft.EntityFrameworkCore;
using PokemonGO.Domain.Entity;

namespace PokemonGO.Persistance.Data;

public class PokemonDB : DbContext
{
    public PokemonDB(DbContextOptions<PokemonDB> options) : base(options)
    {
    }
    
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<PokemonCategory> PokemonCategories { get; set; }
    public DbSet<Ability> Abilities { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<PokemonAbility> PokemonAbilities { get; set; }
    public DbSet<TrainerPokemon> TrainerPokemons { get; set; }
    public DbSet<Gym> Gyms { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<TrainerBadge> TrainerBadges { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<TrainerItem> TrainerItems { get; set; }
    public DbSet<Battle> Battles { get; set; }
    public DbSet<BattleLog> BattleLogs { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<TournamentTrainer> TournamentTrainers { get; set; }
    public DbSet<LegendaryPokemonEncounter> LegendaryPokemonEncounters { get; set; }

    
}