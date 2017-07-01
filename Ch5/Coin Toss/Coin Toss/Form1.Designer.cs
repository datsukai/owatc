namespace Coin_Toss
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
            this.TossButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.TailsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TossButton
            // 
            this.TossButton.Location = new System.Drawing.Point(30, 247);
            this.TossButton.Name = "TossButton";
            this.TossButton.Size = new System.Drawing.Size(97, 35);
            this.TossButton.TabIndex = 0;
            this.TossButton.Text = "Toss";
            this.TossButton.UseVisualStyleBackColor = true;
            this.TossButton.Click += new System.EventHandler(this.TossButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(167, 247);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 35);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = global::Coin_Toss.Properties.Resources.Heads1;
            this.headsPictureBox.Location = new System.Drawing.Point(41, 25);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(209, 205);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headsPictureBox.TabIndex = 2;
            this.headsPictureBox.TabStop = false;
            // 
            // TailsPictureBox
            // 
            this.TailsPictureBox.Image = global::Coin_Toss.Properties.Resources.Tails1;
            this.TailsPictureBox.Location = new System.Drawing.Point(41, 25);
            this.TailsPictureBox.Name = "TailsPictureBox";
            this.TailsPictureBox.Size = new System.Drawing.Size(209, 205);
            this.TailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TailsPictureBox.TabIndex = 3;
            this.TailsPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 301);
            this.Controls.Add(this.TailsPictureBox);
            this.Controls.Add(this.headsPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TossButton);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TailsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TossButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox TailsPictureBox;
    }
}

