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

namespace Distance_Calculator
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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double speed, time, distance;
            int count = 1;
            string display;


            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("DistanceCalculator.txt");
                
                speed = double.Parse(SpeedMPHTextBox.Text);
                time = double.Parse(HoursTraveledTextBox.Text);

                while ( count <= time)
                {
                    distance = speed * count;
                    outputFile.WriteLine(" After hour " + count + " the distance is " + distance);
                    count += 1;
                }

                outputFile.Close();

                MessageBox.Show("Data has been placed in the Distance Calculator document.")
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
}
