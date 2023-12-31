﻿using Microsoft.AspNetCore.Builder;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Helpers
{
    public static class SwaggerExtension
    {
        public static void UseCustomSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger().UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Samcooks API v1");
                //c.RoutePrefix = string.Empty;
                c.DisplayRequestDuration();
                c.DefaultModelsExpandDepth(-1);
                c.DocExpansion(DocExpansion.None);
            });
        }

        //public static IApplicationBuilder UseSwaggerAuthorized(this IApplicationBuilder builder)
        //{
        //    return builder.UseMiddleware<SwaggerAuthMiddleware>();
        //}
    }
}
