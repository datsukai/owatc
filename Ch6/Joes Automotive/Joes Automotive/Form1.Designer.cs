namespace Joes_Automotive
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OilChangecheckBox = new System.Windows.Forms.CheckBox();
            this.LubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.RadiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.TransmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.InspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.MufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.TireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PartsTextBox = new System.Windows.Forms.TextBox();
            this.LaborTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayServicesPartsLabel = new System.Windows.Forms.Label();
            this.displayPartsLabel = new System.Windows.Forms.Label();
            this.displayTaxLabel = new System.Windows.Forms.Label();
            this.displayTotalFeesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LubeJobCheckBox);
            this.groupBox1.Controls.Add(this.OilChangecheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil && Lube";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TransmissionFlushCheckBox);
            this.groupBox2.Controls.Add(this.RadiatorCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(285, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TireRotationCheckBox);
            this.groupBox3.Controls.Add(this.MufflerCheckBox);
            this.groupBox3.Controls.Add(this.InspectionCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 108);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LaborTextBox);
            this.groupBox4.Controls.Add(this.PartsTextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(285, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 108);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts && Labor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.displayTotalFeesLabel);
            this.groupBox5.Controls.Add(this.displayTaxLabel);
            this.groupBox5.Controls.Add(this.displayPartsLabel);
            this.groupBox5.Controls.Add(this.displayServicesPartsLabel);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(88, 223);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 166);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(52, 407);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(106, 30);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(182, 407);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 30);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(318, 407);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(106, 30);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OilChangecheckBox
            // 
            this.OilChangecheckBox.AutoSize = true;
            this.OilChangecheckBox.Location = new System.Drawing.Point(26, 28);
            this.OilChangecheckBox.Name = "OilChangecheckBox";
            this.OilChangecheckBox.Size = new System.Drawing.Size(120, 17);
            this.OilChangecheckBox.TabIndex = 0;
            this.OilChangecheckBox.Text = "Oil Change ($26.00)";
            this.OilChangecheckBox.UseVisualStyleBackColor = true;
            // 
            // LubeJobCheckBox
            // 
            this.LubeJobCheckBox.AutoSize = true;
            this.LubeJobCheckBox.Location = new System.Drawing.Point(26, 51);
            this.LubeJobCheckBox.Name = "LubeJobCheckBox";
            this.LubeJobCheckBox.Size = new System.Drawing.Size(112, 17);
            this.LubeJobCheckBox.TabIndex = 1;
            this.LubeJobCheckBox.Text = "Lube Job ($18.00)";
            this.LubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // RadiatorCheckBox
            // 
            this.RadiatorCheckBox.AutoSize = true;
            this.RadiatorCheckBox.Location = new System.Drawing.Point(16, 19);
            this.RadiatorCheckBox.Name = "RadiatorCheckBox";
            this.RadiatorCheckBox.Size = new System.Drawing.Size(136, 17);
            this.RadiatorCheckBox.TabIndex = 2;
            this.RadiatorCheckBox.Text = "Radiator Flush ($30.00)";
            this.RadiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransmissionFlushCheckBox
            // 
            this.TransmissionFlushCheckBox.AutoSize = true;
            this.TransmissionFlushCheckBox.Location = new System.Drawing.Point(16, 51);
            this.TransmissionFlushCheckBox.Name = "TransmissionFlushCheckBox";
            this.TransmissionFlushCheckBox.Size = new System.Drawing.Size(157, 17);
            this.TransmissionFlushCheckBox.TabIndex = 3;
            this.TransmissionFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.TransmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // InspectionCheckBox
            // 
            this.InspectionCheckBox.AutoSize = true;
            this.InspectionCheckBox.Location = new System.Drawing.Point(26, 30);
            this.InspectionCheckBox.Name = "InspectionCheckBox";
            this.InspectionCheckBox.Size = new System.Drawing.Size(117, 17);
            this.InspectionCheckBox.TabIndex = 4;
            this.InspectionCheckBox.Text = "Inspection ($15.00)";
            this.InspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // MufflerCheckBox
            // 
            this.MufflerCheckBox.AutoSize = true;
            this.MufflerCheckBox.Location = new System.Drawing.Point(26, 53);
            this.MufflerCheckBox.Name = "MufflerCheckBox";
            this.MufflerCheckBox.Size = new System.Drawing.Size(149, 17);
            this.MufflerCheckBox.TabIndex = 7;
            this.MufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.MufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // TireRotationCheckBox
            // 
            this.TireRotationCheckBox.AutoSize = true;
            this.TireRotationCheckBox.Location = new System.Drawing.Point(26, 76);
            this.TireRotationCheckBox.Name = "TireRotationCheckBox";
            this.TireRotationCheckBox.Size = new System.Drawing.Size(129, 17);
            this.TireRotationCheckBox.TabIndex = 7;
            this.TireRotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.TireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor ($)";
            // 
            // PartsTextBox
            // 
            this.PartsTextBox.Location = new System.Drawing.Point(67, 27);
            this.PartsTextBox.Name = "PartsTextBox";
            this.PartsTextBox.Size = new System.Drawing.Size(72, 20);
            this.PartsTextBox.TabIndex = 2;
            // 
            // LaborTextBox
            // 
            this.LaborTextBox.Location = new System.Drawing.Point(67, 53);
            this.LaborTextBox.Name = "LaborTextBox";
            this.LaborTextBox.Size = new System.Drawing.Size(72, 20);
            this.LaborTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Services && Labor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tax (on parts)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Fees";
            // 
            // displayServicesPartsLabel
            // 
            this.displayServicesPartsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayServicesPartsLabel.Location = new System.Drawing.Point(143, 30);
            this.displayServicesPartsLabel.Name = "displayServicesPartsLabel";
            this.displayServicesPartsLabel.Size = new System.Drawing.Size(108, 22);
            this.displayServicesPartsLabel.TabIndex = 8;
            // 
            // displayPartsLabel
            // 
            this.displayPartsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPartsLabel.Location = new System.Drawing.Point(143, 56);
            this.displayPartsLabel.Name = "displayPartsLabel";
            this.displayPartsLabel.Size = new System.Drawing.Size(108, 22);
            this.displayPartsLabel.TabIndex = 9;
            // 
            // displayTaxLabel
            // 
            this.displayTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTaxLabel.Location = new System.Drawing.Point(143, 83);
            this.displayTaxLabel.Name = "displayTaxLabel";
            this.displayTaxLabel.Size = new System.Drawing.Size(108, 22);
            this.displayTaxLabel.TabIndex = 10;
            // 
            // displayTotalFeesLabel
            // 
            this.displayTotalFeesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTotalFeesLabel.Location = new System.Drawing.Point(143, 114);
            this.displayTotalFeesLabel.Name = "displayTotalFeesLabel";
            this.displayTotalFeesLabel.Size = new System.Drawing.Size(108, 22);
            this.displayTotalFeesLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 449);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LubeJobCheckBox;
        private System.Windows.Forms.CheckBox OilChangecheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox TransmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox RadiatorCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox TireRotationCheckBox;
        private System.Windows.Forms.CheckBox MufflerCheckBox;
        private System.Windows.Forms.CheckBox InspectionCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox LaborTextBox;
        private System.Windows.Forms.TextBox PartsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label displayTotalFeesLabel;
        private System.Windows.Forms.Label displayTaxLabel;
        private System.Windows.Forms.Label displayPartsLabel;
        private System.Windows.Forms.Label displayServicesPartsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

