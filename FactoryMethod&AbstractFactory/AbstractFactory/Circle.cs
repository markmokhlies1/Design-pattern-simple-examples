using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("I am Circle ");
        }
    }
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("I am Rectangle ");
        }
    }
    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("I am Square ");
        }
    }

}
