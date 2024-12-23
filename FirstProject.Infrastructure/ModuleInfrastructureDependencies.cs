using FirstProject.Infrastructure.Abstracts;
using FirstProject.Infrastructure.InfrastructureBases;
using FirstProject.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FirstProject.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddModuleInfrastructureDependencies(this IServiceCollection services) 

            {
              
             services.AddTransient<IEmpolyeeRepository,EmployeeRepository>();
            services.AddTransient<IPayrollRepository,PayrollRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            return services;

            }
    }
}
