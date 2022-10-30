using Microsoft.AspNetCore.Identity;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;
using TYPO.Identity;

namespace TYPO.Infrastructure.Configurations
{

    public static class ConfigureIdentity
    {
        public static IdentityBuilder AddIdentityConfiguration(this IServiceCollection services) => 
            services.AddIdentity<User, Role>(options =>
                {
                    options.User.RequireUniqueEmail = false;
                })
                .AddEntityFrameworkStores<TypoDbContext>()
                .AddDefaultTokenProviders();
    }
}
