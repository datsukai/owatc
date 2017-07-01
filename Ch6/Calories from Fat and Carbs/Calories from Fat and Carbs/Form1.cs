using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_from_Fat_and_Carbs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private double FatCalories(double FatCal)
        {
            double fat;

            if (double.TryParse(FatTextBox.Text, out fat))
                {
                return (fat * 9.0);
            }
            else
            {
                MessageBox.Show("Enter a valid number for fat grams.");
            }
            return 0;
        }

        private double CarbCalories(double CarbCal)
        {
            double carbs;
            if (double.TryParse(CarbohydrateTextbox.Text, out carbs))
            { return (carbs * 4.0);
            }
            else
            {
                MessageBox.Show("Enter a valid number for carb grams.");
            }
            return 0;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double totalcarbs, totalfat, carbs, fat;
                fat = Convert.ToDouble(FatTextBox.Text);
                carbs = Convert.ToDouble(CarbohydrateTextbox.Text);
                totalcarbs = CarbCalories(carbs);
                totalfat = FatCalories(fat);
                displayCarbsLabel.Text = totalcarbs.ToString("n1");
                DisplayFatLabel.Text = totalfat.ToString("n1"); }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            }
    }


        
    

