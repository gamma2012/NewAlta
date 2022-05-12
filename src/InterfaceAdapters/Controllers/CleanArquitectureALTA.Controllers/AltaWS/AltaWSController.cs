using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
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
        [HttpPost("SEND_MESSAGE")]
        public async Task<IActionResult> SEND_MESSAGE(JsonElement json)
        {
            JsonElement aux;
            bool Has(string prop) => json.TryGetProperty(prop, out aux);
            DtoBase dto;
            dto = JsonSerializer.Deserialize<LoadDetailedDTO>(json.ToString(), new JsonSerializerOptions());
            
            var posibles = new[] {
                ("HEARTBEAT_CONFIRM", typeof(HeartBeatConfirmDTO)), 
                ("LOAD_DETAIL", typeof(LoadDetailedDTO)), 
                ("LOAD_ERROR", typeof(LoadErrorDTO))};
            
            // foreach (var (property, dtoType) in posibles)
            // {
            //     if (Has(property))
            //     {
            //         dto = (DtoBase) JsonConvert.DeserializeObject(json.ToString(), dtoType);
            //         //dto = json.ToString().FromJson<DtoBase>(dtoType);
            //     }
            // }
            return Ok();
        }
        

    }
    
}
