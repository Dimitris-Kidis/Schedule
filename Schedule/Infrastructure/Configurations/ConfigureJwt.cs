using TYPO.Identity;

namespace TYPO.Infrastructure.Configurations
{
    public static class ConfigureJwt
    {
        public static IServiceCollection AddJwt(this IServiceCollection services)
        {
            services.AddJwtAuthentication();
            services.AddScoped<JwtHandler>();
            return services;
        }
    }
}
