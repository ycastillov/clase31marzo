using clase31marzo.src.Data;
using clase31marzo.src.Interfaces;
using clase31marzo.src.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext> (options => options.UseSqlite("Data Source=Practica1.db"));
builder.Services.AddControllers();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IStoreRepository, StoreRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope()) // Se levanta la base de datos
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DataContext>(); // Obtener servicio 
    await context.Database.MigrateAsync(); // Se realiza la migración de la base de datos de forma asincrona
}

app.Run();