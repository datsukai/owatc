namespace Calories_from_Fat_and_Carbs
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
            this.CarbohydrateTextbox = new System.Windows.Forms.TextBox();
            this.FatTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DisplayFatLabel = new System.Windows.Forms.Label();
            this.displayCarbsLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Fat Grams Consumed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Carbohydrate Grams Consumed:";
            // 
            // CarbohydrateTextbox
            // 
            this.CarbohydrateTextbox.Location = new System.Drawing.Point(243, 12);
            this.CarbohydrateTextbox.Name = "CarbohydrateTextbox";
            this.CarbohydrateTextbox.Size = new System.Drawing.Size(87, 20);
            this.CarbohydrateTextbox.TabIndex = 2;
            // 
            // FatTextBox
            // 
            this.FatTextBox.Location = new System.Drawing.Point(243, 45);
            this.FatTextBox.Name = "FatTextBox";
            this.FatTextBox.Size = new System.Drawing.Size(87, 20);
            this.FatTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calories from Fat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calories from Carbs:";
            // 
            // DisplayFatLabel
            // 
            this.DisplayFatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayFatLabel.Location = new System.Drawing.Point(242, 85);
            this.DisplayFatLabel.Name = "DisplayFatLabel";
            this.DisplayFatLabel.Size = new System.Drawing.Size(88, 23);
            this.DisplayFatLabel.TabIndex = 6;
            // 
            // displayCarbsLabel
            // 
            this.displayCarbsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayCarbsLabel.Location = new System.Drawing.Point(242, 119);
            this.displayCarbsLabel.Name = "displayCarbsLabel";
            this.displayCarbsLabel.Size = new System.Drawing.Size(88, 23);
            this.displayCarbsLabel.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(58, 180);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(115, 32);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(215, 180);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(115, 32);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.displayCarbsLabel);
            this.Controls.Add(this.DisplayFatLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FatTextBox);
            this.Controls.Add(this.CarbohydrateTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calories from Fat and Carbs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CarbohydrateTextbox;
        private System.Windows.Forms.TextBox FatTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DisplayFatLabel;
        private System.Windows.Forms.Label displayCarbsLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

