using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace Institute_Management_System
{
    public class @class
    {
        public static int add_class(int classID,int lecID,int hallID, string subject, string grade,int year, string medium, string classDay, string timeSlot,int totalFee,int instituteFee,int lecturerFee)
        {
            string query = "insert into class values("+classID+","+lecID+","+hallID+", '"+subject+"', '"+grade+"',"+year+", '"+medium+"', '"+classDay+"', '"+timeSlot+"', "+totalFee+", "+instituteFee+", "+lecturerFee+", 'available'); ";
            string hallName = null;
            if (hallID == 1)
                hallName = "hall_one";
            else if (hallID == 2)
                hallName = "hall_two";
            else if (hallID == 3)
                hallName = "hall_three";
            string query1 = "update "+hallName+" set "+classDay+"='allocated' where time_slot='"+timeSlot+"' and "+classDay+"='unallocated' ";
            int x=dbcon.SendQuery(query1);
            if (x == 1)
            {
                int result = dbcon.SendQuery(query);
                return result;
            }
            else
                return 0 ;
        }

        public static DataTable search_All()
        {
            string query = "select c.classid as Class_ID,l.name as Lecturer_Name,c.hallid as Hall_ID,c.subject as Subject,c.grade as Grade,c.year as Year,c.medium as Medium,c.class_day as Class_Day, c.time_slot as Time_Slot,c.total_fee as Monthly_Fee_Per_Student,c.institute_fee as Institute_Fee,c.lecturer_fee as Lecturer_Fee from class c,lecturer l where c.lecid=l.lecturerid  and c.availability='available'";
            DataTable dt = new DataTable();
            dt = dbcon.GetData(query);
            return dt;
        }

        public static DataTable search_Individual_Class(int class_id)
        {
            string query = "select c.classid as Class_ID,l.name as Lecturer_Name,c.hallid as Hall_ID,c.subject as Subject,c.grade as Grade,c.year as Year,c.medium as Medium,c.class_day as Class_Day, c.time_slot as Time_Slot,c.total_fee as Monthly_Fee_Per_Student,c.institute_fee as Institute_Fee,c.lecturer_fee as Lecturer_Fee from class c,lecturer l where c.lecid=l.lecturerid  and c.availability='available' and c.classid="+class_id ;
            DataTable dt = new DataTable();
            dt = dbcon.GetData(query);
            return dt;
        }

        public static void remove_Class(int classID)
        {
            string query = "select count(classID) from student_course_enroll  where classID="+classID+" AND status='ENROLLED' ";
            DataTable dt = new DataTable();
            dt = dbcon.GetData(query);
            if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure you want remove class with class ID " + classID + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    string query2 = "update class set availability='NOT' where classid=" + classID;
                    dbcon.SendQuery(query2);
                    MessageBox.Show("Successfully removed", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
                MessageBox.Show("Cannot be removed,all the students must be unenrolled from the class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
