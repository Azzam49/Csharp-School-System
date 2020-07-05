namespace AlaaSchool_TimeTable
{
    partial class Sample2
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
            this.rightPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightPanel.Controls.Add(this.panel2);
            this.rightPanel.Controls.Add(this.panel3);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightPanel.ForeColor = System.Drawing.Color.White;
            this.rightPanel.Location = new System.Drawing.Point(0, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(240, 662);
            this.rightPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 55);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.BackButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 60);
            this.panel3.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Controls.Add(this.panel4);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(240, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(904, 662);
            this.leftPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 55);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchGroupBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(178, 49);
            this.SearchGroupBox.TabIndex = 4;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "بحث";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTextBox.Location = new System.Drawing.Point(3, 21);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(172, 25);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = global::AlaaSchool_TimeTable.Properties.Resources.delete_24;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.Location = new System.Drawing.Point(187, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(174, 49);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.UsernameLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(904, 60);
            this.panel4.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(776, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(128, 60);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "المستخدم";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.FlatAppearance.BorderSize = 2;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Image = global::AlaaSchool_TimeTable.Properties.Resources.save_24;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.Location = new System.Drawing.Point(367, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(174, 49);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "حفظ";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditButton.FlatAppearance.BorderSize = 2;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = global::AlaaSchool_TimeTable.Properties.Resources.edit_property_24;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditButton.Location = new System.Drawing.Point(547, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(174, 49);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "تعديل";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::AlaaSchool_TimeTable.Properties.Resources.add_user_3_24;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.Location = new System.Drawing.Point(727, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(174, 49);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "إضافة";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::AlaaSchool_TimeTable.Properties.Resources.Back;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(189, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(51, 60);
            this.BackButton.TabIndex = 0;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 662);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sample2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.Sample2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sample2_KeyDown);
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel rightPanel;
        public System.Windows.Forms.Panel leftPanel;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label UsernameLabel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.Button EditButton;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.GroupBox SearchGroupBox;
        public System.Windows.Forms.TextBox SearchTextBox;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button BackButton;
    }
}