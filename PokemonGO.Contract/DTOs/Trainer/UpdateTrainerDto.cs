namespace PokemonGO.Contract.DTOs.Trainer;

public record UpdateTrainerDto
{
    public string Name { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
}