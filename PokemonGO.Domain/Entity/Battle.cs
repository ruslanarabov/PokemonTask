using PokemonGO.Domain.Enums;

namespace PokemonGO.Domain.Entity;

public class Battle : BaseEntity
{
    public string Name { get; set; }
    
    public int Trainer1Id { get; set; }
    public Trainer Trainer1 { get; set; }

    public int? Trainer2Id { get; set; }
    public Trainer Trainer2 { get; set; }

    public int? WinnerTrainerId { get; set; }
    public Trainer WinnerTrainer { get; set; }

    public BattleType BattleType { get; set; }
    public DateTime Date { get; set; }

    public ICollection<BattleLog> BattleLogs { get; set; }
    
}