using SoapMiddleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreAPI
{
    public class Extensions
    {
    }
}

namespace Microsoft.AspNetCore.Builder
{
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class SOAPEndpointExtensions
    {
        public static IApplicationBuilder UseSOAPEndpoint(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SoapEndpoint>();
        }
    }
}