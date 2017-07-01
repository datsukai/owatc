namespace Dice_Simulator
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
            this.FIRST_PictureBox = new System.Windows.Forms.PictureBox();
            this.SECOND_PictureBox = new System.Windows.Forms.PictureBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FIRST_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SECOND_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FIRST_PictureBox
            // 
            this.FIRST_PictureBox.Image = global::Dice_Simulator.Properties.Resources.Die1;
            this.FIRST_PictureBox.Location = new System.Drawing.Point(54, 24);
            this.FIRST_PictureBox.Name = "FIRST_PictureBox";
            this.FIRST_PictureBox.Size = new System.Drawing.Size(107, 109);
            this.FIRST_PictureBox.TabIndex = 0;
            this.FIRST_PictureBox.TabStop = false;
            // 
            // SECOND_PictureBox
            // 
            this.SECOND_PictureBox.Image = global::Dice_Simulator.Properties.Resources.Die2;
            this.SECOND_PictureBox.Location = new System.Drawing.Point(211, 24);
            this.SECOND_PictureBox.Name = "SECOND_PictureBox";
            this.SECOND_PictureBox.Size = new System.Drawing.Size(104, 109);
            this.SECOND_PictureBox.TabIndex = 1;
            this.SECOND_PictureBox.TabStop = false;
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(57, 214);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(111, 35);
            this.RollButton.TabIndex = 2;
            this.RollButton.Text = "Roll Dice";
            this.RollButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(204, 214);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(111, 35);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dice_Simulator.Properties.Resources.Die2;
            this.pictureBox1.Location = new System.Drawing.Point(57, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 109);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dice_Simulator.Properties.Resources.Die1;
            this.pictureBox2.Location = new System.Drawing.Point(211, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 109);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 272);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.SECOND_PictureBox);
            this.Controls.Add(this.FIRST_PictureBox);
            this.Name = "Form1";
            this.Text = "Dice Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.FIRST_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SECOND_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FIRST_PictureBox;
        private System.Windows.Forms.PictureBox SECOND_PictureBox;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

