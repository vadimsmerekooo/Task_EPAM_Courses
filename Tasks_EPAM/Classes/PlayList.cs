using System.Collections.Generic;

namespace Task_0_EPAM.Classes
{
    interface IFind
    {
        public bool FindByName(string searchString);
    }
    abstract class PlayList : MediaBase, IFind
    {
        List<MediaFile> MediaFileList { get; set; }

        public void Add(MediaFile mediaFile)
        {

        }

        public void Delete(MediaFile mediaFile)
        {

        }
        public bool FindByName(string searchString)
        {
            return true;
        }
    }
}
