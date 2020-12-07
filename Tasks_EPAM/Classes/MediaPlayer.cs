using System;
using System.Collections.Generic;

namespace Task_0_EPAM.Classes
{
    interface IPlay<T> where T : MediaFile
    {
        public void Play(T file);
        public void Pause();
    }
    class MusicPlayer : IPlay<AudioFile>
    {
        public void Play(AudioFile play)
        {

        }
        public void Pause()
        {

        }
    }
}
