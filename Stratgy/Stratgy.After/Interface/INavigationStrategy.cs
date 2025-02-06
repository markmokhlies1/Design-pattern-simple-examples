using Stratgy.After.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratgy.After.Interface
{
    public interface INavigationStrategy
    {
        Route Navigate(string origin, string destination);
    }
}
