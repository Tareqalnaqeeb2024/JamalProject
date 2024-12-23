using AutoMapper;
using FirstProject.Core.Bases;
using FirstProject.Core.Features.Payrolls.Commands.Models;
using FirstProject.Data.Entities;
using FirstProject.Service.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Features.Payrolls.Commands.Handlers
{
    internal class PayrollHandlers : ResponseHandler,
                                 IRequestHandler<AddPayrollCommand, Response<string>>,
                                IRequestHandler<UpdatePayrollCommand,Response<string>>,
                                IRequestHandler<DeletePayrollCommand,Response<string>>



    {
        private readonly IPayrollService _payrollService;
        private readonly IMapper _mapper;

        public PayrollHandlers(IPayrollService payrollService , IMapper mapper)
        {
           _payrollService = payrollService;
            _mapper = mapper;
        }

      

        public async Task<Response<string>> Handle(AddPayrollCommand request, CancellationToken cancellationToken)
        {
           
            var payroll = new Payroll
            {
                EmployeeID = request.EmployeeID,
                PaymentAmount = request.PaymentAmount,
                BasicSalary = request.BasicSalary,
                Housing = request.Housing,
                OtherEarnings = request.OtherEarnings,
                Deductions = request.Deductions,
                Year = request.Year,
                Period = request.Period
            };

          
            var result = await _payrollService.CreatePayrollAsync(payroll);

            
            if (result == "Exist")
            {
                return UnProcessableEntity<string>("Payroll record already exists.");
            }
            else if (result == "Success")
            {
                return Created("Added entity successfully.");
            }
            else
            {
                return BadRequest<string>("Failed to add payroll record.");
            }
        }

        public async Task<Response<string>> Handle(UpdatePayrollCommand request, CancellationToken cancellationToken)
        {
            var payroll = await _payrollService.GetPayrollByIDAsync(request.PayrollID);

            if (payroll == null)
            {
                return BadRequest<string>("Payroll record not found.");
            }

            
            payroll.PaymentAmount = request.PaymentAmount;
            payroll.BasicSalary = request.BasicSalary;
            payroll.Housing = request.Housing;
            payroll.OtherEarnings = request.OtherEarnings;
            payroll.Deductions = request.Deductions;
            payroll.Year = request.Year;
            payroll.Period = request.Period;

           
            var result = await _payrollService.UpdatePayrollAsync(payroll);

            if (result == "Success")
            {
                return Created("Updated entity successfully.");
            }
            else
            {
                return BadRequest<string>("Failed to update payroll record.");
            }
        }

        public async Task<Response<string>> Handle(DeletePayrollCommand request, CancellationToken cancellationToken)
        {
           

            var Payroll = await _payrollService.GetPayrollByIDAsync(request.Id);

            if (Payroll == null)
            {
                return NotFound<string>();
            }

            var IsDeleted = await _payrollService.DeleteAsync(Payroll);
            if (IsDeleted == "Success") return Delete<string>();
            else
                return BadRequest<string>();
        }
    }

 }

