namespace Adpter.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adaptee: AudioPlayer
            var audioPlayer = new AudioPlayer();

            // Adapter: Wrap the AudioPlayer with an adapter
            var adapter = new AudioToVideoAdapter(audioPlayer);

            // Client: Works with the VideoPlayer interface
            var mediaClient = new MediaClient(adapter);

            // Play media using the client
            mediaClient.PlayMedia("song.mp3");
        }
    }
}
