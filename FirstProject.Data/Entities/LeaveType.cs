using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Data.Entities
{
    public  class LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }
    }
}
