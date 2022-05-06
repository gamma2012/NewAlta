using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Presenters.Interfaces
{
    public interface IPresenter<out FormatDataType>
    {
        public FormatDataType Content { get; }
    }
}
