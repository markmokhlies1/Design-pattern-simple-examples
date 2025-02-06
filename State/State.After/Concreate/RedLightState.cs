using State.After.Context;
using State.After.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.After.Concreate
{
    public class RedLightState : ITrafficLightState
    {
        public void Handle(TrafficLight context)
        {
            Console.WriteLine("Red Light: Stop!");
            context.SetState(new GreenLightState()); // Transition to Green
        }
    }
}
