using BusinessLogicLayer;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        /// <summary>
        /// Phương thức lấy thông tin người dùng từ các trường nhập liệu trên giao diện
        /// </summary>
        /// <returns></returns>
        private UserAccount GetUserInfor()
        {
            UserAccount useraccount = new UserAccount();
            useraccount.Birthday = dtp_Birthday.Value;
            useraccount.Address = txt_Address.Text.Trim();
            useraccount.CreatedAt = DateTime.Now;
            useraccount.CreatedBy = Session.LogonUser.Username; ;
            useraccount.Email = txt_Email.Text.Trim();
            useraccount.Fullname = txt_Fullname.Text.Trim();
            useraccount.ModifiedAt = DateTime.Now;
            useraccount.ModifiedBy = Session.LogonUser.Username; ;
            useraccount.Note = "new year";
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
        private bool IsValidUser(UserAccount user)
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
                MessageBox.Show(strMessage, "Lỗi nhập liệu!\n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Phương thức để thêm người dùng vào cơ sở dữ liệu.
        /// </summary>
        private void AddNewUser()
        {
            var newUser = GetUserInfor();
            if (!IsValidUser(newUser))
                return; // thoát
            try
            {
                BUserAccount.AddNewUser(newUser);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
        }

        private void SetEnableControl(bool isEnable = true)
        {
            foreach (Control ctrl in grb_Infor.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtInput = (TextBox)ctrl;
                    txtInput.Enabled = isEnable;
                }
                else if (ctrl is DateTimePicker)
                {
                    DateTimePicker dpkInput = ctrl as DateTimePicker;
                    dpkInput.Enabled = isEnable;
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox cmbInput = ctrl as ComboBox;
                    cmbInput.Enabled = isEnable;
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            isAddNew = true;
            ShowHideButton(true);
            SetEnableControl(true);
            txt_UserID.Text = "0";
            txt_UserID.ReadOnly = true;
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
                MessageBox.Show(ex.Message, "Thông báo lỗi!");
            }
        }

        private void grv_DataUser_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grv_DataUser["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
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
                dtp_Birthday.Text = row.Cells["Birthday"].FormattedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Cập nhật thành công!", "Thông báo!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo");
                return;
            }

            try
            {
                string fullname = txt_Fullname.Text.Trim();
                if (MessageBox.Show($"Bạn có chắc muốn xóa người dùng \"{fullname}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BUserAccount.DeleteUser(userId);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);            
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
                MessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Search_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_Search.Clear();
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Search.Text.Trim()))
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
        }
    }
}
