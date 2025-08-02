using PokemonGO.Domain.Enums;
namespace PokemonGO.Domain.Entity;
public class SpecieEffect
{
    public int AttackSpecieId { get; set; }
    public Specie AttackSpecie { get; set; } = null!;
    public int DefenseSpecieId { get; set; }
    public Specie DefenseSpecie { get; set; } = null!;
    public Multiplier MultiplierType { get; set; } = Multiplier.Normal;
}