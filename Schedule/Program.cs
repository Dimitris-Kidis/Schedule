using Microsoft.EntityFrameworkCore;
using Schedule_Project.ApplicationCore.Controllers;
using Schedule_Project.ApplicationCore.Domain;
using Schedule_Project.ApplicationCore.Domain.Entities;



var user = new User()
{
    Id = 1,
    IsClient = true,
    Email = "m",
    FirstName = "Michael",
    LastName = "Adams",
    Password = "123",
    ProfilePic = "/1234",
    Age = 25,
    Gender = "Male",
    userInfos = new List<UserInfo>()
};

var context = new ScheduleDbContext();
context.Users.Add(user);
context.SaveChanges();

try
{
    var firstContext = new ScheduleDbContext(/*_options*/);
    var secondContext = new ScheduleDbContext(/*_options*/);

    var userChosen = firstContext.Users.First(s => s.Id == 1);
    var userOne = secondContext.Users.First(s => s.Id == 1);

    userChosen.Email = "32r43r";
    userOne.Email = "3r34r";

    firstContext.SaveChanges();
    secondContext.SaveChanges();
}
catch (DbUpdateConcurrencyException ex)
{

    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!" + ex.Message);
}




var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

Console.WriteLine("rrgergreg");




