using FirstProject.Core.Features.Payrolls.Queries.Responses;
using FirstProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstProject.Core.Mapping.Employees
{

    public partial class PayrollEmployeeProfile
    {

        public void GetPayrollsListMapping()
        {
            CreateMap<Payroll, GetPayrollsListResponse>()
                 .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.Employee.EmployeeId))
            .ForMember(dest => dest.ResidentID, opt => opt.MapFrom(src => src.Employee.ResidentID))
            .ForMember(dest => dest.BankID, opt => opt.MapFrom(src => src.Employee.BankID))
            .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.Employee.AccountNumber))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Employee.Name))
            .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Employee.Department))

            .ForMember(dest => dest.PaymentAmount, opt => opt.MapFrom(src => src.PaymentAmount))
            .ForMember(dest => dest.BasicSalary, opt => opt.MapFrom(src => src.BasicSalary))
            .ForMember(dest => dest.Housing, opt => opt.MapFrom(src => src.Housing))
            .ForMember(dest => dest.OtherEarnings, opt => opt.MapFrom(src => src.OtherEarnings))
            .ForMember(dest => dest.Deductions, opt => opt.MapFrom(src => src.Deductions));

        }
    }
}
