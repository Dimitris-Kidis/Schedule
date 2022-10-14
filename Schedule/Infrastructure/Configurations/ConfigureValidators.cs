﻿using FluentValidation.AspNetCore;

namespace TYPO.Infrastructure.Configurations
{
    public static class ConfigureValidators
    {
        public static IMvcBuilder AddValidators(this IMvcBuilder services) =>
            services.AddFluentValidation(opt => opt.RegisterValidatorsFromAssembly(typeof(Command.Users.CreateNewUser.CreateNewUserCommand).Assembly));
    }
}
