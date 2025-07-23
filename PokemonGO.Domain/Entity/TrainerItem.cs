namespace PokemonGO.Domain.Entity;

public class TrainerItem : BaseEntity
{
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }

    public int ItemId { get; set; }
    public Item Item { get; set; }

    public int Quantity { get; set; }
}