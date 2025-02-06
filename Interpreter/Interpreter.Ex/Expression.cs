using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Ex
{
    public interface Expression
    {
        public void Interpret(Dictionary<string, List<Dictionary<string, object>>> data);
    }
}
