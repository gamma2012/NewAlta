using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArquitectureALTA.Controllers.AltaWS
{
    [Route("api/altaws")]
    [ApiController]
    public class MovementConfirmController : ControllerBase
    {
        private readonly IMovementConfirmInputPort _movementConfirmInputPort;
        public MovementConfirmController(IMovementConfirmInputPort movementConfirmInputPort)
        {
            _movementConfirmInputPort = movementConfirmInputPort;
        }

        [HttpPost("MOVEMENT_CONFIRM")]
        public async Task<IActionResult> MovementConfirm(MovementConfirmDTO data)
        {
            await _movementConfirmInputPort.Handle(data);

            return Ok();
        }
    }
}
