using ApplicationCore.Services.Repository;
using ApplicationCore.Services.Repository.UserRepository;
using TYPO.ApplicationCore.Domain.Entities;

namespace TYPO.Configurations
{
    public static class ConfigureRepository
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(ITypoRepository<>), typeof(TypoRepository<>));
            services.AddScoped(typeof(IUserRepository<User>), typeof(UserRepository));
            return services;
        }
        
    }
}
