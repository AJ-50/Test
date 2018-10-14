using System.Web.Http;
using WebActivatorEx;
using Swashbuckle.Swagger;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerDocsConfig), "Register")]

namespace WebAPIDotNet
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerDocsConfig).Assembly;
            GlobalConfiguration.Configuration
                .EnableSwagger(c => c.SingleApiVersion("v1", "WebAPIDotNet"))
                .EnableSwaggerUi();
        }
    }
}
