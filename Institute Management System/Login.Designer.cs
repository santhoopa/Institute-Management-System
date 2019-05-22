namespace Institute_Management_System
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlLoginRight = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlTopLogin = new System.Windows.Forms.Panel();
            this.pnlLoginBottom = new System.Windows.Forms.Panel();
            this.pnlLoginLeft = new System.Windows.Forms.Panel();
            this.lblIntitute = new System.Windows.Forms.Label();
            this.lblOnitka = new System.Windows.Forms.Label();
            this.picLoginPic = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.picLoginImg = new System.Windows.Forms.PictureBox();
            this.pnlLoginRight.SuspendLayout();
            this.pnlTopLogin.SuspendLayout();
            this.pnlLoginLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.lblUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUsername.Location = new System.Drawing.Point(77, 224);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(133, 30);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(77, 322);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 30);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // pnlLoginRight
            // 
            this.pnlLoginRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.pnlLoginRight.Controls.Add(this.picLoginImg);
            this.pnlLoginRight.Controls.Add(this.btnLogin);
            this.pnlLoginRight.Controls.Add(this.textBox2);
            this.pnlLoginRight.Controls.Add(this.textBox1);
            this.pnlLoginRight.Controls.Add(this.lblPassword);
            this.pnlLoginRight.Controls.Add(this.lblUsername);
            this.pnlLoginRight.Location = new System.Drawing.Point(406, 43);
            this.pnlLoginRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLoginRight.Name = "pnlLoginRight";
            this.pnlLoginRight.Size = new System.Drawing.Size(427, 559);
            this.pnlLoginRight.TabIndex = 2;
            this.pnlLoginRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeft_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(77, 417);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(273, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(77, 356);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 33);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Outlook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox1.Location = new System.Drawing.Point(77, 261);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 33);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlTopLogin
            // 
            this.pnlTopLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.pnlTopLogin.Controls.Add(this.btnExit);
            this.pnlTopLogin.Location = new System.Drawing.Point(407, 0);
            this.pnlTopLogin.Name = "pnlTopLogin";
            this.pnlTopLogin.Size = new System.Drawing.Size(427, 43);
            this.pnlTopLogin.TabIndex = 4;
            // 
            // pnlLoginBottom
            // 
            this.pnlLoginBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.pnlLoginBottom.Location = new System.Drawing.Point(407, 603);
            this.pnlLoginBottom.Name = "pnlLoginBottom";
            this.pnlLoginBottom.Size = new System.Drawing.Size(427, 43);
            this.pnlLoginBottom.TabIndex = 5;
            // 
            // pnlLoginLeft
            // 
            this.pnlLoginLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.pnlLoginLeft.Controls.Add(this.lblIntitute);
            this.pnlLoginLeft.Controls.Add(this.lblOnitka);
            this.pnlLoginLeft.Controls.Add(this.picLoginPic);
            this.pnlLoginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoginLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginLeft.Name = "pnlLoginLeft";
            this.pnlLoginLeft.Size = new System.Drawing.Size(410, 647);
            this.pnlLoginLeft.TabIndex = 6;
            // 
            // lblIntitute
            // 
            this.lblIntitute.AutoSize = true;
            this.lblIntitute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.lblIntitute.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntitute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.lblIntitute.Location = new System.Drawing.Point(102, 382);
            this.lblIntitute.Name = "lblIntitute";
            this.lblIntitute.Size = new System.Drawing.Size(189, 23);
            this.lblIntitute.TabIndex = 2;
            this.lblIntitute.Text = "Education Institute";
            this.lblIntitute.Click += new System.EventHandler(this.lblIntitute_Click);
            // 
            // lblOnitka
            // 
            this.lblOnitka.AutoSize = true;
            this.lblOnitka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.lblOnitka.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnitka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.lblOnitka.Location = new System.Drawing.Point(139, 337);
            this.lblOnitka.Name = "lblOnitka";
            this.lblOnitka.Size = new System.Drawing.Size(106, 34);
            this.lblOnitka.TabIndex = 1;
            this.lblOnitka.Text = "Onitka";
            // 
            // picLoginPic
            // 
            this.picLoginPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.picLoginPic.Image = global::Institute_Management_System.Properties.Resources.icons8_school_filled_100_1_;
            this.picLoginPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLoginPic.InitialImage")));
            this.picLoginPic.Location = new System.Drawing.Point(125, 205);
            this.picLoginPic.Name = "picLoginPic";
            this.picLoginPic.Size = new System.Drawing.Size(146, 129);
            this.picLoginPic.TabIndex = 0;
            this.picLoginPic.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(46)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Institute_Management_System.Properties.Resources.icons8_Delete_30px;
            this.btnExit.Location = new System.Drawing.Point(385, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 37);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLoginImg
            // 
            this.picLoginImg.Image = global::Institute_Management_System.Properties.Resources.icons8_name_filled_100_1_;
            this.picLoginImg.Location = new System.Drawing.Point(153, 79);
            this.picLoginImg.Name = "picLoginImg";
            this.picLoginImg.Size = new System.Drawing.Size(123, 124);
            this.picLoginImg.TabIndex = 5;
            this.picLoginImg.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(834, 647);
            this.Controls.Add(this.pnlLoginLeft);
            this.Controls.Add(this.pnlLoginBottom);
            this.Controls.Add(this.pnlTopLogin);
            this.Controls.Add(this.pnlLoginRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLoginRight.ResumeLayout(false);
            this.pnlLoginRight.PerformLayout();
            this.pnlTopLogin.ResumeLayout(false);
            this.pnlLoginLeft.ResumeLayout(false);
            this.pnlLoginLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlLoginRight;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlTopLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlLoginBottom;
        private System.Windows.Forms.Panel pnlLoginLeft;
        private System.Windows.Forms.PictureBox picLoginPic;
        private System.Windows.Forms.Label lblIntitute;
        private System.Windows.Forms.Label lblOnitka;
        private System.Windows.Forms.PictureBox picLoginImg;
    }
}

