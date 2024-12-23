using FirstProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
       

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; } 
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Payroll> payrolls {  get; set; }
        public DbSet<VacationBalance> vacations { get; set; }
    }
}
