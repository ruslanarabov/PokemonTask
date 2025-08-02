namespace PokemonGO.Domain.Entity;
public class Pokemon : BaseEntity
{ 
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public int DefaultHP { get; set; }
    public int DefaultAtack { get; set; }
    public int DefaultDefense { get; set; }
    
    public ICollection<Specie> Species { get; set; } = [];
    public ICollection<TrainerPokemon> TrainerPokemons { get; set; } = [];
}
