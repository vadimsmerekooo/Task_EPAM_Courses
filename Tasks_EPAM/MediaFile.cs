using System;
using System.Collections.Generic;
using System.Text;

namespace Task_0_EPAM
{
    class MediaFile
    {
        string Name { get; set; }
        float Size { get; set; }
        DateTime DateCreate { get; set; }
        DateTime LastChange;
        Type_File TypeMediaFile { get; set; }

        Format_File FormatMediaFile { get; set; }
    }
}
