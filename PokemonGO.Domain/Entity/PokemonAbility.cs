namespace PokemonGO.Domain.Entity;

public class PokemonAbility
{
    public int TrainerPokemonId { get; set; }
    public TrainerPokemon TrainerPokemon { get; set; } = null!;
    
    public int BaseAbilityId { get; set; }
    public BaseAbility BaseAbility { get; set; } = null!;
}