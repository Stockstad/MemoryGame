using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace MemoryGame
{
    static class Sounds
    {
        public static string[] soundList = { "main_menu.wav",  "charSelect.wav", "background.wav" };
        //Potential fix might be coming. However, the priority is low and this works fine. 
        public static void playSound(int soundToPlay, bool loop)
        {
            SoundPlayer play = new SoundPlayer(Game.GetSoundsFolder() + soundList[soundToPlay]);
            if (loop == false)
            {
                play.Play();
            }
            else
            {
                play.PlayLooping();
            }
        }
        public static void stopSound(int soundToStop)
        {
            SoundPlayer play = new SoundPlayer(Game.GetSoundsFolder() + soundList[soundToStop]);
            play.Stop();
        }
    }
}