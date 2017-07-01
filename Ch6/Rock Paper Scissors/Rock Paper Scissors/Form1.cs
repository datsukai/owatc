using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Play()
        {
            Random rand = new Random();
            int play, rock = 1, paper = 2, scissors = 3;
            play = rand.Next(1,4);
            if (play == 1)
            {
                play = rock;
            }
            if (play == 2)
            {
                play = paper;
            }
            if (play == 3)
            {
                play = scissors;
            }
            return play;

        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            Play();
            if (Play() == 1)
            {
                MessageBox.Show("Computer:Rock, its a Tie.");
            }
            else if (Play() == 2)
            {
                MessageBox.Show("Computer: Paper, Computer wins.");
            }
            else if (Play() == 3)
            {
                MessageBox.Show("Computer: Scissors, User Wins.");
            }

        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            Play();
            if (Play() == 1)
            {
                MessageBox.Show("Computer:Rock, User Wins.");
            }
            else if (Play() == 2)
            {
                MessageBox.Show("Computer: Paper, It's a Tie.");
            }
            else if (Play() == 3)
            {
                MessageBox.Show("Computer: Scissors, Computer Wins.");
            }

        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            Play();
            if (Play() == 1)
            {
                MessageBox.Show("Computer:Rock, Computer Wins.");
            }
            else if (Play() == 2)
            {
                MessageBox.Show("Computer: Paper, User Wins.");
            }
            else if (Play() == 3)
            {
                MessageBox.Show("Computer: Scissors, It's a Tie.");
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}