using AutoMapper;
using FirstProject.Core.Features.Payrolls.Queries.Responses;
using FirstProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Mapping.Employees
{
   public partial class PayrollEmployeeProfile :Profile
    {
        public PayrollEmployeeProfile()
        {
            GetPayrollsListMapping();
            GetPayrollByID();
        }

        
       
    }
}
