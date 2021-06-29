using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace AttendanceMonitoringSystem2.DatabaseConnection
{
    class DatabaseClass
    {
        public static string database = "datasource=localhost; port=3306; username=root; password=; database=school";

        public static string showAll = "SELECT * FROM student";

        public static string showLogs = "SELECT "+
                                            "log_record.log_id,"+
                                            "log_record.student_number,"+
                                            "student.lrn,"+
                                            "student.first_name," +
                                            "student.last_name," +
                                            "student.course," +
                                            "student.section," +
                                            "log_record.date_time " +
                                            "FROM log_record JOIN student "+
                                            "ON log_record.student_number = student.student_number";

        public static string sql_showStudent = DatabaseConnection.DatabaseClass.showAll;

        //INSERT
        public static string sql_insert_student(string student_number ,string lrn,string firstName, string lastName, string course, string section)
        {
            return "INSERT INTO student(student_number ,lrn, first_name, last_name, course, section) VALUES ('" + student_number + "','" + lrn+"','"+firstName+"','"+lastName+"','"+course+"','"+section+"')";
        }
        //UPDATE
        public static string sql_update_student(string lrn, string firstName, string lastName, string course, string section, string ID)
        {
            return "UPDATE student SET lrn='"+lrn+"', first_name='"+firstName+"', last_name='"+lastName+"', course='"+course+"', section='"+section+"' WHERE student_number='"+ID+"' ";
        }
        //SELECT
        public static string sql_checker_student(string firstName, string lastName)
        {
            return "SELECT * FROM student WHERE first_name='"+firstName+"' AND last_name='"+lastName+"' ";
        }
        //SEARCH
        public static string sql_search_student(string ID)
        {
            return "SELECT * FROM student WHERE student_number="+ID;
        }
        //DELETE
        public static string sql_delete_student(string ID)
        {
            return "DELETE FROM student WHERE student_number="+ID;
        }

        //login
        public static string sql_login_admin(string username, string password)
        {
            return "SELECT * FROM admin WHERE username='"+username+"' AND password='"+password+"' ";
        }

        
        //Processes
        public static MySqlConnection connect;
        public static MySqlCommand command;
        public static MySqlDataAdapter adapter;
        public static DataTable tableStudent;
        public static DataTable tableRecord;
        public static DataTable tableLogin;

        public static void setupDB()
        {
            DatabaseConnection.DatabaseClass.connect = new MySqlConnection(DatabaseConnection.DatabaseClass.database);
            DatabaseConnection.DatabaseClass.adapter = new MySqlDataAdapter();
        }

        public static void recordSetup()
        {
            DatabaseConnection.DatabaseClass.setupDB();
            DatabaseConnection.DatabaseClass.tableRecord = new DataTable();
        }

        public static void loginSetup()
        {
            DatabaseConnection.DatabaseClass.setupDB();
            DatabaseConnection.DatabaseClass.tableLogin = new DataTable();
        }

        public static void manageSetup()
        {
            DatabaseConnection.DatabaseClass.setupDB();
            DatabaseConnection.DatabaseClass.tableStudent = new DataTable();
        }

        public void refreshForm()
        {
            DatabaseConnection.DatabaseClass.connect.Close();
            try
            {
                DatabaseConnection.DatabaseClass.tableRecord.Clear();
                DatabaseConnection.DatabaseClass.connect.Open();
                DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.showLogs, DatabaseConnection.DatabaseClass.connect);
                DatabaseConnection.DatabaseClass.adapter.SelectCommand = DatabaseConnection.DatabaseClass.command;
                DatabaseConnection.DatabaseClass.adapter.Fill(DatabaseConnection.DatabaseClass.tableRecord);

                //dataGridView1.DataSource = DatabaseConnection.DatabaseClass.tableRecord;
                DatabaseConnection.DatabaseClass.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





    }
}
