using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Controllers.AltaWS
{
    [Route("api/altaws")]
    [ApiController]
    public class CreateLineInventoryController : ControllerBase
    {

        private readonly ICreateLineInventoryInputPort _createLineInventoryInputPort;

        public CreateLineInventoryController(ICreateLineInventoryInputPort createLineInventoryInputPort)
        {
            _createLineInventoryInputPort = createLineInventoryInputPort;
        }


        //TODO validate header filter
        [HttpPost("CREATE_LINE_INVENTORY_IN_IFD")]
        public async Task<IActionResult> CreateLineInventoryInIFD(CreateLineInventoryDTO data)
        {
            TransactionResult result = new TransactionResult();
            
            try
            {
                await this._createLineInventoryInputPort.Handle(data);
            }catch(Exception ex)
            {
                //TODO exception filter
            }


            return Ok();
        }
    }
}
