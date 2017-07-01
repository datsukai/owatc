using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            StartingNumTextbox.Text = "";
            AverageTextbox.Text = "";
            DaysTextbox.Text = "";
            DisplayListBox.Items.Clear();
            StartingNumTextbox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            double START_NUM, AVERAGE, DAYS, TOTAL_POP = 0, DAY_POP;
            int count = 1;

            try
            {
                START_NUM = double.Parse(StartingNumTextbox.Text);
                AVERAGE = double.Parse(AverageTextbox.Text);
                DAYS = double.Parse(DaysTextbox.Text);

                AVERAGE = AVERAGE / 100;
                    while (count <= DAYS)
                    {

                        DisplayListBox.Items.Add("The Day is " + count + " and the Average Population is " + START_NUM);
                        DAY_POP = AVERAGE * START_NUM;
                        START_NUM = START_NUM + DAY_POP;
                        count += 1;
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter values of all boxes");
            }
        }
    }
}
