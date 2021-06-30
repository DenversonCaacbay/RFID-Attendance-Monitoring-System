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
using System.Drawing.Text;
using MySql.Data.MySqlClient;


namespace AttendanceMonitoringSystem2
{
    public partial class Form1 : Form
    {

        /*
        //database needs
        //string database = "datasource=localhost; port=3306; username=root; password=; database=school";

        public static MySqlConnection connect;
        public static MySqlCommand command;
        public static MySqlDataAdapter adapter;
        public static DataTable table;
        public static string sql_showStudent = DatabaseConnection.DatabaseClass.showAll;

        public static void setupDB()
        {
            connect = new MySqlConnection(DatabaseConnection.DatabaseClass.database);
            adapter = new MySqlDataAdapter();
            table = new DataTable();
        }

        public static void refreshForm()
        {
            try
            {
                Form1.table.Clear();
                Form1.connect.Open();
                Form1.command = new MySqlCommand(sql_showStudent, connect);
                Form1.adapter.SelectCommand = command;
                Form1.adapter.Fill(table);

                //dataGridView1.DataSource = table;
                //manage.dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */


        [DllImport("Gdi32.dll" ,EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft, 
            int nTop, 
            int nRight, 
            int nBottom, 
            int nWidthEllipse, 
            int nWeightEllipse

        );
    public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0,Width,Height, 15, 15));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //iconButton1.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,iconButton1.Width,iconButton1.Height,20,20));
            //iconButton2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, iconButton2.Width, iconButton1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 50, 50));


            //label8.Text = DateTime.Now.ToString("hh:mm tt"); //result 11:11:45 PM
            //label9.Text = DateTime.Now.ToShortDateString(); //30.5.2012
            timer1.Start();
            
            attendance1.Show();
            manage1.Hide();
            record1.Hide();
            accounts1.Hide();

            panel3.Hide();
            panel5.Hide();
            panel7.Hide();
            panel6.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            attendance1.Show();
            manage1.Hide();
            record1.Hide();

            panel4.Show();
            panel5.Hide();
            panel7.Hide();
            panel6.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (login.admin_access == "1")
            {
                attendance1.Hide();
                manage1.Show();
                record1.Hide();

                panel4.Hide();
                panel5.Show();
                panel7.Hide();
                panel6.Hide();
            }
            else
            {
                MessageBox.Show("You do not have the access!", "Alert");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panel6.Show();
            DialogResult dr = MessageBox.Show("Do you want to Log Out.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                new login().Show();
                login.admin_access = "";
            }
            else
            { 
                
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            attendance1.Hide();
            manage1.Hide();

            panel4.Hide();
            panel5.Hide();
            panel7.Show();
            panel6.Hide();
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            attendance1.Hide();
            manage1.Hide();
            record1.Show();

            panel4.Hide();
            panel5.Hide();
            panel7.Show();
            panel6.Hide();
        }

        private void manage1_Load(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void attendance1_Load(object sender, EventArgs e)
        {

        }

        //Date and time
        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("hh:mm:ss tt"); //result 11:11:45 PM
            label9.Text = DateTime.Now.ToShortDateString(); //30.5.2012
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            accounts1.Show();
            attendance1.Hide();
            manage1.Hide();
            record1.Hide();

            panel3.Show();
            panel4.Hide();
            panel5.Hide();
            panel7.Hide();
            panel6.Hide();
        }
    }
}
