using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class ReusableObject
    {
        public int Id { get; }
        public ReusableObject(int id) => Id = id;

        public void Reset()
        {
            // Reset the state of the object if needed
            Console.WriteLine($"Object {Id} reset.");
        }
    }
}
