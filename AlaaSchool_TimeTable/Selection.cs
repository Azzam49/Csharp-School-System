using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AlaaSchool_TimeTable
{
    class Selection
    {

        public static DataTable Get_DataTable(string query)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            MainClass.sqlite_conn.Open();
            string SelectQuery = query;
            SQLiteCommand command = new SQLiteCommand(SelectQuery, MainClass.sqlite_conn);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            MainClass.sqlite_conn.Close();

            return dataTable;
        }

        public static DataTable Get_UsersTable()
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            MainClass.sqlite_conn.Open();
            string SelectQuery = "SELECT UserID AS 'أيدي',Username AS 'الإسم',Password AS 'كلمة مرور',Position AS 'رتبة',Active AS 'مفعل' FROM Users";
            SQLiteCommand command = new SQLiteCommand(SelectQuery,MainClass.sqlite_conn);            
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            MainClass.sqlite_conn.Close();

            return dataTable;
        }

        public static DataTable Get_TeachersTable()
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            MainClass.sqlite_conn.Open();
            string SelectQuery = "SELECT TeacherID AS 'أيدي',TeacherName AS 'الإسم',Gender AS 'جنس',Phone AS 'الهاتف',Active AS 'مفعل' FROM Teachers";
            SQLiteCommand command = new SQLiteCommand(SelectQuery, MainClass.sqlite_conn);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            MainClass.sqlite_conn.Close();

            return dataTable;
        }

        public static DataTable Get_SubjectsTable()
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            MainClass.sqlite_conn.Open();
            string SelectQuery = "SELECT SubjectID AS 'أيدي المادة',SubjectName AS 'المادة' FROM Subjects";
            SQLiteCommand command = new SQLiteCommand(SelectQuery, MainClass.sqlite_conn);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            MainClass.sqlite_conn.Close();

            return dataTable;
        }

 
        public static DataTable Get_AssignmentsNewTable(string sectionid)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            MainClass.sqlite_conn.Open();

            string SelectQuery
              = "SELECT a.AssignmentID AS 'الأيدي', " +
              "d.DayName AS 'اليوم'," +
              "a.Section_ID AS 'أيدي القسم'," +
              "c.ClassName AS 'الفصل'," +
              "c.ClassID AS 'أيدي الفصل'," +
              "s.SubjectName AS 'المادة'," +
              "s.SubjectID AS 'أيدي المادة'," +
              "p.PeriodName AS 'الحصه'," +
              "p.PeriodID AS 'أيدي الحصه'," +
              "t.TeacherName AS 'المعلمين'," +
              "t.TeacherID AS 'أيدي المعلم'," +
              "tt.TimingID AS 'أيدي التوقيت'" +
              //" FROM AssignmentsNew a" +
              //" FROM Assignments2 a" +
              " FROM Assignments3 a" +
              " INNER JOIN Classes c ON c.ClassID = a.Class_ID" +
              " INNER JOIN Periods p ON p.PeriodID = tt.Period_ID" +
              " INNER JOIN Subjects s ON s.SubjectID = a.Subject_ID" +
              " INNER JOIN Teachers t ON t.TeacherID = a.Teacher_ID" +
              " INNER JOIN Timings tt ON tt.TimingID = a.Timing_ID" +
              " INNER JOIN Days d ON d.DayID = tt.Day_ID" +
              " WHERE a.Section_ID = '" + sectionid + "' ";

            SQLiteCommand command = new SQLiteCommand(SelectQuery, MainClass.sqlite_conn);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            MainClass.sqlite_conn.Close();

            return dataTable;
        }

        public static DataTable Get_Period_By_Timing()
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            MainClass.sqlite_conn.Open();
            string SelectQuery = "SELECT tt.TimingID AS 'TimingID',(p.PeriodName || '   (' || d.DayName || ' )') AS 'Periods' FROM Timings tt INNER JOIN Periods p ON p.PeriodID = tt.Period_ID INNER JOIN Days d ON d.DayID = tt.Day_ID WHERE tt.Level_ID = 1 ";
            SQLiteCommand command = new SQLiteCommand(SelectQuery, MainClass.sqlite_conn);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            MainClass.sqlite_conn.Close();

            return dataTable;
        }

        //public static DataTable Get_TimetTableReport()
        //{
        //    DataTable dataTable = new DataTable();
        //    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

        //    MainClass.sqlite_conn.Open();
        //    string SelectQuery =
        //     "SELECT DISTINCT " +
        //     "tt.TimingID AS 'TimingID', " +
        //      //"SELECT tt.TimingID AS 'TimingID', " + //Trying to fix duplicates on report
        //      "c.ClassName AS 'Class'," +
        //      "p.PeriodName AS 'Period'," +
        //      "s.SectionName AS 'Section'," +
        //      "t.TeacherName AS 'Teacher'," +
        //      "t.Gender AS 'Gender'," +
        //      "d.DayID AS 'DayID'," +
        //      "d.DayName AS 'Day'," +
        //      "su.SubjectName AS 'Subject'," +
        //      "lv.LevelName AS 'Level'," +
        //      "(tt.FromTime || '-' || tt.ToTime) AS 'Timings' " +
        //      " FROM AssignmentsNew a" +
        //      " INNER JOIN Classes c ON c.ClassID = a.Class_ID" +
        //      " LEFT JOIN Sections s ON a.Section_ID = s.SectionID" +
        //      " INNER JOIN Subjects su ON a.Subject_ID = su.SubjectID" +
        //      " INNER JOIN Teachers t ON t.TeacherID = a.Teacher_ID" +
        //      " INNER JOIN Timings tt ON tt.TimingID = a.Timing_ID" +
        //      //" LEFT JOIN Timings tt ON a.Timing_ID = tt.TimingID" + //Trying to fix duplicates on report
        //      " INNER JOIN Days d ON d.DayID = tt.Day_ID" +
        //      " INNER JOIN Periods p ON p.PeriodID = tt.Period_ID" +
        //      //" LEFT JOIN Periods p ON tt.Period_ID = p.PeriodID" + //Trying to fix duplicates on report
        //      " INNER JOIN Levels lv ON c.Level_ID = lv.LevelID" +
        //      " WHERE c.ClassID = '1' " + //Search by Class
        //      //" WHERE t.TeacherName = 'محمد' " + //Search by Teacher
        //      //" GROUP BY d.DayID " + //Trying to fix duplicates on report
        //      " ORDER BY tt.TimingID ASC ";

        //    SQLiteCommand command = new SQLiteCommand(SelectQuery, MainClass.sqlite_conn);
        //    dataAdapter.SelectCommand = command;
        //    dataAdapter.Fill(dataTable);
        //    MainClass.sqlite_conn.Close();

        //    return dataTable;
        //} // Original



        public static DataTable Get_TimetTableReport(string Case,string Value,string Section="None")
        {
            string whereStatement = "";
            if(Case == "ByClass")
            {
                whereStatement = $" WHERE c.ClassID = '{Value}' AND s.SectionName = '{Section}' ";
            }
            if(Case == "ByTeacher")
            {
                //whereStatement = $" WHERE t.TeacherName = '{Value}' AND s.SectionName = '{Section}' ";
                whereStatement = $" WHERE t.TeacherName = '{Value}' ";
            }

            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            MainClass.sqlite_conn.Open();
            string SelectQuery =
             "SELECT DISTINCT " +
             "tt.TimingID AS 'TimingID', " +
              "c.ClassName AS 'Class'," +
              "p.PeriodID AS 'PeriodID'," +
              "p.PeriodName AS 'Period'," +
              "s.SectionName AS 'Section'," +
              "t.TeacherName AS 'Teacher'," +
              "t.Gender AS 'Gender'," +
              "d.DayID AS 'DayID'," +
              "d.DayName AS 'Day'," +
              "su.SubjectName AS 'Subject'," +
              "lv.LevelName AS 'Level'," +
              "(tt.FromTime || '-' || tt.ToTime) AS 'Timings' " +
              //" FROM AssignmentsNew a" +
              //" FROM Assignments2 a" +
              " FROM Assignments3 a" +
              " INNER JOIN Classes c ON c.ClassID = a.Class_ID" +
              " LEFT JOIN Sections s ON a.Section_ID = s.SectionID" +
              " INNER JOIN Subjects su ON a.Subject_ID = su.SubjectID" +
              " INNER JOIN Teachers t ON t.TeacherID = a.Teacher_ID" +
              " INNER JOIN Timings tt ON tt.TimingID = a.Timing_ID" +
              " INNER JOIN Days d ON d.DayID = tt.Day_ID" +
              " INNER JOIN Periods p ON p.PeriodID = tt.Period_ID" +
              " INNER JOIN Levels lv ON c.Level_ID = lv.LevelID" +
              //" WHERE c.ClassID = '1' " +   
              //" WHERE t.TeacherName = 'محمد' " + //Search by Teacher
              whereStatement + // dynamiclly
              " ORDER BY tt.TimingID ASC ";

            SQLiteCommand command = new SQLiteCommand(SelectQuery, MainClass.sqlite_conn);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            MainClass.sqlite_conn.Close();

            return dataTable;
        } 

        public static DataTable Get_Teacher_and_Timing_for_UniqueIndexError(string teacherid, string timingid)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            MainClass.sqlite_conn.Open();

            //string SelectQuery = "SELECT tt.TimingID AS 'TimingID',(p.PeriodName || '   (' || d.DayName || ' )') AS 'Periods' FROM Timings tt INNER JOIN Periods p ON p.PeriodID = tt.Period_ID INNER JOIN Days d ON d.DayID = tt.Day_ID WHERE tt.Level_ID = 1 AND tt.TimingID = 2";
            string SelectQuery = "SELECT tt.TimingID AS 'TimingID'," +
                "(p.PeriodName || '   (' || d.DayName || ' )') AS 'Periods'," +
                "c.ClassName AS 'Class'," +
                "t.TeacherName AS 'Teacher', " +
                "s.SectionName AS 'Section' " +
                "FROM Timings tt " +
                "INNER JOIN Periods p ON p.PeriodID = tt.Period_ID " +
                "INNER JOIN Days d ON d.DayID = tt.Day_ID " +
                "INNER JOIN Assignments3 a ON a.Timing_ID = tt.TimingID " +
                "INNER JOIN Classes c ON a.Class_ID = c.ClassID " +
                "INNER JOIN Teachers t ON a.Teacher_ID = t.TeacherID " +
                "INNER JOIN Sections s ON a.Section_ID = s.SectionID " +
                "WHERE tt.Level_ID = 1 AND tt.TimingID = " + timingid;

            //string SelectQuery =
            //"SELECT t.TeacherName AS 'Teacher', "+
            //"(p.PeriodName || '   (' || d.DayName || ' )') AS 'Periods', "+
            //"tt.TimingID AS 'TimingID' " +
            //"tt.Day_ID AS 'DayID' " +
            //"FROM Assignments3 a " +
            //"INNER JOIN Timings tt ON tt.TimingID = a.Timing_ID " +
            //"INNER JOIN Periods p ON p.PeriodID = tt.Period_ID " +
            //"INNER JOIN Days d ON d.DayID = tt.Day_ID "+
            //"INNER JOIN Teachers t ON t.TeacherID = a.Teacher_ID "+            
            ////"WHERE  a.Timing_ID = '" + timingid+"' ";
            //"WHERE  a.Timing_ID = '2' ";

            //string SelectQuery =
            //"SELECT t.TeacherName AS 'Teacher', " +
            //    "(p.PeriodName || '   (' || d.DayName || ' )') AS 'Periods', " +
            //    "tt.TimingID AS 'TimingID' " +
            //    "tt.Day_ID AS 'DayID' " +
            //    "FROM Assignments3 a " +
            //    "INNER JOIN Timings tt ON tt.TimingID = a.Timing_ID " +
            //    "INNER JOIN Periods p ON p.PeriodID = tt.Period_ID " +
            //    "INNER JOIN Days d ON d.DayID = tt.Day_ID " +
            //    "INNER JOIN Teachers t ON t.TeacherID = a.Teacher_ID " +
            //    //"WHERE  a.Timing_ID = '" + timingid+"' ";
            //    "WHERE  a.Timing_ID = '2' ";

            SQLiteCommand command = new SQLiteCommand(SelectQuery, MainClass.sqlite_conn);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            MainClass.sqlite_conn.Close();

            return dataTable;
        }

        
    }
}
