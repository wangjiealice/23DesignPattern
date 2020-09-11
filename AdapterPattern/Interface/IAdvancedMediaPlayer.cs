using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace AdapterPattern
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(string fileName);

        void PlayMp4(string fileName);
    }
}
