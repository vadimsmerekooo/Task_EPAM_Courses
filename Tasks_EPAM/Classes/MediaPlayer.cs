using System;
using System.Collections.Generic;

namespace Task_0_EPAM.Classes
{
    class MediaPlayer
    {
        public PlayList PlayList { get; set; }
        public MediaFile playMedialFile;
        bool play;

        public MediaPlayer(PlayList playList)
        {
            PlayList = playList;
        }
        public void Play(MediaFile mediaFile)
        {
            playMedialFile = mediaFile;
            play = true;
            Console.WriteLine("Play " + mediaFile.Name);
        }
        public void Pause()
        {
            play = false;
            Console.WriteLine("Stop " + playMedialFile.Name);
        }

    }
}
