using AutoMapper;
using FirstProject.Core.Bases;
using FirstProject.Core.Features.Payrolls.Queries.Models;
using FirstProject.Core.Features.Payrolls.Queries.Responses;
using FirstProject.Data.Entities;
using FirstProject.Service.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Features.Payrolls.Queries.Handlers
{
    internal class PayrollHandler :ResponseHandler, 

                               IRequestHandler<GetPayrollsListQuery, Response< List<GetPayrollsListResponse>>>,
                                 IRequestHandler<GetPayrollsByIDQuery, Response< GetPayrollByIDResponse>>
    {
        private readonly IPayrollService _payrollService;
        private readonly IMapper _mapper;

        public PayrollHandler(IPayrollService payrollService , IMapper mapper )
        {
            _payrollService = payrollService;
            _mapper = mapper;
        }

        public async Task<Response <List<GetPayrollsListResponse>>> Handle(GetPayrollsListQuery request, CancellationToken cancellationToken)
        {

            var PayrollList = await _payrollService.GetPayrollListAsync();
            var PayrollMapper = _mapper.Map<List<GetPayrollsListResponse>>(PayrollList);

            return Success(PayrollMapper);
        }

        public async Task<Response <GetPayrollByIDResponse>> Handle(GetPayrollsByIDQuery request, CancellationToken cancellationToken)
        {


            

            var payroll = await _payrollService.GetPayrollByIDAsync(request.Id);

            if(payroll == null)
            {
                return NotFound<GetPayrollByIDResponse>("Not Found ");
            }
           
            var payrollMapper = _mapper.Map<GetPayrollByIDResponse>(payroll);

            return Success( payrollMapper);
        }

       
    }
}
