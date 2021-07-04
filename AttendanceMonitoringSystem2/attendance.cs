using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace AttendanceMonitoringSystem2
{
    public partial class attendance : UserControl
    {
        public attendance()
        {
            InitializeComponent();
            DatabaseConnection.DatabaseClass.attendanceSetup();
        }

        private void attendance_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //search
        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseConnection.DatabaseClass.connect.Open();
            DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_search_studNum(textbox_StudSearch.Text), DatabaseConnection.DatabaseClass.connect);
            MySqlDataReader reader;
            reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();
            DatabaseConnection.DatabaseClass.adapter.SelectCommand = DatabaseConnection.DatabaseClass.command;

            //clear
            if (textbox_studNumber.Text.Length > 0)
            {
                textbox_studNumber.Text = string.Empty;
                textbox_lrn.Text = string.Empty;
                textbox_firstName.Text = string.Empty;
                textbox_lastName.Text = string.Empty;
                textbox_course.Text = string.Empty;
                textbox_section.Text = string.Empty;
            }

            if (reader.HasRows)
            {
                reader.Close();
                DatabaseConnection.DatabaseClass.adapter.Fill(DatabaseConnection.DatabaseClass.tableStudentSearch);

                textbox_studNumber.Text = Convert.ToString(DatabaseConnection.DatabaseClass.tableStudentSearch.Rows[0][0]);
                textbox_lrn.Text = Convert.ToString(DatabaseConnection.DatabaseClass.tableStudentSearch.Rows[0][1]);
                textbox_firstName.Text = Convert.ToString(DatabaseConnection.DatabaseClass.tableStudentSearch.Rows[0][2]);
                textbox_lastName.Text = Convert.ToString(DatabaseConnection.DatabaseClass.tableStudentSearch.Rows[0][3]);
                textbox_course.Text = Convert.ToString(DatabaseConnection.DatabaseClass.tableStudentSearch.Rows[0][4]);
                textbox_section.Text = Convert.ToString(DatabaseConnection.DatabaseClass.tableStudentSearch.Rows[0][5]);

                //pic
                byte[] img = (byte[])DatabaseConnection.DatabaseClass.tableStudentSearch.Rows[0][6];

                //check if empty pic
                if (img.Length <= 0 || img == null)
                {
                    pictureBox1.Image = Image.FromFile("Student.jpg");
                }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    //DatabaseConnection.DatabaseClass.adapter.Dispose();
                }

                textbox_StudSearch.Text = string.Empty;

                DataTable newTable = new DataTable();
                DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_check_attendance(textbox_studNumber.Text), DatabaseConnection.DatabaseClass.connect);
                DatabaseConnection.DatabaseClass.adapter.SelectCommand = DatabaseConnection.DatabaseClass.command;
                DatabaseConnection.DatabaseClass.adapter.Fill(newTable);

                if (newTable.Rows.Count == 0)
                {
                    MessageBox.Show("Attendance In");
                    DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_insert_attendance(textbox_studNumber.Text, 1), DatabaseConnection.DatabaseClass.connect);
                    reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();
                    
                    DatabaseConnection.DatabaseClass.connect.Close();
                    DatabaseConnection.DatabaseClass.tableStudentSearch.Clear();
                }
                else
                {
                    int rows = newTable.Rows.Count - 1;
                    string last = newTable.Rows[rows][2].ToString();

                    if (last == "0")
                    {
                        MessageBox.Show("Attendance In");
                        DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_insert_attendance(textbox_studNumber.Text, 1), DatabaseConnection.DatabaseClass.connect);
                        reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();

                        DatabaseConnection.DatabaseClass.connect.Close();
                        DatabaseConnection.DatabaseClass.tableStudentSearch.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Attendance Out");
                        DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_insert_attendance(textbox_studNumber.Text, 0), DatabaseConnection.DatabaseClass.connect);
                        reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();

                        DatabaseConnection.DatabaseClass.connect.Close();
                        DatabaseConnection.DatabaseClass.tableStudentSearch.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Student does not exist!", "Alert");
                DatabaseConnection.DatabaseClass.connect.Close();
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


    }
}
