﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AttendanceMonitoringSystem2
{
    public partial class accounts : UserControl
    {
        public accounts()
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

        //new admin
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void accounts_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

    }

}
