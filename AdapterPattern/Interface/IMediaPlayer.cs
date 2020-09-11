using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace AdapterPattern
{
    public interface IMediaPlayer
    {
        void Play(string audioType, string fileName);
    }
}
