using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Memory : Form
    {


        Random rnd = new Random();

        List<string> cards = new List<string>()
        {
            "A", "A", "a", "a", "x", "x", "!", "!", "C", "C", "g", "g", "k", "k", "M", "M", "q", "q", "Q", "Q", "i", "i", 
            "P", "P", "e", "e", "S", "S", "d", "d", "v", "v", "y", "y", "B", "B"
        };

        Label firstCard;
        Label secondCard;
        Label rightCard1;
        Label rightCard2;
        int selectedPlayer = 0;
        bool isMatch = false;
        int playerSC1 = 0;
        int playerSC2 = 0;

        List<Player> players = new List<Player>();


        int amountOfPlayers = 2; //current number of players






        public Memory()
        {
            InitializeComponent();
            RandomiseCards();





            






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

            players = new List<Player>();
            for (int i = 0; i < 4; i++)
            {
                players.Add(new Player() {1, 1, });


            }



            if (timer1.Enabled == true)
            {
                return;
            }

          

            Label clickedCard = sender as Label;

            if (clickedCard != null && clickedCard.ForeColor != Color.Red)
            {


                if (clickedCard.ForeColor == Color.Black)
                {
                    return;
                }




                if (firstCard == null)
                {
                    firstCard = clickedCard;
                    firstCard.ForeColor = Color.Black;

                    return;
                }

                secondCard = clickedCard;
                secondCard.ForeColor = Color.Black;

                timer1.Start();

               

                    isMatch = matchcheck.Matching();


                    if (isMatch == true)
                    {

                        if (matchcheck.player == 0)
                        {
                            
                            playerSC1++;
                            playerScore1.Text = Convert.ToString(playerSC1);
                        }
                        else if (matchcheck.player == 1)
                        {
                            playerSC2++;
                            player2score.Text = Convert.ToString(playerSC2);


                        }
                    

                        rightCard1 = secondCard;
                        rightCard2 = firstCard;

                        rightCard1.ForeColor = Color.Red;
                        rightCard2.ForeColor = Color.Red;



                    }
                    else
                    ContinueTurn();


                if (playerSC1 + playerSC2 ==  18)
                {
                    if (playerSC1 > playerSC2)
                        MessageBox.Show("Player 1 is victorious!");

                    if (playerSC2 > playerSC1)
                        MessageBox.Show("Player 2 is victorious!");
                }

            }


           

        }





        private void RandomiseCards()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label cardLabel = control as Label;
                if (cardLabel != null)
                {
                    int randomNumber = rnd.Next(cards.Count);
                    cardLabel.Text = cards[randomNumber];
                    cards.RemoveAt(randomNumber);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();


            

            if (firstCard.ForeColor != Color.Red)
            {
                firstCard.ForeColor = firstCard.BackColor;
                secondCard.ForeColor = secondCard.BackColor;
               
            }

            firstCard = null;
            secondCard = null;

            isMatch = false;

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
    }
}
