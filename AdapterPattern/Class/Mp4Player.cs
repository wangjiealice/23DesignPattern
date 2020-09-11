using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing MP4 file. Name: " + fileName);
        }

        public void PlayVlc(string fileName)
        {
        }
    }
}
