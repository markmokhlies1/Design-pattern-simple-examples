using Memento.Ex.CareTaker;
using Memento.Ex.Originator;

namespace Memento.Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Originator (TextEditor) and Caretaker
            var editor = new TextEditor();
            var caretaker = new CareTaker01();

            // Set and save content
            editor.SetContent("Version 1");
            caretaker.Save(editor.Save());

            editor.SetContent("Version 2");
            caretaker.Save(editor.Save());

            editor.SetContent("Version 3");

            // Undo changes
            Console.WriteLine("\nPerforming Undo...");
            var memento = caretaker.Undo();
            if (memento != null) editor.Restore(memento);

            Console.WriteLine("\nPerforming Undo...");
            memento = caretaker.Undo();
            if (memento != null) editor.Restore(memento);
        }
    }
}
