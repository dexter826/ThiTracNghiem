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
    public partial class frmManageSubject : UserControl
    {
        private bool isAddNew = false;
        private string strMessageInputSearch = "Nhập nội dung cần tìm...";
        private int rowIndex = 0;
        public frmManageSubject()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        /// <summary>
        /// Đổ màu background
        /// </summary>
        /// <param name="e"></param>
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
        /// Lấy thông tin môn thi
        /// </summary>
        /// <returns></returns>
        private Subject GetSubjectInfor()
        {
            Subject subject = new Subject();
            subject.SubjectId = txt_SubjectId.Text.Trim();
            subject.SubjectName = txt_SubjectName.Text.Trim();
            subject.QuesQuantity = int.Parse(cbb_NumberOfQuestion.Text);
            subject.Description = txt_SubjectDesb.Text.Trim();

            subject.CreatedAt = DateTime.Now;
            subject.CreatedBy = Session.LogonUser.Username; ;
            subject.ModifiedAt = DateTime.Now;
            subject.ModifiedBy = Session.LogonUser.Username; ;
            return subject;
        }
        /// <summary>
        /// Phương thức kiểm tra tính hợp lệ của thông tin môn thi
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        private static bool IsValidInfor(Subject subject)
        {
            string strMessage = string.Empty;
            if (string.IsNullOrEmpty(subject.SubjectName))
            {
                strMessage = "Tên môn thi không được để trống!\n";
            }
            if (string.IsNullOrEmpty(subject.SubjectId))
            {
                strMessage += "Mã môn thi không được để trống!\n";
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
        /// Phương thức kiểm tra trùng khóa
        /// </summary>
        /// <param name="subjectId"></param>
        /// <param name="subjectName"></param>
        /// <returns></returns>
        private bool IsDuplicateSubject(string subjectId, string subjectName)
        {
            var subjects = BSubject.GetAll();
            foreach (DataRow row in subjects.Rows)
            {
                var subject = new Subject
                {
                    SubjectId = row["SubjectId"].ToString(),
                    SubjectName = row["SubjectName"].ToString()
                };
                if (subject.SubjectId.Equals(subjectId, StringComparison.OrdinalIgnoreCase) || subject.SubjectName.Equals(subjectName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Phương thức để thêm môn thi vào cơ sở dữ liệu.
        /// </summary>
        private void AddNewSubject()
        {
            var newSubject = GetSubjectInfor();
            if (!IsValidInfor(newSubject))
                return; // thoát

            if (IsDuplicateSubject(newSubject.SubjectId, newSubject.SubjectName))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Mã môn thi hoặc tên môn thi đã tồn tại!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                BSubject.AddNewSubject(newSubject);
                DevExpress.XtraEditors.XtraMessageBox.Show("Thêm mới môn thi mới thành công!", "Thông báo!");
                LoadData();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + ex.Message);
            }
        }
        /// <summary>
        /// Phương thức điều khiển việc hiển thị các nút bấm
        /// </summary>
        /// <param name="isSaveCancel"></param>
        private void ShowHideButton(bool isSaveCancel = false)
        {
            //Nếu isSaveCancel là true, hiển thị các nút "Lưu" và "Hủy".
            btn_Save.Visible = btn_Cancel.Visible = isSaveCancel;
            //Nếu isSaveCancel là false, ẩn các nút "Lưu", "Hủy" và hiển thị các nút "Thêm", "Sửa", "Xóa".
            btn_Add.Visible = btn_Edit.Visible = btn_Delete.Visible = !isSaveCancel;
        }

        /// <summary>
        /// Phương thức kích hoạt hoặc vô hiệu hóa tất cả các điều khiển trong nhóm grb_Infor (các TextBox, DateTimePicker, ComboBox):
        /// </summary>
        /// <param name="isEnable"></param>
        private void SetEnableControl(bool isEnable = true)
        {
            grb_Infor.Enabled = isEnable;
        }
        /// <summary>
        /// Phương thức xử lý sự kiện khi người dùng nhấn nút "Thêm mới":
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Thiết lập isAddNew là true, điều này cho biết người dùng đang thêm mới môn thi.
            isAddNew = true;
            ShowHideButton(true);
            SetEnableControl(true);
            txt_SubjectId.Clear();
            txt_SubjectName.Clear();
            txt_SubjectDesb.Clear();
            txt_SubjectId.ReadOnly = false;
            txt_SubjectId.Enabled = true;
        }

        private void frmManageSubject_Load(object sender, EventArgs e)
        {
            //Tải dữ liệu môn thi và hiển thị chúng lên giao diện.
            LoadData();
            //Vô hiệu hóa tất cả các điều khiển nhập liệu.
            SetEnableControl(false);
        }
        /// <summary>
        /// Phương thức tải dữ liệu môn thi từ cơ sở dữ liệu:
        /// </summary>
        private void LoadData()
        {
            //Cập nhật nguồn dữ liệu cho grv_DataUser bằng cách lấy tất cả môn thi từ BSubject.GetAll().
            try
            {
                grv_DataUser.AutoGenerateColumns = false;
                grv_DataUser.DataSource = BSubject.GetAll();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Thông báo lỗi!");
            }
        }
        /// <summary>
        /// Phương thức định dạng lại các hàng trong DataGridView khi vẽ:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grv_DataUser_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Cập nhật số thứ tự (STT) của mỗi hàng trong bảng, đảm bảo nó có dạng "01", "02", v.v.
            grv_DataUser["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
        }
        /// <summary>
        /// Phương thức hiển thị chi tiết thông tin của môn thi khi người dùng chọn một hàng trong bảng
        /// </summary>
        /// <param name="rowIndex"></param>
        private void ShowDetailData(int rowIndex)
        {
            //Lấy thông tin môn thi từ các ô trong hàng đã chọn và hiển thị lên các ô nhập liệu.
            try
            {
                DataGridViewRow row = grv_DataUser.Rows[rowIndex];
                txt_SubjectId.Text = row.Cells["SubjectID"].Value.ToString();
                txt_SubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                cbb_NumberOfQuestion.Text = row.Cells["QuesQuantity"].Value.ToString();
                txt_SubjectDesb.Text = row.Cells["Description"].Value.ToString();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Phương thức xử lý sự kiện khi người dùng chọn một hàng trong DataGridView:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grv_DataUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            //Cập nhật rowIndex với chỉ số hàng hiện tại.
            rowIndex = e.RowIndex;
            //Hiển thị chi tiết môn thi từ ShowDetailData(rowIndex).
            ShowDetailData(rowIndex);
        }
        /// <summary>
        /// Phương thức cập nhật thông tin môn thi:
        /// </summary>
        private void UpdateSubject()
        {
            //Lấy thông tin môn thi mới từ GetSubjectInfor().
            var editSubject = GetSubjectInfor();
            //Kiểm tra tính hợp lệ và nếu hợp lệ, gọi BSubject.UpdateSubject(editSubject) để cập nhật môn thi trong cơ sở dữ liệu.
            if (!IsValidInfor(editSubject))
                return; // thoát
            try
            {
                BSubject.UpdateSubject(editSubject);
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
            //Thiết lập isAddNew là false, cho biết người dùng đang sửa môn thi.
            isAddNew = false;
            //Hiển thị các nút "Lưu" và "Hủy", đồng thời ẩn các nút khác.
            ShowHideButton(true);
            //Kích hoạt tất cả các điều khiển và làm cho ô SubjectId không thể sửa.
            SetEnableControl(true);
            txt_SubjectId.ReadOnly = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string subjectId = txt_SubjectId.Text.Trim();
            if (string.IsNullOrEmpty(subjectId) || rowIndex < 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn môn thi cần xóa!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            try
            {
                string fullname = txt_SubjectName.Text.Trim();
                if (DevExpress.XtraEditors.XtraMessageBox.Show($"Bạn có chắc muốn xóa môn thi \"{fullname}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BSubject.DeleteSubject(subjectId);
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
                grv_DataUser.DataSource = BSubject.Search(keyword);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Phương thức xử lý sự kiện khi người dùng nhấp đúp chuột vào ô tìm kiếm:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Search_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_Search.Clear(); //Xóa nội dung trong ô tìm kiếm.
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text.Trim()))
            {
                txt_Search.Text = strMessageInputSearch; //Đặt lại giá trị mặc định "Nhập nội dung cần tìm...".
            }
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            txt_Search.Clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Ẩn các nút "Lưu" và "Hủy". Hiển thị lại thông tin môn thi đã chọn và vô hiệu hóa các điều khiển.
            ShowHideButton(false);
            ShowDetailData(rowIndex);
            SetEnableControl(false);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Nếu đang thêm môn thi mới, gọi phương thức AddNewSubject().
            if (isAddNew)
            {
                AddNewSubject();
            }
            //Nếu đang sửa môn thi, gọi phương thức UpdateSubject().
            else
            {
                UpdateSubject();
            }
            //Sau khi lưu thành công, ẩn các nút "Lưu" và "Hủy", vô hiệu hóa các điều khiển.
            ShowHideButton(false);
            SetEnableControl(false);
        }
    }
}
