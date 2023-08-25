using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    static class Game
    {
        public static int numberOfPlayers = 0;
        public static int cardPick = 18; //For debugging purposes, default is 18. Script may break if not set to default value. Final fix may come.
        public static List<Player> playerList = new List<Player>();
        public static List<Playable> playables = new List<Playable>();
        public static int crntPlayer = 0;
        public static string[] hints = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\hints.txt");
        public static int time = 0;
        public static int minutes = 0;
        public static string GetPictureFolder()
        {
           return  Directory.GetCurrentDirectory() + @"\Pictures";
        }

        public static string GetSoundsFolder()
        {
            return Directory.GetCurrentDirectory() + @"\Sound\";
        }

        public static List<Playable> CreatePlayables()
        {
            playables.Add(new Playable("Elon Musk", Image.FromFile(Directory.GetCurrentDirectory() + @"\players\elon_musk.png"), Image.FromFile(Directory.GetCurrentDirectory() + @"\players_blur\elon_musk_blur.png")));
            playables.Add(new Playable("Ougi Oshino", Image.FromFile(Directory.GetCurrentDirectory() + @"\players\ougi.png"), Image.FromFile(Directory.GetCurrentDirectory() + @"\players_blur\ougi_blur.png")));
            playables.Add(new Playable("Magic Mike", Image.FromFile(Directory.GetCurrentDirectory() + @"\players\magic.png"), Image.FromFile(Directory.GetCurrentDirectory() + @"\players_blur\magic_blur.png")));
            playables.Add(new Playable("Crewmate", Image.FromFile(Directory.GetCurrentDirectory() + @"\players\crewmate.png"), Image.FromFile(Directory.GetCurrentDirectory() + @"\players_blur\crewmate_blur.png")));
            return playables;
        }

        public static void HasFinished()
        {
            if (Player.totalScore == cardPick)
            {
                finalForm fform = new finalForm();
                fform.ShowDialog();
            }
        }

        public static void Validate(string[] pictures)
        {
            if (pictures.Length != 18)
            {
                MessageBox.Show("The number of cards is not equal to 18. " +
                    "Please restart the program and check settings. If problems remain, please reinstall.", "The game encountered an error!");
                Application.Exit();
            }
        }

    }
}
