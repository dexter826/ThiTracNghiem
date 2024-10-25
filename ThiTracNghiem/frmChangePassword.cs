using BusinessLogicLayer;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ThiTracNghiem
{
    public partial class frmChangePassword : XtraForm
    {
        public bool IsLoginSuccess = false;
        public frmChangePassword()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    Rectangle rc = ClientRectangle;
        //    if (rc.IsEmpty)
        //        return;
        //    if (rc.Width == 0 || rc.Height == 0)
        //        return;
        //    using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
        //    {
        //        e.Graphics.FillRectangle(brush, rc);
        //    }
        //}

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidUserInfor(UserAccount user)
        {
            if (string.IsNullOrEmpty(user.Username))
            {
                XtraMessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(user.Password))
            {
                XtraMessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(user.NewPassword))
            {
                XtraMessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(user.ConfirmNewPassword))
            {
                XtraMessageBox.Show("Vui lòng xác nhận mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //kiểm tra tài khoản và mật khẩu phải đúng
            if (!BUserAccount.IsExistsAccount(user))
            {
                XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //kiểm tra mk mới và xác nhận mk mới phải giống nhau
            if (!user.NewPassword.Equals(user.ConfirmNewPassword))
            {
                XtraMessageBox.Show("Mật khẩu mới và xác nhận mật khẩu mới phải giống nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            UserAccount eUser = new UserAccount()
            {
                Username = txt_TaiKhoan.Text.Trim(),
                Password = txt_MatKhau.Text.Trim(),
                NewPassword = txt_NewPassword.Text.Trim(),
                ConfirmNewPassword = txt_ConfirmNewPassword.Text.Trim()
            };

            //Kiểm tra thông tin hợp lệ
            if (!IsValidUserInfor(eUser))
                return;

            //Cập nhật mk mới cho người dùng
            try
            {
                BUserAccount.UpdatePassword(eUser);
                XtraMessageBox.Show("Cập nhật mật khẩu thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
