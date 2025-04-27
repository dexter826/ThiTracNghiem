namespace ThiTracNghiem
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_TaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Update = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Thoat = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txt_NewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ConfirmNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_ShowPasswordCurrent = new DevExpress.XtraEditors.PictureEdit();
            this.btn_ShowNewPass = new DevExpress.XtraEditors.PictureEdit();
            this.btn_ShowReNewPass = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowPasswordCurrent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowReNewPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(139, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay đổi mật khẩu";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txt_TaiKhoan.BorderColor = System.Drawing.Color.Empty;
            this.txt_TaiKhoan.BorderThickness = 2;
            this.txt_TaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TaiKhoan.DefaultText = "";
            this.txt_TaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TaiKhoan.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TaiKhoan.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.ForeColor = System.Drawing.Color.Empty;
            this.txt_TaiKhoan.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txt_TaiKhoan.Location = new System.Drawing.Point(74, 95);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(6);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.PasswordChar = '\0';
            this.txt_TaiKhoan.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_TaiKhoan.PlaceholderText = "Nhập tài khoản";
            this.txt_TaiKhoan.SelectedText = "";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(404, 33);
            this.txt_TaiKhoan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TaiKhoan.TabIndex = 2;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txt_MatKhau.BorderColor = System.Drawing.Color.Empty;
            this.txt_MatKhau.BorderThickness = 2;
            this.txt_MatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MatKhau.DefaultText = "";
            this.txt_MatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.ForeColor = System.Drawing.Color.Empty;
            this.txt_MatKhau.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txt_MatKhau.Location = new System.Drawing.Point(74, 152);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(6);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_MatKhau.PlaceholderText = "Nhập mật khẩu hiện tại";
            this.txt_MatKhau.SelectedText = "";
            this.txt_MatKhau.Size = new System.Drawing.Size(404, 33);
            this.txt_MatKhau.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_MatKhau.TabIndex = 4;
            // 
            // btn_Update
            // 
            this.btn_Update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Update.BorderRadius = 8;
            this.btn_Update.BorderThickness = 2;
            this.btn_Update.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Update.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Update.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_Update.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Update.Location = new System.Drawing.Point(97, 332);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.BorderRadius = 20;
            this.btn_Update.ShadowDecoration.Depth = 10;
            this.btn_Update.ShadowDecoration.Enabled = true;
            this.btn_Update.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Update.Size = new System.Drawing.Size(166, 54);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Thoat.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Thoat.BorderRadius = 8;
            this.btn_Thoat.BorderThickness = 2;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Thoat.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Thoat.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_Thoat.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Thoat.Location = new System.Drawing.Point(290, 332);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.ShadowDecoration.BorderRadius = 20;
            this.btn_Thoat.ShadowDecoration.Depth = 10;
            this.btn_Thoat.ShadowDecoration.Enabled = true;
            this.btn_Thoat.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Thoat.Size = new System.Drawing.Size(166, 54);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txt_NewPassword.BorderColor = System.Drawing.Color.Empty;
            this.txt_NewPassword.BorderThickness = 2;
            this.txt_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NewPassword.DefaultText = "";
            this.txt_NewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NewPassword.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NewPassword.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NewPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPassword.ForeColor = System.Drawing.Color.Empty;
            this.txt_NewPassword.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txt_NewPassword.Location = new System.Drawing.Point(74, 208);
            this.txt_NewPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.PasswordChar = '*';
            this.txt_NewPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_NewPassword.PlaceholderText = "Nhập mật khẩu mới";
            this.txt_NewPassword.SelectedText = "";
            this.txt_NewPassword.Size = new System.Drawing.Size(404, 33);
            this.txt_NewPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_NewPassword.TabIndex = 6;
            // 
            // txt_ConfirmNewPassword
            // 
            this.txt_ConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txt_ConfirmNewPassword.BorderColor = System.Drawing.Color.Empty;
            this.txt_ConfirmNewPassword.BorderThickness = 2;
            this.txt_ConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ConfirmNewPassword.DefaultText = "";
            this.txt_ConfirmNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ConfirmNewPassword.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ConfirmNewPassword.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ConfirmNewPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmNewPassword.ForeColor = System.Drawing.Color.Empty;
            this.txt_ConfirmNewPassword.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txt_ConfirmNewPassword.Location = new System.Drawing.Point(74, 264);
            this.txt_ConfirmNewPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txt_ConfirmNewPassword.Name = "txt_ConfirmNewPassword";
            this.txt_ConfirmNewPassword.PasswordChar = '*';
            this.txt_ConfirmNewPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_ConfirmNewPassword.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txt_ConfirmNewPassword.SelectedText = "";
            this.txt_ConfirmNewPassword.Size = new System.Drawing.Size(404, 33);
            this.txt_ConfirmNewPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_ConfirmNewPassword.TabIndex = 8;
            // 
            // btn_ShowPasswordCurrent
            // 
            this.btn_ShowPasswordCurrent.EditValue = global::ThiTracNghiem.Properties.Resources.closeeye;
            this.btn_ShowPasswordCurrent.Location = new System.Drawing.Point(448, 152);
            this.btn_ShowPasswordCurrent.Name = "btn_ShowPasswordCurrent";
            this.btn_ShowPasswordCurrent.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShowPasswordCurrent.Properties.Appearance.Options.UseBackColor = true;
            this.btn_ShowPasswordCurrent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_ShowPasswordCurrent.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btn_ShowPasswordCurrent.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.btn_ShowPasswordCurrent.Size = new System.Drawing.Size(30, 24);
            this.btn_ShowPasswordCurrent.TabIndex = 14;
            this.btn_ShowPasswordCurrent.Click += new System.EventHandler(this.btn_ShowPasswordCurrent_Click);
            // 
            // btn_ShowNewPass
            // 
            this.btn_ShowNewPass.EditValue = global::ThiTracNghiem.Properties.Resources.closeeye;
            this.btn_ShowNewPass.Location = new System.Drawing.Point(448, 208);
            this.btn_ShowNewPass.Name = "btn_ShowNewPass";
            this.btn_ShowNewPass.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShowNewPass.Properties.Appearance.Options.UseBackColor = true;
            this.btn_ShowNewPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_ShowNewPass.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btn_ShowNewPass.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.btn_ShowNewPass.Size = new System.Drawing.Size(30, 24);
            this.btn_ShowNewPass.TabIndex = 15;
            this.btn_ShowNewPass.Click += new System.EventHandler(this.btn_ShowNewPass_Click);
            // 
            // btn_ShowReNewPass
            // 
            this.btn_ShowReNewPass.EditValue = global::ThiTracNghiem.Properties.Resources.closeeye;
            this.btn_ShowReNewPass.Location = new System.Drawing.Point(448, 264);
            this.btn_ShowReNewPass.Name = "btn_ShowReNewPass";
            this.btn_ShowReNewPass.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShowReNewPass.Properties.Appearance.Options.UseBackColor = true;
            this.btn_ShowReNewPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_ShowReNewPass.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btn_ShowReNewPass.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.btn_ShowReNewPass.Size = new System.Drawing.Size(30, 24);
            this.btn_ShowReNewPass.TabIndex = 16;
            this.btn_ShowReNewPass.Click += new System.EventHandler(this.btn_ShowReNewPass_Click);
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btn_Update;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(553, 412);
            this.Controls.Add(this.btn_ShowReNewPass);
            this.Controls.Add(this.btn_ShowNewPass);
            this.Controls.Add(this.btn_ShowPasswordCurrent);
            this.Controls.Add(this.txt_ConfirmNewPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmChangePassword.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(569, 452);
            this.MinimumSize = new System.Drawing.Size(555, 444);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowPasswordCurrent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ShowReNewPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_TaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txt_MatKhau;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Update;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Thoat;
        private Guna.UI2.WinForms.Guna2TextBox txt_NewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_ConfirmNewPassword;
        private DevExpress.XtraEditors.PictureEdit btn_ShowPasswordCurrent;
        private DevExpress.XtraEditors.PictureEdit btn_ShowNewPass;
        private DevExpress.XtraEditors.PictureEdit btn_ShowReNewPass;
    }
}