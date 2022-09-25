using ApplicationCore.Services.Repository;
using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;

namespace TYPO.Configurations
{
    public static class ConfigureDbContext
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<ITypoRepository<User>, TypoRepository<User>>();
            
            //services.AddDbContext<TypoDbContext>(opt => opt.UseSqlServer("Server=.;Database=TYPO;Trusted_Connection=True;Integrated Security=True"));

            return services;
        }
    }
}
