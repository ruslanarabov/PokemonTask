using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PokemonGO.Application.Extensions;
using PokemonGO.Application.Profiles;
using PokemonGO.Domain;
using PokemonGO.Domain.Entity;
using PokemonGO.Persistance.Data;
using PokemonGO.Persistance.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PokemonDB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnStr")));

// Add custom services and repositories
builder.Services.AddRepositoryRegistration();
builder.Services.AddServiceRegistration();

// mapper configuration
builder.Services.AddAutoMapper(typeof(CustomProfile));


// Register Identity services
builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireLowercase = false;
            options.User.RequireUniqueEmail = true;
            options.SignIn.RequireConfirmedAccount = false;
        }
    )
    .AddEntityFrameworkStores<PokemonDB>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();