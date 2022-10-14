using TYPO.Configurations;
using TYPO.ExceptionFilter;
using TYPO.Infrastructure.Configurations;

var builder = WebApplication.CreateBuilder(args);



builder.Services
    .AddRepository()
    .AddDbContext(builder)
    .AddMapper()
    .AddSwaggerServices()
    .AddMediatRConfigs()
    .AddControllers(option => option.Filters.Add(typeof(ApiExceptionFilter)))
    .AddValidators();
    
   









var app = builder.Build();




if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseErrorHandlingMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseDbTransaction(); 

app.MapControllers();

app.MapGet("/", () => "Hello World!");
app.Run();




