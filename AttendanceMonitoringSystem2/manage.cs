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
            connect.Close();
            try
            {
                table.Clear();
                connect.Open();
                command = new MySqlCommand(sql_showStudent, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                connect.Close();
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
            connect.Open();
            command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_checker_student(textbox_firstName.Text, textbox_lastName.Text), connect);
            MySqlDataReader reader;
            reader = command.ExecuteReader();

            if (textbox_studNum.Text == "" || textbox_lrn.Text == "" || textbox_firstName.Text == "" || textbox_lastName.Text == "" || textbox_course.Text == "" || textbox_section.Text == "")
            {
                MessageBox.Show("PLEASE COMPLETE THE FORM !");
            }
            else if (reader.HasRows)
            {
                connect.Close();
                MessageBox.Show("Student Already Existed!");
            }
            else
            {
                connect.Close();
                try
                {
                    connect.Open();
                    command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_insert_student(textbox_studNum.Text,
                        textbox_lrn.Text, textbox_firstName.Text, textbox_lastName.Text, textbox_course.Text, textbox_section.Text), connect);
                    MySqlDataReader reader2;
                    reader2 = command.ExecuteReader();
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
                    connect.Close();
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
            connect.Open();
            command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_update_student(textbox_lrn.Text, textbox_firstName.Text, 
                textbox_lastName.Text, textbox_course.Text, textbox_section.Text, textbox_studNum.Text), connect);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
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
            connect.Close();
            refreshForm();
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                connect.Open();
                command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_delete_student(textbox_studNum.Text), connect);
                MySqlDataReader reader;
                reader = command.ExecuteReader();
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
                connect.Close();
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
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();
                command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_search_student(textbox_studNum.Text), connect);
                MySqlDataReader reader2;
                reader2 = command.ExecuteReader();
        }
    }
}
