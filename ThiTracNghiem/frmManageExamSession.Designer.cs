namespace ThiTracNghiem
{
    partial class frmManageExamSession
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grv_ExamSessions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.groupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbb_Subject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_UserCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Add = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Exam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SessionName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grv_SessionUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_ExamSessions)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_SessionUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BorderRadius = 5;
            this.groupBox1.Controls.Add(this.grv_ExamSessions);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1365, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Danh sách kỳ thi";
            // 
            // grv_ExamSessions
            // 
            this.grv_ExamSessions.AllowUserToAddRows = false;
            this.grv_ExamSessions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
            this.grv_ExamSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_ExamSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.grv_ExamSessions.ColumnHeadersHeight = 40;
            this.grv_ExamSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_ExamSessions.DefaultCellStyle = dataGridViewCellStyle45;
            this.grv_ExamSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_ExamSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_ExamSessions.Location = new System.Drawing.Point(0, 40);
            this.grv_ExamSessions.Name = "grv_ExamSessions";
            this.grv_ExamSessions.ReadOnly = true;
            this.grv_ExamSessions.RowHeadersVisible = false;
            this.grv_ExamSessions.RowHeadersWidth = 51;
            this.grv_ExamSessions.Size = new System.Drawing.Size(1365, 244);
            this.grv_ExamSessions.TabIndex = 0;
            this.grv_ExamSessions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_ExamSessions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_ExamSessions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_ExamSessions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_ExamSessions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_ExamSessions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_ExamSessions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_ExamSessions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_ExamSessions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_ExamSessions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_ExamSessions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_ExamSessions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_ExamSessions.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_ExamSessions.ThemeStyle.ReadOnly = true;
            this.grv_ExamSessions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_ExamSessions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_ExamSessions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_ExamSessions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_ExamSessions.ThemeStyle.RowsStyle.Height = 22;
            this.grv_ExamSessions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_ExamSessions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_ExamSessions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_ExamSessions_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BorderRadius = 5;
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "Thao tác";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderRadius = 5;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(75, 47);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(139, 36);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Hủy kỳ thi";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BorderRadius = 5;
            this.groupBox3.Controls.Add(this.cbb_Subject);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbl_UserCount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_Add);
            this.groupBox3.Controls.Add(this.dtp_EndTime);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtp_StartTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbb_Exam);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_SessionName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 261);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "Thêm kỳ thi mới";
            // 
            // cbb_Subject
            // 
            this.cbb_Subject.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Subject.BorderRadius = 5;
            this.cbb_Subject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Subject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Subject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Subject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbb_Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Subject.ItemHeight = 15;
            this.cbb_Subject.Location = new System.Drawing.Point(137, 69);
            this.cbb_Subject.Name = "cbb_Subject";
            this.cbb_Subject.Size = new System.Drawing.Size(294, 21);
            this.cbb_Subject.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Môn thi:";
            // 
            // lbl_UserCount
            // 
            this.lbl_UserCount.AutoSize = true;
            this.lbl_UserCount.Location = new System.Drawing.Point(136, 175);
            this.lbl_UserCount.Name = "lbl_UserCount";
            this.lbl_UserCount.Size = new System.Drawing.Size(97, 15);
            this.lbl_UserCount.TabIndex = 11;
            this.lbl_UserCount.Text = "Số người dùng: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Người tham gia:";
            // 
            // btn_Add
            // 
            this.btn_Add.BorderRadius = 5;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(167, 209);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 36);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtp_EndTime
            // 
            this.dtp_EndTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_EndTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndTime.Location = new System.Drawing.Point(136, 143);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.Size = new System.Drawing.Size(294, 23);
            this.dtp_EndTime.TabIndex = 7;
            this.dtp_EndTime.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời gian kết thúc:";
            // 
            // dtp_StartTime
            // 
            this.dtp_StartTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_StartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartTime.Location = new System.Drawing.Point(136, 117);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.Size = new System.Drawing.Size(294, 23);
            this.dtp_StartTime.TabIndex = 5;
            this.dtp_StartTime.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian bắt đầu:";
            // 
            // cbb_Exam
            // 
            this.cbb_Exam.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Exam.BorderRadius = 5;
            this.cbb_Exam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Exam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Exam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Exam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Exam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbb_Exam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Exam.ItemHeight = 15;
            this.cbb_Exam.Location = new System.Drawing.Point(136, 90);
            this.cbb_Exam.Name = "cbb_Exam";
            this.cbb_Exam.Size = new System.Drawing.Size(294, 21);
            this.cbb_Exam.TabIndex = 3;
            this.cbb_Exam.SelectedIndexChanged += new System.EventHandler(this.cbb_Exam_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đề thi:";
            // 
            // txt_SessionName
            // 
            this.txt_SessionName.BorderRadius = 5;
            this.txt_SessionName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SessionName.DefaultText = "";
            this.txt_SessionName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SessionName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SessionName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SessionName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SessionName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SessionName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SessionName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SessionName.Location = new System.Drawing.Point(136, 44);
            this.txt_SessionName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SessionName.Name = "txt_SessionName";
            this.txt_SessionName.PasswordChar = '\0';
            this.txt_SessionName.PlaceholderText = "";
            this.txt_SessionName.SelectedText = "";
            this.txt_SessionName.Size = new System.Drawing.Size(294, 20);
            this.txt_SessionName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kỳ thi:";
            // 
            // groupBox4
            // 
            this.groupBox4.BorderRadius = 5;
            this.groupBox4.Controls.Add(this.grv_SessionUsers);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(912, 355);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.Text = "Danh sách người tham gia";
            // 
            // grv_SessionUsers
            // 
            this.grv_SessionUsers.AllowUserToAddRows = false;
            this.grv_SessionUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            this.grv_SessionUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_SessionUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.grv_SessionUsers.ColumnHeadersHeight = 40;
            this.grv_SessionUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_SessionUsers.DefaultCellStyle = dataGridViewCellStyle48;
            this.grv_SessionUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_SessionUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_SessionUsers.Location = new System.Drawing.Point(0, 40);
            this.grv_SessionUsers.Name = "grv_SessionUsers";
            this.grv_SessionUsers.ReadOnly = true;
            this.grv_SessionUsers.RowHeadersVisible = false;
            this.grv_SessionUsers.RowHeadersWidth = 51;
            this.grv_SessionUsers.Size = new System.Drawing.Size(912, 315);
            this.grv_SessionUsers.TabIndex = 0;
            this.grv_SessionUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_SessionUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_SessionUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_SessionUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_SessionUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_SessionUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_SessionUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_SessionUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_SessionUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_SessionUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_SessionUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_SessionUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_SessionUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_SessionUsers.ThemeStyle.ReadOnly = true;
            this.grv_SessionUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_SessionUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_SessionUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_SessionUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_SessionUsers.ThemeStyle.RowsStyle.Height = 22;
            this.grv_SessionUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_SessionUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 302);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1374, 355);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(458, 355);
            this.splitContainer2.SplitterDistance = 90;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BorderRadius = 5;
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Edit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(245, 47);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(139, 36);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Chỉnh sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // frmManageExamSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManageExamSession";
            this.Size = new System.Drawing.Size(1380, 660);
            this.Load += new System.EventHandler(this.frmManageExamSession_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_ExamSessions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_SessionUsers)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView grv_ExamSessions;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Cancel;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Add;
        private System.Windows.Forms.DateTimePicker dtp_EndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_StartTime;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Exam;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_SessionName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2DataGridView grv_SessionUsers;
        private System.Windows.Forms.Label lbl_UserCount;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Subject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Edit;
    }
}
