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
    public class CreateLineInventoryPresenter : ICreateLineInventoryOutputPort, IPresenter<CreateLineInventoryDTO>
    {
        public CreateLineInventoryDTO Content { get; private set; }

        public Task Handle(CreateLineInventoryDTO createLineInventoryDTO)
        {
            Content = createLineInventoryDTO;

            return Task.CompletedTask;
        }
    }
}
