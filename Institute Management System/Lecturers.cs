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
    public partial class frmLecturer : Form
    {
        public frmLecturer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMain main = new frmMain();
            main.Show();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {

            pnlLecTop.Visible = true;
            pnlLecBottom.Visible = true;
            pnlColorBar.Height = btnAddLecturer.Height;
            pnlColorBar.Top = btnAddLecturer.Top;



            pnlHome.Visible = false;
            pnlAddLecturer.Visible = true;
            pnlViewLecturer.Visible = false;
            pnlUpdateLecturer.Visible = false;
            pnlRemoveLecturer.Visible = false;
            String query = "select max(lecturerID) from lecturer";
            DataTable dt = dbcon.GetData(query);
            int x = Convert.ToInt32(dt.Rows[0][0].ToString());
            x++;
            lblDisplayLecId_AddLecturer.Text = x.ToString();
        }

        private void Lecturers_Load(object sender, EventArgs e)
        {
            pnlHome.Visible = true;
            pnlAddLecturer.Visible = false;
            pnlViewLecturer.Visible = false;
            pnlUpdateLecturer.Visible = false;
            pnlRemoveLecturer.Visible = false;

            /* String query = "select max(lecturerID) from lecturer";
             DataTable dt = dbcon.GetData(query);
             int x = Convert.ToInt32(dt.Rows[0][0].ToString());
             x++;
             lblDisplayLecId_AddLecturer.Text = x.ToString();*/


            Point ptTop = pnlLecTop.PointToScreen(new Point(0, 0));
            pnlLecTop.Parent = this;
            pnlLecTop.Location = this.PointToClient(ptTop);
            pnlLecTop.BringToFront();

            Point ptBottom = pnlLecBottom.PointToScreen(new Point(0, 0));
            pnlLecBottom.Parent = this;
            pnlLecBottom.Location = this.PointToClient(ptBottom);
            pnlLecBottom.BringToFront();
        }

        private void btnViewLecturer_Click(object sender, EventArgs e)
        {
            pnlLecTop.Visible = true;
            pnlLecBottom.Visible = true;

            pnlColorBar.Height = btnViewLecturer.Height;
            pnlColorBar.Top = btnViewLecturer.Top;

            pnlHome.Visible = false;
            pnlAddLecturer.Visible = false;
            pnlViewLecturer.Visible = true;
            pnlUpdateLecturer.Visible = false;
            pnlRemoveLecturer.Visible = false;
        }

        private void btnUpdateLecturer_Click(object sender, EventArgs e)
        {
            pnlLecTop.Visible = true;
            pnlLecBottom.Visible = true;

            pnlColorBar.Height = btnUpdateLecturer.Height;
            pnlColorBar.Top = btnUpdateLecturer.Top;

            pnlHome.Visible = false;
            pnlAddLecturer.Visible = false;
            pnlViewLecturer.Visible = false;
            pnlUpdateLecturer.Visible = true;
            pnlRemoveLecturer.Visible = false;
        }

        private void btnDeleteLecturer_Click(object sender, EventArgs e)
        {
            pnlLecTop.Visible = true;
            pnlLecBottom.Visible = true;

            pnlColorBar.Height = btnDeleteLecturer.Height;
            pnlColorBar.Top = btnDeleteLecturer.Top;

            pnlHome.Visible = false;
            pnlAddLecturer.Visible = false;
            pnlViewLecturer.Visible = false;
            pnlUpdateLecturer.Visible = false;
            pnlRemoveLecturer.Visible = true;
        }

        private void grpLecturerInfo_AddLecturer_Enter(object sender, EventArgs e)
        {

        }

        private void pnlAddLecturer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddLecturer_AddLecturer_Click(object sender, EventArgs e)
        {
            string dob = dtpDob_AddLecturer.Value.ToString("yyyy-MM-dd");
            if (txtSub1_AddLecturer.Text == "")
                txtSub1_AddLecturer.Text = "NULL";
            if (txtSub2_AddLecturer.Text == "")
                txtSub2_AddLecturer.Text = "NULL";
            if (txtSub3_AddLecturer.Text == "")
                txtSub3_AddLecturer.Text = "NULL";

            int x = lecturer.add_lecturer(Convert.ToInt32(lblDisplayLecId_AddLecturer.Text),txtName_AddLecturer.Text,txtNIC_AddLecturer.Text,txtAddress_AddLecturer.Text,Convert.ToInt32(txtContactNumber_AddLecturer.Text),dob,cmbGender_AddLecturer.Text,cmbMedium_AddLecturer.Text,txtSub1_AddLecturer.Text,txtSub2_AddLecturer.Text,txtSub3_AddLecturer.Text);
            if (x == 1)
                MessageBox.Show("Successfully Added");

            string query = "select max(lecturerID) from lecturer";
            DataTable dt = dbcon.GetData(query);
            int y = Convert.ToInt32(dt.Rows[0][0].ToString());
            y++;
            lblDisplayLecId_AddLecturer.Text = y.ToString();

            txtName_AddLecturer.Text = "";
            txtNIC_AddLecturer.Text = "";
            txtContactNumber_AddLecturer.Text = "";
            txtAddress_AddLecturer.Text = "";
            txtSub1_AddLecturer.Text = "";
            txtSub2_AddLecturer.Text = "";
            txtSub3_AddLecturer.Text = "";
            cmbGender_AddLecturer.ResetText();
            cmbMedium_AddLecturer.ResetText();
            dtpDob_AddLecturer.Value = DateTime.Today;
        }

        private void btnClear_AddLecturer_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchAll_ViewLecturer_Click(object sender, EventArgs e)
        {
            dgvDisplay_ViewLecturer.DataSource=lecturer.view_all();
        }

        private void btnSearchIndividual_ViewLecturer_Click(object sender, EventArgs e)
        {
            dgvDisplay_ViewLecturer.DataSource=lecturer.view_individual(Convert.ToInt32(txtLecID_ViewLecturer.Text));
        }

        private void btnUpdate_UpdateStudent_Click(object sender, EventArgs e)
        {

           int x = lecturer.update_Lecturer(txtSub1_UpdateLecturer.Text, txtSub2_UpdateLecturer.Text, txtSub3_UpdateLecturer.Text, Convert.ToInt32(txtNewContact_UpdateLecturer.Text), txtAddress_UpdateLecturer.Text, UpdateLecID);
           if (x == 1)
                MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
                MessageBox.Show("Update Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        int UpdateLecID;
        private void btnSearch_UpdateLecturer_Click(object sender, EventArgs e)
        {
            UpdateLecID = Convert.ToInt32(txtLecID_UpdateLecturer.Text);
            string query = "select lecturerID AS Lecturer_ID,name as Name,NIC,address as Address,contact_number as Contact_Number,dob as Date_of_Birth,gender as Gender,medium as Medium,subject1 as Subject1,subject2 as Subject2,subject3 as Subject3 from lecturer where lecturerID="+UpdateLecID;
            DataTable dt = new DataTable();
            dt= dbcon.GetData(query);
            dgvDisplay_UpdateLecturer.DataSource = dt;
            txtAddress_UpdateLecturer.Text= dt.Rows[0][3].ToString();
            txtNewContact_UpdateLecturer.Text= dt.Rows[0][4].ToString();
            txtSub1_UpdateLecturer.Text = dt.Rows[0][8].ToString();
            txtSub2_UpdateLecturer.Text = dt.Rows[0][9].ToString();
            txtSub3_UpdateLecturer.Text = dt.Rows[0][10].ToString();
            UpdateLecID = 0;


        }
        int RemoveLecID;
        private void btnSearch_RemoveStudent_Click(object sender, EventArgs e)
        {
            RemoveLecID = Convert.ToInt32(txtLecID_RemoveLecturer.Text);
            string query = "select lecturerID AS Lecturer_ID,name as Name,NIC,address as Address,contact_number as Contact_Number,dob as Date_of_Birth,gender as Gender,medium as Medium,subject1 as Subject1,subject2 as Subject2,subject3 as Subject3 from lecturer where lecturerID=" + RemoveLecID;
            DataTable dt = new DataTable();
            dt = dbcon.GetData(query);
            dgvDisplay__RemoveLecturer.DataSource = dt;
        }

        private void btnRemove_RemoveLecturer_Click(object sender, EventArgs e)
        {
            lecturer.remove_Lecturer(RemoveLecID);
            dgvDisplay__RemoveLecturer.DataSource = null;
            RemoveLecID = 0;
        }

        private void btnlecExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
