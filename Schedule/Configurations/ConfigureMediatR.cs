using MediatR;
using Query.Users.GetAllUsers;

namespace TYPO.Configurations
{
    public static class ConfigureMediatR
    {
        public static IServiceCollection AddMediatRConfigs(this IServiceCollection services)
        {
            //builder.Services.AddMediatR(typeof(/* тут command file */).Assembly);
            services.AddMediatR(typeof(GetAllUsersQueryHandler).Assembly);
            return services;
        }
           
    }
}
