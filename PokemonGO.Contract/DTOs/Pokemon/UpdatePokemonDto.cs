namespace PokemonGO.Contract.DTOs.Pokemon;

public record UpdatePokemonDto
{
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Level { get; set; }
    public int Experience { get; set; }

    // Category
    public int CategoryId { get; set; }

    // Evolution Pokémon (əgər varsa)
    public int? EvolutionPokemonId { get; set; }

    // Pokémon's Abilities
    public List<int> AbilityIds { get; set; } = new List<int>(); 
}