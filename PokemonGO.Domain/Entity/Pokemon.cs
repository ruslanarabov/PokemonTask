using PokemonGO.Domain.Enums;

namespace PokemonGO.Domain.Entity;

public class Pokemon : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Level { get; set; } = 1;
    public int Experience { get; set; } = 0;
    
    public int CategoryId { get; set; }
    public PokemonCategory Category { get; set; }

    public int? EvolutionPokemonId { get; set; }
    public Pokemon EvolutionPokemon { get; set; }

    public ICollection<PokemonAbility> PokemonAbilities { get; set; }
    public ICollection<TrainerPokemon> TrainerPokemons { get; set; }
}
