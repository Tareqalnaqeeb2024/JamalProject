using FirstProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Service.Abstracts
{
     public interface IEmployeeService
    {
         public Task<List<Employee>> GetAllEmpoyeeAsync();
    }
}
