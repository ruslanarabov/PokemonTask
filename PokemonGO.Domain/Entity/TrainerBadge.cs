namespace PokemonGO.Domain.Entity;

public class TrainerBadge : BaseEntity
{
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }

    public int BadgeId { get; set; }
    public Badge Badge { get; set; }
}