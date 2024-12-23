using FirstProject.Service.Abstracts;
using FirstProject.Service.Implementaions;
using Microsoft.Extensions.DependencyInjection;

namespace FirstProject.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService,EmployeeService>();
            services.AddTransient<IPayrollService,PayrollService>();
            return services;
        }

    }
}
