//using ApplicationCore.Services.Repository;
using TYPO.Configurations;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;


var builder = WebApplication.CreateBuilder(args);






builder.Services
    .AddRepository()
    .AddDbContext(builder);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<TypoDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("connectionString")));



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapGet("/", () => "Hello World!");
app.Run();





