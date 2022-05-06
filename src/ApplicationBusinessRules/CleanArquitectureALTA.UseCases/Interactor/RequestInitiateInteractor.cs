using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactor
{
    public class RequestInitiateInteractor : IRequestInitiateInputPort
    {
        private readonly IRequestInitiateOutputPort _requestInitiateOutputPort;

        public RequestInitiateInteractor(IRequestInitiateOutputPort requestInitiateOutputPort) => _requestInitiateOutputPort = requestInitiateOutputPort;

        async public Task Handle(RequestInitiateDTO requestInitiateDTO)
        {
            Console.WriteLine($"---> Completed Task: {requestInitiateDTO.REQUEST.CTRLSEG.TRANID}");
            await Task.CompletedTask;
        }
    }
}
