namespace AlaaSchool_TimeTable
{
    partial class HomePage
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
            this.FormLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimeTableFormButton = new System.Windows.Forms.Button();
            this.AssignmentsFormButton = new System.Windows.Forms.Button();
            this.SubjectsFormButton = new System.Windows.Forms.Button();
            this.TeachersFormButton = new System.Windows.Forms.Button();
            this.UsersFormButton = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(270, 616);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(270, 556);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FormLabel);
            this.panel3.Size = new System.Drawing.Size(270, 60);
            // 
            // leftPanel
            // 
            this.leftPanel.Location = new System.Drawing.Point(270, 0);
            this.leftPanel.Size = new System.Drawing.Size(874, 616);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel1);
            this.panel6.Size = new System.Drawing.Size(874, 556);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(874, 60);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(725, 0);
            this.UsernameLabel.Size = new System.Drawing.Size(149, 60);
            this.UsernameLabel.Text = "";
            // 
            // FormLabel
            // 
            this.FormLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FormLabel.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.ForeColor = System.Drawing.Color.White;
            this.FormLabel.Location = new System.Drawing.Point(0, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(240, 60);
            this.FormLabel.TabIndex = 7;
            this.FormLabel.Text = "الأساسية";
            this.FormLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.TimeTableFormButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AssignmentsFormButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SubjectsFormButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TeachersFormButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UsersFormButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 556);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TimeTableFormButton
            // 
            this.TimeTableFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeTableFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeTableFormButton.FlatAppearance.BorderSize = 2;
            this.TimeTableFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeTableFormButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTableFormButton.Location = new System.Drawing.Point(659, 114);
            this.TimeTableFormButton.Name = "TimeTableFormButton";
            this.TimeTableFormButton.Size = new System.Drawing.Size(212, 105);
            this.TimeTableFormButton.TabIndex = 4;
            this.TimeTableFormButton.Text = "عرض الجدول";
            this.TimeTableFormButton.UseVisualStyleBackColor = true;
            this.TimeTableFormButton.Click += new System.EventHandler(this.TimeTableFormButton_Click);
            // 
            // AssignmentsFormButton
            // 
            this.AssignmentsFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignmentsFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignmentsFormButton.FlatAppearance.BorderSize = 2;
            this.AssignmentsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignmentsFormButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentsFormButton.Location = new System.Drawing.Point(3, 3);
            this.AssignmentsFormButton.Name = "AssignmentsFormButton";
            this.AssignmentsFormButton.Size = new System.Drawing.Size(214, 105);
            this.AssignmentsFormButton.TabIndex = 3;
            this.AssignmentsFormButton.Text = "إدارة الحصص";
            this.AssignmentsFormButton.UseVisualStyleBackColor = true;
            this.AssignmentsFormButton.Click += new System.EventHandler(this.AssignmentsFormButton_Click);
            // 
            // SubjectsFormButton
            // 
            this.SubjectsFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubjectsFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectsFormButton.FlatAppearance.BorderSize = 2;
            this.SubjectsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectsFormButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectsFormButton.Location = new System.Drawing.Point(223, 3);
            this.SubjectsFormButton.Name = "SubjectsFormButton";
            this.SubjectsFormButton.Size = new System.Drawing.Size(212, 105);
            this.SubjectsFormButton.TabIndex = 2;
            this.SubjectsFormButton.Text = "المواد";
            this.SubjectsFormButton.UseVisualStyleBackColor = true;
            this.SubjectsFormButton.Click += new System.EventHandler(this.SubjectsFormButton_Click);
            // 
            // TeachersFormButton
            // 
            this.TeachersFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeachersFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeachersFormButton.FlatAppearance.BorderSize = 2;
            this.TeachersFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeachersFormButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeachersFormButton.Location = new System.Drawing.Point(441, 3);
            this.TeachersFormButton.Name = "TeachersFormButton";
            this.TeachersFormButton.Size = new System.Drawing.Size(212, 105);
            this.TeachersFormButton.TabIndex = 1;
            this.TeachersFormButton.Text = "المعلمين";
            this.TeachersFormButton.UseVisualStyleBackColor = true;
            this.TeachersFormButton.Click += new System.EventHandler(this.TeachersFormButton_Click);
            // 
            // UsersFormButton
            // 
            this.UsersFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersFormButton.FlatAppearance.BorderSize = 2;
            this.UsersFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersFormButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersFormButton.Location = new System.Drawing.Point(659, 3);
            this.UsersFormButton.Name = "UsersFormButton";
            this.UsersFormButton.Size = new System.Drawing.Size(212, 105);
            this.UsersFormButton.TabIndex = 0;
            this.UsersFormButton.Text = "المستخدمين";
            this.UsersFormButton.UseVisualStyleBackColor = true;
            this.UsersFormButton.Click += new System.EventHandler(this.usersFormButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 616);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button TimeTableFormButton;
        private System.Windows.Forms.Button AssignmentsFormButton;
        private System.Windows.Forms.Button SubjectsFormButton;
        private System.Windows.Forms.Button TeachersFormButton;
        private System.Windows.Forms.Button UsersFormButton;
    }
}