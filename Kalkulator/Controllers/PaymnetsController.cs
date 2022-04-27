using Kalkulator.AplicationServices.API.Domain;
using Kalkulator.DataAccess;
using Kalkulator.DataAccess.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Kalkulator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymnetsController : ControllerBase
    {
        private readonly IMediator mediator;
        public PaymnetsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllPayments([FromQuery] GetPaymentsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
