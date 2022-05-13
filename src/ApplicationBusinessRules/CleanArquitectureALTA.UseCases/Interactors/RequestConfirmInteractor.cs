using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactors
{
    public class RequestConfirmInteractor : IRequestConfirmInputPort
    {
        public Task Handle(RequestConfirmDTO _requestConfirmDTO)
        {
            //TODO: registrar con mongo
            //TODO: publicar
            

            return Task.CompletedTask;


        }
    }
}
