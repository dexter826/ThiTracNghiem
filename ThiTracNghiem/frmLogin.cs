using BusinessLogicLayer;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Windows.Forms;
using ThiTracNghiem.Common;


namespace ThiTracNghiem
{
    public partial class frmLogin : XtraForm
    {
        public bool IsLoginSuccess = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        /// <summary>
        /// Phương thức kiểm tra tính hợp lệ của thông tin tài khoản người dùng:
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private bool IsValidUser(UserAccount user)
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
            return true;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //Lấy thông tin từ giao diện
            UserAccount eUser = new UserAccount()
            {
                Username = txt_TaiKhoan.Text.Trim(),
                Password = txt_MatKhau.Text.Trim()
            };

            //Kiểm tra thông tin hợp lệ
            if (!IsValidUser(eUser))
                return;

            try
            {
                //Kiểm tra tài khoản đăng nhập(kết nối tới csdl)
                if (BUserAccount.IsExistsAccount(eUser))
                {
                    IsLoginSuccess = true;
                    Session.LogonUser = BUserAccount.GetInforUser(eUser.Username);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TaiKhoan_Enter(object sender, EventArgs e)
        {
            txt_TaiKhoan.IconLeft = Properties.Resources.profile_avatar___copy;
        }

        private void txt_TaiKhoan_Leave(object sender, EventArgs e)
        {
            txt_TaiKhoan.IconLeft = Properties.Resources.profile_avatar;
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            txt_MatKhau.IconLeft = Properties.Resources._lock;
        }

        private void txt_MatKhau_Enter(object sender, EventArgs e)
        {
            txt_MatKhau.IconLeft = Properties.Resources.lock___Copy;
        }
    }
}
