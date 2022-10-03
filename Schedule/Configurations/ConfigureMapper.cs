using AutoMapper;
using TYPO.MapperProfile;

namespace TYPO.Configurations
{
    public static class ConfigureMapper
    {
        //public static IServiceCollection AddMapper(this IServiceCollection services) =>
        //    services.AddAutoMapper(typeof(Program).Assembly, typeof(TypoMapperProfile).Assembly);

        public static IServiceCollection AddMapper(this IServiceCollection services, WebApplicationBuilder builder)
        {
            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new TypoMapperProfile());
            });
            builder.Services.AddSingleton(mapperConfig.CreateMapper());
            return services.AddAutoMapper(typeof(Program).Assembly, typeof(TypoMapperProfile).Assembly);
        }
            
           

    }
}
