namespace PokemonGO.Domain.Entity;

public class Badge : BaseEntity
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public int GymId { get; set; }
    public Gym Gym { get; set; }
    // Navigation properties
    public ICollection<TrainerBadge> TrainerBadges { get; set; }
    
}