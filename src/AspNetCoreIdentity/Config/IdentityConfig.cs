using AspNetCoreIdentity.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Config
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddAuthorizationConfig(this IServiceCollection services)
        {
            services.AddAuthorization(options => {
                options.AddPolicy("PodeExecutar", policy => policy.RequireClaim("PodeExecutar"));

                options.AddPolicy("PodeLer", policy => policy.Requirements.Add(new PermissaoNecessaria("PodeLer")));
                options.AddPolicy("PodeGravar", policy => policy.Requirements.Add(new PermissaoNecessaria("PodeGravar")));
            });

            return services;
        }
    }
}
