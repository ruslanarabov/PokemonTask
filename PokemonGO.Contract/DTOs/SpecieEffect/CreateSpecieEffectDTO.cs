using PokemonGO.Domain.Enums;

namespace PokemonGO.Contract.DTOs.SpecieEffectiveness;

public class CreateSpecieEffectDTO
{
    public int AttackingSpecieId { get; set; }
    public int DefendingSpecieId { get; set; }
    public Multiplier Type { get; set; }
}