using State.AnotherExample.Interface;

namespace State.AnotherExample.Concreate
{
    public class StoppedState : IMusicPlayerState
    {
        public void Play(MusicPlayer context)
        {
            Console.WriteLine("Starting the music.");
            context.SetState(new PlayingState());
        }

        public void Pause(MusicPlayer context)
        {
            Console.WriteLine("Music is stopped; can't pause.");
        }

        public void Stop(MusicPlayer context)
        {
            Console.WriteLine("Already stopped.");
        }
    }
}
