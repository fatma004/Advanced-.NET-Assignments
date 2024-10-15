namespace Day2_MediaPlayerPlugins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            
            Video video = new Video();
            mediaPlayer.MediaPlay(video);

        }
    }
}
