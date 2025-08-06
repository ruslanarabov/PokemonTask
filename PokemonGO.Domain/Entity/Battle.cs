using PokemonGO.Domain.Enums;
namespace PokemonGO.Domain.Entity;
public class Battle : BaseEntity
{
    public BattleType BattleType { get; set; }

    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; } = null!;
    public int OpponentId { get; set; }
    public Trainer Opponent { get; set; } = null!;

    public bool IsCompleted { get; set; } = false;
    public bool IsDraw { get; set; } = false;

    public int? WinnerTrainerId { get; set; }
    public Trainer? WinnerTrainer { get; set; }

    public int? LoserTrainerId { get; set; }
    public Trainer? LoserTrainer { get; set; }

    public ICollection<BattleTurn> BattleTurns { get; set; } = [];
}