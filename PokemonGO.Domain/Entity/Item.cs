using PokemonGO.Domain.Enums;

namespace PokemonGO.Domain.Entity;

public class Item : BaseEntity
{
    public string Name { get; set; }
    public string Effect { get; set; }
    public ItemType ItemType { get; set; }

    public ICollection<TrainerItem> TrainerItems { get; set; }
    
}