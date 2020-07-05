namespace AlaaSchool_TimeTable
{
    partial class Subjects
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
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DetialsGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.SubjectIDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Countcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.DetialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubjects)).BeginInit();
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
            this.formLabel.TabIndex = 9;
            this.formLabel.Text = "المواد";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SubjectTextBox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 525);
            this.panel5.TabIndex = 3;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTextBox.Location = new System.Drawing.Point(21, 47);
            this.SubjectTextBox.MaxLength = 25;
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(227, 24);
            this.SubjectTextBox.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "المادة";
            // 
            // DetialsGroupBox
            // 
            this.DetialsGroupBox.Controls.Add(this.DataGridViewSubjects);
            this.DetialsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetialsGroupBox.Location = new System.Drawing.Point(0, 115);
            this.DetialsGroupBox.Name = "DetialsGroupBox";
            this.DetialsGroupBox.Size = new System.Drawing.Size(874, 525);
            this.DetialsGroupBox.TabIndex = 14;
            this.DetialsGroupBox.TabStop = false;
            this.DetialsGroupBox.Text = "تفاصيل";
            // 
            // DataGridViewSubjects
            // 
            this.DataGridViewSubjects.AllowUserToAddRows = false;
            this.DataGridViewSubjects.AllowUserToDeleteRows = false;
            this.DataGridViewSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewSubjects.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectIDcolumn,
            this.Countcolumn,
            this.SubjectColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSubjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewSubjects.Location = new System.Drawing.Point(3, 21);
            this.DataGridViewSubjects.Name = "DataGridViewSubjects";
            this.DataGridViewSubjects.ReadOnly = true;
            this.DataGridViewSubjects.RowHeadersVisible = false;
            this.DataGridViewSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSubjects.Size = new System.Drawing.Size(868, 501);
            this.DataGridViewSubjects.TabIndex = 0;
            this.DataGridViewSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSubjects_CellClick);
            // 
            // SubjectIDcolumn
            // 
            this.SubjectIDcolumn.HeaderText = "الأيدي";
            this.SubjectIDcolumn.Name = "SubjectIDcolumn";
            this.SubjectIDcolumn.ReadOnly = true;
            this.SubjectIDcolumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectIDcolumn.Visible = false;
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
            // SubjectColumn
            // 
            this.SubjectColumn.HeaderText = "المادة";
            this.SubjectColumn.Name = "SubjectColumn";
            this.SubjectColumn.ReadOnly = true;
            this.SubjectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 640);
            this.Name = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.DetialsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox DetialsGroupBox;
        private System.Windows.Forms.DataGridView DataGridViewSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectIDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Countcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectColumn;
    }
}