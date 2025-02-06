using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOFResponsabilty.EX
{
    public interface IHandler
    {
        void SetNext(IHandler Handler);
        void HandleRequest(string issue);
    }
}

