using State.AnotherExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AnotherExample.Concreate
{
    public class PlayingState : IMusicPlayerState
    {
        public void Play(MusicPlayer context)
        {
            Console.WriteLine("Already playing!");
        }

        public void Pause(MusicPlayer context)
        {
            Console.WriteLine("Pausing the music.");
            context.SetState(new PausedState());
        }

        public void Stop(MusicPlayer context)
        {
            Console.WriteLine("Stopping the music.");
            context.SetState(new StoppedState());
        }
    }
}
