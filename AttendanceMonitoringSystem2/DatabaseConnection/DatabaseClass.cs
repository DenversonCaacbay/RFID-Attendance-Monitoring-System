﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AttendanceMonitoringSystem2.DatabaseConnection
{
    class DatabaseClass
    {
        public static string database = "datasource=localhost; port=3306; username=root; password=; database=school";

        public static string showAll = "SELECT * FROM student";

        public static string sql_insert_student(string lrn,string firstName, string lastName, string course, string section)
        {
            return "INSERT INTO student(lrn, first_name, last_name, course, section) VALUES ('"+lrn+"','"+firstName+"','"+lastName+"','"+course+"','"+section+"')";
        }

        public static string sql_update_student(string lrn, string firstName, string lastName, string course, string section, string ID)
        {
            return "UPDATE student SET lrn='"+lrn+"', first_name='"+firstName+"', last_name='"+lastName+"', course='"+course+"', section='"+section+"' WHERE student_number='"+ID+"' ";
        }

        public static string sql_checker_student(string firstName, string lastName)
        {
            return "SELECT * FROM student WHERE first_name='"+firstName+"' AND last_name='"+lastName+"' ";
        }

        public static string sql_delete_student(string ID)
        {
            return "DELETE FROM student WHERE student_number="+ID;
        }
    }
}
