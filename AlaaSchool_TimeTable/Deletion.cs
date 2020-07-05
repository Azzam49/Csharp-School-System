using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AlaaSchool_TimeTable
{
    class Deletion
    {

        public static void Delete_User(string userid)
        {
            MainClass.sqlite_conn.Open();
            string query = "DELETE FROM Users WHERE UserID = "+userid+" ";
            SQLiteCommand command = new SQLiteCommand(query,MainClass.sqlite_conn);
            command.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }

        public static void Delete_Teacher(string teacherid)
        {
            MainClass.sqlite_conn.Open();
            string query = "DELETE FROM Teachers WHERE TeacherID = " + teacherid + " ";
            SQLiteCommand command = new SQLiteCommand(query, MainClass.sqlite_conn);
            command.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }

        public static void Delete_Subject(string subjectid)
        {
            MainClass.sqlite_conn.Open();
            string query = "DELETE FROM Subjects WHERE SubjectID = " + subjectid + " ";
            SQLiteCommand command = new SQLiteCommand(query, MainClass.sqlite_conn);
            command.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }

   

        public static void Delete_AssignmentNew(string assignmentid)
        {
            MainClass.sqlite_conn.Open();
            //string query = "DELETE FROM AssignmentsNew WHERE AssignmentID = " + assignmentid + " ";
            //string query = "DELETE FROM Assignments2 WHERE AssignmentID = " + assignmentid + " ";
            string query = "DELETE FROM Assignments3 WHERE AssignmentID = " + assignmentid + " ";
            SQLiteCommand command = new SQLiteCommand(query, MainClass.sqlite_conn);
            command.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }
    }
}
