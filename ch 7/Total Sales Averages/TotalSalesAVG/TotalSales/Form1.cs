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

        private decimal Average(decimal total)
        {
            decimal average;

            average = (decimal)total / 8;
            return average;
        }

        private decimal Highest(decimal[] iArray)
        {
            decimal highest = iArray[0];
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] > highest)
                {
                    highest = Convert.ToDecimal(iArray[index]);
                }
            }
            return highest;
        }

        private decimal Lowest(decimal[] iArray)
        {
            decimal lowest = iArray[0];
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] < lowest)
                {
                    lowest = Convert.ToDecimal(iArray[index]);
                }
            }
            return lowest;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                int SIZE = 7; int index = 0; decimal total = 0;
                decimal[] numbers = new decimal[SIZE];
                inputFile = File.OpenText("Sales.txt");
                decimal average;
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
                average = Average(total);
                LowestLabel.Text = Convert.ToString(Lowest(numbers));
                HighestLabel.Text = Convert.ToString(Highest(numbers));

                AverageLabel.Text = Convert.ToString(average.ToString("n2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
       
    }

