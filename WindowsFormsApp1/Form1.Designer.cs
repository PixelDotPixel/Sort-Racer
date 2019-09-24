namespace WindowsFormsApp1
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
            this.userRacer = new System.Windows.Forms.ComboBox();
            this.cpuRacer1 = new System.Windows.Forms.ComboBox();
            this.cpuRacer2 = new System.Windows.Forms.ComboBox();
            this.cpuTrack2 = new System.Windows.Forms.ProgressBar();
            this.cpuTrack1 = new System.Windows.Forms.ProgressBar();
            this.userTrack = new System.Windows.Forms.ProgressBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblTrack = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userRacer
            // 
            this.userRacer.FormattingEnabled = true;
            this.userRacer.Location = new System.Drawing.Point(34, 66);
            this.userRacer.Name = "userRacer";
            this.userRacer.Size = new System.Drawing.Size(121, 21);
            this.userRacer.TabIndex = 0;
            // 
            // cpuRacer1
            // 
            this.cpuRacer1.FormattingEnabled = true;
            this.cpuRacer1.Location = new System.Drawing.Point(34, 110);
            this.cpuRacer1.Name = "cpuRacer1";
            this.cpuRacer1.Size = new System.Drawing.Size(121, 21);
            this.cpuRacer1.TabIndex = 1;
            // 
            // cpuRacer2
            // 
            this.cpuRacer2.FormattingEnabled = true;
            this.cpuRacer2.Location = new System.Drawing.Point(34, 154);
            this.cpuRacer2.Name = "cpuRacer2";
            this.cpuRacer2.Size = new System.Drawing.Size(121, 21);
            this.cpuRacer2.TabIndex = 2;
            // 
            // cpuTrack2
            // 
            this.cpuTrack2.Location = new System.Drawing.Point(166, 154);
            this.cpuTrack2.Name = "cpuTrack2";
            this.cpuTrack2.Size = new System.Drawing.Size(586, 21);
            this.cpuTrack2.TabIndex = 5;
            // 
            // cpuTrack1
            // 
            this.cpuTrack1.Location = new System.Drawing.Point(166, 110);
            this.cpuTrack1.Name = "cpuTrack1";
            this.cpuTrack1.Size = new System.Drawing.Size(586, 21);
            this.cpuTrack1.TabIndex = 6;
            // 
            // userTrack
            // 
            this.userTrack.Location = new System.Drawing.Point(166, 66);
            this.userTrack.Name = "userTrack";
            this.userTrack.Size = new System.Drawing.Size(586, 21);
            this.userTrack.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 196);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(44, 219);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(44, 242);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(31, 180);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(38, 13);
            this.lblTrack.TabIndex = 11;
            this.lblTrack.Text = "Track:";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LawnGreen;
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(235, 211);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(340, 29);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start Race";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Firebrick;
            this.restartButton.Location = new System.Drawing.Point(581, 211);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(134, 29);
            this.restartButton.TabIndex = 13;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.userTrack);
            this.Controls.Add(this.cpuTrack1);
            this.Controls.Add(this.cpuTrack2);
            this.Controls.Add(this.cpuRacer2);
            this.Controls.Add(this.cpuRacer1);
            this.Controls.Add(this.userRacer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userRacer;
        private System.Windows.Forms.ComboBox cpuRacer1;
        private System.Windows.Forms.ComboBox cpuRacer2;
        private System.Windows.Forms.ProgressBar cpuTrack2;
        private System.Windows.Forms.ProgressBar cpuTrack1;
        private System.Windows.Forms.ProgressBar userTrack;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button restartButton;
    }
}

