using Bridge.Ex.Implemention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Ex.Abstraction
{
    public abstract class Shape
    {
        protected readonly IRenderer _renderer;

        protected Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }

}
