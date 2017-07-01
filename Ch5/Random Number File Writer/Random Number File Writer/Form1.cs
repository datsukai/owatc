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

namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
           
            try {
                StreamWriter outputFile;
                int randomNumber = 0;
                int number = Convert.ToInt32(howmanyTextBox.Text);
                

                Random rand = new Random();

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.ShowDialog();
                string filePath = saveFile.FileName;

                outputFile = File.CreateText(filePath);



                while (number > 0)
                {
                    randomNumber = rand.Next(1, 100);
                    outputFile.WriteLine(randomNumber.ToString());
                    number--;

                }
                outputFile.Close();
                    }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
