using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace AttendanceMonitoringSystem2
{
    public partial class manage : UserControl
    {
        public static MySqlConnection connect;
        public static MySqlCommand command;
        public static MySqlDataAdapter adapter;
        public static DataTable table;
        public static string sql_showStudent = DatabaseConnection.DatabaseClass.showAll;

        public void setupDB()
        {
            connect = new MySqlConnection(DatabaseConnection.DatabaseClass.database);
            adapter = new MySqlDataAdapter();
            table = new DataTable();
        }

        public void refreshForm()
        {
            try
            {
                table.Clear();
                connect.Open();
                command = new MySqlCommand(sql_showStudent, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nWeightEllipse

        );
        public manage()
        {
            InitializeComponent();
            setupDB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manage_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 10, 10));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 10, 10));
            refreshForm();
        }
    }
}
