using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactor
{
    public class MovementConfirmInteractor : IMovementConfirmInputPort
    {
        private readonly IMovementConfirmOutputPort _movementConfirmOutputPort;
        public MovementConfirmInteractor(IMovementConfirmOutputPort movementConfirmOutputPort) => (movementConfirmOutputPort) = (_movementConfirmOutputPort);
        public async Task Handle(MovementConfirmDTO movementConfirmDTO)
        {
            Console.WriteLine($"---> Completed Task: {movementConfirmDTO.MOVEMENTCONFIRM.CTRLSEG.TRANID}");
            await Task.CompletedTask;
        }
    }
}