using Microsoft.EntityFrameworkCore;
using Schedule_Project.ApplicationCore.Domain;
using Schedule_Project.ApplicationCore.Domain.Entities;





var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();





