namespace earlyTest
{
    partial class mainMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teacherBTN = new System.Windows.Forms.Button();
            this.highscoreBTN = new System.Windows.Forms.Button();
            this.quitBTN = new System.Windows.Forms.Button();
            this.startGameBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::earlyTest.Properties.Resources.titlle2;
            this.pictureBox1.Location = new System.Drawing.Point(296, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // teacherBTN
            // 
            this.teacherBTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherBTN.Location = new System.Drawing.Point(218, 342);
            this.teacherBTN.Name = "teacherBTN";
            this.teacherBTN.Size = new System.Drawing.Size(403, 62);
            this.teacherBTN.TabIndex = 1;
            this.teacherBTN.Text = "Questions";
            this.teacherBTN.UseVisualStyleBackColor = true;
            this.teacherBTN.Visible = false;
            this.teacherBTN.Click += new System.EventHandler(this.teacherBTN_Click);
            // 
            // highscoreBTN
            // 
            this.highscoreBTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreBTN.Location = new System.Drawing.Point(218, 274);
            this.highscoreBTN.Name = "highscoreBTN";
            this.highscoreBTN.Size = new System.Drawing.Size(403, 62);
            this.highscoreBTN.TabIndex = 2;
            this.highscoreBTN.Text = "Highscore";
            this.highscoreBTN.UseVisualStyleBackColor = true;
            this.highscoreBTN.Click += new System.EventHandler(this.highscoreBTN_Click);
            // 
            // quitBTN
            // 
            this.quitBTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBTN.Location = new System.Drawing.Point(218, 342);
            this.quitBTN.Name = "quitBTN";
            this.quitBTN.Size = new System.Drawing.Size(403, 62);
            this.quitBTN.TabIndex = 3;
            this.quitBTN.Text = "Exit";
            this.quitBTN.UseVisualStyleBackColor = true;
            this.quitBTN.Click += new System.EventHandler(this.quitBTN_Click);
            // 
            // startGameBTN
            // 
            this.startGameBTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBTN.Location = new System.Drawing.Point(218, 206);
            this.startGameBTN.Name = "startGameBTN";
            this.startGameBTN.Size = new System.Drawing.Size(403, 62);
            this.startGameBTN.TabIndex = 4;
            this.startGameBTN.Text = "Start game";
            this.startGameBTN.UseVisualStyleBackColor = true;
            this.startGameBTN.Click += new System.EventHandler(this.startGameBTN_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::earlyTest.Properties.Resources.bgtest3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 556);
            this.Controls.Add(this.startGameBTN);
            this.Controls.Add(this.quitBTN);
            this.Controls.Add(this.highscoreBTN);
            this.Controls.Add(this.teacherBTN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button teacherBTN;
        private System.Windows.Forms.Button highscoreBTN;
        private System.Windows.Forms.Button quitBTN;
        private System.Windows.Forms.Button startGameBTN;
    }
}