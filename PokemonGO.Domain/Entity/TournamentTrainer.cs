namespace PokemonGO.Domain.Entity;

public class TournamentTrainer : BaseEntity
{
    public int TournamentId { get; set; }
    public Tournament Tournament { get; set; }

    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }

    public bool IsWinner { get; set; }
}