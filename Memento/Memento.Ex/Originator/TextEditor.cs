using Memento.Ex.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Ex.Originator
{
    public class TextEditor
    {
        private string _content;

        public void SetContent(string content)
        {
            _content = content;
            Console.WriteLine($"Content Set: {_content}");
        }

        public string GetContent() => _content;

        // Create a memento of the current state
        public TextMemento Save() => new TextMemento(_content);

        // Restore the state from a memento
        public void Restore(TextMemento memento)
        {
            _content = memento.Content;
            Console.WriteLine($"Content Restored: {_content}");
        }
    }
}
