namespace PokemonGO.Contract.DTOs.Pokemon;

public record PokemonDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    // Category
    public string CategoryName { get; set; } // Pokémon'un Category adı

    // Evolution Pokémon 
    public string? EvolutionPokemonName { get; set; } 

    // Pokémon's Abilities 
    public List<string> PokemonAbilities { get; set; }
}
