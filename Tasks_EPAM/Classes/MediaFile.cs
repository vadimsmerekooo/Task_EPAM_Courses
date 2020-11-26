using System;

namespace Task_0_EPAM.Classes
{
    class MediaFile
    {
        public string Name { get; set; }
        public float Size { get; set; }
        public string Author { get;set; }
        public DateTime DateCreate { get; set; }
        public DateTime LastChange { get; set; }
        public Type_File TypeMediaFile { get; set; }
        public Format_File FormatMediaFile { get; set; }
    }
}
