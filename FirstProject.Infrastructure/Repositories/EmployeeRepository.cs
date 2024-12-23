using FirstProject.Data.Entities;
using FirstProject.Infrastructure.Abstracts;
using FirstProject.Infrastructure.Data;
using FirstProject.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Infrastructure.Repositories
{
    public class EmployeeRepository :GenericRepository<Employee>,IEmpolyeeRepository
    {
        public EmployeeRepository(ApplicationDBContext dBContext) :base(dBContext) 
        {

        }

        public async Task<List<Employee>> GetAllEmpoyeeAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }
    }
}
