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
            this.CalculateButton.Location = new System.Drawing.Point(17, 204);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(110, 30);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(189, 204);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 257);
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
    }
}

