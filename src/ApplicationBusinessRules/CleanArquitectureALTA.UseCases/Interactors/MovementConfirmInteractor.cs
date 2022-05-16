using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using Alta.Utils;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactor
{
    public class MovementConfirmInteractor : IMovementConfirmInputPort
    {
        private readonly IMovementConfirmOutputPort _movementconfirmoutputport;
        private readonly ILoggingRepository _loggingRepository;
        private readonly IPrimeClient _primeClient;
        private readonly PrimeWsOptions _primeWsOptions;

        public MovementConfirmInteractor(IMovementConfirmOutputPort movementconfirmoutputport, ILoggingRepository loggingRepository,
            IPrimeClient primeClient, IOptions<PrimeWsOptions> options) => 
            (_loggingRepository, _movementconfirmoutputport, _primeClient, _primeWsOptions) = 
            (loggingRepository, movementconfirmoutputport, primeClient, options.Value);
       

        public async Task Handle(MovementConfirmDTO movmentConfirmDTO) 
        {
            //TODO: add maping from DTO to log
            
            string uri = _primeWsOptions.Endpoints["MovementConfirm"];
            await _loggingRepository.InsertLogAsync(new Log());
            await _primeClient.SendMessage(uri, movmentConfirmDTO);
            await Task.CompletedTask;
        }
    }
}