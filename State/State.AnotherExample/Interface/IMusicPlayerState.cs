using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AnotherExample.Interface
{
    public interface IMusicPlayerState
    {
        void Play(MusicPlayer context);
        void Pause(MusicPlayer context);
        void Stop(MusicPlayer context);
    }
}
