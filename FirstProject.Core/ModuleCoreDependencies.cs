using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace FirstProject.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddModuleCoreDependencies( this IServiceCollection services)
        {
            //Configratuion of Medaior 
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            // Configratuion of AutoMapper

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }

    }
}
