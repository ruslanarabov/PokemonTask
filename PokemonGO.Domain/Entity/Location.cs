namespace PokemonGO.Domain.Entity;

public class Location : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } 
    public ICollection<Trainer> Trainers { get; set; } = [];
    public ICollection<Gym> Gyms { get; set; } = [];
    public ICollection<Trainer> EliteFour { get; set; } = [];
    
    public int WinnerId { get; set; }
    public Trainer? Winner { get; set; }
}