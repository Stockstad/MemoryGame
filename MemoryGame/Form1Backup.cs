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

        int crntPlayer = 1;
        int temp = 0;
        int index1 = 0;
        int index2 = 0;
        string[] pictures = Directory.GetFiles(@"C:\Users\johan.torner\source\repos\Stockstad\MemoryGameNew\MemoryGame\bin\Debug\Pictures", "*.jpg");
        List<Player> players = new List<Player>();
        List<PlayingCards> cards = new List<PlayingCards>();

        PictureBox firstCard;
        PictureBox secondCard;


        bool allowClick = true;
    






        public Memory()
        { 
            InitializeComponent();
            pictures = ShuffleCards(pictures);
            CreateCards();
            nextBtn.Hide();
            tableLayoutPanel1.Hide();













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
            Sounds.playFanfare();
            tableLayoutPanel1.Show();
            playerBtn.Hide();
            startButton.Hide();
            textBox1.Hide();
        }

     

        private void CreateCards()
        {



            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < 18; i++)
                {
                    cards.Add(new PlayingCards(pictures[i], i));

                }

            }




            int t = 0;
  
               
            foreach (PictureBox pictureBox in tableLayoutPanel1.Controls.OfType<PictureBox>())
            {
                
                pictureBox.Image = Image.FromFile(cards[t].getFilename());

                if (t == 18)
                    t = 0;
                else
                    t++;

              
            }

            foreach (PictureBox pictureBox in tableLayoutPanel1.Controls.OfType<PictureBox>())
            {
                pictureBox.Image = null;
            }




        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

            

        }

        public string[] ShuffleCards(string[] cards)
        {
            var Random = new Random();
            return cards.OrderBy(x => Random.Next()).ToArray();

        }

        private void picture_Click(object sender, EventArgs e)
        {
        
            PictureBox clickedCard = sender as PictureBox;

    
        
            int index = tableLayoutPanel1.Controls.IndexOf(clickedCard);


            if (cards[index].unclickable == false && allowClick)
            {

                if (cards[index].isVisible == false)
                {
                    clickedCard.Image = Image.FromFile(cards[index].getFilename());
                    cards[index].isVisible = true;

                    if (temp == 0)
                    {
                        firstCard = clickedCard;
                        index1 = index;
                        temp++;
                    }

                    else if (temp == 1)
                    {
                        secondCard = clickedCard;
                        index2 = index;
                        

                        if (PlayingCards.matchCheck(cards[index1].getFilename(), cards[index2].getFilename()))
                        {
                            MessageBox.Show("Matching!");
                            cards[index1].changeUnclick();
                            cards[index2].changeUnclick();
                        }
                        else
                        {
                            cards[index1].isVisible = false;
                            cards[index2].isVisible = false;

                            allowClick = false;

                            

                            nextBtn.Show();


                        }
                        temp = 0;
                    }



                }
               

            }
            else
                MessageBox.Show("Pick another card or press 'Next Player!'");





















        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            firstCard.Image = null;
            secondCard.Image = null;
            nextBtn.Hide();
            allowClick = true;
        }

        private void playerBtn_Click(object sender, EventArgs e)
        {
            
            players.Add(new Player(crntPlayer, 0, textBox1.Text));

         
            listBox1.Items.Add(players[crntPlayer - 1].GetAll());
            

            crntPlayer++;

            Sounds.playDing();




        }
    }
}
