using State.After.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.After.Context
{
    public class TrafficLight
    {
        private ITrafficLightState _state;

        public TrafficLight(ITrafficLightState initialState)
        {
            _state = initialState;
        }

        public void SetState(ITrafficLightState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
