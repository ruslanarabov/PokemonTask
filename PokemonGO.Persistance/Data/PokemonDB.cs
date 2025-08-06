using Microsoft.EntityFrameworkCore;
using PokemonGO.Domain.Entity;

namespace PokemonGO.Persistance.Data;

public class PokemonDB : DbContext
{
    public PokemonDB(DbContextOptions<PokemonDB> options) : base(options) { }

    public DbSet<ActiveAbility> ActiveAbilities { get; set; }
    public DbSet<AbilityLevel> AbilityLevels { get; set; }
    public DbSet<BaseAbility> BaseAbilities { get; set; }
    public DbSet<Battle> Battles { get; set; }
    public DbSet<BattleTurn> BattleTurns { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<PassiveAbility> PassiveAbilities { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<PokemonAbility> PokemonAssignAbilities { get; set; }
    public DbSet<Specie> Species { get; set; }
    public DbSet<SpecieEffect> SpecieEffects { get; set; }
    public DbSet<StatusAbility> StatusAbilities { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<TrainerPokemon> TrainerPokemons { get; set; }
    public DbSet<Gym> Gyms { get; set; }
    public DbSet<Location> Locations { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<AbilityLevel>()
            .HasKey(al => new { al.PokemonId, al.BaseAbilityId });
        
        modelBuilder.Entity<PokemonAbility>()
            .HasKey((pa=>new { pa.TrainerPokemonId, pa.BaseAbilityId }));
        modelBuilder.Entity<SpecieEffect>()
            .HasKey(se => new { se.AttackSpecieId, se.DefenseSpecieId });

        modelBuilder.Entity<AbilityLevel>()
            .HasOne(al => al.BaseAbility)
            .WithMany(ba => ba.AbilityLevels)
            .HasForeignKey(al => al.BaseAbilityId);
        
        modelBuilder.Entity<SpecieEffect>()
            .HasOne(se => se.DefenseSpecie)
            .WithMany()
            .HasForeignKey(se => se.DefenseSpecieId)
            .OnDelete(DeleteBehavior.NoAction); 

        modelBuilder.Entity<SpecieEffect>()
            .HasOne(se => se.AttackSpecie)
            .WithMany()
            .HasForeignKey(se => se.AttackSpecieId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Location>()
            .HasOne(l => l.Winner)
            .WithMany()
            .HasForeignKey(l => l.WinnerId)
            .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<Location>()
            .HasOne(l => l.Loser)
            .WithMany()
            .HasForeignKey(l => l.LoserId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Badge>()
            .HasOne(b => b.Trainer)
            .WithMany()
            .HasForeignKey(b => b.TrainerId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Battle>()
            .HasOne(b => b.Trainer)
            .WithMany()
            .HasForeignKey(b => b.TrainerId)
            .OnDelete(DeleteBehavior.Restrict); 

        
        modelBuilder.Entity<Battle>()
            .HasOne(b => b.Opponent)
            .WithMany()
            .HasForeignKey(b => b.OpponentId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<BattleTurn>()
            .HasOne(bt => bt.DefenderTrainerPokemon)
            .WithMany()
            .HasForeignKey(bt => bt.DefenderTrainerPokemonId)
            .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<BattleTurn>()
            .HasOne(bt => bt.AttackerTrainerPokemon)
            .WithMany()
            .HasForeignKey(bt => bt.AttackerTrainerPokemonId)
            .OnDelete(DeleteBehavior.Restrict);
        
        
    }
}