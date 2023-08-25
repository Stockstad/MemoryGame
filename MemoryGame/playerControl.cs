using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MemoryGame
{
    public partial class playerControl : Form
    {
        List<Playable> playables = Game.CreatePlayables();
        PictureBox selected;
        Playable f;

        public playerControl()
        {
            InitializeComponent();
        }

        private void playerControl_Load(object sender, EventArgs e)
        {
            Sounds.stopSound(0);
            Sounds.playSound(1, true);
            int i = 0;
            foreach (Control controls in SelectTable.Controls)
            {
                if (controls is PictureBox)
                {
                    var pb = controls as PictureBox;
                    pb.Image = playables[i].image;
                    pb.Tag = playables[i];
                    i++;
                }
            }
        }

        private void p1Click(object sender, EventArgs e)
        {
          
        }


        private void ctnBtn_Click(object sender, EventArgs e)
        {

            if (Game.numberOfPlayers != 0)
            {
                
                

               
            }
            else
                MessageBox.Show("You need to select at least 1 player!");
        }

        private void P2(object sender, EventArgs e)
        {
           
        }

        private void P4Click(object sender, EventArgs e)
        {
      
        }

        private void P3Click(object sender, EventArgs e)
        {
         
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //if users presses closing button, entire program shuts down.
        }

        private void StartGame()
        {
            



        }

        private void SelectClick(object sender, EventArgs e)
        {
            selected = sender as PictureBox;
  
            f = playables.FirstOrDefault(o => o.image == selected.Image);

            if (f == null)
            {
                f = playables.FirstOrDefault(o => o.blur == selected.Image); 
            }
   
            if (!f.taken)
            {
                selected.Image = f.blur;
                f.taken = true;
                Game.numberOfPlayers++;
                PlayerLabel.Text = Game.numberOfPlayers.ToString();
            }
            else
            {
                selected.Image = f.image;
                f.taken = false;
                Game.numberOfPlayers--;
                PlayerLabel.Text = Game.numberOfPlayers.ToString();
            }

        }
        
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (Game.numberOfPlayers != 0)
            {
                foreach (Control control in SelectTable.Controls)
                {
                    PictureBox indexed = control as PictureBox;
                    var find = playables.FirstOrDefault(o => o.blur == indexed.Image);
                    if (find != null)
                    {
                        if (find.blur == indexed.Image)
                        {
                            Game.playerList.Add(new Player(find));
                        }
                    }
                }

                Memory memory = new Memory();
                memory.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Pick at least 1 player!", "FATAL ERROR");
          
        }

        private void PlayerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
