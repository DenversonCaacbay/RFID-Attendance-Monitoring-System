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
       

        public login()
        {
            InitializeComponent();
            DatabaseConnection.DatabaseClass.loginSetup();
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
            DatabaseConnection.DatabaseClass.connect.Close();
            try
            {
                DatabaseConnection.DatabaseClass.connect.Open();
                DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_login_admin(textbox_username.Text, textbox_password.Text), DatabaseConnection.DatabaseClass.connect);
                DatabaseConnection.DatabaseClass.adapter.SelectCommand = DatabaseConnection.DatabaseClass.command;
                DatabaseConnection.DatabaseClass.adapter.Fill(DatabaseConnection.DatabaseClass.tableLogin);

                if (DatabaseConnection.DatabaseClass.tableLogin.Rows.Count > 0)
                {
                    DatabaseConnection.DatabaseClass.connect.Close();
                    var user = DatabaseConnection.DatabaseClass.tableLogin.Rows[0][1];
                    admin_access = DatabaseConnection.DatabaseClass.tableLogin.Rows[0][3].ToString();
                    Console.WriteLine("Logged In User: "+user+" | Admin Access: "+admin_access);
                    //MessageBox.Show("Admin Log In Successfully", "Success");


                    this.Hide();
                    new Form1().Show();
                }
                else
                {
                    DatabaseConnection.DatabaseClass.connect.Close();
                    MessageBox.Show("Usernane/Password Invalid", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
