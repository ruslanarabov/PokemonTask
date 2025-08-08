namespace PokemonGO.Contract.DTOs.Specie;

public class CreateSpecieDTO
{
    public int? Id { get; set; }
    
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}