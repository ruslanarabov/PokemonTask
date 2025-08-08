using PokemonGO.Domain.Enums;

namespace PokemonGO.Contract.DTOs.Trainer;

public class TrainerDTO
{
    public int Id { get; set; }
    public string Nickname { get; set; }= null!;
    public int Level { get; set; }
    public TrainerType Type { get; set; }
    public string? UserId { get; set; }
    public ICollection<int> BattleIds { get; set; }=[];
    public IDictionary<int,string> TrainerPokemons { get; set; } = new Dictionary<int,string>();
}