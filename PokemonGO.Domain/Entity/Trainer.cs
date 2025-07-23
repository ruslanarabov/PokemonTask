namespace PokemonGO.Domain.Entity;

public class Trainer : BaseEntity
{
    public string Name { get; set; }
    public int Gold { get; set; } = 0;
    public int Level { get; set; } = 1;
    public int Experience { get; set; } = 0;

    public ICollection<TrainerPokemon> Pokemons { get; set; }
    public ICollection<TrainerBadge> Badges { get; set; }
    public ICollection<TrainerItem> Items { get; set; }
    
}