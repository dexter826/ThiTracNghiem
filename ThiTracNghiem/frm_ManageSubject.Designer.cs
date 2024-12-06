namespace ThiTracNghiem
{
    partial class frmManageSubject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_SubjectId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Add = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.grv_DataUser = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SubjectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SubjectDesb = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Search = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.grb_Infor = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TimeLimit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbb_NumberOfQuestion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Save = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DataUser)).BeginInit();
            this.grb_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SubjectId
            // 
            this.txt_SubjectId.BorderRadius = 5;
            this.txt_SubjectId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SubjectId.DefaultText = "";
            this.txt_SubjectId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.txt_SubjectId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubjectId.Location = new System.Drawing.Point(161, 46);
            this.txt_SubjectId.Margin = new System.Windows.Forms.Padding(6);
            this.txt_SubjectId.Name = "txt_SubjectId";
            this.txt_SubjectId.PasswordChar = '\0';
            this.txt_SubjectId.PlaceholderText = "";
            this.txt_SubjectId.SelectedText = "";
            this.txt_SubjectId.Size = new System.Drawing.Size(120, 36);
            this.txt_SubjectId.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BorderRadius = 8;
            this.btn_Add.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(353, 180);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.ShadowDecoration.BorderRadius = 20;
            this.btn_Add.ShadowDecoration.Depth = 10;
            this.btn_Add.ShadowDecoration.Enabled = true;
            this.btn_Add.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Add.Size = new System.Drawing.Size(139, 46);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // grv_DataUser
            // 
            this.grv_DataUser.AllowUserToAddRows = false;
            this.grv_DataUser.AllowUserToDeleteRows = false;
            this.grv_DataUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.grv_DataUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.grv_DataUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_DataUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_DataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grv_DataUser.ColumnHeadersHeight = 40;
            this.grv_DataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_DataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SubjectName,
            this.SubjectID,
            this.QuesQuantity,
            this.TimeLimit,
            this.Description});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_DataUser.DefaultCellStyle = dataGridViewCellStyle14;
            this.grv_DataUser.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_DataUser.Location = new System.Drawing.Point(5, 287);
            this.grv_DataUser.Margin = new System.Windows.Forms.Padding(5);
            this.grv_DataUser.Name = "grv_DataUser";
            this.grv_DataUser.ReadOnly = true;
            this.grv_DataUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_DataUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grv_DataUser.RowHeadersVisible = false;
            this.grv_DataUser.RowHeadersWidth = 51;
            this.grv_DataUser.RowTemplate.Height = 40;
            this.grv_DataUser.Size = new System.Drawing.Size(1207, 370);
            this.grv_DataUser.TabIndex = 7;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_DataUser.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_DataUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_DataUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_DataUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_DataUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_DataUser.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_DataUser.ThemeStyle.ReadOnly = true;
            this.grv_DataUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_DataUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_DataUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DataUser.ThemeStyle.RowsStyle.Height = 40;
            this.grv_DataUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DataUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DataUser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_DataUser_RowEnter);
            this.grv_DataUser.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grv_DataUser_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle13;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Tên môn thi";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // SubjectID
            // 
            this.SubjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "Mã môn thi";
            this.SubjectID.MinimumWidth = 6;
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            this.SubjectID.Width = 150;
            // 
            // QuesQuantity
            // 
            this.QuesQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QuesQuantity.DataPropertyName = "QuesQuantity";
            this.QuesQuantity.HeaderText = "Số lượng câu hỏi";
            this.QuesQuantity.MinimumWidth = 6;
            this.QuesQuantity.Name = "QuesQuantity";
            this.QuesQuantity.ReadOnly = true;
            this.QuesQuantity.Width = 113;
            // 
            // TimeLimit
            // 
            this.TimeLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TimeLimit.DataPropertyName = "TimeLimit";
            this.TimeLimit.HeaderText = "Thời gian";
            this.TimeLimit.MinimumWidth = 6;
            this.TimeLimit.Name = "TimeLimit";
            this.TimeLimit.ReadOnly = true;
            this.TimeLimit.Width = 85;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Mô tả";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn thi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên mô thi";
            // 
            // txt_SubjectName
            // 
            this.txt_SubjectName.BorderRadius = 5;
            this.txt_SubjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SubjectName.DefaultText = "";
            this.txt_SubjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.txt_SubjectName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubjectName.Location = new System.Drawing.Point(401, 46);
            this.txt_SubjectName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_SubjectName.Name = "txt_SubjectName";
            this.txt_SubjectName.PasswordChar = '\0';
            this.txt_SubjectName.PlaceholderText = "";
            this.txt_SubjectName.SelectedText = "";
            this.txt_SubjectName.Size = new System.Drawing.Size(289, 36);
            this.txt_SubjectName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mô tả";
            // 
            // txt_SubjectDesb
            // 
            this.txt_SubjectDesb.BorderRadius = 5;
            this.txt_SubjectDesb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SubjectDesb.DefaultText = "";
            this.txt_SubjectDesb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.txt_SubjectDesb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubjectDesb.Location = new System.Drawing.Point(161, 91);
            this.txt_SubjectDesb.Margin = new System.Windows.Forms.Padding(6);
            this.txt_SubjectDesb.Name = "txt_SubjectDesb";
            this.txt_SubjectDesb.PasswordChar = '\0';
            this.txt_SubjectDesb.PlaceholderText = "";
            this.txt_SubjectDesb.SelectedText = "";
            this.txt_SubjectDesb.Size = new System.Drawing.Size(986, 36);
            this.txt_SubjectDesb.TabIndex = 5;
            // 
            // btn_Delete
            // 
            this.btn_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BorderRadius = 8;
            this.btn_Delete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(692, 180);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.BorderRadius = 20;
            this.btn_Delete.ShadowDecoration.Depth = 10;
            this.btn_Delete.ShadowDecoration.Enabled = true;
            this.btn_Delete.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Delete.Size = new System.Drawing.Size(139, 46);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BorderRadius = 8;
            this.btn_Edit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(522, 180);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.ShadowDecoration.BorderRadius = 20;
            this.btn_Edit.ShadowDecoration.Depth = 10;
            this.btn_Edit.ShadowDecoration.Enabled = true;
            this.btn_Edit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Edit.Size = new System.Drawing.Size(139, 46);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderRadius = 8;
            this.btn_Search.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(369, 243);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.BorderRadius = 20;
            this.btn_Search.ShadowDecoration.Depth = 10;
            this.btn_Search.ShadowDecoration.Enabled = true;
            this.btn_Search.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Search.Size = new System.Drawing.Size(139, 37);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // grb_Infor
            // 
            this.grb_Infor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_Infor.BackColor = System.Drawing.Color.Transparent;
            this.grb_Infor.BorderRadius = 10;
            this.grb_Infor.Controls.Add(this.label3);
            this.grb_Infor.Controls.Add(this.txt_TimeLimit);
            this.grb_Infor.Controls.Add(this.cbb_NumberOfQuestion);
            this.grb_Infor.Controls.Add(this.label1);
            this.grb_Infor.Controls.Add(this.label10);
            this.grb_Infor.Controls.Add(this.txt_SubjectDesb);
            this.grb_Infor.Controls.Add(this.label7);
            this.grb_Infor.Controls.Add(this.txt_SubjectName);
            this.grb_Infor.Controls.Add(this.label2);
            this.grb_Infor.Controls.Add(this.txt_SubjectId);
            this.grb_Infor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Infor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grb_Infor.Location = new System.Drawing.Point(5, 32);
            this.grb_Infor.Margin = new System.Windows.Forms.Padding(5);
            this.grb_Infor.Name = "grb_Infor";
            this.grb_Infor.Padding = new System.Windows.Forms.Padding(5);
            this.grb_Infor.Size = new System.Drawing.Size(1207, 139);
            this.grb_Infor.TabIndex = 1;
            this.grb_Infor.TabStop = false;
            this.grb_Infor.Text = "Thông tin môn thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(960, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời gian";
            // 
            // txt_TimeLimit
            // 
            this.txt_TimeLimit.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimeLimit.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimeLimit.BorderRadius = 5;
            this.txt_TimeLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimeLimit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_TimeLimit.ForeColor = System.Drawing.Color.Gray;
            this.txt_TimeLimit.Location = new System.Drawing.Point(1047, 46);
            this.txt_TimeLimit.Name = "txt_TimeLimit";
            this.txt_TimeLimit.Size = new System.Drawing.Size(100, 36);
            this.txt_TimeLimit.TabIndex = 8;
            this.txt_TimeLimit.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // cbb_NumberOfQuestion
            // 
            this.cbb_NumberOfQuestion.BackColor = System.Drawing.Color.Transparent;
            this.cbb_NumberOfQuestion.BorderColor = System.Drawing.Color.DarkGray;
            this.cbb_NumberOfQuestion.BorderRadius = 5;
            this.cbb_NumberOfQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_NumberOfQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NumberOfQuestion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_NumberOfQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_NumberOfQuestion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NumberOfQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_NumberOfQuestion.ItemHeight = 30;
            this.cbb_NumberOfQuestion.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.cbb_NumberOfQuestion.Location = new System.Drawing.Point(845, 46);
            this.cbb_NumberOfQuestion.Name = "cbb_NumberOfQuestion";
            this.cbb_NumberOfQuestion.Size = new System.Drawing.Size(95, 36);
            this.cbb_NumberOfQuestion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(710, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng câu hỏi";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BorderRadius = 8;
            this.btn_Cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(603, 181);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.BorderRadius = 20;
            this.btn_Cancel.ShadowDecoration.Depth = 10;
            this.btn_Cancel.ShadowDecoration.Enabled = true;
            this.btn_Cancel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Cancel.Size = new System.Drawing.Size(139, 46);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BorderRadius = 8;
            this.btn_Save.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(443, 181);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ShadowDecoration.BorderRadius = 20;
            this.btn_Save.ShadowDecoration.Depth = 10;
            this.btn_Save.ShadowDecoration.Enabled = true;
            this.btn_Save.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Save.Size = new System.Drawing.Size(139, 46);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BorderRadius = 8;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.IconLeft = global::ThiTracNghiem.Properties.Resources.search_grey;
            this.txt_Search.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_Search.Location = new System.Drawing.Point(11, 243);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Nhập nội dung cần tìm...";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(348, 37);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            this.txt_Search.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_Search_MouseDoubleClick);
            // 
            // frmManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.grb_Infor);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.grv_DataUser);
            this.Controls.Add(this.btn_Add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmManageSubject";
            this.Size = new System.Drawing.Size(1217, 662);
            this.Load += new System.EventHandler(this.frmManageSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_DataUser)).EndInit();
            this.grb_Infor.ResumeLayout(false);
            this.grb_Infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_SubjectId;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Add;
        private Guna.UI2.WinForms.Guna2DataGridView grv_DataUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_SubjectName;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_SubjectDesb;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Delete;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Edit;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Search;
        private Guna.UI2.WinForms.Guna2GroupBox grb_Infor;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Cancel;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Save;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_NumberOfQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuesQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_TimeLimit;
    }
}