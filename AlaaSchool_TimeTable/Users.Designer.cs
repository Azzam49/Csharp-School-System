namespace AlaaSchool_TimeTable
{
    partial class Users
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
            this.DetialsGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.UserIDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Countcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usernamecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwordcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Positioncolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ActiveComboBox = new System.Windows.Forms.ComboBox();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.DetialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Size = new System.Drawing.Size(270, 640);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
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
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Size = new System.Drawing.Size(270, 54);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.Controls.SetChildIndex(this.BackButton, 0);
            this.panel3.Controls.SetChildIndex(this.formLabel, 0);
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
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(874, 55);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTextBox.Size = new System.Drawing.Size(166, 25);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Size = new System.Drawing.Size(270, 55);
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.Location = new System.Drawing.Point(219, 0);
            this.BackButton.Size = new System.Drawing.Size(51, 54);
            // 
            // formLabel
            // 
            this.formLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.formLabel.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.ForeColor = System.Drawing.Color.White;
            this.formLabel.Location = new System.Drawing.Point(0, 0);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(124, 54);
            this.formLabel.TabIndex = 7;
            this.formLabel.Text = "المستخدمين";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DetialsGroupBox
            // 
            this.DetialsGroupBox.Controls.Add(this.DataGridViewUsers);
            this.DetialsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetialsGroupBox.Location = new System.Drawing.Point(0, 115);
            this.DetialsGroupBox.Name = "DetialsGroupBox";
            this.DetialsGroupBox.Size = new System.Drawing.Size(874, 525);
            this.DetialsGroupBox.TabIndex = 12;
            this.DetialsGroupBox.TabStop = false;
            this.DetialsGroupBox.Text = "تفاصيل";
            // 
            // DataGridViewUsers
            // 
            this.DataGridViewUsers.AllowUserToAddRows = false;
            this.DataGridViewUsers.AllowUserToDeleteRows = false;
            this.DataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIDcolumn,
            this.Countcolumn,
            this.Usernamecolumn,
            this.Passwordcolumn,
            this.Positioncolumn,
            this.Activecolumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewUsers.Location = new System.Drawing.Point(3, 21);
            this.DataGridViewUsers.Name = "DataGridViewUsers";
            this.DataGridViewUsers.ReadOnly = true;
            this.DataGridViewUsers.RowHeadersVisible = false;
            this.DataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUsers.Size = new System.Drawing.Size(868, 501);
            this.DataGridViewUsers.TabIndex = 0;
            this.DataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsers_CellClick);
            // 
            // UserIDcolumn
            // 
            this.UserIDcolumn.HeaderText = "الأيدي";
            this.UserIDcolumn.Name = "UserIDcolumn";
            this.UserIDcolumn.ReadOnly = true;
            this.UserIDcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserIDcolumn.Visible = false;
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
            // Usernamecolumn
            // 
            this.Usernamecolumn.HeaderText = "المستخدم";
            this.Usernamecolumn.Name = "Usernamecolumn";
            this.Usernamecolumn.ReadOnly = true;
            this.Usernamecolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Passwordcolumn
            // 
            this.Passwordcolumn.HeaderText = "كلمة المرور";
            this.Passwordcolumn.Name = "Passwordcolumn";
            this.Passwordcolumn.ReadOnly = true;
            this.Passwordcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Passwordcolumn.Visible = false;
            // 
            // Positioncolumn
            // 
            this.Positioncolumn.HeaderText = "الرتبة";
            this.Positioncolumn.Name = "Positioncolumn";
            this.Positioncolumn.ReadOnly = true;
            this.Positioncolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Activecolumn
            // 
            this.Activecolumn.HeaderText = "مغعل";
            this.Activecolumn.Name = "Activecolumn";
            this.Activecolumn.ReadOnly = true;
            this.Activecolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "إسم المستخدم";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(23, 46);
            this.UsernameTextBox.MaxLength = 25;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(227, 24);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(23, 147);
            this.PasswordTextBox.MaxLength = 25;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(227, 24);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "كلمة المرور";
            // 
            // RePasswordTextBox
            // 
            this.RePasswordTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePasswordTextBox.Location = new System.Drawing.Point(23, 194);
            this.RePasswordTextBox.MaxLength = 25;
            this.RePasswordTextBox.Name = "RePasswordTextBox";
            this.RePasswordTextBox.PasswordChar = '*';
            this.RePasswordTextBox.Size = new System.Drawing.Size(227, 24);
            this.RePasswordTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "إعادة كلمة المرور";
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Items.AddRange(new object[] {
            "إداري",
            "موظف"});
            this.PositionComboBox.Location = new System.Drawing.Point(23, 243);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(227, 24);
            this.PositionComboBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "الرتبة";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.ActiveComboBox);
            this.panel5.Controls.Add(this.UsernameTextBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.PositionComboBox);
            this.panel5.Controls.Add(this.PasswordTextBox);
            this.panel5.Controls.Add(this.RePasswordTextBox);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 640);
            this.panel5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "مفعل";
            // 
            // ActiveComboBox
            // 
            this.ActiveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveComboBox.FormattingEnabled = true;
            this.ActiveComboBox.Items.AddRange(new object[] {
            "نعم",
            "لا"});
            this.ActiveComboBox.Location = new System.Drawing.Point(23, 288);
            this.ActiveComboBox.Name = "ActiveComboBox";
            this.ActiveComboBox.Size = new System.Drawing.Size(227, 24);
            this.ActiveComboBox.TabIndex = 11;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 640);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.DetialsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.GroupBox DetialsGroupBox;
        private System.Windows.Forms.DataGridView DataGridViewUsers;
        private System.Windows.Forms.TextBox RePasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ActiveComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Countcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usernamecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwordcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Positioncolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activecolumn;
    }
}