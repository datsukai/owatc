using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TossButton_Click(object sender, EventArgs e)
        {
            int sideUp;
            Random rand = new Random();
            sideUp = rand.Next(2);
            if (sideUp == 0)
            {
                TailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                headsPictureBox.Visible = true;
                TailsPictureBox.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TailsPictureBox.Visible = false;
            headsPictureBox.Visible = false;
        }
    }
}
