using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joes_Automotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void ClearOilLube()
        {
             OilChangecheckBox.Checked = false;
            LubeJobCheckBox.Checked = false;
        }
        private void ClearFlushes()
        {
             RadiatorCheckBox.Checked = false;
            TransmissionFlushCheckBox.Checked = false;
        }
        private void ClearMisc()
        {
            InspectionCheckBox.Checked = false;
            MufflerCheckBox.Checked = false;
            TireRotationCheckBox.Checked = false;
        }
        private void ClearOther()
        {
            PartsTextBox.Text = "";
            LaborTextBox.Text = "";
        }
        private void ClearFees()
        {
            displayPartsLabel.Text = "";
            displayServicesPartsLabel.Text = "";
            displayTaxLabel.Text = "";
            displayTotalFeesLabel.Text = "";
        }
        private double OilLubeCharges()
        {
            double oil, lube;
            if (OilChangecheckBox.Checked == true)
            {
                oil = 26.00;
            }
            else
            {
                oil = 0.0;
            }
            if (LubeJobCheckBox.Checked == true)
            {
                lube = 18.00;
            }
            else
            {
                lube = 0.0;
            }
            return lube + oil;
        }

        private double FlushCharges()
        {
            double radiator, transmission;
            if (RadiatorCheckBox.Checked == true)
            {
                radiator = 30.00;
            }
            else
            {
                radiator = 0.0;
            }
            if (TransmissionFlushCheckBox.Checked == true)
            {
                transmission = 80.00;
            }
            else
            {
                transmission = 0.0;
            }
            return transmission + radiator;
        }
        private double MiscCharges()
        {
            double inspection, muffler, tire_rotation;

            if (InspectionCheckBox.Checked == true)
            {
                inspection =  15.00;
            }
            else
            {
                inspection = 0.0;
            }
            if (MufflerCheckBox.Checked == true)
            {
               muffler = 100.00;
            }
            else
            {
                muffler = 0.0;
            }
            if (TireRotationCheckBox.Checked == true)
            {
                tire_rotation = 20.00;
            }
            else
            {
                tire_rotation = 0.0;
            }
            return muffler + inspection + tire_rotation;
        }
        private double OtherCharges()
        {
            double parts, labor, totalLabor, totalParts;
            if (double.TryParse(PartsTextBox.Text, out parts))
            {
                totalParts = parts;
            }
            else
            {
                totalParts = 0.0;
            }
            if (double.TryParse(LaborTextBox.Text, out labor))
            {
                totalLabor = 20.00 * labor;
            }
            else
            {
                totalLabor = 0.0;
            }
            return totalParts + totalLabor;
        }
        private double TaxCharges()
        {
            double partsTax, totalTax, tax = 0.06;
            if (double.TryParse(PartsTextBox.Text, out partsTax))
            {
                totalTax = partsTax * tax;
            }
            else
            {
                totalTax = 0.0;
            }
            return totalTax;
        }
        private double TotalCharges()
        {
            //double Total;

            return  OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {

            ClearOther();
            ClearFees();
            ClearOilLube();
            ClearFlushes();
            ClearMisc();                
            OilChangecheckBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
          
            displayTotalFeesLabel.Text =  TotalCharges().ToString("c");
            displayServicesPartsLabel.Text = (FlushCharges() + MiscCharges() + OilLubeCharges()).ToString("C");
            displayPartsLabel.Text = PartsTextBox.Text;
            displayTaxLabel.Text = TaxCharges().ToString("C");
        }
    }
}
