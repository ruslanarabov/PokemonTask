namespace PokemonGO.Domain.Entity;

public class TrainerPokemon : BaseEntity
{
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }

    public int PokemonId { get; set; }
    public Pokemon Pokemon { get; set; }

    public string Nickname { get; set; }
    public int Level { get; set; } = 5;
    public int CurrentHP { get; set; }
    
    public int Experience { get; set; }
    public bool IsFainted { get; set; }
}