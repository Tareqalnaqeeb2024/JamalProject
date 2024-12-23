using FirstProject.Data.Entities;
using FirstProject.Infrastructure.Abstracts;
using FirstProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Service.Implementaions
{
    public class EmployeeService :IEmployeeService
    {
        private readonly IEmpolyeeRepository _empolyeeRepository;

        public EmployeeService(IEmpolyeeRepository empolyeeRepository)
        {  
             _empolyeeRepository = empolyeeRepository;
        }

      
        public async Task<List<Employee>> GetAllEmpoyeeAsync()
        {
            return await _empolyeeRepository.GetAllEmpoyeeAsync();
        }
    }
}
