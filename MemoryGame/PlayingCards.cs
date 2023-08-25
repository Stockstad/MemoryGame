using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace MemoryGame
{
    class PlayingCards
    {

        private string filename;
        public int cardId;
        public bool isVisible = false;
        public Image image;
        public Image background = Image.FromFile(Directory.GetCurrentDirectory() + @"\rest\background.jpg");
        public static Image backgroundMain = Image.FromFile(Directory.GetCurrentDirectory() + @"\rest\background.jpg");
        public PlayingCards(string filename, int cardId)
        {

            this.filename = filename;
            this.cardId = cardId;
            image = Image.FromFile(filename);
        }
        public static bool IsMatch(int a, int b)
        {
            if (a == b) { return true; }
            else { return false; }
        }
        public static List<PlayingCards> ShuffleCards(List<PlayingCards> cards)
        {
            var Random = new Random();
            return cards.OrderBy(x => Random.Next()).ToList();
         }
        public void TurnCardUp(object sender)
        {
            PictureBox selected = sender as PictureBox;
            selected.Image = this.image;
        }
        
        public void TurnCardDown(PictureBox sender)
        {
            sender.Image = this.background;
        }
        public static Image GetBackground()
        {
            return backgroundMain;
        }
     }
        


       





 }

