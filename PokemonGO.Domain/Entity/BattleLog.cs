namespace PokemonGO.Domain.Entity;

public class BattleLog : BaseEntity
{
    public int BattleId { get; set; }
    public Battle Battle { get; set; }

    public int RoundNumber { get; set; }
    public string ActionDescription { get; set; }
}