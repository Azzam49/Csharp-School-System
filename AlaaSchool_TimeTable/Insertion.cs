using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaaSchool_TimeTable
{
    class Insertion
    {

        public static void Insert_User(string user,string password,string position,string active)
        {
            MainClass.sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            string Query = "INSERT INTO Users(Username,Password,Position,Active) VALUES ('" + user + "','"+ password + "','"+ position + "','" + active + "')";
            sqlite_cmd = MainClass.sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Query;
            sqlite_cmd.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }

        public static void Insert_Teacher(string teacher, string gender, string phone, string active)
        {
            MainClass.sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            string Query = "INSERT INTO Teachers(TeacherName,Gender,Phone,Active) VALUES ('" + teacher + "','" + gender + "','" + phone + "','" + active + "')";
            sqlite_cmd = MainClass.sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Query;
            sqlite_cmd.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }

        public static void Insert_Subject(string subject)
        {
            MainClass.sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            string Query = "INSERT INTO Subjects(SubjectName) VALUES ('" + subject + "')";
            sqlite_cmd = MainClass.sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Query;
            sqlite_cmd.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }

       
        public static void Insert_AssignmentNew(string classid,  string subjectid, string teacherid, string sectionid, string timingid)
        {
            MainClass.sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            //string Query = "INSERT INTO AssignmentsNew(Class_ID,Subject_ID,Teacher_ID,Section_ID,Timing_ID) VALUES ('" + classid + "','" + subjectid + "','" + teacherid + "','" + sectionid + "','" + timingid + "')";
            //string Query = "INSERT INTO Assignments2(Class_ID,Subject_ID,Teacher_ID,Section_ID,Timing_ID) VALUES ('" + classid + "','" + subjectid + "','" + teacherid + "','" + sectionid + "','" + timingid + "')";
            string Query = "INSERT INTO Assignments3(Class_ID,Subject_ID,Teacher_ID,Section_ID,Timing_ID) VALUES ('" + classid + "','" + subjectid + "','" + teacherid + "','" + sectionid + "','" + timingid + "')";
            sqlite_cmd = MainClass.sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Query;
            sqlite_cmd.ExecuteNonQuery();
            MainClass.sqlite_conn.Close();
        }
    }
}
