using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace AutoShopping.Modules
{
    /// <summary>
    /// Swagger da aplicação.
    /// </summary>
    public static class SwaggerExtensions
    {
        public static void UsaSwaggerUi(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AutoShopping - Eduardo");

            });
        }

        public static void ConfiguraSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API Auto Shopping",
                    Description = "Api responsável pela venda dos veiculos do Auto Shopping.",
                    Version = "v1",
                    TermsOfService = new Uri("https://www.autoshopping.com.br/")
                });

                var apiPath = Path.Combine(AppContext.BaseDirectory, "AutoShopping.xml");
                var applicationPath = Path.Combine(AppContext.BaseDirectory, "AutoShopping.Application.xml");

                c.IncludeXmlComments(apiPath);
                c.IncludeXmlComments(applicationPath);
            });
        }
    }

            
}
