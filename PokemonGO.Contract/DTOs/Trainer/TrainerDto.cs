namespace PokemonGO.Contract.DTOs.Trainer;

public record TrainerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public List<TrainerPokemonDto> Pokemons { get; set; }
    public List<TrainerBadgeDto> Badges { get; set; }
    public List<TrainerItemDto> Items { get; set; }
}