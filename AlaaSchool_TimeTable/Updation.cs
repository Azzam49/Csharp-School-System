using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AlaaSchool_TimeTable
{
    class Updation
    {

        public static void Update_User(string userid,string username,string position,string active)
        {
            MainClass.sqlite_conn.Open();
            string UpdateQuery = "UPDATE Users SET Username = '" + username + "' ,Position = '" + position + "',Active = '" + active + "' WHERE UserID = " + userid + " ";
            SQLiteCommand cmd = new SQLiteCommand(UpdateQuery, MainClass.sqlite_conn);
            cmd.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }

        public static void Update_Teacher(string teacherid, string teacher,string gender,string phone,string active)
        {
            MainClass.sqlite_conn.Open();
            string UpdateQuery = "UPDATE Teachers SET TeacherName = '" + teacher + "' ,Gender = '" + gender + "',Phone = '" + phone + "',Active = '" + active + "' WHERE TeacherID = " + teacherid + " ";
            SQLiteCommand cmd = new SQLiteCommand(UpdateQuery, MainClass.sqlite_conn);
            cmd.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }

        public static void Update_Subject(string subject,string subjectid)
        {
            MainClass.sqlite_conn.Open();
            string UpdateQuery = "UPDATE Subjects SET SubjectName = '" + subject + "' WHERE SubjectID = " + subjectid + " ";
            SQLiteCommand cmd = new SQLiteCommand(UpdateQuery, MainClass.sqlite_conn);
            cmd.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }

     

        public static void Update_AssignmentNew(string assignid, string classid, string subjectid, string teacherid, string timingid)
        {
            MainClass.sqlite_conn.Open();
            //string UpdateQuery = "UPDATE AssignmentsNew SET Class_ID = '" + classid + "',Timing_ID = '" + timingid + "',Subject_ID = '" + subjectid + "',Teacher_ID = '" + teacherid + "' WHERE AssignmentID = " + assignid + " ";
            //string UpdateQuery = "UPDATE Assignments2 SET Class_ID = '" + classid + "',Timing_ID = '" + timingid + "',Subject_ID = '" + subjectid + "',Teacher_ID = '" + teacherid + "' WHERE AssignmentID = " + assignid + " ";
            string UpdateQuery = "UPDATE Assignments3 SET Class_ID = '" + classid + "',Timing_ID = '" + timingid + "',Subject_ID = '" + subjectid + "',Teacher_ID = '" + teacherid + "' WHERE AssignmentID = " + assignid + " ";
            SQLiteCommand cmd = new SQLiteCommand(UpdateQuery, MainClass.sqlite_conn);
            cmd.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }
    }
}
