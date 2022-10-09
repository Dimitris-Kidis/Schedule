using AutoMapper;
using TYPO.MapperProfile;

namespace TYPO.Configurations
{
    public static class ConfigureMapper
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {

            services.AddAutoMapper(typeof(Program).Assembly, typeof(Query.Texts.GetRandomTextByLanguage.GetRandomTextByLanguageQuery).Assembly);
            services.AddAutoMapper(typeof(Program).Assembly, typeof(Controllers.Users.MapperProfiles).Assembly);
            return services;
        }
        // Добавить для команды
    }
}
