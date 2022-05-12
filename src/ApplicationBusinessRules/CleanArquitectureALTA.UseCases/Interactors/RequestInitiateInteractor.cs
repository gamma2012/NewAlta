using System;
using System.Threading.Tasks;
using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.UseCasesPorts.Interfaces;
using Alta.Utils;
using AutoMapper;

namespace Alta.UseCases.Interactors
{
    public class RequestInitiateInteractor : IRequestInitiateInputPort
    {
        private readonly IRequestInitiateOutputPort _requestinitiateoutputport;
        private readonly ILoggingRepository _loggingRepository;
        private readonly IPrimeClient _primeClient;
        private readonly IAltaRepository _altaRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RequestInitiateInteractor(IRequestInitiateOutputPort requestinitiateoutputport, ILoggingRepository loggingRepository, IPrimeClient primeClient, IAltaRepository altaRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _loggingRepository = loggingRepository;
            _requestinitiateoutputport = requestinitiateoutputport;
            _primeClient = primeClient;
            _altaRepository = altaRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RequestInitiateDTO requestInitiateDTO)
        {
            //TODO: add maping from DTO to log
            string uri = "https://www.mockachino.com/30736d33-ce94-49/REQUEST_INITIATE";
            await _loggingRepository.InsertLogAsync(new Log());
            TransactionResult result = await _primeClient.SendMessage(uri, requestInitiateDTO);
            await _altaRepository.InsertRequestInitiateAsync(_mapper.Map<RequestInitiate>(requestInitiateDTO));
            await _unitOfWork.SaveChanges();
            Console.WriteLine("result: " + result.ToJson());
            await Task.CompletedTask;
        }
    }
}
