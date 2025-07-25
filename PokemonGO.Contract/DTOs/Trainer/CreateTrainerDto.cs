using System.Reflection.Metadata.Ecma335;

namespace PokemonGO.Contract.DTOs.Trainer;

public record CreateTrainerDto
{
    public string Name { get; set; }
}