using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace Institute_Management_System
{
    public class student
    {
        static private int student_id;
        static private string name;
        static private string address;
        static private int contact_number;
        static private string dob;
        static private string gender;
        static private string school;
        static private string medium;
        static private string availability;
        static private int guardian_id;
        static private string guardian_name;
        static private int guardian_contact;
        static private string relationship;
        static private string guardian_address;
        public static int add_student(int i, string n, string ad, int contact, string date, string gen, string scho, String med, String avail, int g_id, string gna, int gcon, string rel, string gad)
        {
            student_id = i;
            name = n;
            address = ad;
            contact_number = contact;
            dob = date;
            gender = gen;
            school = scho;
            medium = med;
            availability = avail;
            guardian_id = g_id;
            guardian_name = gna;
            guardian_contact = gcon;
            relationship = rel;
            guardian_address = gad;

            string queryStudent = "insert into student values (" + student_id + ", '" + name + "', '" + address + "', " + contact_number + ", '" + dob + "', '" + gender + "', '" + school + "', '" + medium + "', '" + availability + "'," + guardian_id + ")";
            string queryGuardian = "insert into guardian values (" + guardian_id + ",'" + guardian_name + "'," + guardian_contact + ",'" + relationship + "','" + guardian_address + "')";
            dbcon.SendQuery(queryGuardian);
            int result = dbcon.SendQuery(queryStudent);
            return result;
        }

        public static DataTable view_allStudents()
        {
            string query = "select s.studentid as ID,s.name as Student,s.address as Address,s.contact_number as Contact_Number,s.dob as Date_of_Birth,s.gender as Gender,s.school as School,s.medium as Medium,g.name as Guardian_Name,g.relationship as Relationship,g.contact_number as Guardian_Mobile,g.address as Guardian_Address from guardian g,student s  where g.guardian_id=s.guardianid and availability='available'";
            DataTable dt = new DataTable();
            dt = dbcon.GetData(query);
            return dt;
        }

        public static DataTable view_IndividualStudent(int studentId)
        {
            string query = "select s.studentid as ID,s.name as Student,s.address as Address,s.contact_number as Contact_Number,s.dob as Date_of_Birth,s.gender as Gender,s.school as School,s.medium as Medium,g.name as Guardian_Name,g.relationship as Relationship,g.contact_number as Guardian_Mobile,g.address as Guardian_Address from guardian g,student s  where g.guardian_id=s.guardianid AND s.studentid="+studentId+ " AND availability='available'";
            DataTable dt = new DataTable();
            dt = dbcon.GetData(query);
            return dt;
        }

        public static void update_Student(string address,int contact, string school,int studentID)
        {
            string query = "update student set address='"+address+"',contact_number="+contact+",school='"+school+"' where studentid="+studentID;
            int x=dbcon.SendQuery(query);
           
        }

        public static void remove_Student(int id, string name)
        {  //if a student is enrolled into a course then he cannot be removed from the institute,this code is to make sure that
            string query1 = "select count(studentID) from student_course_enroll where studentid ="+id+" AND status = 'ENROLLED'";
            DataTable dt = new DataTable();
            dt=dbcon.GetData(query1);
            if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you want remove student " + id + " "+name+"?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    string query2 = "update student set availability='NOT' where studentid="+id;
                    dbcon.SendQuery(query2);
                    MessageBox.Show("Successfully removed","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }


            }
            else
                MessageBox.Show("Cannot be removed,","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
