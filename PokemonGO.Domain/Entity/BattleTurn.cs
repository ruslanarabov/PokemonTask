namespace PokemonGO.Domain.Entity;

public class BattleTurn : BaseEntity
{
    public int BattleId { get; set; }
    public Battle Battle { get; set; } = null!;

    public int TurnNumber { get; set; }
    public int AttackerTrainerPokemonId { get; set; }
    public TrainerPokemon AttackerTrainerPokemon { get; set; } = null!;

    public int DefenderTrainerPokemonId { get; set; }
    public TrainerPokemon DefenderTrainerPokemon { get; set; } = null!;

    public int AbilityUsedId { get; set; }
    public BaseAbility AbilityUsed { get; set; } = null!;

    public int DamageDealt { get; set; }
    public int DefenderRemainingHp { get; set; }
    // public bool IsCriticalHit { get; set; } = false;
    // public bool IsDodged { get; set; } = false;
}