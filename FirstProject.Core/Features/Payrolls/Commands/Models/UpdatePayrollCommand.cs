using FirstProject.Core.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Features.Payrolls.Commands.Models
{
    public class UpdatePayrollCommand:IRequest<Response<string>>
    {
        public int PayrollID { get; set; }
        public int EmployeeID { get; set; } 
        public decimal PaymentAmount { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Housing { get; set; }
        public decimal OtherEarnings { get; set; }
        public decimal Deductions { get; set; }
        public int Year { get; set; }
        public int Period { get; set; }
    }
}
