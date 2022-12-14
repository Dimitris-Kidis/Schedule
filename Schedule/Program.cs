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
builder.Services.AddJwt().AddIdentityConfiguration();






var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(configurePolicy => configurePolicy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseErrorHandlingMiddleware();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.UseDbTransactionMiddleware(); 

app.MapControllers();

app.Run();




