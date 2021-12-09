using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace MemoryGame
{
    public partial class Memory : Form
    {


        string[] pictures = Directory.GetFiles(@"C:\Users\johan.torner\source\repos\Stockstad\MemoryGameNew\MemoryGame\bin\Debug\Pictures", "*.jpg");

        List<Player> players = new List<Player>();
        List<PlayingCards> cards = new List<PlayingCards>();
           
  






        public Memory()
        {
            InitializeComponent();
         





            






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) //Körs för alla labels i tabellen
        {










        }





       

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

       

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void playerScore1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

           pictures = ShuffleCards(pictures);

            players = new List<Player>();
            AddSound();

           
             players.Add(new Player(0, 0, 0, textBox1.Text, "red", 0));

            for (int i = 0; i < players.Count; i++)
            {
              listBox1.Items.Add(players[i].GetAll());
            }



            CreateCards();

            startButton.Hide();




        }

        private void AddSound()
        {
            SoundPlayer AddSound = new SoundPlayer(@"C:\Users\johan.torner\Desktop\Essentials\ding.wav");
            AddSound.Play();
        }


        private void CreateCards()
        {



            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < 5; i++)
                {
                    cards.Add(new PlayingCards(pictures[i], i));

                }

            }



            for (int j = 0; j < 10; j++)
            tableLayoutPanel1.Controls.Add(new PictureBox { Image = Image.FromFile(cards[j].getFilename()), Size = new Size(100, 100) });
                
             
               

            

        
        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {



        }

        public string[] ShuffleCards(string[] cards)
        {
            var Random = new Random();
            return cards.OrderBy(x => Random.Next()).ToArray();

        }


       
       

    }
}
