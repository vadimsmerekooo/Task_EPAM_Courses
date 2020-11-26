using System;
using System.Collections.Generic;

namespace Task_0_EPAM.Classes
{
    class Mediatek
    {
        public List<PlayList> _playList = new List<PlayList>();
        public MediaPlayer _mediaPlayer;

        public Mediatek(PlayList playLists, MediaPlayer mediaPlayer)
        {
            _playList.Add(playLists);
            _mediaPlayer = mediaPlayer;
        }
                
        public void CreatePlayList(PlayList playList)
        {
            if (playList != null)
                _playList.Add(playList);
        }

        public void DeletePlayList(PlayList playList)
        {
            if (_playList.Contains(playList))
                _playList.Remove(playList);
        }
        public MediaFile SearchMediaFile(string searchString)
        {
            if (String.IsNullOrWhiteSpace(searchString))
                return null;
            foreach (PlayList playList in _playList)
            {
                foreach (MediaFile mediaFile in playList.MediaFileList)
                {
                    if (mediaFile.Name.Contains(searchString)
                        || mediaFile.Author.Contains(searchString))
                        return mediaFile;
                }
            }
            return null;
        }
        public void PlayNewPlayList(PlayList playList)
        {
            if (playList == null)
                return;

            _mediaPlayer.PlayList = playList;
            _mediaPlayer.Play(_mediaPlayer.PlayList.MediaFileList[new Random().Next(_mediaPlayer.PlayList.MediaFileList.Count - 1)]);
        }
    }
}
