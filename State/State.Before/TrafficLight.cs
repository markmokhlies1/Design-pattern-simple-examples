using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Before
{
    public class TrafficLight
    {
        private string _state;

        public TrafficLight(string initialState)
        {
            _state = initialState;
        }

        public void Request()
        {
            if (_state == "Red")
            {
                Console.WriteLine("Red Light: Stop!");
                _state = "Green"; // Transition to Green
            }
            else if (_state == "Green")
            {
                Console.WriteLine("Green Light: Go!");
                _state = "Yellow"; // Transition to Yellow
            }
            else if (_state == "Yellow")
            {
                Console.WriteLine("Yellow Light: Slow Down!");
                _state = "Red"; // Transition to Red
            }
            else
            {
                Console.WriteLine("Invalid State!");
            }
        }
    }
}
