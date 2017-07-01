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

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Total()
        {
            int total = 0;

            for (int index = 0; index <iArray.Length; index++)
            {
                total += iArray[index];
            }
            return total;
        }

         private void DisplaySales(List<double> SalesTaxListBox)
        private void ReadSales(List<int> SalesTaxListBox)
        {
            try
            {
                StreamReader inputFile = File.OpenText("Sales.txt");
                while (!inputFile.EndOfStream)
                {
                    SalesTaxListBox.Add(int.Parse(inputFile.ReadLine()));
                }
                inputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int NumberofItems(int[] iArray)
        {
            int count = 0;
            for (int index = 0; index < iArray.Length; index++)
            {
                count += 1;
            }
            return count;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            

            }
        }
    }
}
