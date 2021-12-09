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
    public partial class startform : Form
    {
        Memory memory = new Memory();
        playerControl pControl = new playerControl();
        public startform()
        {
            InitializeComponent();
            Sounds.menuMusic();
          
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Sounds.playPipe();
            pControl.Show();
            Sounds.menuMusicStop();
            this.Hide();
    

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startBtnHover(object sender, EventArgs e)
        {
         
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet available!");
        }

        private void startform_Load(object sender, EventArgs e)
        {

        }
    }
}
