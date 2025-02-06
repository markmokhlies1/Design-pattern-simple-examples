using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Ex02
{
    public class ChessPieceType
    {
        public string Name { get; }
        public string Color { get; }

        public ChessPieceType(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Displaying {Color} {Name} at position ({x}, {y}).");
        }
    }
}
