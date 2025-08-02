namespace PokemonGO.Domain.Entity;

public class AbilityLevel 
{
    public int PokemonId { get; set; }
    public Pokemon Pokemon { get; set; }
    public int BaseAbilityId { get; set; }
    public BaseAbility BaseAbility { get; set; }
    public int Level { get; set; }
    
   
    
}