using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Data.Entities
{
    public class VacationBalance
    {
        [Key]
        public int EmployeeId { get; set; }
        public int TotalVacationDays { get; set; }
        public int UsedVacationDays { get; set; }
        public int RemainingVacationDays { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
