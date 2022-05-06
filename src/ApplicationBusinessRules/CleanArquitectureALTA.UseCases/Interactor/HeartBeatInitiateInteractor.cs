using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactor
{
    public class HeartBeatInitiateInteractor : IHeartBeatInitiateInputPort
    {
        private readonly IHeartBeatInitiateOutputPort _heartBeatInitiateOutputPort;

        public HeartBeatInitiateInteractor(IHeartBeatInitiateOutputPort heartBeatInitiateOutputPort)
        {
            _heartBeatInitiateOutputPort = heartBeatInitiateOutputPort;
        }

        public async Task Handle(HeartBeatInitiateDTO heartBeatInitiateDTO)
        {
            Console.WriteLine($"---> Completed Task: {heartBeatInitiateDTO.HEARTBEATINITIATE.CTRLSEG.TRANID}");
            await Task.CompletedTask;
        }
    }
}
