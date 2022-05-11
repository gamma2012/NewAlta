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
    public class LoginPresenter : ILoginOutputPort, IPresenter<UserDTO>
    {
        public UserDTO Content { get; private set; }

        public async Task Handle(UserDTO user)
        {
            Content = user;
            await Task.CompletedTask;
        }
    }
}
