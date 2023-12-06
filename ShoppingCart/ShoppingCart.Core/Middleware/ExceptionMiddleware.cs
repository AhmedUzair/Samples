using Microsoft.AspNetCore.Http;
using Serilog;

namespace ShoppingCart.Core
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger _logger;
        private readonly string _correlationId;
        public ExceptionMiddleware(RequestDelegate next,
                                   IHttpContextAccessor contextAccessor,
                                   ILogger logger)
        {
            _next = next;
            _contextAccessor = contextAccessor;
            _logger = logger;
            _correlationId = Guid.NewGuid().ToString();
        }

        public async Task Invoke(HttpContext httpContext, ILogger logger)
        {
            try
            {
                await _next.Invoke(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
                   

            _logger.Error( $"Middleware Exception: {exception.Message}");


            return context.Response.WriteAsync("");

        }
    }
}
