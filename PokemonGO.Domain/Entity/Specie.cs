namespace PokemonGO.Domain.Entity;

public class Specie : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; } 
    // Navigation properties
    public ICollection<Pokemon> Pokemons { get; set; } = [];

}