namespace AlaaSchool_TimeTable
{
    partial class AssignmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.PeriodComboBox = new System.Windows.Forms.ComboBox();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.TeacherComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DetialsGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGridViewAssignments = new System.Windows.Forms.DataGridView();
            this.Countcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentIDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimingIDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daycolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sectioncolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassIDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectIDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subjectcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodIDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherIDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teachercolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoysRadio = new System.Windows.Forms.RadioButton();
            this.GirlsRadio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.DetialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAssignments)).BeginInit();
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.GirlsRadio);
            this.panel2.Controls.Add(this.BoysRadio);
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
            this.formLabel.TabIndex = 10;
            this.formLabel.Text = "إدارة الحصص";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.SubjectComboBox);
            this.panel5.Controls.Add(this.PeriodComboBox);
            this.panel5.Controls.Add(this.ClassComboBox);
            this.panel5.Controls.Add(this.TeacherComboBox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 525);
            this.panel5.TabIndex = 3;
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Location = new System.Drawing.Point(20, 135);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(227, 24);
            this.SubjectComboBox.TabIndex = 45;
            // 
            // PeriodComboBox
            // 
            this.PeriodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeriodComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodComboBox.FormattingEnabled = true;
            this.PeriodComboBox.Location = new System.Drawing.Point(20, 90);
            this.PeriodComboBox.Name = "PeriodComboBox";
            this.PeriodComboBox.Size = new System.Drawing.Size(227, 24);
            this.PeriodComboBox.TabIndex = 43;
            this.PeriodComboBox.TextChanged += new System.EventHandler(this.PeriodComboBox_TextChanged);
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(20, 46);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(227, 24);
            this.ClassComboBox.TabIndex = 41;
            // 
            // TeacherComboBox
            // 
            this.TeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherComboBox.FormattingEnabled = true;
            this.TeacherComboBox.Location = new System.Drawing.Point(20, 179);
            this.TeacherComboBox.Name = "TeacherComboBox";
            this.TeacherComboBox.Size = new System.Drawing.Size(227, 24);
            this.TeacherComboBox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "الحصة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "الفصل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "المادة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "معلم/معلمة";
            // 
            // DetialsGroupBox
            // 
            this.DetialsGroupBox.Controls.Add(this.DataGridViewAssignments);
            this.DetialsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetialsGroupBox.Location = new System.Drawing.Point(0, 115);
            this.DetialsGroupBox.Name = "DetialsGroupBox";
            this.DetialsGroupBox.Size = new System.Drawing.Size(874, 525);
            this.DetialsGroupBox.TabIndex = 15;
            this.DetialsGroupBox.TabStop = false;
            this.DetialsGroupBox.Text = "تفاصيل";
            // 
            // DataGridViewAssignments
            // 
            this.DataGridViewAssignments.AllowUserToAddRows = false;
            this.DataGridViewAssignments.AllowUserToDeleteRows = false;
            this.DataGridViewAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewAssignments.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Countcolumn,
            this.AssignmentIDcolumn,
            this.TimingIDcolumn,
            this.Daycolumn,
            this.Sectioncolumn,
            this.ClassIDcolumn,
            this.Classcolumn,
            this.SubjectIDcolumn,
            this.Subjectcolumn,
            this.PeriodIDcolumn,
            this.Periodcolumn,
            this.TeacherIDcolumn,
            this.Teachercolumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewAssignments.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewAssignments.Location = new System.Drawing.Point(3, 21);
            this.DataGridViewAssignments.Name = "DataGridViewAssignments";
            this.DataGridViewAssignments.ReadOnly = true;
            this.DataGridViewAssignments.RowHeadersVisible = false;
            this.DataGridViewAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAssignments.Size = new System.Drawing.Size(868, 501);
            this.DataGridViewAssignments.TabIndex = 0;
            this.DataGridViewAssignments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAssignments_CellClick);
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
            // AssignmentIDcolumn
            // 
            this.AssignmentIDcolumn.HeaderText = "الأيدي";
            this.AssignmentIDcolumn.Name = "AssignmentIDcolumn";
            this.AssignmentIDcolumn.ReadOnly = true;
            this.AssignmentIDcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AssignmentIDcolumn.Visible = false;
            // 
            // TimingIDcolumn
            // 
            this.TimingIDcolumn.HeaderText = "أيدي التوقيت";
            this.TimingIDcolumn.Name = "TimingIDcolumn";
            this.TimingIDcolumn.ReadOnly = true;
            this.TimingIDcolumn.Visible = false;
            // 
            // Daycolumn
            // 
            this.Daycolumn.HeaderText = "اليوم";
            this.Daycolumn.Name = "Daycolumn";
            this.Daycolumn.ReadOnly = true;
            this.Daycolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sectioncolumn
            // 
            this.Sectioncolumn.HeaderText = "أيدي القسم";
            this.Sectioncolumn.Name = "Sectioncolumn";
            this.Sectioncolumn.ReadOnly = true;
            this.Sectioncolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sectioncolumn.Visible = false;
            // 
            // ClassIDcolumn
            // 
            this.ClassIDcolumn.HeaderText = "أيدي الفصل";
            this.ClassIDcolumn.Name = "ClassIDcolumn";
            this.ClassIDcolumn.ReadOnly = true;
            this.ClassIDcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassIDcolumn.Visible = false;
            // 
            // Classcolumn
            // 
            this.Classcolumn.HeaderText = "الفصل";
            this.Classcolumn.Name = "Classcolumn";
            this.Classcolumn.ReadOnly = true;
            this.Classcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SubjectIDcolumn
            // 
            this.SubjectIDcolumn.HeaderText = "أيدي المادة";
            this.SubjectIDcolumn.Name = "SubjectIDcolumn";
            this.SubjectIDcolumn.ReadOnly = true;
            this.SubjectIDcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectIDcolumn.Visible = false;
            // 
            // Subjectcolumn
            // 
            this.Subjectcolumn.HeaderText = "المادة";
            this.Subjectcolumn.Name = "Subjectcolumn";
            this.Subjectcolumn.ReadOnly = true;
            this.Subjectcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PeriodIDcolumn
            // 
            this.PeriodIDcolumn.HeaderText = "أيدي الحصه";
            this.PeriodIDcolumn.Name = "PeriodIDcolumn";
            this.PeriodIDcolumn.ReadOnly = true;
            this.PeriodIDcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PeriodIDcolumn.Visible = false;
            // 
            // Periodcolumn
            // 
            this.Periodcolumn.HeaderText = "الحصه";
            this.Periodcolumn.Name = "Periodcolumn";
            this.Periodcolumn.ReadOnly = true;
            this.Periodcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TeacherIDcolumn
            // 
            this.TeacherIDcolumn.HeaderText = "أيدي المعلم";
            this.TeacherIDcolumn.Name = "TeacherIDcolumn";
            this.TeacherIDcolumn.ReadOnly = true;
            this.TeacherIDcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherIDcolumn.Visible = false;
            // 
            // Teachercolumn
            // 
            this.Teachercolumn.HeaderText = "معلم\\معلمة";
            this.Teachercolumn.Name = "Teachercolumn";
            this.Teachercolumn.ReadOnly = true;
            this.Teachercolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BoysRadio
            // 
            this.BoysRadio.AutoSize = true;
            this.BoysRadio.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoysRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BoysRadio.Location = new System.Drawing.Point(103, 16);
            this.BoysRadio.Name = "BoysRadio";
            this.BoysRadio.Size = new System.Drawing.Size(47, 23);
            this.BoysRadio.TabIndex = 0;
            this.BoysRadio.TabStop = true;
            this.BoysRadio.Text = "بنين";
            this.BoysRadio.UseVisualStyleBackColor = true;
            this.BoysRadio.CheckedChanged += new System.EventHandler(this.BoysRadio_CheckedChanged);
            // 
            // GirlsRadio
            // 
            this.GirlsRadio.AutoSize = true;
            this.GirlsRadio.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirlsRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GirlsRadio.Location = new System.Drawing.Point(47, 16);
            this.GirlsRadio.Name = "GirlsRadio";
            this.GirlsRadio.Size = new System.Drawing.Size(50, 23);
            this.GirlsRadio.TabIndex = 49;
            this.GirlsRadio.TabStop = true;
            this.GirlsRadio.Text = "بنات";
            this.GirlsRadio.UseVisualStyleBackColor = true;
            this.GirlsRadio.CheckedChanged += new System.EventHandler(this.GirlsRadio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(156, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "إخنتار القسم :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 640);
            this.Name = "AssignmentsForm";
            this.Load += new System.EventHandler(this.AssignmentsForm_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.DetialsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox TeacherComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PeriodComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SubjectComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox DetialsGroupBox;
        private System.Windows.Forms.DataGridView DataGridViewAssignments;
        private System.Windows.Forms.RadioButton GirlsRadio;
        private System.Windows.Forms.RadioButton BoysRadio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Countcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentIDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimingIDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daycolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sectioncolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassIDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectIDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjectcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodIDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherIDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teachercolumn;
        private System.Windows.Forms.Button button1;
    }
}