using FirstProject.Core.Features.Employees.Queries.Models;
using FirstProject.Data.Entities;
using FirstProject.Service.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Features.Employees.Queries.Handlers
{
    public class EmployeesHandler : IRequestHandler<GetAllEmployeesListQuery, List<Employee>>
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesHandler( IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<List<Employee>> Handle(GetAllEmployeesListQuery request, CancellationToken cancellationToken)
        {

            return await _employeeService.GetAllEmpoyeeAsync();
            
        }
    }
}
