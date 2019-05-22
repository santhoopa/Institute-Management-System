using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Institute_Management_System
{
    public class lecturer
    {
        static private int lecturer_id;
        static private string name;
        static private string NIC;
        static private string address;
        static private int contact_number;
        static private string dob;
        static private string gender;
        static private string medium;
        static private string availability;
        static private string subject1;
        static private string subject2;
        static private string subject3;

        public static int add_lecturer(int id, string n, string NI, string a, int con, string b, string gen, string med, string sub1, string sub2, string sub3)
        {
            lecturer_id = id;
            name = n;
            NIC = NI;
            address = a;
            contact_number = con;
            dob = b;
            gender = gen;
            medium = med;
            availability = "available";
            subject1 = sub1;
            subject2 = sub2;
            subject3 = sub3;

            string query = "insert into lecturer values (" + lecturer_id + ", '" + name + "', '" + NIC + "','" + address + "', " + contact_number + ", '" + dob + "', '" + gender + "', '" + medium + "', '" + availability + "', '" + subject1 + "', '" + subject2 + "', '" + subject3 + "'); ";
            int result = dbcon.SendQuery(query);
            return result;
        }

        public static DataTable view_all()
        {
            string query = "select lecturerid as Lecturer_ID,name as Lecturer_Name,NIC,address as Address,contact_number as Contact_Number,dob as Date_of_Birth,gender as Gender,medium as Medium,subject1 as Subject_1,subject2 as Subject_2,subject3 as Subject_3 from lecturer where availability='available'";
            DataTable dt = new DataTable();
            dt = dbcon.GetData(query);
            return dt;
        }

        public static DataTable view_individual(int lecturer_id)
        {
            string query = "select c.classid as Class_ID,l.name as Lecturer_Name,c.hallid as Hall_ID,c.subject as Subject,c.grade as Grade,c.year as Year,c.medium as Medium,c.class_day as Class_Day, c.time_slot as Time_Slot,c.total_fee as Monthly_Fee_Per_Student,c.institute_fee as Institute_Fee,c.lecturer_fee as Lecturer_Fee from class c,lecturer l where c.lecid=l.lecturerid  and c.availability='available' and c.lecid=" + lecturer_id;
            DataTable dt = new DataTable();
            dt = dbcon.GetData(query);
            return dt;
        }


        public static int update_Lecturer(string sub1, string sub2, string sub3, int contact, string add, int LecID)
        {
            string query = "update lecturer set subject1='" + sub1 + "',subject2='" + sub2 + "',subject3='" + sub3 + "',contact_number=" + contact + ",address='" + add + "' where lecturerid=" + LecID + ";";
            int x = dbcon.SendQuery(query);
            return x;
        }

        public static void remove_Lecturer(int lecID)
        {
            string query1 = "select count(lecid) from class where lecid=" + lecID + " and availability='available'";
            DataTable dt = new DataTable();
            dt = dbcon.GetData(query1);
            if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you want remove Lecturer with Lecturer ID " + lecID + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    string query2 = "update lecturer set availability='NOT' where lecturerID=" + lecID;
                    dbcon.SendQuery(query2);
                    MessageBox.Show("Successfully removed", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
                MessageBox.Show("Cannot be removed,", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
