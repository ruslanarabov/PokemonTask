using PokemonGO.Domain.Enums;

namespace PokemonGO.Domain.Entity;

public class PassiveAbility : BaseAbility
{
    public int Duration { get; set; }
    public int HealthEffective { get; set; }
    public int AttackEffective { get; set; }
    public int DefenseEffective { get; set; }
    public int OpponentHealth { get; set; }
    public int OpponentAttack { get; set; }
    public int OpponentDefense { get; set; }
}