using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//register data context service
builder.Services.AddDbContext<DataContext>(opt =>
{
    //creating configuration default connection string 
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors();

var app = builder.Build();

// Middleware 
// Configure the HTTP request pipeline.
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200", "https://localhost:4200"));
app.MapControllers();

app.Run();
