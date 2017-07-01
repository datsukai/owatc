using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Charges
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

        private double CalcStayCharges()
        {
            double days, staycost = 350; 
            if (double.TryParse(DaysTextbox.Text, out days))
                 {
                return staycost* days;
            } else
            {
                return 0;
            }
            
}
        private double CalMiscCharges()
        {
            double total = 0, medication, surgical, lab, rehabilitation;
            
            if (double.TryParse(MedicationTextbox.Text, out medication))
            {

                total += medication;
            }
            if (double.TryParse(SurgicalTextbox.Text, out surgical))
            {

                total += surgical;
            }
            if (double.TryParse(LabTextbox.Text, out lab))
            {

                total += lab;
            }
            if (double.TryParse(RehabilationTextbox.Text, out rehabilitation))
            {

                total += rehabilitation;
            }

            return total;
        }
        private double CalTotalCharges()
        {
            try
            {
                double totaldays, totalmisc;

               
                totaldays = CalcStayCharges();
                
                totalmisc = CalMiscCharges();

                return totaldays + totalmisc;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            DaysTextbox.Text = "";
            MedicationTextbox.Text = "";
            SurgicalTextbox.Text = "";
            LabTextbox.Text = "";
            RehabilationTextbox.Text = "";
            displayMiscLabel.Text = "";
            displayStayLabel.Text = "";
            DisplayTotalCostLabel.Text = "";
            DaysTextbox.Focus();

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalcStayCharges();
            CalMiscCharges();
            CalTotalCharges();
            displayStayLabel.Text = CalcStayCharges().ToString("c");
            displayMiscLabel.Text = CalMiscCharges().ToString("c");
            DisplayTotalCostLabel.Text = CalTotalCharges().ToString("c");
        }
    }
}
