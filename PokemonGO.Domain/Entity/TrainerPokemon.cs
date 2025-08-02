using PokemonGO.Domain.Enums;

namespace PokemonGO.Domain.Entity;
public class TrainerPokemon : BaseEntity
{
    public PokemonType PokemonType { get; set; }
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; } = null!;
    public int PokemonId { get; set; }
    public Pokemon Pokemon { get; set; } = null!;
    public int Level { get; set; }
    public int CurrentHp { get; set; }
    public string NickName { get; set; } = string.Empty;
    public bool IsShiny { get; set; } = false;
    public int Order { get; set; }
    // Navigation properties
    public ICollection<BaseAbility> Abilities { get; set; } = [];
    public ICollection<PokemonAbility> PokemonAbilities { get; set; } = [];
}