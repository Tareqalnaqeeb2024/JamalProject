using FirstProject.Data.Entities;
using FirstProject.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Infrastructure.Abstracts
{
    public interface IPayrollRepository:IGenericRepository<Payroll>
    {
        public Task<List<Payroll>> GetPayrollslListAsync(); 
        
    }
}
