//using ApplicationCore.Services.Repository;
using TYPO.Configurations;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;


var builder = WebApplication.CreateBuilder(args);






builder.Services.AddRepository();

builder.Services.AddDbContext<TypoDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("connectionString")));





var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Run();





