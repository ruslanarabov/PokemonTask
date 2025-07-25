using Microsoft.EntityFrameworkCore;
using PokemonGO.Domain.Entity;

namespace PokemonGO.Persistance.Data;

public class PokemonDB : DbContext
{
    public PokemonDB(DbContextOptions<PokemonDB> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        
        
        modelBuilder.Entity<PokemonAbility>()
            .HasKey(pa => new { pa.PokemonId, pa.AbilityId });

        modelBuilder.Entity<PokemonAbility>()
            .HasOne(pa => pa.Pokemon)
            .WithMany(p => p.PokemonAbilities)
            .HasForeignKey(pa => pa.PokemonId);

        modelBuilder.Entity<PokemonAbility>()
            .HasOne(pa => pa.Ability)
            .WithMany(a => a.PokemonAbilities)
            .HasForeignKey(pa => pa.AbilityId);

        // TrainerBadge (Çoxdan-çoxa)
        modelBuilder.Entity<TrainerBadge>()
            .HasKey(tb => new { tb.TrainerId, tb.BadgeId });
        

        modelBuilder.Entity<TrainerBadge>()
            .HasOne(tb => tb.Trainer)
            .WithMany(t => t.Badges)
            .HasForeignKey(tb => tb.TrainerId)
            .OnDelete(DeleteBehavior.Restrict); // <-- BURADA

        modelBuilder.Entity<TrainerBadge>()
            .HasOne(tb => tb.Badge)
            .WithMany(b => b.TrainerBadges)
            .HasForeignKey(tb => tb.BadgeId)
            .OnDelete(DeleteBehavior.Restrict); 

        // TrainerItem (Çoxdan-çoxa)
        modelBuilder.Entity<TrainerItem>()
            .HasKey(ti => new { ti.TrainerId, ti.ItemId });

        modelBuilder.Entity<TrainerItem>()
            .HasOne(ti => ti.Trainer)
            .WithMany(t => t.Items)
            .HasForeignKey(ti => ti.TrainerId);

        modelBuilder.Entity<TrainerItem>()
            .HasOne(ti => ti.Item)
            .WithMany(i => i.TrainerItems)
            .HasForeignKey(ti => ti.ItemId);

        // TournamentTrainer (Çoxdan-çoxa)
        modelBuilder.Entity<TournamentTrainer>()
            .HasKey(tt => new { tt.TournamentId, tt.TrainerId });

        modelBuilder.Entity<TournamentTrainer>()
            .HasOne(tt => tt.Tournament)
            .WithMany(t => t.Participants)
            .HasForeignKey(tt => tt.TournamentId);

        modelBuilder.Entity<TournamentTrainer>()
            .HasOne(tt => tt.Trainer)
            .WithMany()
            .HasForeignKey(tt => tt.TrainerId);

        // Self-referencing: Pokémon Evolution
        modelBuilder.Entity<Pokemon>()
            .HasOne(p => p.EvolutionPokemon)
            .WithMany()
            .HasForeignKey(p => p.EvolutionPokemonId)
            .OnDelete(DeleteBehavior.Restrict); // Recursive silinmənin qarşısını alır

        // Battle əlaqələri
        modelBuilder.Entity<Battle>()
            .HasOne(b => b.Trainer1)
            .WithMany()
            .HasForeignKey(b => b.Trainer1Id)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Battle>()
            .HasOne(b => b.Trainer2)
            .WithMany()
            .HasForeignKey(b => b.Trainer2Id)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Battle>()
            .HasOne(b => b.WinnerTrainer)
            .WithMany()
            .HasForeignKey(b => b.WinnerTrainerId)
            .OnDelete(DeleteBehavior.Restrict);
    
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