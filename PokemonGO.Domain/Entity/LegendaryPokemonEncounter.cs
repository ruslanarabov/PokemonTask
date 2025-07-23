namespace PokemonGO.Domain.Entity;

public class LegendaryPokemonEncounter : BaseEntity
{
    public int PokemonId { get; set; }
    public Pokemon Pokemon { get; set; }

    public string Location { get; set; }
    public bool IsCaught { get; set; }
    public DateTime EncounterTime { get; set; }
}