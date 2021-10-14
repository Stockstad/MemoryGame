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

        Label firstCard = null;
        Label secondCard = null;
        bool isMatch;

        int playerScore = 0;
        






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
            if (timer1.Enabled == true)
            {
                return;
            }
                


            Label clickedCard = sender as Label;

            if (clickedCard != null)
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

                isMatch = WhileMatch();


                if (isMatch == true)
                {
                    playerScore++;
                    label37.Text = Convert.ToString(playerScore);
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


            firstCard.ForeColor = firstCard.BackColor;
            secondCard.ForeColor = secondCard.BackColor;

         
            firstCard = null;
            secondCard = null;
        }

        public bool WhileMatch()
        {
            if (firstCard.Text == secondCard.Text)
            {
                return true;
            }



            return false;
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
    }
}
