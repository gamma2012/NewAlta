using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace Alta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltaWSController : ControllerBase //ControllerBase is used because allow you to use multiple methods such as Ok(); instead of OkObject
    {

        //We use async Task because when we have multiple request we might have troubles 
        // IActionResult Allow us to make the return with different status
        //When using IActionResult you won't be able to use a generic, usign ActionResult as class allow you to speciify a Generic in the return 
        

        // TODO => implement filters
        [HttpPost("CREATE_LINE_INVENTORY_IN_IFD_DUMMY")]
        public async Task<IActionResult> CreateLineInventoryInIFD(CreateLineInventoryDTO data) {
            return null;
        }
    }
}
