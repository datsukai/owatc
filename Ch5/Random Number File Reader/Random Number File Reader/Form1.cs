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

namespace Random_Number_File_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void ReadButton_Click(object sender, EventArgs e)
        {
            int count = 0, numbers = 0, totalNumbers = 0;
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;
            StreamReader inputFile = new StreamReader(filePath);
            DisplayListBox.Items.Clear();

            while (!inputFile.EndOfStream)
            {
                numbers = Convert.ToInt32(inputFile.ReadLine());
                DisplayListBox.Items.Add(numbers);
                totalNumbers = totalNumbers + numbers;
                count++;

            }
            displayRandNumLabel.Text = Convert.ToString(count);
            displayTotalNumLabel.Text = Convert.ToString(totalNumbers);
        }
    }
}
