
using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Presenters.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Presenters.Presenters
{
    public class CreateLineInventoryPresenter : IHeartbeatOutputPort, IPresenter<TransactionResult>
    {
        public TransactionResult Content { get; private set; }

        public async Task Handle(HeartbeatDTO createLineInventoryDTO)
        {
            /*Content.MESSAGE = createLineInventoryDTO.;
            Content.DATA = 
            Content.OK = */
            await Task.CompletedTask;
        }
    }
}
