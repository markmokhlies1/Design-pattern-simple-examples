using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adpter.Ex02
{
    public interface IVideoPlayer 
    {
        void PlayVideo(string filename);
    }
    // Adaptee: The existing audio player that cannot play video
    public class AudioPlayer
    {
        public void PlayAudio(string filename)
        {
            Console.WriteLine($"Playing audio file: {filename}");
        }
    }

    // Adapter: Adapts the AudioPlayer to work with the VideoPlayer interface
    public class AudioToVideoAdapter : IVideoPlayer
    {
        private readonly AudioPlayer _audioPlayer;

        public AudioToVideoAdapter(AudioPlayer audioPlayer)
        {
            _audioPlayer = audioPlayer;
        }

        public void PlayVideo(string filename)
        {
            Console.WriteLine("Adapter in action: Converting video request to audio...");
            _audioPlayer.PlayAudio(filename);
        }
    }
    // Client: Expects a VideoPlayer interface
    public class MediaClient
    {
        private readonly IVideoPlayer _videoPlayer;

        public MediaClient(IVideoPlayer videoPlayer)
        {
            _videoPlayer = videoPlayer;
        }

        public void PlayMedia(string filename)
        {
            _videoPlayer.PlayVideo(filename);
        }
    }
}
