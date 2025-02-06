using Memento.Ex.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Ex.CareTaker
{
    public class CareTaker01
    {
        private readonly Stack<TextMemento> _history = new();

        public void Save(TextMemento memento) => _history.Push(memento);

        public TextMemento Undo() => _history.Count > 0 ? _history.Pop() : null;
    }
}
