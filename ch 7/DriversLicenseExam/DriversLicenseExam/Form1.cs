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

namespace DriversLicenseExam
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[] GetFileContents(string filename)
        {
            StreamReader inputFile;
            inputFile = File.OpenText(filename);
            string line;
            int index = 0;
            string[] results = new string[20]; 
            while ((line = inputFile.ReadLine()) != null)
            {
                results[index++] = line;
            }

            return results;
            
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
           
            StreamReader inputFile;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);
            }
            else
            {
                MessageBox.Show("Operation Canceled");

            }
            string[] answers = GetFileContents("TestAnswers.txt");
            string[] students = GetFileContents(openFile.FileName);
            decimal incorrect = 0;
            decimal percent = 0;
            int index = 0;
            while (index < answers.Length)
            {
                if (answers[index] != students[index])
                {
                    incorrect += 1;
                }
                index++;
            }
    

            if (incorrect <= 5)
            {
                percent = (20 - incorrect) / 20;
                MessageBox.Show("You have passed with a " + percent.ToString("p0"));
            }
            else
            {
                percent = (20 - incorrect) / 20;
                MessageBox.Show("You have failed with a " + percent.ToString("p0"));
            }
            
    }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }
    }        
}
