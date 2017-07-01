namespace Random_Number_File_Reader
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
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayTotalNumLabel = new System.Windows.Forms.Label();
            this.displayRandNumLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReadButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(49, 57);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(272, 121);
            this.DisplayListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total of the numbers:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of random numbers read from the file:";
            // 
            // displayTotalNumLabel
            // 
            this.displayTotalNumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayTotalNumLabel.Location = new System.Drawing.Point(274, 181);
            this.displayTotalNumLabel.Name = "displayTotalNumLabel";
            this.displayTotalNumLabel.Size = new System.Drawing.Size(66, 26);
            this.displayTotalNumLabel.TabIndex = 3;
            this.displayTotalNumLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.displayTotalNumLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // displayRandNumLabel
            // 
            this.displayRandNumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayRandNumLabel.Location = new System.Drawing.Point(274, 223);
            this.displayRandNumLabel.Name = "displayRandNumLabel";
            this.displayRandNumLabel.Size = new System.Drawing.Size(66, 23);
            this.displayRandNumLabel.TabIndex = 4;
            this.displayRandNumLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Please select File to display numbers from list. ";
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(49, 271);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(99, 29);
            this.ReadButton.TabIndex = 6;
            this.ReadButton.Text = "Read File";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(194, 271);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(99, 29);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 316);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.displayRandNumLabel);
            this.Controls.Add(this.displayTotalNumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayListBox);
            this.Name = "Form1";
            this.Text = "Random Number File Writer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label displayTotalNumLabel;
        private System.Windows.Forms.Label displayRandNumLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

