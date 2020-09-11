using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter adapter;

        public void Play(string audioType, string fileName)
        {
            if(audioType.Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }
            else if (audioType.Equals("vlc")
                || audioType.Equals("mp4"))
            {
                adapter = new MediaAdapter(audioType);
                adapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
