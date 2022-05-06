using Alta.DTOs;
using Alta.Presenters.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Presenters.Presenters
{
    public class HeartBeatInitiatePresenter : IHeartBeatInitiateOutputPort, IPresenter<HeartBeatInitiateDTO>
    {
        public HeartBeatInitiateDTO Content { get; private set; }

        public async Task Handle(HeartBeatInitiateDTO heartBeatInitiateDTO)
        {
            Content = heartBeatInitiateDTO;
            await Task.CompletedTask;
        }
    }
}
