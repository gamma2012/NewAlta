using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.UseCasesPorts.Interfaces;
using Alta.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactor
{
    public class RequestInitiateInteractor : IRequestInitiateInputPort
    {
        private readonly IRequestInitiateOutputPort _requestinitiateoutputport;
        private readonly ILoggingRepository _loggingRepository;
        private readonly IPrimeClient _primeClient;

        public RequestInitiateInteractor(IRequestInitiateOutputPort requestinitiateoutputport, ILoggingRepository loggingRepository, IPrimeClient primeClient)
        {
            _loggingRepository = loggingRepository;
            _requestinitiateoutputport = requestinitiateoutputport;
            _primeClient = primeClient;
        }

        public async Task Handle(RequestInitiateDTO requestInitiateDTO)
        {
            //TODO: add maping from DTO to log
            string uri = "https://www.mockachino.com/30736d33-ce94-49/REQUEST_INITIATE";
            await _loggingRepository.InsertLogAsync(new Log());
            TransactionResult result = await _primeClient.SendMessage(uri, requestInitiateDTO);
            Console.WriteLine("result: " + result.ToJson());
            await Task.CompletedTask;
        }
    }
}
