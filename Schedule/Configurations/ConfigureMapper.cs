using AutoMapper;
using TYPO.MapperProfile;

namespace TYPO.Configurations
{
    public static class ConfigureMapper
    {
        public static IServiceCollection AddMapper(this IServiceCollection services) =>
            services.AddAutoMapper(typeof(Program).Assembly, typeof(Query.Texts.GetTextWithAuthor.GetTextWithAuthorQuery).Assembly);
        // Добавить для команды
    }
}
