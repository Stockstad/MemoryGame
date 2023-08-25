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
      
        settingsform settings = new settingsform();
        playerControl pControl = new playerControl();
        public startform()
        {
            InitializeComponent();
            Sounds.playSound(0, true);
          
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            

            pControl.Show();
        
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
            Application.Exit();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            if (settings.IsDisposed)
            {
                settings = new settingsform();
                settings.ShowDialog();
            }
            else
                settings.ShowDialog();
        }

        private void startform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
