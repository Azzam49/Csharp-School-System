namespace AlaaSchool_TimeTable
{
    partial class TimeTable
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
            this.formLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.GirlsRadio = new System.Windows.Forms.RadioButton();
            this.BoysRadio = new System.Windows.Forms.RadioButton();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeacherComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(270, 663);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.LoadButton);
            this.panel5.Controls.Add(this.TeacherComboBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.ClassComboBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Size = new System.Drawing.Size(270, 603);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BackButton);
            this.panel3.Controls.Add(this.formLabel);
            this.panel3.Size = new System.Drawing.Size(270, 60);
            // 
            // leftPanel
            // 
            this.leftPanel.Location = new System.Drawing.Point(270, 0);
            this.leftPanel.Size = new System.Drawing.Size(874, 663);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.crystalReportViewer1);
            this.panel6.Size = new System.Drawing.Size(874, 603);
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
            // formLabel
            // 
            this.formLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.formLabel.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.ForeColor = System.Drawing.Color.White;
            this.formLabel.Location = new System.Drawing.Point(0, 0);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(124, 60);
            this.formLabel.TabIndex = 11;
            this.formLabel.Text = "عرض الجدول";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.GirlsRadio);
            this.panel1.Controls.Add(this.BoysRadio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 55);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(120, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "إخنتار القسم (للفصول) :";
            // 
            // GirlsRadio
            // 
            this.GirlsRadio.AutoSize = true;
            this.GirlsRadio.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirlsRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GirlsRadio.Location = new System.Drawing.Point(11, 16);
            this.GirlsRadio.Name = "GirlsRadio";
            this.GirlsRadio.Size = new System.Drawing.Size(50, 23);
            this.GirlsRadio.TabIndex = 52;
            this.GirlsRadio.TabStop = true;
            this.GirlsRadio.Text = "بنات";
            this.GirlsRadio.UseVisualStyleBackColor = true;
            this.GirlsRadio.CheckedChanged += new System.EventHandler(this.GirlsRadio_CheckedChanged);
            // 
            // BoysRadio
            // 
            this.BoysRadio.AutoSize = true;
            this.BoysRadio.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoysRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BoysRadio.Location = new System.Drawing.Point(67, 16);
            this.BoysRadio.Name = "BoysRadio";
            this.BoysRadio.Size = new System.Drawing.Size(47, 23);
            this.BoysRadio.TabIndex = 51;
            this.BoysRadio.TabStop = true;
            this.BoysRadio.Text = "بنين";
            this.BoysRadio.UseVisualStyleBackColor = true;
            this.BoysRadio.CheckedChanged += new System.EventHandler(this.BoysRadio_CheckedChanged);
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(20, 101);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(227, 24);
            this.ClassComboBox.TabIndex = 43;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "الفصل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 33);
            this.label2.TabIndex = 45;
            this.label2.Text = "أم";
            // 
            // TeacherComboBox
            // 
            this.TeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherComboBox.FormattingEnabled = true;
            this.TeacherComboBox.Location = new System.Drawing.Point(20, 222);
            this.TeacherComboBox.Name = "TeacherComboBox";
            this.TeacherComboBox.Size = new System.Drawing.Size(227, 24);
            this.TeacherComboBox.TabIndex = 46;
            this.TeacherComboBox.SelectedIndexChanged += new System.EventHandler(this.TeacherComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "معلم/معلمة";
            // 
            // LoadButton
            // 
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.FlatAppearance.BorderSize = 2;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(24, 280);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(223, 49);
            this.LoadButton.TabIndex = 48;
            this.LoadButton.Text = "تحميل التقرير";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(874, 603);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AlaaSchool_TimeTable.Properties.Resources.report_256;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(35, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 151);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::AlaaSchool_TimeTable.Properties.Resources.Back;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(219, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(51, 60);
            this.BackButton.TabIndex = 12;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 663);
            this.KeyPreview = true;
            this.Name = "TimeTable";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimeTable_KeyDown);
            this.rightPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton GirlsRadio;
        private System.Windows.Forms.RadioButton BoysRadio;
        public System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TeacherComboBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button LoadButton;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}