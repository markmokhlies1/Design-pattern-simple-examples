using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Ex.Memento
{
    public class TextMemento
    {
        public string Content { get; }

        public TextMemento(string content)
        {
            Content = content;
        }
    }
}
