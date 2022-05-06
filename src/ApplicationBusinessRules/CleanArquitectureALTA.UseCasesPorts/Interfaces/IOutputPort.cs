using Alta.DTOs;
using Alta.DTOs.DtoAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IOutputPort<TDTO>
        where TDTO : DtoBase
    {
        Task Handle(TDTO tDto);
    }
}
