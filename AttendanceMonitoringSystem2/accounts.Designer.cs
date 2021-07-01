namespace AttendanceMonitoringSystem2
{
    partial class accounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_adminPassword = new System.Windows.Forms.TextBox();
            this.textbox_adminUsername = new System.Windows.Forms.TextBox();
            this.textbox_adminID = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_admin_delete = new System.Windows.Forms.Button();
            this.btn_admin_update = new System.Windows.Forms.Button();
            this.btn_admin_new = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(27, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "USERNAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID :";
            // 
            // textbox_adminPassword
            // 
            this.textbox_adminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_adminPassword.Location = new System.Drawing.Point(32, 264);
            this.textbox_adminPassword.Name = "textbox_adminPassword";
            this.textbox_adminPassword.PasswordChar = '*';
            this.textbox_adminPassword.Size = new System.Drawing.Size(209, 31);
            this.textbox_adminPassword.TabIndex = 37;
            // 
            // textbox_adminUsername
            // 
            this.textbox_adminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_adminUsername.Location = new System.Drawing.Point(32, 162);
            this.textbox_adminUsername.Name = "textbox_adminUsername";
            this.textbox_adminUsername.Size = new System.Drawing.Size(209, 31);
            this.textbox_adminUsername.TabIndex = 36;
            // 
            // textbox_adminID
            // 
            this.textbox_adminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_adminID.Location = new System.Drawing.Point(32, 63);
            this.textbox_adminID.Name = "textbox_adminID";
            this.textbox_adminID.Size = new System.Drawing.Size(209, 31);
            this.textbox_adminID.TabIndex = 35;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btn_cancel.Location = new System.Drawing.Point(607, 318);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 39);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_admin_delete
            // 
            this.btn_admin_delete.BackColor = System.Drawing.Color.White;
            this.btn_admin_delete.Enabled = false;
            this.btn_admin_delete.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btn_admin_delete.Location = new System.Drawing.Point(501, 318);
            this.btn_admin_delete.Name = "btn_admin_delete";
            this.btn_admin_delete.Size = new System.Drawing.Size(82, 39);
            this.btn_admin_delete.TabIndex = 33;
            this.btn_admin_delete.Text = "DELETE";
            this.btn_admin_delete.UseVisualStyleBackColor = false;
            // 
            // btn_admin_update
            // 
            this.btn_admin_update.BackColor = System.Drawing.Color.White;
            this.btn_admin_update.Enabled = false;
            this.btn_admin_update.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btn_admin_update.Location = new System.Drawing.Point(395, 318);
            this.btn_admin_update.Name = "btn_admin_update";
            this.btn_admin_update.Size = new System.Drawing.Size(82, 39);
            this.btn_admin_update.TabIndex = 32;
            this.btn_admin_update.Text = "UPDATE";
            this.btn_admin_update.UseVisualStyleBackColor = false;
            // 
            // btn_admin_new
            // 
            this.btn_admin_new.BackColor = System.Drawing.Color.White;
            this.btn_admin_new.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btn_admin_new.Location = new System.Drawing.Point(289, 318);
            this.btn_admin_new.Name = "btn_admin_new";
            this.btn_admin_new.Size = new System.Drawing.Size(82, 39);
            this.btn_admin_new.TabIndex = 31;
            this.btn_admin_new.Text = "ADD NEW";
            this.btn_admin_new.UseVisualStyleBackColor = false;
            this.btn_admin_new.Click += new System.EventHandler(this.btn_admin_new_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(284, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(409, 272);
            this.dataGridView1.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "admin_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "username";
            this.Column2.HeaderText = "USERNAME";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "password";
            this.Column3.HeaderText = "PASSWORD";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "admin_access";
            this.Column4.HeaderText = "Admin Access";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_adminPassword);
            this.Controls.Add(this.textbox_adminUsername);
            this.Controls.Add(this.textbox_adminID);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_admin_delete);
            this.Controls.Add(this.btn_admin_update);
            this.Controls.Add(this.btn_admin_new);
            this.Controls.Add(this.dataGridView1);
            this.Name = "accounts";
            this.Size = new System.Drawing.Size(730, 382);
            this.Load += new System.EventHandler(this.accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_adminPassword;
        private System.Windows.Forms.TextBox textbox_adminUsername;
        private System.Windows.Forms.TextBox textbox_adminID;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_admin_delete;
        private System.Windows.Forms.Button btn_admin_update;
        private System.Windows.Forms.Button btn_admin_new;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
