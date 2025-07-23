namespace PokemonGO.Domain.Entity;

public class Ability : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    // Navigation properties
    public ICollection<PokemonAbility> PokemonAbilities { get; set; }}