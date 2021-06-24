using System;
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
    }
}
