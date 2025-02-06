
using State.AnotherExample.Context;
using State.AnotherExample.Interface;

namespace State.AnotherExample.Concreate
{
    public class PausedState : IMusicPlayerState
    {
        public void Play(MusicPlayer context)
        {
            Console.WriteLine("Resuming the music.");
            context.SetState(new PlayingState());
        }

        public void Pause(MusicPlayer context)
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop(MusicPlayer context)
        {
            Console.WriteLine("Stopping the music.");
            context.SetState(new StoppedState());
        }
    }
}
