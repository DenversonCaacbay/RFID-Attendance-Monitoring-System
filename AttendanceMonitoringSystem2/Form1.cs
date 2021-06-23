﻿using System;
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


namespace AttendanceMonitoringSystem2
{
    public partial class Form1 : Form
    {
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
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0,Width,Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //iconButton1.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,iconButton1.Width,iconButton1.Height,20,20));
            //iconButton2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, iconButton2.Width, iconButton1.Height, 20, 20));

            label8.Text = DateTime.Now.ToString("hh:mm tt"); //result 11:11:45 PM
            label9.Text = DateTime.Now.ToShortDateString(); //30.5.2012

            attendance1.Show();
            manage1.Hide();

            
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

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            attendance1.Show();
            manage1.Hide();

            panel4.Show();
            panel5.Hide();
            panel7.Hide();
            panel6.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            attendance1.Hide();
            manage1.Show();

            panel4.Hide();
            panel5.Show();
            panel7.Hide();
            panel6.Hide();
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
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
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

            panel4.Hide();
            panel5.Hide();
            panel7.Show();
            panel6.Hide();
        }
    }
}