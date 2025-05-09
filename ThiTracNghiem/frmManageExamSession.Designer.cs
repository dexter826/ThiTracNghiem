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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle82 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle83 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle84 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grv_ExamSessions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Update = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_ViewDetail = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.groupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.clb_Users = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Add = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.dtp_EndTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_StartTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Exam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SessionName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grv_SessionUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.groupBox1.Size = new System.Drawing.Size(1365, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Danh sách kỳ thi";
            //
            // grv_ExamSessions
            //
            this.grv_ExamSessions.AllowUserToAddRows = false;
            this.grv_ExamSessions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle79.BackColor = System.Drawing.Color.White;
            this.grv_ExamSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle79;
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle80.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle80.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle80.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle80.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle80.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_ExamSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle80;
            this.grv_ExamSessions.ColumnHeadersHeight = 40;
            this.grv_ExamSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle81.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle81.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle81.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle81.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle81.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_ExamSessions.DefaultCellStyle = dataGridViewCellStyle81;
            this.grv_ExamSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_ExamSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_ExamSessions.Location = new System.Drawing.Point(0, 40);
            this.grv_ExamSessions.Name = "grv_ExamSessions";
            this.grv_ExamSessions.ReadOnly = true;
            this.grv_ExamSessions.RowHeadersVisible = false;
            this.grv_ExamSessions.Size = new System.Drawing.Size(1365, 147);
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
            //
            // groupBox2
            //
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BorderRadius = 5;
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_ViewDetail);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox2.Location = new System.Drawing.Point(302, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 92);
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
            this.btn_Cancel.Location = new System.Drawing.Point(501, 48);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(139, 36);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Hủy kỳ thi";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            //
            // btn_Update
            //
            this.btn_Update.BorderRadius = 5;
            this.btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Update.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(315, 48);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(139, 36);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            //
            // btn_ViewDetail
            //
            this.btn_ViewDetail.BorderRadius = 5;
            this.btn_ViewDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ViewDetail.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ViewDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ViewDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ViewDetail.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ViewDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ViewDetail.ForeColor = System.Drawing.Color.White;
            this.btn_ViewDetail.Location = new System.Drawing.Point(129, 48);
            this.btn_ViewDetail.Name = "btn_ViewDetail";
            this.btn_ViewDetail.Size = new System.Drawing.Size(139, 36);
            this.btn_ViewDetail.TabIndex = 0;
            this.btn_ViewDetail.Text = "Xem chi tiết";
            this.btn_ViewDetail.Click += new System.EventHandler(this.btn_ViewDetail_Click);
            //
            // groupBox3
            //
            this.groupBox3.BorderRadius = 5;
            this.groupBox3.Controls.Add(this.clb_Users);
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
            this.groupBox3.Size = new System.Drawing.Size(455, 344);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "Thêm kỳ thi mới";
            //
            // clb_Users
            //
            this.clb_Users.BackColor = System.Drawing.Color.White;
            this.clb_Users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clb_Users.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clb_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.clb_Users.FormattingEnabled = true;
            this.clb_Users.Location = new System.Drawing.Point(136, 149);
            this.clb_Users.Name = "clb_Users";
            this.clb_Users.Size = new System.Drawing.Size(294, 146);
            this.clb_Users.TabIndex = 10;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 149);
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
            this.btn_Add.Location = new System.Drawing.Point(224, 305);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 36);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            //
            // dtp_EndTime
            //
            this.dtp_EndTime.BorderRadius = 5;
            this.dtp_EndTime.Checked = true;
            this.dtp_EndTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_EndTime.FillColor = System.Drawing.Color.White;
            this.dtp_EndTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndTime.Location = new System.Drawing.Point(136, 123);
            this.dtp_EndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_EndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.Size = new System.Drawing.Size(294, 20);
            this.dtp_EndTime.TabIndex = 7;
            this.dtp_EndTime.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời gian kết thúc:";
            //
            // dtp_StartTime
            //
            this.dtp_StartTime.BorderRadius = 5;
            this.dtp_StartTime.Checked = true;
            this.dtp_StartTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_StartTime.FillColor = System.Drawing.Color.White;
            this.dtp_StartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartTime.Location = new System.Drawing.Point(136, 97);
            this.dtp_StartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_StartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.Size = new System.Drawing.Size(294, 20);
            this.dtp_StartTime.TabIndex = 5;
            this.dtp_StartTime.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
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
            this.cbb_Exam.Location = new System.Drawing.Point(136, 70);
            this.cbb_Exam.Name = "cbb_Exam";
            this.cbb_Exam.Size = new System.Drawing.Size(294, 21);
            this.cbb_Exam.TabIndex = 3;
            this.cbb_Exam.SelectedIndexChanged += new System.EventHandler(this.cbb_Exam_SelectedIndexChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
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
            this.groupBox4.Size = new System.Drawing.Size(906, 344);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.Text = "Danh sách người tham gia";
            //
            // grv_SessionUsers
            //
            this.grv_SessionUsers.AllowUserToAddRows = false;
            this.grv_SessionUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle82.BackColor = System.Drawing.Color.White;
            this.grv_SessionUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle82;
            dataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle83.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle83.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle83.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle83.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle83.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_SessionUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle83;
            this.grv_SessionUsers.ColumnHeadersHeight = 40;
            this.grv_SessionUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle84.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle84.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle84.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle84.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle84.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle84.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle84.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_SessionUsers.DefaultCellStyle = dataGridViewCellStyle84;
            this.grv_SessionUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_SessionUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_SessionUsers.Location = new System.Drawing.Point(0, 40);
            this.grv_SessionUsers.Name = "grv_SessionUsers";
            this.grv_SessionUsers.ReadOnly = true;
            this.grv_SessionUsers.RowHeadersVisible = false;
            this.grv_SessionUsers.Size = new System.Drawing.Size(906, 304);
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
            this.splitContainer1.Location = new System.Drawing.Point(8, 303);
            this.splitContainer1.Name = "splitContainer1";
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1365, 344);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 4;
            //
            // frmManageExamSession
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManageExamSession";
            this.Size = new System.Drawing.Size(1380, 650);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView grv_ExamSessions;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Cancel;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Update;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_ViewDetail;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox clb_Users;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Add;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_EndTime;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_StartTime;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Exam;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_SessionName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2DataGridView grv_SessionUsers;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
