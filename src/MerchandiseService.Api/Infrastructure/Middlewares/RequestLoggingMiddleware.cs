using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MerchandiseService.Api.Infrastructure.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await LogRequest(context);
            await _next(context);
        }

        private async Task LogRequest(HttpContext context)
        {
            try
            {
                var requestPath = context.Request.Path;
                var headers = context.Request.Headers.Values;
                _logger.LogInformation("Request path logged");
                _logger.LogInformation(requestPath);
                _logger.LogInformation("Request headers logged");
                foreach (var header in headers)
                {
                    _logger.LogInformation(header);
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Could not log request headers and path");
            }
        }
    }
}