using State.After.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.After.Interface
{
    public interface ITrafficLightState
    {
        void Handle(TrafficLight context);
    }
}
