using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Features.Payrolls.Queries.Responses
{
    public class GetPayrollByIDResponse
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string ResidentID { get; set; }
        public string BankID { get; set; }
        public string AccountNumber { get; set; }
        public string Department { get; set; }

        public decimal PaymentAmount { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Housing { get; set; }
        public decimal OtherEarnings { get; set; }
        public decimal Deductions { get; set; }
    }
}
