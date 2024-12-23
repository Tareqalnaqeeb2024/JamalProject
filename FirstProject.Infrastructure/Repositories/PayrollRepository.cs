using FirstProject.Data.Entities;
using FirstProject.Infrastructure.Abstracts;
using FirstProject.Infrastructure.Data;
using FirstProject.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Infrastructure.Repositories
{
    public class PayrollRepository :GenericRepository<Payroll>, IPayrollRepository
    {
        private readonly ApplicationDBContext _dBContext;

        public PayrollRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<List<Payroll>> GetPayrollslListAsync()
        {
            return await _dBContext.payrolls.Include(e => e.Employee).ToListAsync();

        }

        

        //public async Task<Payroll> GetPayrollAsync(int payrollId)
        //{
        //   //return await _dBContext.payrolls.Include(e => e.Employee)
        //   //                                 .Where(e => e.EmployeeID.Equals(payrollId))
        //   //                                  .SingleOrDefaultAsync(); 

        //    var Payroll  = _


    }


       
    
}
