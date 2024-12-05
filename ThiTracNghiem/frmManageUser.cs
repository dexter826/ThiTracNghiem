using BusinessLogicLayer;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ThiTracNghiem.Common;


namespace ThiTracNghiem
{
    public partial class frmManageUser : UserControl
    {
        private bool isAddNew = false;
        private string strMessageInputSearch = "Nhập nội dung cần tìm...";
        private int rowIndex = 0;
        public frmManageUser()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }

        private static byte[] ImageToByteArray(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        private UserAccount GetUserInfor()
        {
            UserAccount useraccount = new UserAccount();
            useraccount.Birthday = dtp_Birthday.Value;
            useraccount.Address = txt_Address.Text.Trim();
            useraccount.CreatedAt = DateTime.Now;
            useraccount.CreatedBy = Session.LogonUser.Username;
            useraccount.Email = txt_Email.Text.Trim();
            useraccount.Fullname = txt_Fullname.Text.Trim();
            useraccount.ModifiedAt = DateTime.Now;
            useraccount.ModifiedBy = Session.LogonUser.Username;
            useraccount.Note = txt_Note.Text.Trim();
            //useraccount.Image = ImageToByteArray(ptb_Avatar.Image);
            if (ptb_Avatar.Image != null)
            {
                useraccount.Image = ImageToByteArray(ptb_Avatar.Image);
            }
            else
            {
                useraccount.Image = null;
            }
            useraccount.Password = txt_Password.Text.Trim();
            useraccount.PhoneNumber = txt_PhoneMumber.Text.Trim();
            useraccount.RoldId = cbb_Role.SelectedValue.ToString();
            int.TryParse(txt_UserID.Text, out int roleId);
            useraccount.UsertId = roleId;
            useraccount.Username = txt_Username.Text.Trim();
            return useraccount;
        }

        /// <summary>
        /// Phương thức kiểm tra tính hợp lệ của các thông tin nhập vào
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private static bool IsValidUser(UserAccount user)
        {
            string strMessage = string.Empty;
            if (string.IsNullOrEmpty(user.Username))
            {
                strMessage = "Tài khoản không được để trống!\n";
            }
            if (string.IsNullOrEmpty(user.Fullname))
            {
                strMessage += "Họ tên không được để trống!\n";
            }
            if (string.IsNullOrEmpty(user.Password))
            {
                strMessage += "Mật khẩu không được để trống!\n";
            }
            if (string.IsNullOrEmpty(user.Email))
            {
                strMessage += "Email không được để trống!\n";
            }
            if (string.IsNullOrEmpty(user.PhoneNumber))
            {
                strMessage += "Số điện thoại không được để trống!\n";
            }

            //kiểm tra tuổi
            int minAge = 10;
            if (DateTime.Now.Year - user.Birthday.Year < minAge)
            {
                strMessage += $"Bạn chưa đủ tuổi! Độ tuổi tối thiểu là {minAge}\n";
            }

            //kiểm tra hợp lệ
            if (!string.IsNullOrEmpty(strMessage))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(strMessage, "Lỗi nhập liệu!\n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Phương thức kiểm tra trùng khóa chính khi thêm user mới
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        private static bool IsDuplicateUser(string username)
        {
            var users = BUserAccount.GetAll();
            foreach (DataRow user in users.Rows)
            {
                if (user["Username"].ToString().Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Phương thức để thêm người dùng vào cơ sở dữ liệu.
        /// </summary>
        private void AddNewUser()
        {
            var newUser = GetUserInfor();
            if (!IsValidUser(newUser))
                return;

            if (IsDuplicateUser(newUser.Username))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Tài khoản đã tồn tại!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                BUserAccount.AddNewUser(newUser);
                DevExpress.XtraEditors.XtraMessageBox.Show("Thêm người dùng mới thành công!", "Thông báo!");
                LoadData();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Phương thức này dùng để hiển thị/ẩn các nút lưu và hủy khi đang trong chế độ thêm/sửa người dùng. Các nút như "Thêm", "Sửa", "Xóa" sẽ bị ẩn khi lưu hoặc hủy.
        /// </summary>
        /// <param name="isSaveCancel"></param>
        private void ShowHideButton(bool isSaveCancel = false)
        {
            btn_Save.Visible = btn_Cancel.Visible = isSaveCancel;
            btn_Add.Visible = btn_Edit.Visible = btn_Delete.Visible = !isSaveCancel;
            ptb_NoImage.Visible = !isSaveCancel;
            ptb_Avatar.Visible = isSaveCancel;
        }

        private void SetEnableControl(bool isEnabled = true)
        {
            txt_UserID.Enabled = isEnabled;
            cbb_Role.Enabled = isEnabled;
            txt_Username.Enabled = isEnabled;
            txt_Fullname.Enabled = isEnabled;
            txt_Password.Enabled = isEnabled;
            txt_Email.Enabled = isEnabled;
            txt_PhoneMumber.Enabled = isEnabled;
            txt_Address.Enabled = isEnabled;
            txt_Note.Enabled = isEnabled;
            btn_UploadImg.Enabled = isEnabled;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            isAddNew = true;
            ShowHideButton(true);
            SetEnableControl(true);
            txt_UserID.Text = "0";
            txt_UserID.ReadOnly = true;
            txt_Username.Clear();
            txt_Fullname.Clear();
            txt_Password.Clear();
            txt_Email.Clear();
            txt_PhoneMumber.Clear();
            txt_Address.Clear();
            txt_Note.Clear();
            ptb_Avatar.Image = null;
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            int defaultAge = 18;
            dtp_Birthday.Value = DateTime.Now.AddYears(-defaultAge);
            LoadData();
            SetEnableControl(false);
        }

        private void LoadData()
        {
            try
            {
                grv_DataUser.AutoGenerateColumns = false;
                grv_DataUser.DataSource = BUserAccount.GetAll();

                //load data for user role
                cbb_Role.DataSource = BUserRole.GetAll();
                cbb_Role.DisplayMember = "RoleName";
                cbb_Role.ValueMember = "RoleID";

                //set data for combobox filter
                DataTable dbData = BUserRole.GetAll();
                DataRow row = dbData.NewRow();
                row["RoleName"] = "Tất cả";
                row["RoleID"] = "all";
                dbData.Rows.InsertAt(row, 0);

                cbb_RoleFilter.DataSource = dbData;
                cbb_RoleFilter.DisplayMember = "RoleName";
                cbb_RoleFilter.ValueMember = "RoleID";
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Thông báo lỗi!");
            }
        }

        private void grv_DataUser_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grv_DataUser["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
        }

        private static Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        private void ShowDetailData(int rowIndex)
        {
            try
            {
                DataGridViewRow row = grv_DataUser.Rows[rowIndex];
                txt_UserID.Text = row.Cells["UserID"].Value.ToString();
                txt_Username.Text = row.Cells["Username"].Value.ToString();
                txt_Fullname.Text = row.Cells["Fullname"].Value.ToString();
                txt_PhoneMumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_Address.Text = row.Cells["Address"].Value.ToString();
                txt_Password.Text = row.Cells["Password"].Value.ToString();
                cbb_Role.SelectedValue = row.Cells["RoleID"].Value.ToString();
                txt_Note.Text = row.Cells["Note"].Value.ToString();
                dtp_Birthday.Text = row.Cells["Birthday"].FormattedValue.ToString();
                if (row.Cells["Image"].Value is byte[] imageBytes)
                {
                    ptb_Avatar.Image = ConvertByteArrayToImage(imageBytes);
                    ptb_NoImage.Visible = false;
                    ptb_Avatar.Visible = true;
                }
                else
                {
                    ptb_Avatar.Image = null;
                    ptb_Avatar.Visible = false;
                    ptb_NoImage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grv_DataUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            rowIndex = e.RowIndex;
            ShowDetailData(rowIndex);
        }

        private void UpdateUser()
        {
            var editUser = GetUserInfor();
            if (!IsValidUser(editUser))
                return; // thoát
            try
            {
                BUserAccount.UpdateUser(editUser);
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công!", "Thông báo!");
                LoadData();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            isAddNew = false;
            ShowHideButton(true);
            SetEnableControl(true);
            txt_UserID.ReadOnly = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_UserID.Text, out int userId);
            if (userId == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo");
                return;
            }

            try
            {
                string fullname = txt_Fullname.Text.Trim();
                if (DevExpress.XtraEditors.XtraMessageBox.Show($"Bạn có chắc muốn xóa người dùng \"{fullname}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BUserAccount.DeleteUser(userId);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_Search.Text.Trim();
                if (keyword.Equals(strMessageInputSearch))
                {
                    keyword = string.Empty;
                }
                string roleFilter = cbb_RoleFilter.SelectedValue.ToString();
                grv_DataUser.DataSource = BUserAccount.Search(keyword, roleFilter);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Search_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_Search.Clear();
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text.Trim()))
            {
                txt_Search.Text = strMessageInputSearch;
            }
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            txt_Search.Clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ShowHideButton(false);
            ShowDetailData(rowIndex);
            SetEnableControl(false);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Ktra số điện thoại hợp lệ
            if (txt_PhoneMumber.Text.Length != 10)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_PhoneMumber.Focus();
                return;
            }

            //Kiểm tra email hợp lệ
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txt_Email.Text.Trim(), emailPattern))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Email không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return;
            }

            if (isAddNew)
            {
                AddNewUser();
            }
            else
            {
                UpdateUser();
            }
            ShowHideButton(false);
            SetEnableControl(false);
            ptb_NoImage.Visible = false;
            ptb_Avatar.Visible = true;
        }

        /// <summary>
        /// Kiểm tra số điện thoại hợp lệ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_PhoneMumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_UploadImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PNG files (*.png) | *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Load the image into the picture box
                    ptb_Avatar.Image = System.Drawing.Image.FromFile(filePath);
                }
            }
        }
    }
}
