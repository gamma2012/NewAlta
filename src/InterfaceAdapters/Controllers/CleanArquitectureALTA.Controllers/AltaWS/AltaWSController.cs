using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Alta.Controllers.Filters;
using Alta.DTOs;
using Alta.DTOs.DtoAbstraction;
using Alta.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Alta.Controllers.AltaWS
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltaWSController : ControllerBase //ControllerBase is used because allow you to use multiple methods such as Ok(); instead of OkObject
    {

        //We use async Task because when we have multiple request we might have troubles 
        // IActionResult Allow us to make the return with different status
        //When using IActionResult you won't be able to use a generic, usign ActionResult as class allow you to speciify a Generic in the return 



        // TODO => implement filters
        //[Authorize]
        [ServiceFilter(typeof(MessageFilter))]
        [HttpPost("SEND_MESSAGE")]
        public async Task<IActionResult> SEND_MESSAGE(JsonElement json)
        {
            DtoBase dto = (DtoBase)HttpContext.Items["data"];
            return Ok();
        }
        

    }
    
}
