using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Data.Entities
{
    public  class Payroll
    {
        [Key]
        public int PayrollID { get; set; }
        public int EmployeeID { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Housing { get; set; }
        public decimal OtherEarnings { get; set; }
        public decimal Deductions { get; set; }
        public int Year { get; set; }
        public int Period { get; set; }

       
        public virtual Employee Employee { get; set; }
    }
}
