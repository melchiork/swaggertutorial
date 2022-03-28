using System.IO;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SwaggerTutorial.API
{
    public class DescriptionFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "SwaggerTutorial.API.Docs.intro.md";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                swaggerDoc.Info.Description = reader.ReadToEnd().Replace("\r", ""); ;
            }
        }
    }
}