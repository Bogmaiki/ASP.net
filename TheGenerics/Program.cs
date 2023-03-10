using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheGenerics.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TheGenericsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TheGenericsContext") ?? throw new InvalidOperationException("Connection string 'TheGenericsContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(x=>x.AddPolicy("mypolicy", 
    c=>c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCors("mypolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
