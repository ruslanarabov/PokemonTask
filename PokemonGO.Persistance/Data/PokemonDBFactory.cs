using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace PokemonGO.Persistance.Data;
public class PokemonDBFactory : IDesignTimeDbContextFactory<PokemonDB>
{
    public PokemonDB CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PokemonDB>();
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=PokemonGame;User Id=SA;Password=Str0ng@Pwd123;Encrypt=True;TrustServerCertificate=True;");
        return new PokemonDB(optionsBuilder.Options);
    }
}