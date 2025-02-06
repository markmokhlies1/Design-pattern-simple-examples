using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_EX01
{
    public interface IIterator <T>
    {
        T Current { get; }      // Get the current item
        bool MoveNext();        // Move to the next item
        void Reset();
    }
}
