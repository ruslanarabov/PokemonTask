namespace PokemonGO.Contract.DTOs.Pokemon;

public class PokemonDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = string.Empty;
    public int DefaultHP { get; set; }
    public int DefaultAttack { get; set; }
    public int DefaultDefense { get; set; }

    public IDictionary<int, string> Species { get; set; } = new Dictionary<int, string>();
}