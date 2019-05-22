namespace Institute_Management_System
{
    partial class frmAddNewStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStuaddress = new System.Windows.Forms.Label();
            this.lblStuschool = new System.Windows.Forms.Label();
            this.lblStuname = new System.Windows.Forms.Label();
            this.txtStufName = new System.Windows.Forms.TextBox();
            this.txtStuSchool = new System.Windows.Forms.TextBox();
            this.txtStuAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtStulName = new System.Windows.Forms.TextBox();
            this.txtStumName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Student";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStumName);
            this.groupBox1.Controls.Add(this.txtStulName);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStuAddress);
            this.groupBox1.Controls.Add(this.txtStuSchool);
            this.groupBox1.Controls.Add(this.txtStufName);
            this.groupBox1.Controls.Add(this.lblStuaddress);
            this.groupBox1.Controls.Add(this.lblStuschool);
            this.groupBox1.Controls.Add(this.lblStuname);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(820, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblStuaddress
            // 
            this.lblStuaddress.AutoSize = true;
            this.lblStuaddress.Location = new System.Drawing.Point(56, 135);
            this.lblStuaddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStuaddress.Name = "lblStuaddress";
            this.lblStuaddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStuaddress.Size = new System.Drawing.Size(77, 21);
            this.lblStuaddress.TabIndex = 2;
            this.lblStuaddress.Text = "Address";
            // 
            // lblStuschool
            // 
            this.lblStuschool.AutoSize = true;
            this.lblStuschool.Location = new System.Drawing.Point(56, 94);
            this.lblStuschool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStuschool.Name = "lblStuschool";
            this.lblStuschool.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStuschool.Size = new System.Drawing.Size(64, 21);
            this.lblStuschool.TabIndex = 1;
            this.lblStuschool.Text = "School";
            // 
            // lblStuname
            // 
            this.lblStuname.AutoSize = true;
            this.lblStuname.Location = new System.Drawing.Point(56, 60);
            this.lblStuname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStuname.Name = "lblStuname";
            this.lblStuname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStuname.Size = new System.Drawing.Size(66, 21);
            this.lblStuname.TabIndex = 0;
            this.lblStuname.Text = "Name ";
            // 
            // txtStufName
            // 
            this.txtStufName.Location = new System.Drawing.Point(276, 57);
            this.txtStufName.Name = "txtStufName";
            this.txtStufName.Size = new System.Drawing.Size(160, 27);
            this.txtStufName.TabIndex = 3;
            // 
            // txtStuSchool
            // 
            this.txtStuSchool.Location = new System.Drawing.Point(276, 91);
            this.txtStuSchool.Name = "txtStuSchool";
            this.txtStuSchool.Size = new System.Drawing.Size(255, 27);
            this.txtStuSchool.TabIndex = 4;
            // 
            // txtStuAddress
            // 
            this.txtStuAddress.Location = new System.Drawing.Point(276, 132);
            this.txtStuAddress.Multiline = true;
            this.txtStuAddress.Name = "txtStuAddress";
            this.txtStuAddress.Size = new System.Drawing.Size(255, 85);
            this.txtStuAddress.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 27);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 27);
            this.textBox2.TabIndex = 9;
            // 
            // txtStulName
            // 
            this.txtStulName.Location = new System.Drawing.Point(626, 57);
            this.txtStulName.Name = "txtStulName";
            this.txtStulName.Size = new System.Drawing.Size(160, 27);
            this.txtStulName.TabIndex = 10;
            // 
            // txtStumName
            // 
            this.txtStumName.Location = new System.Drawing.Point(451, 57);
            this.txtStumName.Name = "txtStumName";
            this.txtStumName.Size = new System.Drawing.Size(160, 27);
            this.txtStumName.TabIndex = 11;
            // 
            // frmAddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 768);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddNewStudent";
            this.Text = "AddNewStudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStuaddress;
        private System.Windows.Forms.Label lblStuschool;
        private System.Windows.Forms.Label lblStuname;
        private System.Windows.Forms.TextBox txtStuAddress;
        private System.Windows.Forms.TextBox txtStuSchool;
        private System.Windows.Forms.TextBox txtStufName;
        private System.Windows.Forms.TextBox txtStumName;
        private System.Windows.Forms.TextBox txtStulName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}