using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
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

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double measurement;
                string ToUnits;
                string FromUnits;
                
                double Result = 0;

                

                if (FromListBox.SelectedIndex != -1 || ToListBox.SelectedIndex != -1)
                {
                    FromUnits = FromListBox.SelectedItem.ToString();
                    ToUnits = ToListBox.SelectedItem.ToString();
                    measurement = double.Parse(MeasurementTextBox.Text);

                    switch (FromUnits)
                    {
                        case "Yards":
                            switch (ToUnits)
                            {
                                case "Yards":
                                    Result = measurement;
                                    break;
                                case "Feet":
                                    Result = measurement * 3;
                                    break;
                                case "Inches":
                                    Result = measurement * 3 * 12;
                                    break;
                            }
                            break;
                        case "Feet":
                            switch (ToUnits)
                            {
                                case "Feet":
                                    Result = measurement;
                                    break;
                                case "Yards":
                                    Result = measurement / 3;
                                    break;
                                case "Inches":
                                    Result = measurement * 12;
                                    break;
                            }
                            break;
                        case "Inches":
                            switch (ToUnits)
                            {
                                case "Inches":
                                    Result = measurement;
                                    break;
                                case "Feet":
                                    Result = measurement / 12;
                                    break;
                                case "Yards":
                                    Result = measurement / (3 * 12);
                                    break;
                            }
                            break;
                    }
                    DisplayConversionLabel.Text = Result.ToString();
                }
          
                else
                {
                    MessageBox.Show("Missing Measurement.");
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
