using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactor
{
    public class CreateLineInventoryInteractor : ICreateLineInventoryInputPort
    {

        private readonly ICreateLineInventoryOutputPort _createLineInventoryOutputPort;

        public CreateLineInventoryInteractor(ICreateLineInventoryOutputPort createLineInventoryOutputPort) 
        {
            _createLineInventoryOutputPort = createLineInventoryOutputPort;
        }
        public async Task Handle(CreateLineInventoryDTO createLineInventoryDTO)
        {
            Console.WriteLine($"---> Completed Task {createLineInventoryDTO.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.TRANID}");
            await Task.CompletedTask;
        }
    }
}
