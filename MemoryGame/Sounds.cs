using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MemoryGame
{
    class Sounds
    {

       private static SoundPlayer ding = new SoundPlayer(@"C:\Users\johan.torner\source\repos\Stockstad\MemoryGameNew\MemoryGame\bin\Debug\Sound\ding.wav");
       private static SoundPlayer fanfare = new SoundPlayer(@"C:\Users\johan.torner\source\repos\Stockstad\MemoryGameNew\MemoryGame\bin\Debug\Sound\fanfare.wav");
       private static SoundPlayer mainMenu = new SoundPlayer(@"C:\Users\johan.torner\source\repos\Stockstad\MemoryGameNew\MemoryGame\bin\Debug\Sound\main_menu.wav");
       private static SoundPlayer buttonHov = new SoundPlayer(@"C:\Users\johan.torner\source\repos\Stockstad\MemoryGameNew\MemoryGame\bin\Debug\Sound\buttonHover.wav");
       private static SoundPlayer pipe = new SoundPlayer(@"C:\Users\johan.torner\source\repos\Stockstad\MemoryGameNew\MemoryGame\bin\Debug\Sound\pipe.wav");
       private static SoundPlayer charSelect = new SoundPlayer(@"C:\Users\johan.torner\source\repos\Stockstad\MemoryGameNew\MemoryGame\bin\Debug\Sound\charSelect.wav");

        public static void playDing()
        {
            ding.Play();
        }
        public static void playFanfare()
        {
            fanfare.Play();
        }
        public static void menuMusic()
        {
            mainMenu.Play();

        }
        public static void menuMusicStop()
        {
            mainMenu.Stop();
        }
        public static void buttonHover()
        {
            buttonHov.Play();
        }
        public static void playPipe()
        {
            pipe.Play();
        }
        public static void charMenu()
        {
            charSelect.Play();
        }








    }
}
