﻿using TYPO.Infrastructure.Middleware;

namespace TYPO.Configurations
{
    public static class ConfigureMiddlewares
    {
        public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder app) => app.UseMiddleware<ErrorHandlingMiddleware>();

        public static IApplicationBuilder UseDbTransactionMiddleware(this IApplicationBuilder app) => app.UseMiddleware<DbTransactionMiddleware>();
    }
}