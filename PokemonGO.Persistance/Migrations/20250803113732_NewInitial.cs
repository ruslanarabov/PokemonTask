using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGO.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class NewInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultHP = table.Column<int>(type: "int", nullable: false),
                    DefaultAtack = table.Column<int>(type: "int", nullable: false),
                    DefaultDefense = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSpecie",
                columns: table => new
                {
                    PokemonsId = table.Column<int>(type: "int", nullable: false),
                    SpeciesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSpecie", x => new { x.PokemonsId, x.SpeciesId });
                    table.ForeignKey(
                        name: "FK_PokemonSpecie_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonSpecie_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecieEffects",
                columns: table => new
                {
                    AttackSpecieId = table.Column<int>(type: "int", nullable: false),
                    DefenseSpecieId = table.Column<int>(type: "int", nullable: false),
                    MultiplierType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecieEffects", x => new { x.AttackSpecieId, x.DefenseSpecieId });
                    table.ForeignKey(
                        name: "FK_SpecieEffects_Species_AttackSpecieId",
                        column: x => x.AttackSpecieId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecieEffects_Species_DefenseSpecieId",
                        column: x => x.DefenseSpecieId,
                        principalTable: "Species",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AbilityLevels",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    BaseAbilityId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityLevels", x => new { x.PokemonId, x.BaseAbilityId });
                    table.ForeignKey(
                        name: "FK_AbilityLevels_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Badges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    GymId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaseAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    TrainerPokemonId = table.Column<int>(type: "int", nullable: true),
                    CoolDown = table.Column<int>(type: "int", nullable: true),
                    HealthEffective = table.Column<int>(type: "int", nullable: true),
                    AttackEffective = table.Column<int>(type: "int", nullable: true),
                    DefenseEffective = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    PassiveAbility_HealthEffective = table.Column<int>(type: "int", nullable: true),
                    PassiveAbility_AttackEffective = table.Column<int>(type: "int", nullable: true),
                    PassiveAbility_DefenseEffective = table.Column<int>(type: "int", nullable: true),
                    OpponentHealth = table.Column<int>(type: "int", nullable: true),
                    OpponentAttack = table.Column<int>(type: "int", nullable: true),
                    OpponentDefense = table.Column<int>(type: "int", nullable: true),
                    IsHealthEffective = table.Column<bool>(type: "bit", nullable: true),
                    IsAttackEffective = table.Column<bool>(type: "bit", nullable: true),
                    IsDefenseEffective = table.Column<bool>(type: "bit", nullable: true),
                    StatusAbilityTypes = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseAbilities_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BattleType = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    OpponentId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDraw = table.Column<bool>(type: "bit", nullable: false),
                    WinnerTrainerId = table.Column<int>(type: "int", nullable: true),
                    LoserTrainerId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BattleTurns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BattleId = table.Column<int>(type: "int", nullable: false),
                    TurnNumber = table.Column<int>(type: "int", nullable: false),
                    AttackerTrainerPokemonId = table.Column<int>(type: "int", nullable: false),
                    DefenderTrainerPokemonId = table.Column<int>(type: "int", nullable: false),
                    AbilityUsedId = table.Column<int>(type: "int", nullable: false),
                    DamageDealt = table.Column<int>(type: "int", nullable: false),
                    DefenderRemainingHp = table.Column<int>(type: "int", nullable: false),
                    IsCriticalHit = table.Column<bool>(type: "bit", nullable: false),
                    IsDodged = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleTurns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BattleTurns_BaseAbilities_AbilityUsedId",
                        column: x => x.AbilityUsedId,
                        principalTable: "BaseAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BattleTurns_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gyms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaderTrainerId = table.Column<int>(type: "int", nullable: false),
                    LocationsId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gyms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WinnerId = table.Column<int>(type: "int", nullable: false),
                    LoserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    LocationId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trainers_Locations_LocationId1",
                        column: x => x.LocationId1,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trainers_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TrainerPokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonType = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CurrentHp = table.Column<int>(type: "int", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsShiny = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    GymId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerPokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerPokemons_Gyms_GymId",
                        column: x => x.GymId,
                        principalTable: "Gyms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TrainerPokemons_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerPokemons_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonAssignAbilities",
                columns: table => new
                {
                    TrainerPokemonId = table.Column<int>(type: "int", nullable: false),
                    BaseAbilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAssignAbilities", x => new { x.TrainerPokemonId, x.BaseAbilityId });
                    table.ForeignKey(
                        name: "FK_PokemonAssignAbilities_BaseAbilities_BaseAbilityId",
                        column: x => x.BaseAbilityId,
                        principalTable: "BaseAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonAssignAbilities_TrainerPokemons_TrainerPokemonId",
                        column: x => x.TrainerPokemonId,
                        principalTable: "TrainerPokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityLevels_BaseAbilityId",
                table: "AbilityLevels",
                column: "BaseAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Badges_GymId",
                table: "Badges",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_Badges_TrainerId",
                table: "Badges",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseAbilities_SpeciesId",
                table: "BaseAbilities",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseAbilities_TrainerPokemonId",
                table: "BaseAbilities",
                column: "TrainerPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_LoserTrainerId",
                table: "Battles",
                column: "LoserTrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_OpponentId",
                table: "Battles",
                column: "OpponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_TrainerId",
                table: "Battles",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_WinnerTrainerId",
                table: "Battles",
                column: "WinnerTrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleTurns_AbilityUsedId",
                table: "BattleTurns",
                column: "AbilityUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleTurns_AttackerTrainerPokemonId",
                table: "BattleTurns",
                column: "AttackerTrainerPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleTurns_BattleId",
                table: "BattleTurns",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleTurns_DefenderTrainerPokemonId",
                table: "BattleTurns",
                column: "DefenderTrainerPokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Gyms_LeaderTrainerId",
                table: "Gyms",
                column: "LeaderTrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Gyms_LocationsId",
                table: "Gyms",
                column: "LocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LoserId",
                table: "Locations",
                column: "LoserId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_WinnerId",
                table: "Locations",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAssignAbilities_BaseAbilityId",
                table: "PokemonAssignAbilities",
                column: "BaseAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSpecie_SpeciesId",
                table: "PokemonSpecie",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecieEffects_DefenseSpecieId",
                table: "SpecieEffects",
                column: "DefenseSpecieId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemons_GymId",
                table: "TrainerPokemons",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemons_PokemonId",
                table: "TrainerPokemons",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerPokemons_TrainerId",
                table: "TrainerPokemons",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_LocationId",
                table: "Trainers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_LocationId1",
                table: "Trainers",
                column: "LocationId1");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_UserId",
                table: "Trainers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbilityLevels_BaseAbilities_BaseAbilityId",
                table: "AbilityLevels",
                column: "BaseAbilityId",
                principalTable: "BaseAbilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Badges_Gyms_GymId",
                table: "Badges",
                column: "GymId",
                principalTable: "Gyms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Badges_Trainers_TrainerId",
                table: "Badges",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseAbilities_TrainerPokemons_TrainerPokemonId",
                table: "BaseAbilities",
                column: "TrainerPokemonId",
                principalTable: "TrainerPokemons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Trainers_LoserTrainerId",
                table: "Battles",
                column: "LoserTrainerId",
                principalTable: "Trainers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Trainers_OpponentId",
                table: "Battles",
                column: "OpponentId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Trainers_TrainerId",
                table: "Battles",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Trainers_WinnerTrainerId",
                table: "Battles",
                column: "WinnerTrainerId",
                principalTable: "Trainers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleTurns_TrainerPokemons_AttackerTrainerPokemonId",
                table: "BattleTurns",
                column: "AttackerTrainerPokemonId",
                principalTable: "TrainerPokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BattleTurns_TrainerPokemons_DefenderTrainerPokemonId",
                table: "BattleTurns",
                column: "DefenderTrainerPokemonId",
                principalTable: "TrainerPokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gyms_Locations_LocationsId",
                table: "Gyms",
                column: "LocationsId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gyms_Trainers_LeaderTrainerId",
                table: "Gyms",
                column: "LeaderTrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Trainers_LoserId",
                table: "Locations",
                column: "LoserId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Trainers_WinnerId",
                table: "Locations",
                column: "WinnerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Trainers_LoserId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Trainers_WinnerId",
                table: "Locations");

            migrationBuilder.DropTable(
                name: "AbilityLevels");

            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "BattleTurns");

            migrationBuilder.DropTable(
                name: "PokemonAssignAbilities");

            migrationBuilder.DropTable(
                name: "PokemonSpecie");

            migrationBuilder.DropTable(
                name: "SpecieEffects");

            migrationBuilder.DropTable(
                name: "Battles");

            migrationBuilder.DropTable(
                name: "BaseAbilities");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "TrainerPokemons");

            migrationBuilder.DropTable(
                name: "Gyms");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
