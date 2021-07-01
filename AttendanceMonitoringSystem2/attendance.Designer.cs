namespace AttendanceMonitoringSystem2
{
    partial class attendance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textbox_StudSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_studNumber = new System.Windows.Forms.TextBox();
            this.textbox_lrn = new System.Windows.Forms.TextBox();
            this.textbox_firstName = new System.Windows.Forms.TextBox();
            this.textbox_lastName = new System.Windows.Forms.TextBox();
            this.textbox_course = new System.Windows.Forms.TextBox();
            this.textbox_section = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_student = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_StudSearch
            // 
            this.textbox_StudSearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_StudSearch.Location = new System.Drawing.Point(442, 89);
            this.textbox_StudSearch.Name = "textbox_StudSearch";
            this.textbox_StudSearch.Size = new System.Drawing.Size(451, 36);
            this.textbox_StudSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(442, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Student Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(71, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Number :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(71, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "LRN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(71, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(71, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(76, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Course :";
            // 
            // textbox_studNumber
            // 
            this.textbox_studNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_studNumber.Location = new System.Drawing.Point(76, 89);
            this.textbox_studNumber.Name = "textbox_studNumber";
            this.textbox_studNumber.ReadOnly = true;
            this.textbox_studNumber.Size = new System.Drawing.Size(274, 36);
            this.textbox_studNumber.TabIndex = 8;
            // 
            // textbox_lrn
            // 
            this.textbox_lrn.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_lrn.Location = new System.Drawing.Point(76, 171);
            this.textbox_lrn.Name = "textbox_lrn";
            this.textbox_lrn.ReadOnly = true;
            this.textbox_lrn.Size = new System.Drawing.Size(274, 36);
            this.textbox_lrn.TabIndex = 9;
            // 
            // textbox_firstName
            // 
            this.textbox_firstName.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_firstName.Location = new System.Drawing.Point(76, 259);
            this.textbox_firstName.Name = "textbox_firstName";
            this.textbox_firstName.ReadOnly = true;
            this.textbox_firstName.Size = new System.Drawing.Size(274, 36);
            this.textbox_firstName.TabIndex = 10;
            this.textbox_firstName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textbox_lastName
            // 
            this.textbox_lastName.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_lastName.Location = new System.Drawing.Point(76, 346);
            this.textbox_lastName.Name = "textbox_lastName";
            this.textbox_lastName.ReadOnly = true;
            this.textbox_lastName.Size = new System.Drawing.Size(274, 36);
            this.textbox_lastName.TabIndex = 11;
            // 
            // textbox_course
            // 
            this.textbox_course.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_course.Location = new System.Drawing.Point(76, 436);
            this.textbox_course.Name = "textbox_course";
            this.textbox_course.ReadOnly = true;
            this.textbox_course.Size = new System.Drawing.Size(274, 36);
            this.textbox_course.TabIndex = 12;
            // 
            // textbox_section
            // 
            this.textbox_section.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_section.Location = new System.Drawing.Point(76, 532);
            this.textbox_section.Name = "textbox_section";
            this.textbox_section.ReadOnly = true;
            this.textbox_section.Size = new System.Drawing.Size(274, 36);
            this.textbox_section.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(76, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Section";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::AttendanceMonitoringSystem2.Properties.Resources.Student;
            this.pictureBox1.Location = new System.Drawing.Point(442, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // search_student
            // 
            this.search_student.BackColor = System.Drawing.Color.White;
            this.search_student.FlatAppearance.BorderSize = 0;
            this.search_student.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.search_student.Location = new System.Drawing.Point(778, 89);
            this.search_student.Name = "search_student";
            this.search_student.Size = new System.Drawing.Size(115, 36);
            this.search_student.TabIndex = 21;
            this.search_student.Text = "SEARCH";
            this.search_student.UseVisualStyleBackColor = false;
            this.search_student.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(480, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_student);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbox_section);
            this.Controls.Add(this.textbox_course);
            this.Controls.Add(this.textbox_lastName);
            this.Controls.Add(this.textbox_firstName);
            this.Controls.Add(this.textbox_lrn);
            this.Controls.Add(this.textbox_studNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_StudSearch);
            this.Name = "attendance";
            this.Size = new System.Drawing.Size(1000, 704);
            this.Load += new System.EventHandler(this.attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textbox_StudSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_studNumber;
        private System.Windows.Forms.TextBox textbox_lrn;
        private System.Windows.Forms.TextBox textbox_firstName;
        private System.Windows.Forms.TextBox textbox_lastName;
        private System.Windows.Forms.TextBox textbox_course;
        private System.Windows.Forms.TextBox textbox_section;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search_student;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}
