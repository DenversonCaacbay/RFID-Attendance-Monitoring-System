using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AttendanceMonitoringSystem2
{
    public partial class m_account : Form
    {
       

        public m_account()
        {
            InitializeComponent();
            DatabaseConnection.DatabaseClass.accountSetup();
        }
        public void refreshForm()
        {
            DatabaseConnection.DatabaseClass.connect.Close();
            try
            {
                DatabaseConnection.DatabaseClass.tableAdmin.Clear();
                DatabaseConnection.DatabaseClass.connect.Open();
                DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.showAdmin, DatabaseConnection.DatabaseClass.connect);
                DatabaseConnection.DatabaseClass.adapter.SelectCommand = DatabaseConnection.DatabaseClass.command;
                DatabaseConnection.DatabaseClass.adapter.Fill(DatabaseConnection.DatabaseClass.tableAdmin);

                dataGridView1.DataSource = DatabaseConnection.DatabaseClass.tableAdmin;
                DatabaseConnection.DatabaseClass.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void m_account_Load(object sender, EventArgs e)
        {
            refreshForm();
            btn_admin_update.Enabled = false;
            btn_admin_delete.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_admin_new.Enabled = true;
            btn_admin_update.Enabled = false;
            btn_admin_delete.Enabled = false;

            textbox_adminID.Enabled = false;
            textbox_adminUsername.Enabled = true;
            textbox_adminPassword.Enabled = true;
            textbox_adminID.Text = String.Empty;
            textbox_adminUsername.Text = String.Empty;
            textbox_adminPassword.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void btn_admin_new_Click(object sender, EventArgs e)
        {

           
            DatabaseConnection.DatabaseClass.connect.Open();
            DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_checker_admin(textbox_adminUsername.Text, textbox_adminPassword.Text), DatabaseConnection.DatabaseClass.connect);
            MySqlDataReader reader;
            reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();
            
            if (String.IsNullOrEmpty(textbox_adminUsername.Text) && String.IsNullOrEmpty(textbox_adminUsername.Text) || textbox_adminUsername.Text.Contains(" ") && textbox_adminPassword.Text.Contains(" "))
            {
                DatabaseConnection.DatabaseClass.connect.Close();
                MessageBox.Show("Username and Password is Empty!", "Alert");
            }
            else if (reader.HasRows)
            {
                DatabaseConnection.DatabaseClass.connect.Close();
                MessageBox.Show("Admin already existed!", "Alert");
                textbox_adminUsername.Text = String.Empty;
                textbox_adminPassword.Text = String.Empty;
            }
            else if (DatabaseConnection.DatabaseClass.tableAdmin.Rows.Count >= 3)
            {
                DatabaseConnection.DatabaseClass.connect.Close();
                MessageBox.Show("Admin account limit has exceeded!", "Alert");
                textbox_adminUsername.Text = String.Empty;
                textbox_adminPassword.Text = String.Empty;
            }
            else
            {
                DatabaseConnection.DatabaseClass.connect.Close();
                try
                {
                    DatabaseConnection.DatabaseClass.connect.Open();
                    DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_insert_admin(textbox_adminUsername.Text, textbox_adminPassword.Text), DatabaseConnection.DatabaseClass.connect);
                    MySqlDataReader reader2;
                    reader2 = DatabaseConnection.DatabaseClass.command.ExecuteReader();
                    MessageBox.Show("Admin Created!");
                    //clear
                    textbox_adminUsername.Text = String.Empty;
                    textbox_adminPassword.Text = String.Empty;
                    refreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_admin_delete_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    DatabaseConnection.DatabaseClass.connect.Open();
                    DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_delete_admin(textbox_adminID.Text), DatabaseConnection.DatabaseClass.connect);
                    MySqlDataReader reader;
                    reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();
                    MessageBox.Show("Admin Deleted!", "Message");

                    textbox_adminID.Text = String.Empty;
                    textbox_adminUsername.Text = String.Empty;
                    textbox_adminPassword.Text = String.Empty;
                    refreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            textbox_adminID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textbox_adminUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textbox_adminPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            textbox_adminID.Enabled = false;
            */
        }

        private void btn_admin_update_Click(object sender, EventArgs e)
        {

            try
            {
                DatabaseConnection.DatabaseClass.connect.Open();
                DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_update_admin(textbox_adminUsername.Text, textbox_adminPassword.Text, textbox_adminID.Text), DatabaseConnection.DatabaseClass.connect);
                MySqlDataReader reader;
                reader = DatabaseConnection.DatabaseClass.command.ExecuteReader();


                MessageBox.Show("Admin Updated!", "Message");
                textbox_adminID.Text = String.Empty;
                textbox_adminUsername.Text = String.Empty;
                textbox_adminPassword.Text = String.Empty;
                refreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex == 0)
                {
                    textbox_adminID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textbox_adminUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textbox_adminPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                    btn_admin_new.Enabled = false;
                    btn_admin_delete.Enabled = false;
                    btn_admin_update.Enabled = false;

                    textbox_adminPassword.Enabled = false;
                    textbox_adminUsername.Enabled = false;
                    textbox_adminID.Enabled = false;
                }
                else
                {
                    textbox_adminID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textbox_adminUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textbox_adminPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                    btn_admin_new.Enabled = false;
                    btn_admin_delete.Enabled = true;
                    btn_admin_update.Enabled = true;

                    textbox_adminPassword.Enabled = true;
                    textbox_adminUsername.Enabled = true;
                    textbox_adminID.Enabled = false;
                }
            }
           
            
            //button3.Enabled = Enabled;
            // button1.Enabled = false;

            else
            { 
            
            }
        }

        private void textbox_adminID_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textbox_adminUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_adminPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
