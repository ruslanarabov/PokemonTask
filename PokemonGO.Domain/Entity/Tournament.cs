namespace PokemonGO.Domain.Entity;

public class Tournament : BaseEntity
{
    public string Name { get; set; }
    public string Location { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int RequiredBadges { get; set; }

    // Navigation properties
    public ICollection<TournamentTrainer> Participants { get; set; }
    
}