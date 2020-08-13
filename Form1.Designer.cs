namespace PlaylistPlayer
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
            this.Mp3Button = new System.Windows.Forms.Button();
            this.URLInserter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mp4Button = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.UFButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 27.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video/Music downloader";
            // 
            // Mp3Button
            // 
            this.Mp3Button.Location = new System.Drawing.Point(21, 138);
            this.Mp3Button.Name = "Mp3Button";
            this.Mp3Button.Size = new System.Drawing.Size(184, 51);
            this.Mp3Button.TabIndex = 1;
            this.Mp3Button.Text = "Download as MP3";
            this.Mp3Button.UseVisualStyleBackColor = true;
            this.Mp3Button.Click += new System.EventHandler(this.Mp3Button_Click);
            // 
            // URLInserter
            // 
            this.URLInserter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLInserter.Location = new System.Drawing.Point(21, 97);
            this.URLInserter.Name = "URLInserter";
            this.URLInserter.Size = new System.Drawing.Size(385, 22);
            this.URLInserter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert your song\'s url here!";
            // 
            // Mp4Button
            // 
            this.Mp4Button.Location = new System.Drawing.Point(21, 204);
            this.Mp4Button.Name = "Mp4Button";
            this.Mp4Button.Size = new System.Drawing.Size(184, 51);
            this.Mp4Button.TabIndex = 1;
            this.Mp4Button.Text = "Download as MP4";
            this.Mp4Button.UseVisualStyleBackColor = true;
            this.Mp4Button.Click += new System.EventHandler(this.Mp4Button_Click);
            // 
            // LogButton
            // 
            this.LogButton.Location = new System.Drawing.Point(21, 394);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(150, 44);
            this.LogButton.TabIndex = 1;
            this.LogButton.Text = "Change Log";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // UFButton
            // 
            this.UFButton.Location = new System.Drawing.Point(177, 394);
            this.UFButton.Name = "UFButton";
            this.UFButton.Size = new System.Drawing.Size(150, 44);
            this.UFButton.TabIndex = 1;
            this.UFButton.Text = "Upcoming features";
            this.UFButton.UseVisualStyleBackColor = true;
            this.UFButton.Click += new System.EventHandler(this.UFButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Download as MP4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.URLInserter);
            this.Controls.Add(this.UFButton);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mp4Button);
            this.Controls.Add(this.Mp3Button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mp3Button;
        private System.Windows.Forms.TextBox URLInserter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Mp4Button;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button UFButton;
        private System.Windows.Forms.Button button1;
    }
}

