namespace AlaaSchool_TimeTable
{
    partial class Teachers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formLabel = new System.Windows.Forms.Label();
            this.DetialsGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.TeacherIDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Countcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gendercolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.TeacherTextBox = new System.Windows.Forms.TextBox();
            this.ActiveComboBox = new System.Windows.Forms.ComboBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.DetialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeachers)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Size = new System.Drawing.Size(270, 640);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.DetialsGroupBox);
            this.leftPanel.Location = new System.Drawing.Point(270, 0);
            this.leftPanel.Size = new System.Drawing.Size(874, 640);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.DetialsGroupBox, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.formLabel);
            this.panel3.Size = new System.Drawing.Size(270, 60);
            this.panel3.Controls.SetChildIndex(this.BackButton, 0);
            this.panel3.Controls.SetChildIndex(this.formLabel, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(874, 60);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(746, 0);
            this.UsernameLabel.Text = "";
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(874, 55);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Size = new System.Drawing.Size(166, 25);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(270, 55);
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.Location = new System.Drawing.Point(219, 0);
            // 
            // formLabel
            // 
            this.formLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.formLabel.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.ForeColor = System.Drawing.Color.White;
            this.formLabel.Location = new System.Drawing.Point(0, 0);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(124, 60);
            this.formLabel.TabIndex = 8;
            this.formLabel.Text = "الأساتذة";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DetialsGroupBox
            // 
            this.DetialsGroupBox.Controls.Add(this.DataGridViewTeachers);
            this.DetialsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetialsGroupBox.Location = new System.Drawing.Point(0, 115);
            this.DetialsGroupBox.Name = "DetialsGroupBox";
            this.DetialsGroupBox.Size = new System.Drawing.Size(874, 525);
            this.DetialsGroupBox.TabIndex = 13;
            this.DetialsGroupBox.TabStop = false;
            this.DetialsGroupBox.Text = "تفاصيل";
            // 
            // DataGridViewTeachers
            // 
            this.DataGridViewTeachers.AllowUserToAddRows = false;
            this.DataGridViewTeachers.AllowUserToDeleteRows = false;
            this.DataGridViewTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewTeachers.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherIDcolumn,
            this.Countcolumn,
            this.Gendercolumn,
            this.TeacherColumn,
            this.Phonecolumn,
            this.Activecolumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTeachers.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewTeachers.Location = new System.Drawing.Point(3, 21);
            this.DataGridViewTeachers.Name = "DataGridViewTeachers";
            this.DataGridViewTeachers.ReadOnly = true;
            this.DataGridViewTeachers.RowHeadersVisible = false;
            this.DataGridViewTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTeachers.Size = new System.Drawing.Size(868, 501);
            this.DataGridViewTeachers.TabIndex = 0;
            this.DataGridViewTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTeachers_CellClick);
            // 
            // TeacherIDcolumn
            // 
            this.TeacherIDcolumn.HeaderText = "الأيدي";
            this.TeacherIDcolumn.Name = "TeacherIDcolumn";
            this.TeacherIDcolumn.ReadOnly = true;
            this.TeacherIDcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherIDcolumn.Visible = false;
            // 
            // Countcolumn
            // 
            this.Countcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Countcolumn.HeaderText = "الرقم";
            this.Countcolumn.Name = "Countcolumn";
            this.Countcolumn.ReadOnly = true;
            this.Countcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Countcolumn.Width = 56;
            // 
            // Gendercolumn
            // 
            this.Gendercolumn.HeaderText = "معلم/معلمة";
            this.Gendercolumn.Name = "Gendercolumn";
            this.Gendercolumn.ReadOnly = true;
            this.Gendercolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TeacherColumn
            // 
            this.TeacherColumn.HeaderText = "الإسم";
            this.TeacherColumn.Name = "TeacherColumn";
            this.TeacherColumn.ReadOnly = true;
            // 
            // Phonecolumn
            // 
            this.Phonecolumn.HeaderText = "الهاتف";
            this.Phonecolumn.Name = "Phonecolumn";
            this.Phonecolumn.ReadOnly = true;
            this.Phonecolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Activecolumn
            // 
            this.Activecolumn.HeaderText = "مغعل";
            this.Activecolumn.Name = "Activecolumn";
            this.Activecolumn.ReadOnly = true;
            this.Activecolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.GenderComboBox);
            this.panel5.Controls.Add(this.TeacherTextBox);
            this.panel5.Controls.Add(this.ActiveComboBox);
            this.panel5.Controls.Add(this.PhoneTextBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 525);
            this.panel5.TabIndex = 3;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "معلم",
            "معلمة",
            "-"});
            this.GenderComboBox.Location = new System.Drawing.Point(20, 46);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(227, 24);
            this.GenderComboBox.TabIndex = 37;
            // 
            // TeacherTextBox
            // 
            this.TeacherTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherTextBox.Location = new System.Drawing.Point(21, 90);
            this.TeacherTextBox.MaxLength = 25;
            this.TeacherTextBox.Name = "TeacherTextBox";
            this.TeacherTextBox.Size = new System.Drawing.Size(227, 24);
            this.TeacherTextBox.TabIndex = 38;
            // 
            // ActiveComboBox
            // 
            this.ActiveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveComboBox.FormattingEnabled = true;
            this.ActiveComboBox.Items.AddRange(new object[] {
            "نعم",
            "لا"});
            this.ActiveComboBox.Location = new System.Drawing.Point(21, 183);
            this.ActiveComboBox.Name = "ActiveComboBox";
            this.ActiveComboBox.Size = new System.Drawing.Size(227, 24);
            this.ActiveComboBox.TabIndex = 40;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(21, 135);
            this.PhoneTextBox.MaxLength = 25;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(227, 24);
            this.PhoneTextBox.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "معلم/معلمة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "الإسم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "مغعل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "الهاتف";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlaaSchool_TimeTable.Properties.Resources.user_128;
            this.pictureBox1.Location = new System.Drawing.Point(73, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 100);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 640);
            this.Name = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.DetialsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTeachers)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.GroupBox DetialsGroupBox;
        private System.Windows.Forms.DataGridView DataGridViewTeachers;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.TextBox TeacherTextBox;
        private System.Windows.Forms.ComboBox ActiveComboBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherIDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Countcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gendercolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activecolumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}