using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_MediaPlayerPlugins
{
    public class Audio : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Audio is Playing!");
        }

        public void Stop()
        {
            Console.WriteLine("Audio is Stopping!");

        }
    }
}
