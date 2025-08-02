namespace PokemonGO.Domain.Entity;

public class ActiveAbility : BaseAbility
{
    public int CoolDown { get; set; } 
    public int HealthEffective { get; set; }
    public int AttackEffective { get; set; }
    public int DefenseEffective { get; set; }
}