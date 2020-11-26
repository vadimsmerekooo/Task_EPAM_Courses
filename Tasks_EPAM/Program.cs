using System;
using System.Collections.Generic;
using System.Threading;
using Task_0_EPAM.Classes;

namespace Task_0_EPAM
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayList playList = new PlayList()
            {
                NamePlayList = "First PlayList",
                MediaFileList = new List<MediaFile>()
                {
                    new MediaFile()
                    {
                        Author = "First Author",
                        DateCreate = DateTime.Now.AddDays(-3),
                        TypeMediaFile = Type_File.photo,
                        FormatMediaFile = Format_File.jpeg,
                        LastChange = DateTime.Now,
                        Name = "47",
                        Size = new Random().Next(999999)
                    },
                    new MediaFile()
                    {
                        Author = "Second Author",
                        DateCreate = DateTime.Now.AddDays(-2),
                        TypeMediaFile = Type_File.video,
                        FormatMediaFile = Format_File.avi,
                        LastChange = DateTime.Now,
                        Name = "A few moments later",
                        Size = new Random().Next(999999)
                    },
                    new MediaFile()
                    {
                        Author = "Third Author",
                        DateCreate = DateTime.Now.AddDays(-5),
                        TypeMediaFile = Type_File.audio,
                        FormatMediaFile = Format_File.mp3,
                        LastChange = DateTime.Now,
                        Name = "A 1 million years later",
                        Size = new Random().Next(999999)
                    }
                }
            };
            MediaPlayer mediaPlayer = new MediaPlayer(playList);

            Mediatek mediatek = new Mediatek(playList, mediaPlayer);

            Console.WriteLine("Список файлов в плейлистах");
            foreach (PlayList playListItem in mediatek._playList)
            {
                Console.WriteLine("Плейлист: " + playListItem.NamePlayList + "\n Список медиафайлов:");
                foreach (MediaFile mediaFile in playListItem.MediaFileList)
                {
                    Console.WriteLine($"{mediaFile.Name} {mediaFile.Author} {mediaFile.TypeMediaFile} {mediaFile.FormatMediaFile}");
                }
            }

            mediaPlayer.Play(mediaPlayer.PlayList.MediaFileList[new Random().Next(mediaPlayer.PlayList.MediaFileList.Count - 1)]);
            Thread.Sleep(3000);
            mediaPlayer.Pause();

            MediaFile searchMediaFile = mediatek?.SearchMediaFile("few");
            if (searchMediaFile != null)
                Console.WriteLine($"Search result(\"few\"): {searchMediaFile.Name} {searchMediaFile.Author} {searchMediaFile.TypeMediaFile} {searchMediaFile.FormatMediaFile}");

            PlayList playList2 = new PlayList()
            {
                NamePlayList = "Second PlayList",
                MediaFileList = new List<MediaFile>()
                {
                    new MediaFile()
                    {
                        Author = "Second PlayList First Author",
                        DateCreate = DateTime.Now.AddDays(-3),
                        TypeMediaFile = Type_File.photo,
                        FormatMediaFile = Format_File.jpeg,
                        LastChange = DateTime.Now,
                        Name = "AUF",
                        Size = new Random().Next(999999)
                    },
                    new MediaFile()
                    {
                        Author = "Second PlayList Second Author",
                        DateCreate = DateTime.Now.AddDays(-2),
                        TypeMediaFile = Type_File.video,
                        FormatMediaFile = Format_File.avi,
                        LastChange = DateTime.Now,
                        Name = "Bara bara bara",
                        Size = new Random().Next(999999)
                    },
                    new MediaFile()
                    {
                        Author = "Second PlayList Third Author",
                        DateCreate = DateTime.Now.AddDays(-5),
                        TypeMediaFile = Type_File.audio,
                        FormatMediaFile = Format_File.mp3,
                        LastChange = DateTime.Now,
                        Name = "Bere bere bere",
                        Size = new Random().Next(999999)
                    }
                }
            };

            mediatek.CreatePlayList(playList2);
            Console.WriteLine("Список файлов в плейлистах");
            foreach (PlayList playListItem in mediatek._playList)
            {
                Console.WriteLine("Плейлист: " + playListItem.NamePlayList + "\n Список медиафайлов:");
                foreach (MediaFile mediaFile in playListItem.MediaFileList)
                {
                    Console.WriteLine($"{mediaFile.Name} {mediaFile.Author} {mediaFile.TypeMediaFile} {mediaFile.FormatMediaFile}");
                }
            }
            mediatek.PlayNewPlayList(playList2);

            mediatek.DeletePlayList(playList2);
            Console.WriteLine("\n Список файлов в плейлистах");
            foreach (PlayList playListItem in mediatek._playList)
            {
                Console.WriteLine("Плейлист: " + playListItem.NamePlayList + "\n Список медиафайлов:");
                foreach (MediaFile mediaFile in playListItem.MediaFileList)
                {
                    Console.WriteLine($"{mediaFile.Name} {mediaFile.Author} {mediaFile.TypeMediaFile} {mediaFile.FormatMediaFile}");
                }
            }
            Console.ReadLine();
        }
    }
}
