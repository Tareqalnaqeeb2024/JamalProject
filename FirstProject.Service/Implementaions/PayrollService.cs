using AutoMapper;
using FirstProject.Data.Entities;
using FirstProject.Infrastructure.Abstracts;
using FirstProject.Service.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Service.Implementaions
{
    public class PayrollService :IPayrollService
    {
        private readonly IPayrollRepository _payrollRepository;
      

        public PayrollService( IPayrollRepository payrollRepository)
        {
            _payrollRepository = payrollRepository;
         
        }

        public async Task<string> CreatePayrollAsync(Payroll payroll)
        {
            var newpayroll = _payrollRepository.GetTableNoTracking()
                                                .Where(x => x.PayrollID.Equals(payroll.PayrollID))
                                                .FirstOrDefault();
            if (newpayroll != null)
            {
                return "Exist";
            }


            

            await _payrollRepository.AddAsync(payroll);

            return "Success";
        }

        public async Task<string> DeleteAsync(Payroll payroll)
        {
            var Trans = _payrollRepository.BeginTransaction();

            try
            {
                await _payrollRepository.DeleteAsync(payroll);
                await Trans.CommitAsync();
                return "Success";
            }
            catch (Exception)
            {
                await Trans.RollbackAsync();
                return "Faild";
            }
        }

        public async Task<Payroll> GetPayrollByIDAsync(int id)
        {
           

            var payroll = _payrollRepository.GetTableNoTracking()
                                             .Include(e => e.Employee)
                                             .Where(x => x.EmployeeID.Equals(id))
                                             .SingleOrDefault();

            return payroll;
                                  
        }

        public async Task<List<Payroll>> GetPayrollListAsync()
        {
            
            
            return await _payrollRepository.GetPayrollslListAsync();
        }

        public async Task<string> UpdatePayrollAsync(Payroll payroll)
        {
            await _payrollRepository.UpdateAsync(payroll);

            return "Success";
        }
    }
}
