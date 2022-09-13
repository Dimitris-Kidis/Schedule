using Microsoft.EntityFrameworkCore;
using Schedule_Project.ApplicationCore.Domain;
using Schedule_Project.ApplicationCore.Domain.Entities;




var user = new User()
{
    Id = 1,
    IsClient = true,
    Email = "mikeadams@gmail.com",
    FirstName = "Michael",
    LastName = "Adams",
    Password = "12&^*3",
    ProfilePic = "db:1234",
    Age = 25,
    Gender = "Male",
    userInfos = new List<UserInfo>()
};

var context = new ScheduleDbContext();
context.Users.Add(user);
context.SaveChanges();


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();





