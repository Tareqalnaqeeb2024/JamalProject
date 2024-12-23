using FirstProject.Data.Entities;
using FirstProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Infrastructure.Abstracts
{
    public interface IEmpolyeeRepository
    {
         public Task<List<Employee>> GetAllEmpoyeeAsync( );
    }
}
