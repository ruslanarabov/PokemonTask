using PokemonGO.Domain.Enums;

namespace PokemonGO.Contract.DTOs.SpecieEffectiveness;

public class SpecieEffectDTO
{
    public int AttackingSpecieId { get; set; }
    public string AttackingSpecie { get; set; } = string.Empty;

    public int DefendingSpecieId { get; set; }
    public string DefendingSpecie { get; set; } = string.Empty;

    public Multiplier Type { get; set; }
}