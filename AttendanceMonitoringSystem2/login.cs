using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AttendanceMonitoringSystem2
{
    public partial class login : Form
    {
        public static MySqlConnection connect;
        public static MySqlCommand command;
        public static MySqlDataAdapter adapter;
        public static DataTable tableLogin;

        public static string admin_access;

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

        public static void setupDB()
        {
            connect = new MySqlConnection(DatabaseConnection.DatabaseClass.database);
            adapter = new MySqlDataAdapter();
            tableLogin = new DataTable();
        }

        public login()
        {
            InitializeComponent();
            setupDB();
        }

        private void login_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 50, 50));

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 35, 35));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button1.Height, 35, 35));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                
            }
        }

        //login
        private void button1_Click(object sender, EventArgs e)
        {
            //tableLogin.Clear();
            connect.Close();
            try
            {
                connect.Open();
                command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_login_admin(textbox_username.Text, textbox_password.Text), connect);
                adapter.SelectCommand = command;
                adapter.Fill(tableLogin);

                if (tableLogin.Rows.Count > 0)
                {
                    connect.Close();
                    var user = tableLogin.Rows[0][1];
                    admin_access = tableLogin.Rows[0][3].ToString();
                    Console.WriteLine("Logged In User: "+user+" | Admin Access: "+admin_access);


                    this.Hide();
                    new Form1().Show();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Usernane/Password Invalid", "Alert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
