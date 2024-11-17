namespace ThiTracNghiem
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            this.btn_SendOtp = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_VerifyOtp = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txt_Otp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Timer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btn_SendOtp
            // 
            this.btn_SendOtp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendOtp.BackColor = System.Drawing.Color.Transparent;
            this.btn_SendOtp.BorderColor = System.Drawing.Color.Transparent;
            this.btn_SendOtp.BorderRadius = 12;
            this.btn_SendOtp.BorderThickness = 2;
            this.btn_SendOtp.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.btn_SendOtp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendOtp.ForeColor = System.Drawing.Color.White;
            this.btn_SendOtp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_SendOtp.HoverState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_SendOtp.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_SendOtp.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_SendOtp.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_SendOtp.Location = new System.Drawing.Point(154, 78);
            this.btn_SendOtp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_SendOtp.Name = "btn_SendOtp";
            this.btn_SendOtp.ShadowDecoration.BorderRadius = 20;
            this.btn_SendOtp.ShadowDecoration.Depth = 20;
            this.btn_SendOtp.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_SendOtp.Size = new System.Drawing.Size(156, 45);
            this.btn_SendOtp.TabIndex = 6;
            this.btn_SendOtp.Text = "Gửi mã xác nhận";
            this.btn_SendOtp.Click += new System.EventHandler(this.btn_SendOtp_Click);
            // 
            // btn_VerifyOtp
            // 
            this.btn_VerifyOtp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_VerifyOtp.BackColor = System.Drawing.Color.Transparent;
            this.btn_VerifyOtp.BorderColor = System.Drawing.Color.Transparent;
            this.btn_VerifyOtp.BorderRadius = 12;
            this.btn_VerifyOtp.BorderThickness = 2;
            this.btn_VerifyOtp.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.btn_VerifyOtp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerifyOtp.ForeColor = System.Drawing.Color.White;
            this.btn_VerifyOtp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_VerifyOtp.HoverState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_VerifyOtp.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_VerifyOtp.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_VerifyOtp.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_VerifyOtp.Location = new System.Drawing.Point(154, 176);
            this.btn_VerifyOtp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_VerifyOtp.Name = "btn_VerifyOtp";
            this.btn_VerifyOtp.ShadowDecoration.BorderRadius = 20;
            this.btn_VerifyOtp.ShadowDecoration.Depth = 20;
            this.btn_VerifyOtp.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_VerifyOtp.Size = new System.Drawing.Size(156, 45);
            this.btn_VerifyOtp.TabIndex = 8;
            this.btn_VerifyOtp.Text = "Xác nhận";
            this.btn_VerifyOtp.Click += new System.EventHandler(this.btn_VerifyOtp_Click);
            // 
            // txt_Otp
            // 
            this.txt_Otp.BackColor = System.Drawing.Color.Transparent;
            this.txt_Otp.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Otp.BorderThickness = 2;
            this.txt_Otp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Otp.DefaultText = "";
            this.txt_Otp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Otp.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Otp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Otp.ForeColor = System.Drawing.Color.Empty;
            this.txt_Otp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Otp.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Otp.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txt_Otp.Location = new System.Drawing.Point(78, 133);
            this.txt_Otp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Otp.Name = "txt_Otp";
            this.txt_Otp.PasswordChar = '\0';
            this.txt_Otp.PlaceholderText = "Nhập mã xác nhận";
            this.txt_Otp.SelectedText = "";
            this.txt_Otp.Size = new System.Drawing.Size(309, 33);
            this.txt_Otp.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Otp.TabIndex = 9;
            this.txt_Otp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Otp.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Timer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Timer.Location = new System.Drawing.Point(327, 89);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(21, 22);
            this.lbl_Timer.TabIndex = 10;
            this.lbl_Timer.Text = "60";
            this.lbl_Timer.Visible = false;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.Transparent;
            this.txt_Email.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Email.BorderThickness = 2;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.DefaultText = "";
            this.txt_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.Empty;
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.IconLeft = global::ThiTracNghiem.Properties.Resources.mail;
            this.txt_Email.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txt_Email.Location = new System.Drawing.Point(78, 35);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderText = "Vui lòng nhập email để lấy mã";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(309, 33);
            this.txt_Email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Email.TabIndex = 7;
            this.txt_Email.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // frmForgotPassword
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 250);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.txt_Otp);
            this.Controls.Add(this.btn_VerifyOtp);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.btn_SendOtp);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmForgotPassword.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton btn_SendOtp;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_VerifyOtp;
        private Guna.UI2.WinForms.Guna2TextBox txt_Otp;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Timer;
    }
}