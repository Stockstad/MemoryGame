using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MemoryGame
{
    public partial class settingsform : Form
    {
        public settingsform()
        {
            InitializeComponent();
        }
        private void settingsform_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2; 
        }
        private void Shutclose(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You might have made changes which can impact the game negatively. Do you wish to procede?", "Warning: Potential Changes Made", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Game.cardPick = int.Parse(comboBox1.SelectedItem.ToString()) / 2;
            }
            else
                MessageBox.Show("Select number of cards!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(Game.GetPictureFolder());
        }
    }
}
