namespace PokemonGO.Domain.Entity;

public class PokemonCategory : BaseEntity
{
    public string Name { get; set; } 
    public string Description { get; set; } 
    
    // Navigation properties
    public ICollection<Pokemon> Pokemons { get; set; }  = new List<Pokemon>();
    
}   