using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_MediaPlayerPlugins
{
    public class MediaPlayer
    {
       public void MediaPlay(IMedia media)
        {
            media.Play();
        }

        public void MediaStop(IMedia media)
        {
            media.Stop();
        }
    }
}
