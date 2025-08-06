using Microsoft.AspNetCore.Identity;
namespace PokemonGO.Domain.Entity;

public class AppUser : IdentityUser
{ 
    public DateTime CreatedTime { get; set; } 
    public DateTime? UpdatedTime { get; set; } 
    public bool IsDeleted { get; set; }
}