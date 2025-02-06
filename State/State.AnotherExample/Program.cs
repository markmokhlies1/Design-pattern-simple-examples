using State.AnotherExample.Concreate;
using State.AnotherExample.Context;

namespace State.AnotherExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the player in the stopped state
            var player = new MusicPlayer(new StoppedState());

            // Simulate user interactions
            player.Play();  // Output: Starting the music.
            player.Pause(); // Output: Pausing the music.
            player.Play();  // Output: Resuming the music.
            player.Stop();  // Output: Stopping the music.
            player.Pause(); // Output: Music is stopped; can't pause.
        }
    }
}
