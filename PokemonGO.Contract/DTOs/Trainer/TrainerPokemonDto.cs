namespace PokemonGO.Contract.DTOs.Trainer;

public record TrainerPokemonDto
{
    public int Id { get; set; }
    public int PokemonId { get; set; }
    public string Nickname { get; set; }
}