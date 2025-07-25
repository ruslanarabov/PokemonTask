namespace PokemonGO.Contract.DTOs.Trainer;

public record TrainerItemDto
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; }
}