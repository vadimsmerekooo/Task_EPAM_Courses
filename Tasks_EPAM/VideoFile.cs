using System;
using System.Collections.Generic;
using System.Text;

namespace Task_0_EPAM
{
    class VideoFile : MediaFile
    {
        public float Duration { get; private set; }
        public int Heigh { get; private set; }
        public int Widhh { get; private set; }
        public int Resolution { get; set; }
    }
}
