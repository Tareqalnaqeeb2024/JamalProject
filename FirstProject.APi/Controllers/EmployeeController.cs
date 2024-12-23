using FirstProject.Core.Features.Employees.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController( IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetEmployeeListAsync() 
        {
            var response =  await _mediator.Send( new GetAllEmployeesListQuery() );

            return Ok(response);
        }
    }
}
