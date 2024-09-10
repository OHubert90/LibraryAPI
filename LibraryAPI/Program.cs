using LibraryAPI.Data;
using LibraryAPI.Repositories;
using LibraryAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register your services and repositories
builder.Services.AddScoped<ILibraryRepository, LibraryRepository>(); // Geändert von Singleton zu Scoped
builder.Services.AddScoped<ILibraryService, LibraryService>(); // Geändert von Singleton zu Scoped

// Add InMemory database
builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseInMemoryDatabase("LibraryDb"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
