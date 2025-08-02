using PokemonGO.Domain.Enums;

namespace PokemonGO.Domain.Entity;
public class Trainer : BaseEntity
{
    public string NickName { get; set; }
    public int Level { get; set; }
    public ICollection<TrainerPokemon> TrainerPokemons  { get; set; } = [];
    public string? UserId { get; set; }
    public TrainerType Type { get; set; }
    public User? User { get; set; }
}