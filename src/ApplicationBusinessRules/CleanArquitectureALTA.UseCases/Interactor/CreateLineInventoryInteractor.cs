using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using Alta.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactor
{
    public class CreateLineInventoryInteractor : ICreateLineInventoryInputPort
    {

        private readonly IHeartbeatOutputPort _createLineInventoryOutputPort;
        private readonly ILoggingRepository _loggingRepository;
        private readonly IPrimeClient _primeClient;

        public CreateLineInventoryInteractor(IHeartbeatOutputPort createLineInventoryOutputPort, ILoggingRepository loggingRepository, IPrimeClient primeClient) 
        {
            _loggingRepository = loggingRepository;
            _createLineInventoryOutputPort = createLineInventoryOutputPort;
            _primeClient = primeClient;
        }

        public async Task Handle(HeartbeatDTO createLineInventoryDTO)
        {
            //TODO: add maping from DTO to log
            string uri = "https://www.mockachino.com/30736d33-ce94-49/CREATE_LINE_INVENTORY_IN_IFD";
            await _loggingRepository.InsertLogAsync(new Log());
            TransactionResult result  = await _primeClient.SendMessage(uri,createLineInventoryDTO);
            Console.WriteLine("result: "+ result.ToJson());
            await Task.CompletedTask;
        }
    }
}
