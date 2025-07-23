namespace PokemonGO.Domain.Entity;

public class Gym : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public int RequiredLevel { get; set; }
    
    // Navigation properties
    public int GymLeaderId { get; set; }
    public Trainer GymLeader { get; set; }
    public ICollection<Badge> Badges { get; set; }
    
}