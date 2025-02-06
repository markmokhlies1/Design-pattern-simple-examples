using State.AnotherExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AnotherExample.Context
{
    public class MusicPlayer
    {
        private IMusicPlayerState _state;

        public MusicPlayer(IMusicPlayerState initialState)
        {
            _state = initialState;
        }

        public void SetState(IMusicPlayerState state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play(this);
        }

        public void Pause()
        {
            _state.Pause(this);
        }

        public void Stop()
        {
            _state.Stop(this);
        }
    }
}
