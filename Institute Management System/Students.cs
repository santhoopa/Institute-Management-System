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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            pnlHome.Visible = true;
            pnlAddStudent.Visible = false;
            pnlUpdateStudent.Visible = false;
            pnlViewStudent.Visible = false;
            pnlDeleteStudent.Visible = false;
            
            string query = "select max(studentid) from student";
            DataTable dt = dbcon.GetData(query);
            int x = Convert.ToInt32(dt.Rows[0][0].ToString());
            x++;
            lblDisplayStuId_AddStudent.Text = x.ToString();

           
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            pnlColorBar.Height = btnAddStudent.Height;
            pnlColorBar.Top = btnAddStudent.Top;

              pnlAddStudent.Visible = true;
              pnlUpdateStudent.Visible = false;
              pnlViewStudent.Visible = false;
              pnlDeleteStudent.Visible = false;
              pnlHome.Visible = false;


            string query = "select max(studentid) from student";
              DataTable dt = dbcon.GetData(query);
              int x = Convert.ToInt32(dt.Rows[0][0].ToString());
              x++;
              lblDisplayStuId_AddStudent.Text = x.ToString();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            pnlColorBar.Height = btnViewStudent.Height;
            pnlColorBar.Top = btnViewStudent.Top;

            pnlAddStudent.Visible = false;
            pnlUpdateStudent.Visible = false;
            pnlViewStudent.Visible = true;
            pnlDeleteStudent.Visible = false;
            pnlHome.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMain main = new frmMain();
            main.Show();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            pnlColorBar.Height = btnUpdateStudent.Height;
            pnlColorBar.Top = btnUpdateStudent.Top;

            pnlAddStudent.Visible = false;
            pnlUpdateStudent.Visible = true;
            pnlViewStudent.Visible = false;
            pnlDeleteStudent.Visible = false;
            pnlHome.Visible = false;
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            pnlColorBar.Height = btnDeleteStudent.Height;
            pnlColorBar.Top = btnDeleteStudent.Top;

            pnlAddStudent.Visible = false;
            pnlUpdateStudent.Visible = false;
            pnlViewStudent.Visible = false;
            pnlDeleteStudent.Visible = true;
            pnlHome.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_AddStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_UpdateStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_AddStudent_Click(object sender, EventArgs e)
        {
            string query = "select max(guardian_id) from guardian";
            DataTable dt = dbcon.GetData(query);
            int x = Convert.ToInt32(dt.Rows[0][0].ToString());
            x++;
            lblDisplayStuId_AddStudent.Text = x.ToString();
            string dob = dtpDob_AddStudent.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(dob);
            int y=student.add_student(Convert.ToInt32(lblDisplayStuId_AddStudent.Text), txtName_AddStudent.Text, txtAddress_AddStudent.Text, Convert.ToInt32(txtContactNumber_AddStudent.Text),dob, cmbGender_AddStudent.Text, txtSchool_AddStudent.Text, cmbMedium_AddStudent.Text, "available", x,txtGuradianName_AddStudent.Text,Convert.ToInt32(txtGuardianContact_AddStudent.Text),txtGuardianRelationship_AddStudent.Text,txtGuradianaAddress_AddStudent.Text);
            if (y == 1)
                MessageBox.Show("Successfully Added");

            string query1 = "select max(studentid) from student";
            DataTable dt1 = dbcon.GetData(query1);
            int z = Convert.ToInt32(dt.Rows[0][0].ToString());
            z++;
            lblDisplayStuId_AddStudent.Text = z.ToString();

            

        }

        private void pnlAddStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbMedium_AddStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_AddStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_AddStudent_Click(object sender, EventArgs e)
        {
            txtName_AddStudent.Text = "";
            txtContactNumber_AddStudent.Text = "";
            cmbGender_AddStudent.ResetText();
            cmbMedium_AddStudent.ResetText();
            txtAddress_AddStudent.Text = "";
            txtSchool_AddStudent.Text = "";
            txtContactNumber_AddStudent.Text = "";
            txtGuradianName_AddStudent.Text = "";
            txtGuardianContact_AddStudent.Text= "";
            txtGuardianRelationship_AddStudent.Text = "";
            txtGuradianaAddress_AddStudent.Text = "";

            
        }

        private void btnSearchAll_ViewStudent_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = student.view_allStudents();
            dgvDisplayResults_ViewStudent.DataSource = dt;
        }

        private void btnSearchIndividual_ViewStudent_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(txtStudentID_ViewStudent.Text);
            DataTable dt = new DataTable();
            dt=student.view_IndividualStudent(studentId);
            dgvDisplayResults_ViewStudent.DataSource = dt;
        }

        private void btnClear_ViewStudent_Click(object sender, EventArgs e)
        {
            dgvDisplayResults_ViewStudent.DataSource = null;
        }

        private void btnSearchStudent_UpdateStudent_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(txtIdInput_UpdateStudent.Text);
            DataTable dt = new DataTable();
            dt = student.view_IndividualStudent(studentId);
            dgvDisplayResult_UpdateStudent.DataSource = dt;

            txtNewSchool_UpdateStudent.Text = dt.Rows[0][6].ToString();
            txtNewContact_UpdateStudent.Text= dt.Rows[0][3].ToString();
            txtNewAddress_UpdateStudent.Text= dt.Rows[0][2].ToString();
        }

        private void btnUpdate_UpdateStudent_Click(object sender, EventArgs e)
        {
            student.update_Student(txtNewAddress_UpdateStudent.Text, Convert.ToInt32(txtNewContact_UpdateStudent.Text), txtNewSchool_UpdateStudent.Text, Convert.ToInt32(txtIdInput_UpdateStudent.Text));
            txtIdInput_UpdateStudent.Text = "";
            txtNewAddress_UpdateStudent.Text = "";
            txtNewContact_UpdateStudent.Text = "";
            txtNewSchool_UpdateStudent.Text = "";
            dgvDisplayResult_UpdateStudent.DataSource = null;
        }
        string RemoveName;
        int RemoveID;
        private void btnSearch_RemoveStudent_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(txtStuID_RemoveStudent.Text);
            DataTable dt = new DataTable();
            dt = student.view_IndividualStudent(studentId);
            dgvViewResult_RemoveStudent.DataSource = dt;
            RemoveName=dt.Rows[0][1].ToString();
            RemoveID= Convert.ToInt32(dt.Rows[0][0].ToString());

        }

        private void btnRemove_RemoveStudent_Click(object sender, EventArgs e)
        {
            student.remove_Student(RemoveID,RemoveName);
            dgvViewResult_RemoveStudent.DataSource = null;
            RemoveName = null;
            RemoveID = 0;
        }

        private void btnStuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
