namespace PokemonGO.Domain.Entity;

public class PokemonAbility : BaseEntity
{
    public int PokemonId { get; set; }
    public Pokemon Pokemon { get; set; }

    public int AbilityId { get; set; }
    public Ability Ability { get; set; }
}