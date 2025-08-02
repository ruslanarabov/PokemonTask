namespace PokemonGO.Domain.Entity;

public abstract class BaseAbility : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    // Navigation properties
    public Specie Species  { get; set; } = null!;
    public int Difficulty { get; set; }
    public ICollection<AbilityLevel> AbilityLevels { get; set; } = [];
}