using System;
using System.Collections.Generic;

namespace Task_0_EPAM.Classes
{
    class MediaBase 
    {
        public string Name { get; set; }
    }

    abstract class Mediatek
    {
        List<MediaBase> mediaBaseCollection;
        //List<MediaFile> _mediaFile;
        //List<PlayList> _playList;

        public void AddMediaFile(MediaBase mediaBase)
        {
            mediaBaseCollection.Add(mediaFile);
        }
        public void DeleteMediaFile(MediaBase mediabase)
        {

        }
        public bool FindByName(string searchString)
        {
            foreach (MediaBase itemMediaBase in mediaBaseCollection)
            {
                if(itemMediaBase is IFind)
                {
                    return ((IFind)itemMediaBase).FindByName(searchString);
                }
                if (itemMediaBase.Name.Contains(searchString, StringComparison.CurrentCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
