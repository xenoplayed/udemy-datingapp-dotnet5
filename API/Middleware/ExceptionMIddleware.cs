using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using API.Erros;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API.Middleware
{
    public class ExceptionMIddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMIddleware> _logger;
        private readonly IHostEnvironment _env;
        public ExceptionMIddleware(RequestDelegate next, ILogger<ExceptionMIddleware> logger, IHostEnvironment env)
        {
            _logger = logger;
            _next = next;
            _env = env;

        }


        public async Task InvokeAsync(HttpContext context)
        {
            try 
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;

                var response = _env.IsDevelopment()
                    ? new ApiException(context.Response.StatusCode, ex.Message, ex.StackTrace?.ToString())
                    : new ApiException(context.Response.StatusCode, "Internal Server Error");

                var options = new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
                var json = JsonSerializer.Serialize(response, options);

                await context.Response.WriteAsync(json);
            }
        }
    }
}