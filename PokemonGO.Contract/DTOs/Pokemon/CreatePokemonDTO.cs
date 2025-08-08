namespace PokemonGO.Contract.DTOs.Pokemon;

public class CreatePokemonDTO
{
    public int? Id { get; set; }
    
    public string Name { get; set; } = null!;
    
    public string Description { get; set; } = string.Empty;
    
    public int DefaultHP { get; set; }
    
    public int DefaultAttack { get; set; }
    
    public int DefaultDefense { get; set; }
    
    public int Specie1Id { get; set; }
    
    public int Specie2Id { get; set; } 
    
}