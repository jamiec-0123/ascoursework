namespace earlyTest
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
            this.loginHelpBTN = new System.Windows.Forms.Button();
            this.passwordHelpBTN = new System.Windows.Forms.Button();
            this.loginBTN = new System.Windows.Forms.Button();
            this.signUpBTN = new System.Windows.Forms.Button();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.helpLBL = new System.Windows.Forms.Label();
            this.usernametTXT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginPCT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPCT)).BeginInit();
            this.SuspendLayout();
            // 
            // loginHelpBTN
            // 
            this.loginHelpBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHelpBTN.Location = new System.Drawing.Point(256, 154);
            this.loginHelpBTN.Name = "loginHelpBTN";
            this.loginHelpBTN.Size = new System.Drawing.Size(40, 37);
            this.loginHelpBTN.TabIndex = 0;
            this.loginHelpBTN.Text = "?";
            this.loginHelpBTN.UseVisualStyleBackColor = true;
            this.loginHelpBTN.Click += new System.EventHandler(this.loginHelpBTN_Click);
            // 
            // passwordHelpBTN
            // 
            this.passwordHelpBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordHelpBTN.Location = new System.Drawing.Point(256, 277);
            this.passwordHelpBTN.Name = "passwordHelpBTN";
            this.passwordHelpBTN.Size = new System.Drawing.Size(40, 37);
            this.passwordHelpBTN.TabIndex = 1;
            this.passwordHelpBTN.Text = "?";
            this.passwordHelpBTN.UseVisualStyleBackColor = true;
            this.passwordHelpBTN.Click += new System.EventHandler(this.passwordHelpBTN_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(12, 326);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(108, 35);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // signUpBTN
            // 
            this.signUpBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBTN.Location = new System.Drawing.Point(126, 326);
            this.signUpBTN.Name = "signUpBTN";
            this.signUpBTN.Size = new System.Drawing.Size(113, 35);
            this.signUpBTN.TabIndex = 3;
            this.signUpBTN.Text = "Sign up";
            this.signUpBTN.UseVisualStyleBackColor = true;
            // 
            // passwordTXT
            // 
            this.passwordTXT.AcceptsReturn = true;
            this.passwordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTXT.Location = new System.Drawing.Point(12, 280);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(227, 30);
            this.passwordTXT.TabIndex = 4;
            this.passwordTXT.UseSystemPasswordChar = true;
            // 
            // helpLBL
            // 
            this.helpLBL.BackColor = System.Drawing.Color.Transparent;
            this.helpLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLBL.ForeColor = System.Drawing.Color.SeaShell;
            this.helpLBL.Location = new System.Drawing.Point(432, 85);
            this.helpLBL.Name = "helpLBL";
            this.helpLBL.Size = new System.Drawing.Size(356, 356);
            this.helpLBL.TabIndex = 5;
            this.helpLBL.Text = "Click any of the \"?\" buttons to veiw extra help.";
            // 
            // usernametTXT
            // 
            this.usernametTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametTXT.Location = new System.Drawing.Point(12, 157);
            this.usernametTXT.Name = "usernametTXT";
            this.usernametTXT.Size = new System.Drawing.Size(227, 30);
            this.usernametTXT.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::earlyTest.Properties.Resources.username;
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::earlyTest.Properties.Resources.HelpAndTips;
            this.pictureBox3.Location = new System.Drawing.Point(432, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(356, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::earlyTest.Properties.Resources.username2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // loginPCT
            // 
            this.loginPCT.BackColor = System.Drawing.Color.Transparent;
            this.loginPCT.Image = global::earlyTest.Properties.Resources.test_size1;
            this.loginPCT.Location = new System.Drawing.Point(12, 12);
            this.loginPCT.Name = "loginPCT";
            this.loginPCT.Size = new System.Drawing.Size(227, 54);
            this.loginPCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPCT.TabIndex = 6;
            this.loginPCT.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::earlyTest.Properties.Resources.bgtest2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usernametTXT);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.loginPCT);
            this.Controls.Add(this.helpLBL);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.signUpBTN);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passwordHelpBTN);
            this.Controls.Add(this.loginHelpBTN);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginHelpBTN;
        private System.Windows.Forms.Button passwordHelpBTN;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Button signUpBTN;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label helpLBL;
        private System.Windows.Forms.PictureBox loginPCT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox usernametTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

