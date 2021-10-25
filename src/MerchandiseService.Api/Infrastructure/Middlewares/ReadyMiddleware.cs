using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MerchandiseService.Api.Infrastructure.Middlewares
{
    public class ReadyMiddleware
    {
        public ReadyMiddleware(RequestDelegate next)
        {
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var jsonResult = new JsonResult(string.Empty)
            {
                StatusCode = StatusCodes.Status200OK
            };
            await context.Response.WriteAsJsonAsync(jsonResult);
        }
    }
}