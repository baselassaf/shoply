using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extentions
{
    public static class SwaggerServiceExtentions
    {
         public static IServiceCollection AddSwaggerDocumentain(this IServiceCollection services)
         {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1" , new OpenApiInfo {Title = "Shoply Api", Version = "v1" });
            });

            return services;
         }

         public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
         {
             app.UseSwagger();
             app.UseSwaggerUI(c => {c
                .SwaggerEndpoint("/swagger/v1/swagger.json", "shoply api v1"); });

            return app;
         }
    }
}