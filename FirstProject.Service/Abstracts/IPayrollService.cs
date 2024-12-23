using FirstProject.Data.Entities;

namespace FirstProject.Service.Abstracts
{
    public interface IPayrollService

    {
        public Task<List<Payroll>> GetPayrollListAsync();
        public Task<Payroll> GetPayrollByIDAsync(int id);
        public Task<string> CreatePayrollAsync(Payroll payroll);
        public Task<string> UpdatePayrollAsync(Payroll payroll);
        public Task<string> DeleteAsync(Payroll payroll);
      

    }
}
