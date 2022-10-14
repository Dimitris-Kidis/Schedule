using ApplicationCore.Services.Repository;

namespace TYPO.Configurations
{
    public static class ConfigureRepository
    {
        public static IServiceCollection AddRepository(this IServiceCollection services) =>
            services.AddScoped(typeof(ITypoRepository<>), typeof(TypoRepository<>));
    }
}
