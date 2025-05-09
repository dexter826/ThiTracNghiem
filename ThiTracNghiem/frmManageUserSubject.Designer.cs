namespace ThiTracNghiem
{
    partial class frmManageUserSubject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Users = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grv_Users = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Subjects = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grv_Subjects = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Assign = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Remove = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox_UserSubjects = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grv_UserSubjects = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullname2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Users)).BeginInit();
            this.groupBox_Subjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Subjects)).BeginInit();
            this.groupBox_UserSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_UserSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Users);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Subjects);
            this.splitContainer1.Size = new System.Drawing.Size(1274, 205);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_Users
            // 
            this.groupBox_Users.Controls.Add(this.grv_Users);
            this.groupBox_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Users.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox_Users.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Users.Name = "groupBox_Users";
            this.groupBox_Users.Size = new System.Drawing.Size(424, 205);
            this.groupBox_Users.TabIndex = 1;
            this.groupBox_Users.Text = "Danh sách người thi";
            // 
            // grv_Users
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.grv_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.grv_Users.ColumnHeadersHeight = 17;
            this.grv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colUsername,
            this.colFullname});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Users.DefaultCellStyle = dataGridViewCellStyle30;
            this.grv_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Users.Location = new System.Drawing.Point(0, 40);
            this.grv_Users.MultiSelect = false;
            this.grv_Users.Name = "grv_Users";
            this.grv_Users.ReadOnly = true;
            this.grv_Users.RowHeadersVisible = false;
            this.grv_Users.Size = new System.Drawing.Size(424, 165);
            this.grv_Users.TabIndex = 2;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Users.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Users.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Users.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_Users.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_Users.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_Users.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Users.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Users.ThemeStyle.HeaderStyle.Height = 17;
            this.grv_Users.ThemeStyle.ReadOnly = true;
            this.grv_Users.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Users.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Users.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_Users.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grv_Users.ThemeStyle.RowsStyle.Height = 22;
            this.grv_Users.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Users.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_Users.SelectionChanged += new System.EventHandler(this.grv_Users_SelectionChanged);
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "colUserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Visible = false;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Tài khoản";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colFullname
            // 
            this.colFullname.HeaderText = "Tên người thi";
            this.colFullname.Name = "colFullname";
            this.colFullname.ReadOnly = true;
            // 
            // groupBox_Subjects
            // 
            this.groupBox_Subjects.Controls.Add(this.grv_Subjects);
            this.groupBox_Subjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Subjects.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox_Subjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox_Subjects.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Subjects.Name = "groupBox_Subjects";
            this.groupBox_Subjects.Size = new System.Drawing.Size(846, 205);
            this.groupBox_Subjects.TabIndex = 1;
            this.groupBox_Subjects.Text = "Danh sách môn thi";
            // 
            // grv_Subjects
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.grv_Subjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Subjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.grv_Subjects.ColumnHeadersHeight = 17;
            this.grv_Subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Subjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubjectID,
            this.colSubjectName});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Subjects.DefaultCellStyle = dataGridViewCellStyle33;
            this.grv_Subjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_Subjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Subjects.Location = new System.Drawing.Point(0, 40);
            this.grv_Subjects.MultiSelect = false;
            this.grv_Subjects.Name = "grv_Subjects";
            this.grv_Subjects.ReadOnly = true;
            this.grv_Subjects.RowHeadersVisible = false;
            this.grv_Subjects.Size = new System.Drawing.Size(846, 165);
            this.grv_Subjects.TabIndex = 2;
            this.grv_Subjects.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Subjects.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Subjects.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Subjects.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_Subjects.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Subjects.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Subjects.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Subjects.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_Subjects.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_Subjects.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_Subjects.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Subjects.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Subjects.ThemeStyle.HeaderStyle.Height = 17;
            this.grv_Subjects.ThemeStyle.ReadOnly = true;
            this.grv_Subjects.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Subjects.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Subjects.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_Subjects.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grv_Subjects.ThemeStyle.RowsStyle.Height = 22;
            this.grv_Subjects.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Subjects.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_Subjects.SelectionChanged += new System.EventHandler(this.grv_Subjects_SelectionChanged);
            // 
            // colSubjectID
            // 
            this.colSubjectID.HeaderText = "colSubjectID";
            this.colSubjectID.Name = "colSubjectID";
            this.colSubjectID.ReadOnly = true;
            this.colSubjectID.Visible = false;
            // 
            // colSubjectName
            // 
            this.colSubjectName.HeaderText = "Tên môn thi";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.ReadOnly = true;
            // 
            // btn_Assign
            // 
            this.btn_Assign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Assign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Assign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Assign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Assign.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Assign.ForeColor = System.Drawing.Color.White;
            this.btn_Assign.Location = new System.Drawing.Point(445, 214);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(114, 35);
            this.btn_Assign.TabIndex = 1;
            this.btn_Assign.Text = "Gán môn học";
            this.btn_Assign.Click += new System.EventHandler(this.btn_Assign_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.Location = new System.Drawing.Point(574, 214);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(132, 35);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Xóa gán môn học";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(721, 214);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(114, 35);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // groupBox_UserSubjects
            // 
            this.groupBox_UserSubjects.Controls.Add(this.grv_UserSubjects);
            this.groupBox_UserSubjects.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox_UserSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox_UserSubjects.Location = new System.Drawing.Point(3, 255);
            this.groupBox_UserSubjects.Name = "groupBox_UserSubjects";
            this.groupBox_UserSubjects.Size = new System.Drawing.Size(1274, 338);
            this.groupBox_UserSubjects.TabIndex = 4;
            this.groupBox_UserSubjects.Text = "Danh sách gán môn học cho người dùng";
            // 
            // grv_UserSubjects
            // 
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            this.grv_UserSubjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_UserSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.grv_UserSubjects.ColumnHeadersHeight = 17;
            this.grv_UserSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_UserSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colUserID2,
            this.colSubjectID2,
            this.colUsername2,
            this.colFullname2,
            this.colSubjectName2});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_UserSubjects.DefaultCellStyle = dataGridViewCellStyle36;
            this.grv_UserSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_UserSubjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_UserSubjects.Location = new System.Drawing.Point(0, 40);
            this.grv_UserSubjects.MultiSelect = false;
            this.grv_UserSubjects.Name = "grv_UserSubjects";
            this.grv_UserSubjects.ReadOnly = true;
            this.grv_UserSubjects.RowHeadersVisible = false;
            this.grv_UserSubjects.Size = new System.Drawing.Size(1274, 298);
            this.grv_UserSubjects.TabIndex = 5;
            this.grv_UserSubjects.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_UserSubjects.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_UserSubjects.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_UserSubjects.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_UserSubjects.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_UserSubjects.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_UserSubjects.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_UserSubjects.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_UserSubjects.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_UserSubjects.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_UserSubjects.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_UserSubjects.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_UserSubjects.ThemeStyle.HeaderStyle.Height = 17;
            this.grv_UserSubjects.ThemeStyle.ReadOnly = true;
            this.grv_UserSubjects.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_UserSubjects.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_UserSubjects.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_UserSubjects.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grv_UserSubjects.ThemeStyle.RowsStyle.Height = 22;
            this.grv_UserSubjects.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_UserSubjects.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colID
            // 
            this.colID.HeaderText = "colID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colUserID2
            // 
            this.colUserID2.HeaderText = "colUserID2";
            this.colUserID2.Name = "colUserID2";
            this.colUserID2.ReadOnly = true;
            this.colUserID2.Visible = false;
            // 
            // colSubjectID2
            // 
            this.colSubjectID2.HeaderText = "colSubjectID2";
            this.colSubjectID2.Name = "colSubjectID2";
            this.colSubjectID2.ReadOnly = true;
            this.colSubjectID2.Visible = false;
            // 
            // colUsername2
            // 
            this.colUsername2.HeaderText = "Tài khoản";
            this.colUsername2.Name = "colUsername2";
            this.colUsername2.ReadOnly = true;
            // 
            // colFullname2
            // 
            this.colFullname2.HeaderText = "Tên người thi";
            this.colFullname2.Name = "colFullname2";
            this.colFullname2.ReadOnly = true;
            // 
            // colSubjectName2
            // 
            this.colSubjectName2.HeaderText = "Tên môn thi";
            this.colSubjectName2.Name = "colSubjectName2";
            this.colSubjectName2.ReadOnly = true;
            // 
            // frmManageUserSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_UserSubjects);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Assign);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmManageUserSubject";
            this.Size = new System.Drawing.Size(1280, 596);
            this.Load += new System.EventHandler(this.frmManageUserSubject_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Users)).EndInit();
            this.groupBox_Subjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Subjects)).EndInit();
            this.groupBox_UserSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_UserSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_Users;
        private Guna.UI2.WinForms.Guna2DataGridView grv_Users;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_Subjects;
        private Guna.UI2.WinForms.Guna2DataGridView grv_Subjects;
        private Guna.UI2.WinForms.Guna2Button btn_Assign;
        private Guna.UI2.WinForms.Guna2Button btn_Remove;
        private Guna.UI2.WinForms.Guna2Button btn_Refresh;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_UserSubjects;
        private Guna.UI2.WinForms.Guna2DataGridView grv_UserSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullname2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectName2;
    }
}
