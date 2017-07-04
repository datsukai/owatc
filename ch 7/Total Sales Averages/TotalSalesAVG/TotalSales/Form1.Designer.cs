namespace TotalSales
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
            this.SalesListBox = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlainLabel = new System.Windows.Forms.Label();
            this.DisplayTotalLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HighestLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LowestLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalesListBox
            // 
            this.SalesListBox.FormattingEnabled = true;
            this.SalesListBox.Location = new System.Drawing.Point(17, 18);
            this.SalesListBox.Name = "SalesListBox";
            this.SalesListBox.Size = new System.Drawing.Size(282, 121);
            this.SalesListBox.TabIndex = 0;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(17, 283);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(110, 30);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(189, 283);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(110, 30);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PlainLabel
            // 
            this.PlainLabel.AutoSize = true;
            this.PlainLabel.Location = new System.Drawing.Point(34, 161);
            this.PlainLabel.Name = "PlainLabel";
            this.PlainLabel.Size = new System.Drawing.Size(73, 13);
            this.PlainLabel.TabIndex = 4;
            this.PlainLabel.Text = "Total Amount:";
            // 
            // DisplayTotalLabel
            // 
            this.DisplayTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayTotalLabel.Location = new System.Drawing.Point(113, 151);
            this.DisplayTotalLabel.Name = "DisplayTotalLabel";
            this.DisplayTotalLabel.Size = new System.Drawing.Size(97, 24);
            this.DisplayTotalLabel.TabIndex = 5;
            // 
            // AverageLabel
            // 
            this.AverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AverageLabel.Location = new System.Drawing.Point(113, 181);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(97, 24);
            this.AverageLabel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Average:";
            // 
            // HighestLabel
            // 
            this.HighestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighestLabel.Location = new System.Drawing.Point(113, 214);
            this.HighestLabel.Name = "HighestLabel";
            this.HighestLabel.Size = new System.Drawing.Size(97, 24);
            this.HighestLabel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Highest Value:";
            // 
            // LowestLabel
            // 
            this.LowestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowestLabel.Location = new System.Drawing.Point(113, 241);
            this.LowestLabel.Name = "LowestLabel";
            this.LowestLabel.Size = new System.Drawing.Size(97, 24);
            this.LowestLabel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lowest Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 325);
            this.Controls.Add(this.LowestLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HighestLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisplayTotalLabel);
            this.Controls.Add(this.PlainLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesListBox);
            this.Name = "Form1";
            this.Text = "Total Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SalesListBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PlainLabel;
        private System.Windows.Forms.Label DisplayTotalLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HighestLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LowestLabel;
        private System.Windows.Forms.Label label6;
    }
}

