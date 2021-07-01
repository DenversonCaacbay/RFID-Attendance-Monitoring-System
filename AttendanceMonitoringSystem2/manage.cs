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

        public void refreshForm()
        {
            DatabaseConnection.DatabaseClass.connect.Close();
            try
            {
                DatabaseConnection.DatabaseClass.tableStudent.Clear();
                DatabaseConnection.DatabaseClass.connect.Open();
                DatabaseConnection.DatabaseClass.command = new MySqlCommand
                    (DatabaseConnection.DatabaseClass.sql_showStudent, DatabaseConnection.DatabaseClass.connect);
                DatabaseConnection.DatabaseClass.adapter.SelectCommand = DatabaseConnection.DatabaseClass.command;
                DatabaseConnection.DatabaseClass.adapter.Fill(DatabaseConnection.DatabaseClass.tableStudent);

                dataGridView1.DataSource = DatabaseConnection.DatabaseClass.tableStudent;
                DatabaseConnection.DatabaseClass.connect.Close();
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
            DatabaseConnection.DatabaseClass.manageSetup();
        }

        private void manage_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 10, 10));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 10, 10));

            refreshForm();
        }

        //onclick
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //create student
        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection.DatabaseClass.connect.Open();
            DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_checker_student(textbox_firstName.Text, textbox_lastName.Text), DatabaseConnection.DatabaseClass.connect);
            MySqlDataReader reader;
            reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();

            if (textbox_studNum.Text == "" || textbox_lrn.Text == "" || textbox_firstName.Text == "" || textbox_lastName.Text == "" || textbox_course.Text == "" || textbox_section.Text == "")
            {
                DatabaseConnection.DatabaseClass.connect.Close();
                MessageBox.Show("Please complete the Form!");
            }
            else if (reader.HasRows)
            {
                DatabaseConnection.DatabaseClass.connect.Close();
                MessageBox.Show("Student Already Existed!");
            }
            else
            {
                DatabaseConnection.DatabaseClass.connect.Close();
                try
                {
                    DatabaseConnection.DatabaseClass.connect.Open();
                    DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_insert_student(textbox_studNum.Text,
                        textbox_lrn.Text, textbox_firstName.Text, textbox_lastName.Text, textbox_course.Text, textbox_section.Text), DatabaseConnection.DatabaseClass.connect);
                    MySqlDataReader reader2;
                    reader2 = DatabaseConnection.DatabaseClass.command.ExecuteReader();
                    MessageBox.Show("Student Created!");
                    //for clearing
                    textbox_studNum.Text = String.Empty;
                    textbox_lrn.Text = String.Empty;
                    textbox_firstName.Text = String.Empty;
                    textbox_lastName.Text = String.Empty;
                    textbox_course.Text = String.Empty;
                    textbox_section.Text = String.Empty;

                    button1.Enabled = true;
                    button1.Enabled = false;
                    button1.Enabled = false;
                    DatabaseConnection.DatabaseClass.connect.Close();
                    refreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //update student
        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseConnection.DatabaseClass.connect.Open();
            DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_update_student(textbox_lrn.Text, textbox_firstName.Text, 
                textbox_lastName.Text, textbox_course.Text, textbox_section.Text, textbox_studNum.Text), DatabaseConnection.DatabaseClass.connect);
            MySqlDataReader reader;
            reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();
            MessageBox.Show("Student Updated!");
            //for clearing
            textbox_studNum.Text = String.Empty;
            textbox_lrn.Text = String.Empty;
            textbox_firstName.Text = String.Empty;
            textbox_lastName.Text = String.Empty;
            textbox_course.Text = String.Empty;
            textbox_section.Text = String.Empty;

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;

            textbox_studNum.Enabled = true;
            textbox_lrn.Enabled = true;
            DatabaseConnection.DatabaseClass.connect.Close();
            refreshForm();
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                DatabaseConnection.DatabaseClass.connect.Open();
                DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_delete_student(textbox_studNum.Text), DatabaseConnection.DatabaseClass.connect);
                MySqlDataReader reader;
                reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();
                MessageBox.Show("Student Deleted!");
                //for clearing
                textbox_studNum.Text = String.Empty;
                textbox_lrn.Text = String.Empty;
                textbox_firstName.Text = String.Empty;
                textbox_lastName.Text = String.Empty;
                textbox_course.Text = String.Empty;
                textbox_section.Text = String.Empty;

                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;

                refreshForm();
                DatabaseConnection.DatabaseClass.connect.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textbox_studNum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textbox_lrn.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textbox_firstName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textbox_lastName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textbox_course.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textbox_section.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            
            button2.Enabled = Enabled;
            button3.Enabled = Enabled;
            button1.Enabled = false;
            textbox_studNum.Enabled = false;
            textbox_lrn.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel?", "Message", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                textbox_studNum.Text = String.Empty;
                textbox_lrn.Text = String.Empty;
                textbox_firstName.Text = String.Empty;
                textbox_lastName.Text = String.Empty;
                textbox_course.Text = String.Empty;
                textbox_section.Text = String.Empty;

                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;

                textbox_studNum.Enabled = true;
                textbox_lrn.Enabled = true;
                refreshForm();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        //search
        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseConnection.DatabaseClass.connect.Close();
            //checks if empty
            if (String.IsNullOrEmpty(textbox_studSearch.Text) || textbox_studSearch.Text.Contains(" "))
            {
                MessageBox.Show("Student Number is Empty!", "Alert");
            }
            else
            {
                DatabaseConnection.DatabaseClass.connect.Open();
                DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_search_student(textbox_studSearch.Text), DatabaseConnection.DatabaseClass.connect);
                DatabaseConnection.DatabaseClass.adapter.SelectCommand = DatabaseConnection.DatabaseClass.command;
                DatabaseConnection.DatabaseClass.tableStudent.Clear();
                DatabaseConnection.DatabaseClass.adapter.Fill(DatabaseConnection.DatabaseClass.tableStudent);

                if (DatabaseConnection.DatabaseClass.tableStudent.Rows.Count > 0)
                {
                    try
                    {
                        dataGridView1.DataSource = DatabaseConnection.DatabaseClass.tableStudent;
                        DatabaseConnection.DatabaseClass.connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        DatabaseConnection.DatabaseClass.connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Student does not exist!", "Alert");
                    DatabaseConnection.DatabaseClass.connect.Close();
                }
            }



        }
    }
}
