using ApplicationCore.Services.Repository;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;

namespace TYPO.Configurations
{
    public static class ConfigureDbContext
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, WebApplicationBuilder builder) =>
            services.AddDbContext<TypoDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("connectionString"));
            });
    }
}
