using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsPrime(bool number)
        {
            int num;
            bool numberIsPrime = false;

            if (int.TryParse(DataTextBox.Text, out num))
            {
                if (num <= 1)
                {
                    numberIsPrime = false;
                    return numberIsPrime;
                }
                else if (num <= 3 || num == 5 || num == 7 || num == 11 || num == 13)
                {
                    numberIsPrime = true;
                    return numberIsPrime;
                }
                else
                {
                    numberIsPrime = false;
                    return numberIsPrime;
                }

            }
            else
            {
                MessageBox.Show("Please enter a number and no other character.");
                return numberIsPrime;

            }


        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            bool number = false;
            if (IsPrime(number))
            {
                MessageBox.Show("This is a prime number.");
            }

            else
            {
                MessageBox.Show("This is NOT a prime number.");
            }
        }
    }
}