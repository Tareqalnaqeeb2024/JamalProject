using Azure;
using FirstProject.Core.Bases;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Features.Payrolls.Commands.Models
{
    public class DeletePayrollCommand: IRequest<Bases.Response<string>>
    {
         public int Id;

        public DeletePayrollCommand( int id)
        {
            Id = id;
        }
    }
}
