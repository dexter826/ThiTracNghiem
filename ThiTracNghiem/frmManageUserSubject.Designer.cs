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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Users);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Subjects);
            this.splitContainer1.Size = new System.Drawing.Size(1699, 303);
            this.splitContainer1.SplitterDistance = 565;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_Users
            // 
            this.groupBox_Users.Controls.Add(this.grv_Users);
            this.groupBox_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Users.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox_Users.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Users.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Users.Name = "groupBox_Users";
            this.groupBox_Users.Size = new System.Drawing.Size(565, 303);
            this.groupBox_Users.TabIndex = 1;
            this.groupBox_Users.Text = "Danh sách người thi";
            // 
            // grv_Users
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_Users.ColumnHeadersHeight = 17;
            this.grv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colUsername,
            this.colFullname});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Users.DefaultCellStyle = dataGridViewCellStyle3;
            this.grv_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Users.Location = new System.Drawing.Point(0, 40);
            this.grv_Users.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grv_Users.MultiSelect = false;
            this.grv_Users.Name = "grv_Users";
            this.grv_Users.ReadOnly = true;
            this.grv_Users.RowHeadersVisible = false;
            this.grv_Users.RowHeadersWidth = 51;
            this.grv_Users.Size = new System.Drawing.Size(565, 263);
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
            this.colUserID.MinimumWidth = 6;
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Visible = false;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Tài khoản";
            this.colUsername.MinimumWidth = 6;
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colFullname
            // 
            this.colFullname.HeaderText = "Tên người thi";
            this.colFullname.MinimumWidth = 6;
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
            this.groupBox_Subjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Subjects.Name = "groupBox_Subjects";
            this.groupBox_Subjects.Size = new System.Drawing.Size(1129, 303);
            this.groupBox_Subjects.TabIndex = 1;
            this.groupBox_Subjects.Text = "Danh sách môn thi";
            // 
            // grv_Subjects
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.grv_Subjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Subjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grv_Subjects.ColumnHeadersHeight = 17;
            this.grv_Subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Subjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubjectID,
            this.colSubjectName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Subjects.DefaultCellStyle = dataGridViewCellStyle6;
            this.grv_Subjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_Subjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Subjects.Location = new System.Drawing.Point(0, 40);
            this.grv_Subjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grv_Subjects.MultiSelect = false;
            this.grv_Subjects.Name = "grv_Subjects";
            this.grv_Subjects.ReadOnly = true;
            this.grv_Subjects.RowHeadersVisible = false;
            this.grv_Subjects.RowHeadersWidth = 51;
            this.grv_Subjects.Size = new System.Drawing.Size(1129, 263);
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
            this.colSubjectID.MinimumWidth = 6;
            this.colSubjectID.Name = "colSubjectID";
            this.colSubjectID.ReadOnly = true;
            this.colSubjectID.Visible = false;
            // 
            // colSubjectName
            // 
            this.colSubjectName.HeaderText = "Tên môn thi";
            this.colSubjectName.MinimumWidth = 6;
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.ReadOnly = true;
            // 
            // btn_Assign
            // 
            this.btn_Assign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Assign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Assign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Assign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Assign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Assign.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Assign.ForeColor = System.Drawing.Color.White;
            this.btn_Assign.Location = new System.Drawing.Point(593, 315);
            this.btn_Assign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(152, 43);
            this.btn_Assign.TabIndex = 1;
            this.btn_Assign.Text = "Gán môn học";
            this.btn_Assign.Click += new System.EventHandler(this.btn_Assign_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.Location = new System.Drawing.Point(765, 315);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(176, 43);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Xóa gán môn học";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(961, 315);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(152, 43);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // groupBox_UserSubjects
            // 
            this.groupBox_UserSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_UserSubjects.Controls.Add(this.grv_UserSubjects);
            this.groupBox_UserSubjects.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox_UserSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox_UserSubjects.Location = new System.Drawing.Point(4, 366);
            this.groupBox_UserSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_UserSubjects.Name = "groupBox_UserSubjects";
            this.groupBox_UserSubjects.Size = new System.Drawing.Size(1699, 364);
            this.groupBox_UserSubjects.TabIndex = 4;
            this.groupBox_UserSubjects.Text = "Danh sách gán môn học cho người dùng";
            // 
            // grv_UserSubjects
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grv_UserSubjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_UserSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grv_UserSubjects.ColumnHeadersHeight = 17;
            this.grv_UserSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_UserSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colUserID2,
            this.colSubjectID2,
            this.colUsername2,
            this.colFullname2,
            this.colSubjectName2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_UserSubjects.DefaultCellStyle = dataGridViewCellStyle9;
            this.grv_UserSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_UserSubjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_UserSubjects.Location = new System.Drawing.Point(0, 40);
            this.grv_UserSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grv_UserSubjects.MultiSelect = false;
            this.grv_UserSubjects.Name = "grv_UserSubjects";
            this.grv_UserSubjects.ReadOnly = true;
            this.grv_UserSubjects.RowHeadersVisible = false;
            this.grv_UserSubjects.RowHeadersWidth = 51;
            this.grv_UserSubjects.Size = new System.Drawing.Size(1699, 324);
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
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colUserID2
            // 
            this.colUserID2.HeaderText = "colUserID2";
            this.colUserID2.MinimumWidth = 6;
            this.colUserID2.Name = "colUserID2";
            this.colUserID2.ReadOnly = true;
            this.colUserID2.Visible = false;
            // 
            // colSubjectID2
            // 
            this.colSubjectID2.HeaderText = "colSubjectID2";
            this.colSubjectID2.MinimumWidth = 6;
            this.colSubjectID2.Name = "colSubjectID2";
            this.colSubjectID2.ReadOnly = true;
            this.colSubjectID2.Visible = false;
            // 
            // colUsername2
            // 
            this.colUsername2.HeaderText = "Tài khoản";
            this.colUsername2.MinimumWidth = 6;
            this.colUsername2.Name = "colUsername2";
            this.colUsername2.ReadOnly = true;
            // 
            // colFullname2
            // 
            this.colFullname2.HeaderText = "Tên người thi";
            this.colFullname2.MinimumWidth = 6;
            this.colFullname2.Name = "colFullname2";
            this.colFullname2.ReadOnly = true;
            // 
            // colSubjectName2
            // 
            this.colSubjectName2.HeaderText = "Tên môn thi";
            this.colSubjectName2.MinimumWidth = 6;
            this.colSubjectName2.Name = "colSubjectName2";
            this.colSubjectName2.ReadOnly = true;
            // 
            // frmManageUserSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_UserSubjects);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Assign);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManageUserSubject";
            this.Size = new System.Drawing.Size(1707, 734);
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
