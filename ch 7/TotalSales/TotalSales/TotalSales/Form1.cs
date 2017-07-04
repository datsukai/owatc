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


namespace TotalSales
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
          

            try
            {  StreamReader inputFile;
                int SIZE = 7; int index = 0; decimal total = 0;
                decimal[] numbers = new decimal[SIZE];
                inputFile = File.OpenText("Sales.txt");

                while (index < numbers.Length && !inputFile.EndOfStream)
                {
                    numbers[index] = decimal.Parse(inputFile.ReadLine());
                    index++;
                }

                inputFile.Close();

                foreach (decimal value in numbers)
                {
                    SalesListBox.Items.Add(value);
                    total += value;
                }
             
                DisplayTotalLabel.Text = Convert.ToString(total);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
