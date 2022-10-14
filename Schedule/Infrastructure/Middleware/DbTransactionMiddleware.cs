using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain;

namespace TYPO.Infrastructure.Middleware
{
    public class DbTransactionMiddleware
    {
        private readonly RequestDelegate _next;
        

        public DbTransactionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, TypoDbContext dbContext)
        {
            if (httpContext.Request.Method == HttpMethod.Get.Method)
            {
                await _next(httpContext);
                return;
            }

            using (var transaction = await dbContext.Database.BeginTransactionAsync())
            {
                await _next(httpContext);
                await dbContext.Database.CommitTransactionAsync();
            }
                
        }
    }
}
