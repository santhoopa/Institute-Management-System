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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMain main = new frmMain();
            main.Show();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            pnlAddClass.Visible = true;
            pnlEnrollStudents.Visible = false;
            pnlViewClasses.Visible = false;
            pnlRemoveClass.Visible = false;
            pnlEnrollStudents.Visible = false;
            pnlRemoveFromClass.Visible = false;
            cmbTimeSlot_AddClass.Enabled = false;
            cmbTimeSlot_AddClass.ResetText();
            cmbHall_AddClass.Enabled = false;

            //loading lecturer names from database to a combobox
            cmbLecName_AddClass.Items.Clear();
            string query = "select name from lecturer";
            DataTable dt = new DataTable();
            dt=dbcon.GetData(query);
            foreach (DataRow dr in dt.Rows)
            {
                cmbLecName_AddClass.Items.Add(dr["name"].ToString());
            }

            //loading next classid to a label
            string query1 = "select max(classid) from class";
            DataTable dt1 = dbcon.GetData(query1);
            int x = Convert.ToInt32(dt1.Rows[0][0].ToString());
            x++;
            lblClassIDDisplay_AddClass.Text = x.ToString();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            pnlAddClass.Visible = false;
            pnlEnrollStudents.Visible = false;
            pnlViewClasses.Visible = false;
            pnlRemoveClass.Visible = false;
        }

        private void btnViewClass_Click(object sender, EventArgs e)
        {
            pnlAddClass.Visible = false;
            pnlEnrollStudents.Visible = false;
            pnlViewClasses.Visible = true;
            pnlRemoveClass.Visible = false;
            pnlEnrollStudents.Visible = false;
            pnlRemoveFromClass.Visible = false;
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            pnlAddClass.Visible = false;
            pnlEnrollStudents.Visible = true;
            pnlViewClasses.Visible = false;
            pnlRemoveClass.Visible = false;
            pnlEnrollStudents.Visible = false;
            pnlRemoveFromClass.Visible = false;
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            pnlAddClass.Visible = false;
            pnlEnrollStudents.Visible = false;
            pnlViewClasses.Visible = false;
            pnlRemoveClass.Visible = true;
            pnlEnrollStudents.Visible = false;
            pnlRemoveFromClass.Visible = false;
        }

        private void cmbClassDay_AddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbHall_AddClass.Enabled = true;
                if (cmbHall_AddClass.SelectedIndex > -1)
                {
                    cmbTimeSlot_AddClass.Items.Clear();
                    string classDay = cmbClassDay_AddClass.Text;
                    string hall = null;
                    if (cmbHall_AddClass.Text == "Hall 1")
                        hall = "hall_one";
                    else if (cmbHall_AddClass.Text == "Hall 2")
                        hall = "hall_two";
                    else if (cmbHall_AddClass.Text == "Hall 3")
                        hall = "hall_three";

                    string query = "select time_slot from " + hall + " where " + classDay + "='unallocated'";
                    DataTable dt = new DataTable();
                    dt = dbcon.GetData(query);
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbTimeSlot_AddClass.Items.Add(dr["time_slot"].ToString());
                    }
                }
            }
            catch(Exception ex)
            {

            }

        }

        private void cmbHall_AddClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbTimeSlot_AddClass.Enabled = true;

                cmbTimeSlot_AddClass.Items.Clear();
                string classDay = cmbClassDay_AddClass.Text;
                string hall = null;
                if (cmbHall_AddClass.Text == "Hall 1")
                    hall = "hall_one";
                else if (cmbHall_AddClass.Text == "Hall 2")
                    hall = "hall_two";
                else if (cmbHall_AddClass.Text == "Hall 3")
                    hall = "hall_three";

                string query = "select time_slot from " + hall + " where " + classDay + "='unallocated'";
                DataTable dt = new DataTable();
                dt = dbcon.GetData(query);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbTimeSlot_AddClass.Items.Add(dr["time_slot"].ToString());
                }
            }
            catch (Exception ex)
            { }
        }

        private void btnAddClass_AddClass_Click(object sender, EventArgs e)
        {
            string lecQuery = "select lecturerid from lecturer where name='"+cmbLecName_AddClass.Text+"'";
            DataTable dt1 = new DataTable(); 
            dt1=dbcon.GetData(lecQuery);
            int id = Convert.ToInt32(dt1.Rows[0][0].ToString());
            int hall=0;
            if (cmbHall_AddClass.Text == "Hall 1")
                hall = 1;
            else if (cmbHall_AddClass.Text == "Hall 2")
                hall = 2;
            else if (cmbHall_AddClass.Text == "Hall 3")
                hall = 3;
            int x=@class.add_class(Convert.ToInt32(lblClassIDDisplay_AddClass.Text),id,hall,txtSubject_AddClass.Text,cmbGrade_AddClass.Text,Convert.ToInt32(txtYear_AddClass.Text), cmbMedium_AddClass.Text,cmbClassDay_AddClass.Text,cmbTimeSlot_AddClass.Text,Convert.ToInt32(txtTotalFee_AddClass.Text), Convert.ToInt32(txtInstituteFee_AddClass.Text), Convert.ToInt32(txtLecFee_AddClass.Text));
            if (x == 1)
                MessageBox.Show("Succesfully added");
            else
                MessageBox.Show("Cannot be added");

            //loading next classid to a label
            String query1 = "select max(classid) from class";
            DataTable dt11 = dbcon.GetData(query1);
            int z = Convert.ToInt32(dt11.Rows[0][0].ToString());
            z++;
            lblClassIDDisplay_AddClass.Text = z.ToString();
            btnClear_AddClass.PerformClick();
        }

        private void btnClear_AddClass_Click(object sender, EventArgs e)
        {
            txtInstituteFee_AddClass.Text = "";
            txtLecFee_AddClass.Text = "";
            txtTotalFee_AddClass.Text = "";
            txtYear_AddClass.Text = "";
            txtSubject_AddClass.Text = "";
            //cmbHall_AddClass.ResetText();
            cmbMedium_AddClass.ResetText();
           // cmbClassDay_AddClass.ResetText();
            cmbLecName_AddClass.ResetText();
            cmbGrade_AddClass.ResetText();
            cmbTimeSlot_AddClass.ResetText();
            cmbHall_AddClass.Enabled = false;
            cmbTimeSlot_AddClass.Enabled = false;

        }

        private void btnSearchAll_ViewClass_Click(object sender, EventArgs e)
        {
            dgvDisplayResults_ViewClass.DataSource = @class.search_All();
        }

        private void btnSearchIndividual_ViewClass_Click(object sender, EventArgs e)
        {
            dgvDisplayResults_ViewClass.DataSource = @class.search_Individual_Class(Convert.ToInt32(txtClassID_ViewClass.Text));
        }

        private void btnSearchClass_RemoveClass_Click(object sender, EventArgs e)
        {
            dgvDisplay_RemoveClass.DataSource = @class.search_Individual_Class(Convert.ToInt32(txtClassID_RemoveClass.Text));

        }

        private void btnRemove_RemoveClass_Click(object sender, EventArgs e)
        {
            @class.remove_Class(Convert.ToInt32(txtClassID_RemoveClass.Text));
            dgvDisplay_RemoveClass.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAddClass.Visible = false;
            pnlEnrollStudents.Visible = false;
            pnlViewClasses.Visible = false;
            pnlRemoveClass.Visible = false;
            pnlEnrollStudents.Visible = true;
            pnlRemoveFromClass.Visible = false;
        }

        private void btnRemoveFromClass_Click(object sender, EventArgs e)
        {
            pnlAddClass.Visible = false;
            pnlEnrollStudents.Visible = false;
            pnlViewClasses.Visible = false;
            pnlRemoveClass.Visible = false;
            pnlEnrollStudents.Visible = false;
            pnlRemoveFromClass.Visible = true;
        }

        private void cmbSelectClassID_EnrollStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
