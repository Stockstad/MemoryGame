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
    public partial class finalForm : Form
    {
        Player winner;
        List<int> scorelist = new List<int>();
        public finalForm()
        {
            InitializeComponent();
        }

        private void winnerPicture_Click(object sender, EventArgs e)
        {

        }

        private void movesmade_Click(object sender, EventArgs e)
        {

        }

        private void totalPoints_Click(object sender, EventArgs e)
        {

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, but this option isn't supported yet. Please return to the desktop instead.");
        }

        private void desktopBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void start(object sender, EventArgs e)
        {
            winner = Compare();
            winnerPicture.Image = winner.playable.image;
            movesmade.Text = winner.movesMade.ToString();
            totalPoints.Text = winner.score.ToString();
            TimeLabel.Text = Game.minutes.ToString() + ":" + Game.time.ToString();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private Player Compare()
        {
            foreach (var player in Game.playerList)
            {
                scorelist.Add(player.score);
            }
            return Game.playerList.FirstOrDefault(f => f.score == scorelist.Max());
        }
    }
}
