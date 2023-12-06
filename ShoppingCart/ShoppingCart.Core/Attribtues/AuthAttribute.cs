using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.IdentityModel.Tokens.Jwt;

namespace ShoppingCart.Core.Attribtues
{
    public class AuthAttribute : ActionFilterAttribute
    {
        private ILogger _logger;

        private IConfiguration _config;

        private string _correlationId = Guid.NewGuid().ToString();

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            _logger = (ILogger)context.HttpContext.RequestServices.GetService(typeof(ILogger));

            _config = (IConfiguration)context.HttpContext.RequestServices.GetService(typeof(IConfiguration));

            var httpContext = context.HttpContext;

            string responseDescription = "Authorization header not present in request";

            DateTime tokenExpiryTime = DateTime.Now;

            if (httpContext.Request.Headers.ContainsKey("Authorization"))

            {

                string value = httpContext.Request.Headers["Authorization"];

                var jwtHandler = new JwtSecurityTokenHandler();

                if (jwtHandler.CanReadToken(value))

                {

                    var token = jwtHandler.ReadJwtToken(value);

                    tokenExpiryTime = token.ValidTo;

                    if (DateTime.UtcNow < token.ValidTo)  // if we need to check expiry and issuer both
                    {
                        // check issuer in here
                    }
                    else
                    {
                        responseDescription = "The token is expired, please generate a new token";
                    }
                }
                else
                {
                    responseDescription = "The token doesn't seem to be in a proper JWT format.";
                }
            }          

            _logger.Warning("Authorization issue");
        }

    }

}

