namespace Distance_Converter
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
            this.FromGroupBox = new System.Windows.Forms.GroupBox();
            this.FromListBox = new System.Windows.Forms.ListBox();
            this.ToListBox = new System.Windows.Forms.ListBox();
            this.ToGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayConversionLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MeasurementTextBox = new System.Windows.Forms.TextBox();
            this.FromGroupBox.SuspendLayout();
            this.ToGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a distance to convert:";
            // 
            // FromGroupBox
            // 
            this.FromGroupBox.Controls.Add(this.FromListBox);
            this.FromGroupBox.Location = new System.Drawing.Point(25, 39);
            this.FromGroupBox.Name = "FromGroupBox";
            this.FromGroupBox.Size = new System.Drawing.Size(167, 89);
            this.FromGroupBox.TabIndex = 1;
            this.FromGroupBox.TabStop = false;
            this.FromGroupBox.Text = "From";
            // 
            // FromListBox
            // 
            this.FromListBox.FormattingEnabled = true;
            this.FromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.FromListBox.Location = new System.Drawing.Point(11, 18);
            this.FromListBox.Name = "FromListBox";
            this.FromListBox.Size = new System.Drawing.Size(142, 56);
            this.FromListBox.TabIndex = 0;
            // 
            // ToListBox
            // 
            this.ToListBox.FormattingEnabled = true;
            this.ToListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.ToListBox.Location = new System.Drawing.Point(11, 18);
            this.ToListBox.Name = "ToListBox";
            this.ToListBox.Size = new System.Drawing.Size(142, 56);
            this.ToListBox.TabIndex = 0;
            // 
            // ToGroupBox
            // 
            this.ToGroupBox.Controls.Add(this.ToListBox);
            this.ToGroupBox.Location = new System.Drawing.Point(219, 39);
            this.ToGroupBox.Name = "ToGroupBox";
            this.ToGroupBox.Size = new System.Drawing.Size(167, 89);
            this.ToGroupBox.TabIndex = 2;
            this.ToGroupBox.TabStop = false;
            this.ToGroupBox.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Converted Distance:";
            // 
            // DisplayConversionLabel
            // 
            this.DisplayConversionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayConversionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayConversionLabel.Location = new System.Drawing.Point(150, 139);
            this.DisplayConversionLabel.Name = "DisplayConversionLabel";
            this.DisplayConversionLabel.Size = new System.Drawing.Size(196, 23);
            this.DisplayConversionLabel.TabIndex = 4;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(70, 182);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(90, 36);
            this.ConvertButton.TabIndex = 5;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(219, 182);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 36);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MeasurementTextBox
            // 
            this.MeasurementTextBox.Location = new System.Drawing.Point(169, 6);
            this.MeasurementTextBox.Name = "MeasurementTextBox";
            this.MeasurementTextBox.Size = new System.Drawing.Size(202, 20);
            this.MeasurementTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 246);
            this.Controls.Add(this.MeasurementTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.DisplayConversionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToGroupBox);
            this.Controls.Add(this.FromGroupBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.FromGroupBox.ResumeLayout(false);
            this.ToGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox FromGroupBox;
        private System.Windows.Forms.GroupBox ToGroupBox;
        private System.Windows.Forms.ListBox ToListBox;
        private System.Windows.Forms.ListBox FromListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DisplayConversionLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox MeasurementTextBox;
    }
}

