using CodeGenerator.Share.Enums;
using CodeGeneratorService.Builders;
using CodeGeneratorService.Interfaces;
using CodeGeneratorService.Interfaces.Builders;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace CodeGeneratorService.Extensions
{
    public static class ServiceBuilderExtensions
    {
        public static IServiceCollection RegisterBuilder(this IServiceCollection services)
        {
            services.AddTransient<ISqlProcedureBuilder, SqlProcedureBuilder>();
            services.AddTransient<ICSharpUserTableTypeBuilder, CSharpUserTableTypeBuilder>();
            services.AddTransient<ICSharpWcfBuilder, CSharpWcfBuilder>();
            services.AddTransient<ICSharpWebApiBuilder, CSharpWebApiBuilder>();
            services.AddTransient<ISqlFunctionBuilder, SqlFunctionBuilder>();
            services.AddTransient<ISqlProcedureBuilder, SqlProcedureBuilder>();
            services.AddTransient<ISqlUserTableTypeBuilder, SqlUserTableTypeBuilder>();

            services.AddTransient<BuilderResolver>(serviceProvider => key =>
            {
                switch (key)
                {
                    case OutputCategories.CSharpApiCore:
                        return serviceProvider.GetService<ICSharpApiCoreBuilder>();
                    case OutputCategories.CSharpUserTableType:
                        return serviceProvider.GetService<ICSharpUserTableTypeBuilder>();
                    case OutputCategories.CSharpWcf:
                        return serviceProvider.GetService<ICSharpWcfBuilder>();
                    case OutputCategories.CSharpWebApi:
                        return serviceProvider.GetService<ICSharpWebApiBuilder>();
                    case OutputCategories.SqlFunction:
                        return serviceProvider.GetService<ISqlFunctionBuilder>();
                    case OutputCategories.SqlProcedure:
                        return serviceProvider.GetService<ISqlProcedureBuilder>();
                    case OutputCategories.SqlUserTableType:
                        return serviceProvider.GetService<ISqlUserTableTypeBuilder>();
                    default:
                        throw new KeyNotFoundException(); // or maybe return null, up to you
                }
            });
            // Add all other services here.
            return services;
        }
    }
}