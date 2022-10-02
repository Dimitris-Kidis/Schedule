//using ApplicationCore.Services.Repository;
using TYPO.Configurations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;
using TYPO.Middleware;
using HT3.Repositories;
using HT3.Services;
using AutoMapper;
using HT3.Mappings;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine(DateTime.Now);

builder.Services
    .AddRepository()
    .AddDbContext(builder);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




var mapperConfig = new MapperConfiguration(m =>
{
    m.AddProfile(new TextMappingProfile());
});
builder.Services.AddSingleton(mapperConfig.CreateMapper());


builder.Services.AddScoped(typeof(IRepo<>), typeof(Repo<>));
builder.Services.AddScoped<ITextService, TextService>();



var app = builder.Build();

// ВОПРОС AddMediatR ???

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => "Hello World!");
app.Run();




