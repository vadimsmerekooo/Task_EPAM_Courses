using System.Collections.Generic;

namespace Task_0_EPAM.Classes
{
    class PlayList
    {
        public string NamePlayList { get; set; }
        public List<MediaFile> MediaFileList { get; set; }

        void Add(MediaFile mediaFile)
        {
            if (mediaFile != null)
                MediaFileList.Add(mediaFile);
        }

        void Delete(MediaFile mediaFile)
        {
            if (mediaFile != null && MediaFileList.Contains(mediaFile))
                MediaFileList.Remove(mediaFile);
        }
    }
}
