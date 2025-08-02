using System.Security.AccessControl;
using PokemonGO.Domain.Enums;

namespace PokemonGO.Domain.Entity;

public class StatusAbility : BaseAbility
{ 
    public bool IsHealthEffective { get; set; } = false;
    public bool IsAttackEffective { get; set; } = false;
    public bool IsDefenseEffective { get; set; } = false;
    public StatusAbilityType StatusAbilityTypes { get; set; }
}