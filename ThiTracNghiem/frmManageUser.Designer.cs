namespace ThiTracNghiem
{
    partial class frmManageUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_UserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Add = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.grv_DataUser = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Fullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_PhoneMumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Search = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.grb_Infor = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_Note = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_Birthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Save = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.cbb_RoleFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptb_NoImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_UploadImg = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ptb_Avatar = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DataUser)).BeginInit();
            this.grb_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_UserID
            // 
            this.txt_UserID.BorderRadius = 5;
            this.txt_UserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserID.DefaultText = "";
            this.txt_UserID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(139, 46);
            this.txt_UserID.Margin = new System.Windows.Forms.Padding(5);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.PasswordChar = '\0';
            this.txt_UserID.PlaceholderText = "";
            this.txt_UserID.SelectedText = "";
            this.txt_UserID.Size = new System.Drawing.Size(246, 36);
            this.txt_UserID.TabIndex = 1;
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
            this.btn_Add.Location = new System.Drawing.Point(435, 277);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.grv_DataUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_DataUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_DataUser.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grv_DataUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_DataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_DataUser.ColumnHeadersHeight = 40;
            this.grv_DataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_DataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Fullname,
            this.Username,
            this.UserId,
            this.PhoneNumber,
            this.Email,
            this.Address,
            this.Birthday,
            this.Password,
            this.RoleId,
            this.Image,
            this.Note});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_DataUser.DefaultCellStyle = dataGridViewCellStyle5;
            this.grv_DataUser.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_DataUser.Location = new System.Drawing.Point(5, 377);
            this.grv_DataUser.Margin = new System.Windows.Forms.Padding(5);
            this.grv_DataUser.Name = "grv_DataUser";
            this.grv_DataUser.ReadOnly = true;
            this.grv_DataUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_DataUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grv_DataUser.RowHeadersVisible = false;
            this.grv_DataUser.RowHeadersWidth = 51;
            this.grv_DataUser.RowTemplate.Height = 40;
            this.grv_DataUser.Size = new System.Drawing.Size(1354, 280);
            this.grv_DataUser.TabIndex = 7;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_DataUser.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grv_DataUser.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_DataUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_DataUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_DataUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_DataUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_DataUser.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_DataUser.ThemeStyle.ReadOnly = true;
            this.grv_DataUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_DataUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "Họ và tên";
            this.Fullname.MinimumWidth = 6;
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tài khoản";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserId.DataPropertyName = "UserID";
            this.UserId.HeaderText = "Mã người dùng";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 150;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Số điện thoại";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "dd/MM/yyyy";
            this.Birthday.DefaultCellStyle = dataGridViewCellStyle4;
            this.Birthday.HeaderText = "Ngày sinh";
            this.Birthday.MinimumWidth = 6;
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "RoleID";
            this.RoleId.HeaderText = "Chức vụ";
            this.RoleId.MinimumWidth = 6;
            this.RoleId.Name = "RoleId";
            this.RoleId.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Visible = false;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tài khoản";
            // 
            // txt_Username
            // 
            this.txt_Username.BorderRadius = 5;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.DefaultText = "";
            this.txt_Username.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(139, 150);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PlaceholderText = "";
            this.txt_Username.SelectedText = "";
            this.txt_Username.Size = new System.Drawing.Size(246, 36);
            this.txt_Username.TabIndex = 5;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderRadius = 5;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.DefaultText = "";
            this.txt_Email.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(498, 150);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(253, 36);
            this.txt_Email.TabIndex = 11;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderRadius = 5;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(498, 98);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.PlaceholderText = "";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(253, 36);
            this.txt_Password.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Họ và tên";
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.BorderRadius = 5;
            this.txt_Fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fullname.DefaultText = "";
            this.txt_Fullname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fullname.Location = new System.Drawing.Point(498, 46);
            this.txt_Fullname.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.PasswordChar = '\0';
            this.txt_Fullname.PlaceholderText = "";
            this.txt_Fullname.SelectedText = "";
            this.txt_Fullname.Size = new System.Drawing.Size(253, 36);
            this.txt_Fullname.TabIndex = 7;
            // 
            // txt_Address
            // 
            this.txt_Address.BorderRadius = 5;
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.DefaultText = "";
            this.txt_Address.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(879, 150);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.PlaceholderText = "";
            this.txt_Address.SelectedText = "";
            this.txt_Address.Size = new System.Drawing.Size(246, 36);
            this.txt_Address.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(775, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(775, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ngày sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(775, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số điện thoại";
            // 
            // txt_PhoneMumber
            // 
            this.txt_PhoneMumber.BorderRadius = 5;
            this.txt_PhoneMumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PhoneMumber.DefaultText = "";
            this.txt_PhoneMumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneMumber.Location = new System.Drawing.Point(879, 46);
            this.txt_PhoneMumber.Margin = new System.Windows.Forms.Padding(5);
            this.txt_PhoneMumber.Name = "txt_PhoneMumber";
            this.txt_PhoneMumber.PasswordChar = '\0';
            this.txt_PhoneMumber.PlaceholderText = "";
            this.txt_PhoneMumber.SelectedText = "";
            this.txt_PhoneMumber.Size = new System.Drawing.Size(246, 36);
            this.txt_PhoneMumber.TabIndex = 13;
            this.txt_PhoneMumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PhoneMumber_KeyPress);
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
            this.btn_Delete.Location = new System.Drawing.Point(775, 277);
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
            this.btn_Edit.Location = new System.Drawing.Point(605, 277);
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
            this.btn_Search.Location = new System.Drawing.Point(520, 331);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.BorderRadius = 15;
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
            this.grb_Infor.Controls.Add(this.ptb_NoImage);
            this.grb_Infor.Controls.Add(this.btn_UploadImg);
            this.grb_Infor.Controls.Add(this.ptb_Avatar);
            this.grb_Infor.Controls.Add(this.txt_Note);
            this.grb_Infor.Controls.Add(this.label1);
            this.grb_Infor.Controls.Add(this.cbb_Role);
            this.grb_Infor.Controls.Add(this.dtp_Birthday);
            this.grb_Infor.Controls.Add(this.txt_Address);
            this.grb_Infor.Controls.Add(this.label8);
            this.grb_Infor.Controls.Add(this.label9);
            this.grb_Infor.Controls.Add(this.label10);
            this.grb_Infor.Controls.Add(this.txt_PhoneMumber);
            this.grb_Infor.Controls.Add(this.txt_Email);
            this.grb_Infor.Controls.Add(this.txt_Password);
            this.grb_Infor.Controls.Add(this.label5);
            this.grb_Infor.Controls.Add(this.label6);
            this.grb_Infor.Controls.Add(this.label7);
            this.grb_Infor.Controls.Add(this.txt_Fullname);
            this.grb_Infor.Controls.Add(this.txt_Username);
            this.grb_Infor.Controls.Add(this.label4);
            this.grb_Infor.Controls.Add(this.label3);
            this.grb_Infor.Controls.Add(this.label2);
            this.grb_Infor.Controls.Add(this.txt_UserID);
            this.grb_Infor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Infor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grb_Infor.Location = new System.Drawing.Point(5, 15);
            this.grb_Infor.Margin = new System.Windows.Forms.Padding(5);
            this.grb_Infor.Name = "grb_Infor";
            this.grb_Infor.Padding = new System.Windows.Forms.Padding(5);
            this.grb_Infor.Size = new System.Drawing.Size(1354, 254);
            this.grb_Infor.TabIndex = 0;
            this.grb_Infor.TabStop = false;
            this.grb_Infor.Text = "Thông tin người dùng";
            // 
            // txt_Note
            // 
            this.txt_Note.BorderRadius = 5;
            this.txt_Note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Note.DefaultText = "";
            this.txt_Note.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Note.Location = new System.Drawing.Point(139, 202);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.PasswordChar = '\0';
            this.txt_Note.PlaceholderText = "";
            this.txt_Note.SelectedText = "";
            this.txt_Note.Size = new System.Drawing.Size(986, 36);
            this.txt_Note.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ghi chú";
            // 
            // cbb_Role
            // 
            this.cbb_Role.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Role.BorderRadius = 5;
            this.cbb_Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Role.FocusedColor = System.Drawing.Color.Empty;
            this.cbb_Role.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Role.FormattingEnabled = true;
            this.cbb_Role.ItemHeight = 30;
            this.cbb_Role.Location = new System.Drawing.Point(139, 98);
            this.cbb_Role.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Role.Name = "cbb_Role";
            this.cbb_Role.Size = new System.Drawing.Size(246, 36);
            this.cbb_Role.TabIndex = 3;
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.BorderRadius = 5;
            this.dtp_Birthday.Checked = true;
            this.dtp_Birthday.CustomFormat = "dd/MM/yyyy";
            this.dtp_Birthday.FillColor = System.Drawing.Color.Empty;
            this.dtp_Birthday.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Birthday.Location = new System.Drawing.Point(880, 98);
            this.dtp_Birthday.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_Birthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Birthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.Size = new System.Drawing.Size(137, 36);
            this.dtp_Birthday.TabIndex = 15;
            this.dtp_Birthday.Value = new System.DateTime(2024, 10, 1, 17, 28, 8, 142);
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
            this.btn_Cancel.Location = new System.Drawing.Point(686, 278);
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
            this.btn_Save.Location = new System.Drawing.Point(525, 278);
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
            // cbb_RoleFilter
            // 
            this.cbb_RoleFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbb_RoleFilter.BorderRadius = 8;
            this.cbb_RoleFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_RoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_RoleFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbb_RoleFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_RoleFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_RoleFilter.FormattingEnabled = true;
            this.cbb_RoleFilter.ItemHeight = 30;
            this.cbb_RoleFilter.Location = new System.Drawing.Point(17, 331);
            this.cbb_RoleFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_RoleFilter.Name = "cbb_RoleFilter";
            this.cbb_RoleFilter.Size = new System.Drawing.Size(135, 36);
            this.cbb_RoleFilter.TabIndex = 18;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderRadius = 8;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.IconLeft = global::ThiTracNghiem.Properties.Resources.search_grey;
            this.txt_Search.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_Search.Location = new System.Drawing.Point(162, 331);
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
            // ptb_NoImage
            // 
            this.ptb_NoImage.BorderRadius = 5;
            this.ptb_NoImage.Image = global::ThiTracNghiem.Properties.Resources.No_Image;
            this.ptb_NoImage.ImageRotate = 0F;
            this.ptb_NoImage.Location = new System.Drawing.Point(1190, 44);
            this.ptb_NoImage.Name = "ptb_NoImage";
            this.ptb_NoImage.Size = new System.Drawing.Size(107, 160);
            this.ptb_NoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_NoImage.TabIndex = 19;
            this.ptb_NoImage.TabStop = false;
            // 
            // btn_UploadImg
            // 
            this.btn_UploadImg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_UploadImg.BackColor = System.Drawing.Color.Transparent;
            this.btn_UploadImg.BorderColor = System.Drawing.Color.DimGray;
            this.btn_UploadImg.BorderRadius = 4;
            this.btn_UploadImg.BorderThickness = 1;
            this.btn_UploadImg.FillColor = System.Drawing.Color.Silver;
            this.btn_UploadImg.FillColor2 = System.Drawing.Color.Silver;
            this.btn_UploadImg.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btn_UploadImg.ForeColor = System.Drawing.Color.Black;
            this.btn_UploadImg.Image = global::ThiTracNghiem.Properties.Resources.upload_img;
            this.btn_UploadImg.Location = new System.Drawing.Point(1207, 212);
            this.btn_UploadImg.Margin = new System.Windows.Forms.Padding(5);
            this.btn_UploadImg.Name = "btn_UploadImg";
            this.btn_UploadImg.ShadowDecoration.BorderRadius = 15;
            this.btn_UploadImg.ShadowDecoration.Depth = 10;
            this.btn_UploadImg.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_UploadImg.Size = new System.Drawing.Size(73, 29);
            this.btn_UploadImg.TabIndex = 20;
            this.btn_UploadImg.Click += new System.EventHandler(this.btn_UploadImg_Click);
            // 
            // ptb_Avatar
            // 
            this.ptb_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Avatar.BorderRadius = 5;
            this.ptb_Avatar.FillColor = System.Drawing.Color.Gainsboro;
            this.ptb_Avatar.ImageRotate = 0F;
            this.ptb_Avatar.Location = new System.Drawing.Point(1190, 46);
            this.ptb_Avatar.Name = "ptb_Avatar";
            this.ptb_Avatar.Size = new System.Drawing.Size(107, 160);
            this.ptb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Avatar.TabIndex = 20;
            this.ptb_Avatar.TabStop = false;
            // 
            // frmManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_RoleFilter);
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
            this.Name = "frmManageUser";
            this.Size = new System.Drawing.Size(1364, 662);
            this.Load += new System.EventHandler(this.frmManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_DataUser)).EndInit();
            this.grb_Infor.ResumeLayout(false);
            this.grb_Infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_UserID;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Add;
        private Guna.UI2.WinForms.Guna2DataGridView grv_DataUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_Fullname;
        private Guna.UI2.WinForms.Guna2TextBox txt_Address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_PhoneMumber;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Delete;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Edit;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Search;
        private Guna.UI2.WinForms.Guna2GroupBox grb_Infor;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Birthday;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Cancel;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Save;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Role;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_RoleFilter;
        private Guna.UI2.WinForms.Guna2TextBox txt_Note;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_Avatar;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_UploadImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_NoImage;
    }
}