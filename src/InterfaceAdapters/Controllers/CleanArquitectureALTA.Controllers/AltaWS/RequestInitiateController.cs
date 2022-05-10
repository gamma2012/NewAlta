﻿using Alta.DTOs;
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
    public class RequestInitiateController : ControllerBase
    {
        private readonly IRequestInitiateInputPort _requestInitiateInputPort;
        public RequestInitiateController(IRequestInitiateInputPort requestInitiateInputPort)
        {
            _requestInitiateInputPort = requestInitiateInputPort;
        }
        [HttpPost("REQUEST_INITIATE")]

        public async Task<IActionResult> RequestInitiate(RequestInitiateDTO data)
        {
            try
            {
                await _requestInitiateInputPort.Handle(data);
            }
            catch (Exception e)
            {

            }

            return Ok();
        }
    }
}