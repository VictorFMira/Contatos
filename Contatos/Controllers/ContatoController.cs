using Cont.Aplicacao.DTOs.Contato;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cont.API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class ContatoController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator;

        [HttpPost("RegistrarContato")]
        public async Task<IActionResult> RegistrarContato([FromBody]RegistrarContatoReq req)
        {
            var result = await _mediator.Send(req);
            return Ok(result);
        }
    }
}
