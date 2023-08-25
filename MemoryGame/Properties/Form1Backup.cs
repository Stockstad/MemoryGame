using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Memory : Form
    {
        int tempInput = 0;
        List<PlayingCards> cards = new List<PlayingCards>();
        PlayingCards card;
        PlayingCards tempCard;
       readonly string[] pictures = Directory.GetFiles(Game.GetPictureFolder(), "*.jpg");
        PictureBox firstCard;
        PictureBox secondCard;
        public Memory()
        {
            InitializeComponent();
            Game.Validate(pictures);
            CreateCards();
            tableLayoutPanel1.Hide();
            TimerOne.Stop();
        }
        private void CreateCards()
        {
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < Game.cardPick; i++)
                {
                    cards.Add(new PlayingCards(pictures[i], i));
                }
            }
            cards = PlayingCards.ShuffleCards(cards); //for debugging purposes it can be nice to comment this function call.
            int t = 0;
            foreach (PictureBox pictureBox in tableLayoutPanel1.Controls.OfType<PictureBox>())
            {
                try //Depends on Game.cardPick
                { pictureBox.Image = cards[t].background;
                    t++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    pictureBox.Image = null;
                }
            }
        }
        private void picture_Click(object sender, EventArgs e)
        {
            if (!TimerOne.Enabled)
            {
                PictureBox selected = sender as PictureBox;
                card = cards.FirstOrDefault(o => o.background == selected.Image);
                if (card == null) { card = cards.FirstOrDefault(o => o.image == selected.Image); }
                if (card != null)
                {
                    if (card.background == selected.Image)
                    {
                        if (tempInput == 0)
                        {
                            firstCard = selected;
                            card.TurnCardUp(firstCard);
                            tempInput++;
                            tempCard = card;
                            Game.playerList[Game.crntPlayer].movesMade++;
                        }
                        else if (tempInput == 1)
                        {
                            secondCard = selected;
                            card.TurnCardUp(secondCard);
                            tempInput = 0;
                            if (PlayingCards.IsMatch(card.cardId, tempCard.cardId))
                            {
                                Game.playerList[Game.crntPlayer].ScoreAdd();
                                showScore();
                                Game.HasFinished();
                            }
                            else
                            {
                                blurPic();
                                if (Game.crntPlayer < Game.playerList.Count - 1)
                                {
                                    Game.crntPlayer++;
                                }
                                else
                                {
                                    Game.crntPlayer = 0;
                                }
                                TimerOne.Start();
                            }
                        }
                    }
                }
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
        
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
        
        }
        private void loadPlayerAvatars()
        {

            if (Game.playerList.Count == 1)
                pictureBoxP1.Image = Game.playerList[0].playable.image;
            if (Game.playerList.Count == 2)
            {
                pictureBoxP1.Image = Game.playerList[0].playable.image;
                pictureBoxP2.Image = Game.playerList[1].playable.blur;
            }
            if (Game.playerList.Count == 3)
            {
                pictureBoxP1.Image = Game.playerList[0].playable.image;
                pictureBoxP2.Image = Game.playerList[1].playable.blur;
                pictureBoxP3.Image = Game.playerList[2].playable.blur;
            }
            if (Game.playerList.Count == 4)
            {
                pictureBoxP1.Image = Game.playerList[0].playable.image;
                pictureBoxP2.Image = Game.playerList[1].playable.blur;
                pictureBoxP3.Image = Game.playerList[2].playable.blur;
                pictureBoxP4.Image = Game.playerList[3].playable.blur;
            }
        }
        private void showScore()
        {
            if (Game.crntPlayer == 0)
                scoreLabel1.Text = Game.playerList[0].GetAll();
            if (Game.crntPlayer == 1)
                scoreLabel2.Text = Game.playerList[1].GetAll();
            if (Game.crntPlayer == 2)
                scoreLabel3.Text = Game.playerList[2].GetAll();
            if (Game.crntPlayer == 3)
                scoreLabel4.Text = Game.playerList[3].GetAll();

        }
        private void blurPic()
        {
            if (Game.crntPlayer == 0)
                pictureBoxP1.Image = Game.playerList[0].playable.blur;
            if (Game.crntPlayer == 1)
                pictureBoxP2.Image = Game.playerList[1].playable.blur;
            if (Game.crntPlayer == 2)
                pictureBoxP3.Image = Game.playerList[2].playable.blur;
            if (Game.crntPlayer == 3)
                pictureBoxP4.Image = Game.playerList[3].playable.blur;

        }
        private void unblur()
        {
            if (Game.crntPlayer == 0)
                pictureBoxP1.Image = Game.playerList[0].playable.image;
            if (Game.crntPlayer == 1)
                pictureBoxP2.Image = Game.playerList[1].playable.image;
            if (Game.crntPlayer == 2)
                pictureBoxP3.Image = Game.playerList[2].playable.image;
            if (Game.crntPlayer == 3)
                pictureBoxP4.Image = Game.playerList[3].playable.image;

        }
        private void onFormLoad(object sender, EventArgs e)
        {
            Sounds.stopSound(1);
            Sounds.playSound(2, true);
            tableLayoutPanel1.Show();
            startButton.Hide();
            loadPlayerAvatars();
            TimerOne.Stop();
            GameTimer.Start();
        }
        private void shopButton_Click(object sender, EventArgs e)
        {
          
        }
      
        private void closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void TimerOne_Tick(object sender, EventArgs e)
        {
            tempCard.TurnCardDown(firstCard);
            card.TurnCardDown(secondCard);
            unblur();
            TimerOne.Stop();
        }
        private void ElapsedTime_Click(object sender, EventArgs e)
        {

        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Game.time++;
            if (Game.time == 60)
            {
                Game.minutes++;
                Game.time = 0;
            }
            ElapsedTime.Text = Game.minutes.ToString() + ":" + Game.time.ToString();
        }
    }
}
