using Command.Texts.CreateNewText;
using MediatR;
using Query.Users.GetAllUsers;

namespace TYPO.Configurations
{
    public static class ConfigureMediatR
    {
        public static IServiceCollection AddMediatRConfigs(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllUsersQueryHandler).Assembly);
            services.AddMediatR(typeof(CreateNewTextCommandHandler).Assembly);
            return services;
        }
           
    }
}
