using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MerchandiseService.Api.Infrastructure.Middlewares
{
    public class VersionMiddleware
    {
        public VersionMiddleware(RequestDelegate next)
        {
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "no version";
            var result = new
            {
                version,
                serviceName = Assembly.GetExecutingAssembly().GetName().Name
            };
            var jsonResult = new JsonResult(result);
            await context.Response.WriteAsJsonAsync(jsonResult);
        }
    }
}