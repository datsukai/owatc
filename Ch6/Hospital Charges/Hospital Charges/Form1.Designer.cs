namespace Hospital_Charges
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DaysTextbox = new System.Windows.Forms.TextBox();
            this.MedicationTextbox = new System.Windows.Forms.TextBox();
            this.SurgicalTextbox = new System.Windows.Forms.TextBox();
            this.LabTextbox = new System.Windows.Forms.TextBox();
            this.RehabilationTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.displayStayLabel = new System.Windows.Forms.Label();
            this.displayMiscLabel = new System.Windows.Forms.Label();
            this.DisplayTotalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of days spent in the hospital:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount of Medication Charges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount of Surgical Charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount of Lab Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount of Physical Rehabilitation Charges:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(83, 274);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(113, 31);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(215, 274);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(113, 31);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(342, 274);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 31);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DaysTextbox
            // 
            this.DaysTextbox.Location = new System.Drawing.Point(227, 25);
            this.DaysTextbox.Name = "DaysTextbox";
            this.DaysTextbox.Size = new System.Drawing.Size(128, 20);
            this.DaysTextbox.TabIndex = 8;
            // 
            // MedicationTextbox
            // 
            this.MedicationTextbox.Location = new System.Drawing.Point(227, 55);
            this.MedicationTextbox.Name = "MedicationTextbox";
            this.MedicationTextbox.Size = new System.Drawing.Size(128, 20);
            this.MedicationTextbox.TabIndex = 9;
            // 
            // SurgicalTextbox
            // 
            this.SurgicalTextbox.Location = new System.Drawing.Point(227, 84);
            this.SurgicalTextbox.Name = "SurgicalTextbox";
            this.SurgicalTextbox.Size = new System.Drawing.Size(128, 20);
            this.SurgicalTextbox.TabIndex = 10;
            // 
            // LabTextbox
            // 
            this.LabTextbox.Location = new System.Drawing.Point(227, 115);
            this.LabTextbox.Name = "LabTextbox";
            this.LabTextbox.Size = new System.Drawing.Size(128, 20);
            this.LabTextbox.TabIndex = 11;
            // 
            // RehabilationTextbox
            // 
            this.RehabilationTextbox.Location = new System.Drawing.Point(227, 141);
            this.RehabilationTextbox.Name = "RehabilationTextbox";
            this.RehabilationTextbox.Size = new System.Drawing.Size(128, 20);
            this.RehabilationTextbox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stay Charges:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Miscellanous Charges:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Charges:";
            // 
            // displayStayLabel
            // 
            this.displayStayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayStayLabel.Location = new System.Drawing.Point(210, 173);
            this.displayStayLabel.Name = "displayStayLabel";
            this.displayStayLabel.Size = new System.Drawing.Size(145, 22);
            this.displayStayLabel.TabIndex = 16;
            // 
            // displayMiscLabel
            // 
            this.displayMiscLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayMiscLabel.Location = new System.Drawing.Point(210, 201);
            this.displayMiscLabel.Name = "displayMiscLabel";
            this.displayMiscLabel.Size = new System.Drawing.Size(145, 22);
            this.displayMiscLabel.TabIndex = 17;
            // 
            // DisplayTotalCostLabel
            // 
            this.DisplayTotalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayTotalCostLabel.Location = new System.Drawing.Point(210, 230);
            this.DisplayTotalCostLabel.Name = "DisplayTotalCostLabel";
            this.DisplayTotalCostLabel.Size = new System.Drawing.Size(145, 22);
            this.DisplayTotalCostLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 336);
            this.Controls.Add(this.DisplayTotalCostLabel);
            this.Controls.Add(this.displayMiscLabel);
            this.Controls.Add(this.displayStayLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RehabilationTextbox);
            this.Controls.Add(this.LabTextbox);
            this.Controls.Add(this.SurgicalTextbox);
            this.Controls.Add(this.MedicationTextbox);
            this.Controls.Add(this.DaysTextbox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox DaysTextbox;
        private System.Windows.Forms.TextBox MedicationTextbox;
        private System.Windows.Forms.TextBox SurgicalTextbox;
        private System.Windows.Forms.TextBox LabTextbox;
        private System.Windows.Forms.TextBox RehabilationTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label displayStayLabel;
        private System.Windows.Forms.Label displayMiscLabel;
        private System.Windows.Forms.Label DisplayTotalCostLabel;
    }
}

