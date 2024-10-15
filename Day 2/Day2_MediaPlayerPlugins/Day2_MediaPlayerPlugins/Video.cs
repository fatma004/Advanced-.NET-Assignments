using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_MediaPlayerPlugins
{
    public class Video : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Video is Playing!");
        }

        public void Stop()
        {
            Console.WriteLine("Video is Stopping!");
        }
    }
}
