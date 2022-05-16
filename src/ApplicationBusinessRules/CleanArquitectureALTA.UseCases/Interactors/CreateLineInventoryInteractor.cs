using System;
using System.Threading.Tasks;
using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using Alta.Utils;
using Microsoft.Extensions.Options;

namespace Alta.UseCases.Interactors
{
    public class CreateLineInventoryInteractor : ICreateLineInventoryInputPort
    {
        private readonly ILoggingRepository _loggingRepository;
        private readonly IPrimeClient _primeClient;
        private readonly PrimeWsOptions _primeWsOptions;

        public CreateLineInventoryInteractor(ILoggingRepository loggingRepository, IPrimeClient primeClient, IOptions<PrimeWsOptions> options) 
        {
            _loggingRepository = loggingRepository;
            _primeClient = primeClient;
            _primeWsOptions = options.Value;
        }

        public async Task Handle(CreateLineInventoryDTO createLineInventoryDTO)
        {
            //TODO: add maping from DTO to log
            string uri = _primeWsOptions.Endpoints["CreateLineInventoryInIFD"];
            await _primeClient.Authenticate();
            await _loggingRepository.InsertLogAsync(new Log());
            await _primeClient.SendMessage(uri, createLineInventoryDTO);
            await Task.CompletedTask;
        }
    }
}
