using FirstProject.APi.ApiControllerBases;
using FirstProject.Core.Bases;
using FirstProject.Core.Features.Employees.Queries.Models;
using FirstProject.Core.Features.Payrolls.Commands.Models;
using FirstProject.Core.Features.Payrolls.Queries.Models;
using FirstProject.Core.Features.Payrolls.Queries.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.APi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class PayrollsController :ApiontrollerBase
    {
        public PayrollsController()
        {
        }


        [HttpGet]
        public async Task<IActionResult> GetPayrollList()
        {
            var response = await Mediator.Send(new GetPayrollsListQuery());

            return Ok(response);
        }
        
        [HttpGet("{id}")]

        public async Task<IActionResult> GetPayrollByID([FromRoute] int id)
        {
            var response = await Mediator.Send(new GetPayrollsByIDQuery(id));
            return NewResult(response);
        }

        [HttpPost]
        
        public async Task<IActionResult> CreatePayroll([FromBody] AddPayrollCommand addPayroll)
        {
            var Response = await Mediator.Send(addPayroll);

            return NewResult(Response);
        }

        [HttpPut]
        public async Task<ActionResult<Response<string>>> UpdatePayroll([FromBody] UpdatePayrollCommand updatePayrollCommand)
        {
            if (updatePayrollCommand == null)
            {
                return BadRequest("Invalid payroll data.");
            }

            var result = await Mediator.Send(updatePayrollCommand);
            return NewResult(result);
        }


    }
}
