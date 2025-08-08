namespace PokemonGO.Contract.DTOs.Specie;

public class SpecieDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public IDictionary<int, string> Pokemons { get; set; } = new Dictionary<int, string>();
}