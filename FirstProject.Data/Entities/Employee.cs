using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Data.Entities
{
    public  class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string ResidentID { get; set; }
        public string BankID { get; set; }
        public string AccountNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }

        public virtual VacationBalance VacationBalance { get; set; }

        public virtual ICollection<Payroll> Payrolls { get; set; }
    }
}
