using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGO.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gold",
                table: "Trainers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gold",
                table: "Trainers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
