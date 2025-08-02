namespace PokemonGO.Domain.Entity;

public class Badge : BaseEntity
{   
    public string Name { get; set; }
    public string Description { get; set; }
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; } = null!;
    
}