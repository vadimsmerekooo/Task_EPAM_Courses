using System;
using System.Collections.Generic;
using System.Text;

namespace Task_0_EPAM
{
    class PhotoFile : MediaFile
    {
        public int Heigh { get; private set; }
        public int Width { get; private set; }
        public byte[] Image { get; private set; }

    }
}
