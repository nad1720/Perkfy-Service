using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Perkfy.Application;
using Perkfy.Data;
using Perkfy.Data.Models;
using Perkfy.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var DefaultString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PerkfyContext>(

    options => options.UseSqlServer(DefaultString)
    );
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
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
