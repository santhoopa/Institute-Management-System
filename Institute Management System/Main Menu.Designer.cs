namespace Institute_Management_System
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMainMenuExit = new System.Windows.Forms.Button();
            this.btnLecturer = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.panel1.Location = new System.Drawing.Point(-1, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 44);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnMainMenuExit);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 44);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 419);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(-1, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(851, 407);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Institute_Management_System.Properties.Resources.icons8_school_filled_150;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(323, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 176);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMainMenuExit
            // 
            this.btnMainMenuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(46)))), ((int)(((byte)(0)))));
            this.btnMainMenuExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(101)))), ((int)(((byte)(109)))));
            this.btnMainMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenuExit.Image = global::Institute_Management_System.Properties.Resources.icons8_Delete_30px;
            this.btnMainMenuExit.Location = new System.Drawing.Point(811, 4);
            this.btnMainMenuExit.Name = "btnMainMenuExit";
            this.btnMainMenuExit.Size = new System.Drawing.Size(39, 37);
            this.btnMainMenuExit.TabIndex = 1;
            this.btnMainMenuExit.UseVisualStyleBackColor = false;
            this.btnMainMenuExit.Click += new System.EventHandler(this.btnMainMenuExit_Click);
            // 
            // btnLecturer
            // 
            this.btnLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnLecturer.FlatAppearance.BorderSize = 0;
            this.btnLecturer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btnLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturer.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnLecturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.btnLecturer.Image = global::Institute_Management_System.Properties.Resources.icons8_training_64_1_1;
            this.btnLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturer.Location = new System.Drawing.Point(568, 469);
            this.btnLecturer.Margin = new System.Windows.Forms.Padding(4);
            this.btnLecturer.Name = "btnLecturer";
            this.btnLecturer.Size = new System.Drawing.Size(285, 91);
            this.btnLecturer.TabIndex = 2;
            this.btnLecturer.Text = "        Lecturers";
            this.btnLecturer.UseVisualStyleBackColor = false;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.btnCourse.Image = global::Institute_Management_System.Properties.Resources.icons8_classroom_642;
            this.btnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourse.Location = new System.Drawing.Point(283, 469);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(286, 91);
            this.btnCourse.TabIndex = 1;
            this.btnCourse.Text = "    Classes";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 469);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(283, 91);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "      Students";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(853, 607);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLecturer);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnLecturer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMainMenuExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}