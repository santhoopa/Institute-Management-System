using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute_Management_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent Student = new frmStudent();
            Student.Show();
            this.Dispose();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            frmClass Class = new frmClass();
            Class.Show();
            this.Dispose();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            frmLecturer lec = new frmLecturer();
            lec.Show();
            this.Dispose();
        }

        private void btnMainMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
