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
    public partial class record : UserControl
    {
        /*
        DataTable dt = new DataTable();

        public static void ExportToExcel(DataTable dt, string filename)
        {
            StreamWriter wr = new StreamWriter(@"c:\LogRecordsAttendance\" + filename + ".xlsx");
            try
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
                }

                wr.WriteLine();

                //write rows to excel file
                for (int i = 0; i < (dt.Rows.Count); i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Rows[i][j] != null)
                        {
                            wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                        }
                        else
                        {
                            wr.Write("\t");
                        }
                    }
                    //go to next line
                    wr.WriteLine();
                }
                //close file
                wr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        */
        public record()
        {
            InitializeComponent();
            DatabaseConnection.DatabaseClass.recordSetup();
        }

        public void refreshForm()
        {
            DatabaseConnection.DatabaseClass.connect.Close();
            try
            {
                DatabaseConnection.DatabaseClass.tableRecord.Clear();
                DatabaseConnection.DatabaseClass.connect.Open();
                DatabaseConnection.DatabaseClass.command = new MySqlCommand(DatabaseConnection.DatabaseClass.showLogs, DatabaseConnection.DatabaseClass.connect);
                DatabaseConnection.DatabaseClass.adapter.SelectCommand = DatabaseConnection.DatabaseClass.command;
                DatabaseConnection.DatabaseClass.adapter.Fill(DatabaseConnection.DatabaseClass.tableRecord);

                dataGridView1.DataSource = DatabaseConnection.DatabaseClass.tableRecord;
                DatabaseConnection.DatabaseClass.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void record_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // ExportToExcel(dt, "FileName");
            
            DialogResult dr = MessageBox.Show("Do you want to Print the Records.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes && dataGridView1.Rows.Count > 0)
            {
                
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();

                xcelApp.Application.Workbooks.Add(Type.Missing);

                string date = DateTime.Now.ToString("dd-M-yyyy");

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
                while (dataGridView1.Rows.Count > 0)
                {
                    DatabaseConnection.DatabaseClass.connect.Open();
                    MySqlCommand command = new MySqlCommand(DatabaseConnection.DatabaseClass.sql_delete_attendance(dataGridView1.Rows[0].Cells[0].Value.ToString()), DatabaseConnection.DatabaseClass.connect);
                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    DatabaseConnection.DatabaseClass.connect.Close();
                    //Console.WriteLine(dataGridView1.Rows[0].Cells[0].Value.ToString());
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                }

                xcelApp.Application.ActiveWorkbook.SaveAs(date+".xls");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshForm();
        }
    }
}
