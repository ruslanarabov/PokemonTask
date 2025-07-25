namespace PokemonGO.Contract.DTOs.Trainer;

public record TrainerBadgeDto
{
    public int Id { get; set; }
    public int BadgeId { get; set; }
    public DateTime EarnedDate { get; set; }
}