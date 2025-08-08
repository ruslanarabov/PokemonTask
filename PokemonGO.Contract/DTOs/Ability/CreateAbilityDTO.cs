namespace PokemonGO.Contract.DTOs.Ability;

public class CreateAbilityDTO
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = string.Empty;
    public int SpecieId { get; set; }
    public int Difficulty { get; set; }
    public IDictionary<int, string> PokemonLevels { get; set; } = new Dictionary<int, string>();
    
    // Active Ability
    public int CoolDown { get; set; } 
    public int HealthEffective { get; set; }
    public int AttackEffective { get; set; }
    public int DefenseEffective { get; set; }
    
    // Passive Ability
    public int? Duration { get; set; }
    public int[]? OwnEffectiveness { get; set; }
    public int[]? OpponentEffectiveness { get; set; }
    
    // Status Ability
    public bool IsHealthEffective { get; set; } = false;
    public bool IsAttackEffective { get; set; } = false;
    public bool IsDefenseEffective { get; set; } = false;
    public int? StatusAbilityType { get; set; }
    public AbilityType AbilityType { get; set; } = AbilityType.Active;
    
}