using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace SoapMiddleware
{
    public class SoapEndpoint
    {
        private readonly RequestDelegate _next;

        public SoapEndpoint(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine($"Request for {httpContext.Request.Path} received ({httpContext.Request.ContentLength ?? 0} bytes)");

            // Call the next middleware delegate in the pipeline 
            await _next.Invoke(httpContext);
        }

    }
}

