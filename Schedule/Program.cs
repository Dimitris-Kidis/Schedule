//using ApplicationCore.Services.Repository;
using TYPO.Configurations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain;
using HT3.Repositories;
using HT3.Services;
using AutoMapper;
using HT3.Mappings;
using TYPO.MapperProfile;
using System.Reflection;
using Query.Users.GetAllUsers;
using TYPO.ExceptionFilter;
using FluentValidation.AspNetCore;
using FluentValidation;
using Command.Users.CreateNewUser;
using TYPO.Infrastructure.Configurations;

var builder = WebApplication.CreateBuilder(args);



builder.Services
    .AddRepository()
    .AddDbContext(builder)
    .AddMapper()
    .AddSwaggerServices()
    .AddMediatRConfigs()
    .AddControllers(option => option.Filters.Add(typeof(ApiExceptionFilter)))
    .AddValidators(); // 
    
   









var app = builder.Build();




if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseErrorHandlingMiddleware(); //

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseDbTransaction(); // 

app.MapControllers();

app.MapGet("/", () => "Hello World!");
app.Run();

public partial class Program { } // Для тестов


