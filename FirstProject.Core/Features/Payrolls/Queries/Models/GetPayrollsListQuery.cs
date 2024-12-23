using FirstProject.Core.Bases;
using FirstProject.Core.Features.Payrolls.Queries.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Features.Payrolls.Queries.Models
{
    public class GetPayrollsListQuery:IRequest<Response <List<GetPayrollsListResponse>>>
    {
    }
}
