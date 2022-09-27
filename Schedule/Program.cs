//using ApplicationCore.Services.Repository;
using TYPO.Configurations;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;


var builder = WebApplication.CreateBuilder(args);






builder.Services.AddRepository();

builder.Services.AddDbContext<TypoDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("connectionString")));

//using var context = new TypoDbContext();
//var person = new User()
//{

//    Age = 20,
//    CreatedBy = DateTime.Now
//};
//context.Users.Add(person);
//context.SaveChanges();



var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.Run();





