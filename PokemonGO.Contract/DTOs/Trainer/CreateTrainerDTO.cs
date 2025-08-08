using PokemonGO.Domain.Enums;

namespace PokemonGO.Contract.DTOs.Trainer;
public class CreateTrainerDTO
{
    public Guid? Id { get; set; }
    public string Nickname { get; set; } = null!;
    public TrainerType TrainerType { get; set; }
}