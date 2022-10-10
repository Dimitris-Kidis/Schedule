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
using TYPO.MapperProfile;
using System.Reflection;
using Query.Users.GetAllUsers;
using TYPO.ExceptionFilter;

var builder = WebApplication.CreateBuilder(args);



builder.Services
    .AddRepository()
    .AddDbContext(builder)
    .AddMapper()
    .AddSwaggerServices()
    .AddMediatRConfigs()
    .AddControllers(option => option.Filters.Add(typeof(ApiExceptionFilter)));







// ********************* УДАЛИИИИИИИИИИИИИИИИИТЬ ПОСЛЕ СДАЧИ ДЗ *********************
//var mapperConfig = new MapperConfiguration(m =>
//{
//    m.AddProfile(new TextMappingProfile());
//});
//builder.Services.AddSingleton(mapperConfig.CreateMapper());
//builder.Services.AddScoped(typeof(IRepo<>), typeof(Repo<>));
//builder.Services.AddScoped<ITextService, TextService>();
// **********************************************************************************



var app = builder.Build();


app.UseMiddleware<ErrorHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => "Hello World!");
app.Run();

public partial class Program { } // Для тестов


