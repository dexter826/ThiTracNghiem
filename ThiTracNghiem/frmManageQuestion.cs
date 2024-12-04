using BusinessLogicLayer;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ThiTracNghiem.Common;


namespace ThiTracNghiem
{
    public partial class frmManageQuestion : UserControl
    {
        private bool isAddNew = false;
        private string strMessageInputSearch = "Nhập nội dung cần tìm...";
        private int rowIndex = 0;
        public frmManageQuestion()
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
        /// Phương thức thu thập dữ liệu từ các điều khiển trong form (như các TextBox, ComboBox) và trả về một đối tượng Question chứa thông tin câu hỏi cần thêm hoặc chỉnh sửa.
        /// </summary>
        /// <returns></returns>
        private Question GetQuestionInfor()
        {
            Question question = new Question();
            int.TryParse(txt_QuestionId.Text, out int roleId);
            question.QuestionID = roleId;
            question.QContent = txt_QContent.Text.Trim();
            question.Answer = txt_CorrectAnswer.Text.Trim();
            question.OptionA = txt_OptionA.Text.Trim();
            question.OptionB = txt_OptionB.Text.Trim();
            question.OptionC = txt_OptionC.Text.Trim();
            question.OptionD = txt_OptionD.Text.Trim();
            question.SubjectID = cbb_Subject.SelectedValue.ToString();
            question.CreatedAt = DateTime.Now;
            question.CreatedBy = Session.LogonUser.Username;
            question.ModifiedBy = Session.LogonUser.Username;
            return question;
        }

        /// <summary>
        /// Phương thức kiểm tra tính hợp lệ của câu hỏi:
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        private static bool IsValidQuestion(Question question)
        {
            string strMessage = string.Empty;
            if (string.IsNullOrEmpty(question.QContent))
            {
                strMessage = "Nội dung câu hỏi không được để trống!\n";
            }
            if (string.IsNullOrEmpty(question.OptionA))
            {
                strMessage += "Lựa chọn A không được để trống!\n";
            }
            if (string.IsNullOrEmpty(question.OptionB))
            {
                strMessage += "Lựa chọn B không được để trống!\n";
            }
            if (string.IsNullOrEmpty(question.OptionC))
            {
                strMessage += "Lựa chọn C không được để trống!\n";
            }
            if (string.IsNullOrEmpty(question.OptionD))
            {
                strMessage += "Lựa chọn D không được để trống!\n";
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
        /// Phương thức thêm câu hỏi
        /// </summary>
        private void AddNewQuestion()
        {
            var newQuestion = GetQuestionInfor();
            //kiểm tra tính hợp lệ của câu hỏi
            if (!IsValidQuestion(newQuestion))
                return; // thoát
            try
            {
                //Thêm câu hỏi mới vào cơ sở dữ liệu thông qua BQuestion.AddNewQuestion.
                BQuestion.AddNewQuestion(newQuestion);
                LoadData();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Ẩn/hiện các nút "Save" và "Cancel" (nếu isSaveCancel là true), đồng thời hiển thị các nút "Add", "Edit", "Delete" (nếu isSaveCancel là false).
        /// </summary>
        /// <param name="isSaveCancel"></param>
        private void ShowHideButton(bool isSaveCancel = false)
        {
            btn_Save.Visible = btn_Cancel.Visible = isSaveCancel;
            btn_Add.Visible = btn_Edit.Visible = btn_Delete.Visible = !isSaveCancel;
        }
        /// <summary>
        /// Kích hoạt hoặc vô hiệu hóa tất cả các điều khiển trong nhóm grb_Infor (các TextBox, ComboBox, DateTimePicker), giúp dễ dàng cho phép người dùng chỉnh sửa hoặc chỉ xem thông tin.
        /// </summary>
        /// <param name="isEnable"></param>
        private void SetEnableControl(bool isEnable = true)
        {
            grb_Infor.Enabled = isEnable;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            isAddNew = true; //Thiết lập isAddNew = true, hiển thị các nút "Save" và "Cancel"
            ShowHideButton(true);
            SetEnableControl(true);
            txt_QuestionId.Text = "0";
            txt_QuestionId.ReadOnly = true;
        }

        private void frmManageQuestion_Load(object sender, EventArgs e)
        {
            LoadData();
            SetEnableControl(false);
        }

        /// <summary>
        /// Tải danh sách tất cả các câu hỏi từ cơ sở dữ liệu và hiển thị chúng trên DataGridView. Đồng thời, tải dữ liệu các môn học từ bảng Subject để hiển thị trong ComboBox.
        /// </summary>
        private void LoadData()
        {
            try
            {
                grv_DataUser.AutoGenerateColumns = false;
                grv_DataUser.DataSource = BQuestion.GetAll();
                cbb_Subject.DataSource = BSubject.GetAll();
                cbb_Subject.DisplayMember = "SubjectName";
                cbb_Subject.ValueMember = "SubjectID";
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
        /// <summary>
        /// Hiển thị chi tiết câu hỏi ở dòng được chọn trong DataGridView vào các trường nhập liệu trong form.
        /// </summary>
        /// <param name="rowIndex"></param>
        private void ShowDetailData(int rowIndex)
        {
            try
            {
                DataGridViewRow row = grv_DataUser.Rows[rowIndex];
                txt_QuestionId.Text = row.Cells["QuestionID"].Value.ToString();
                txt_QContent.Text = row.Cells["QContent"].Value.ToString();
                txt_CorrectAnswer.Text = row.Cells["Answer"].Value.ToString();
                txt_OptionA.Text = row.Cells["OptionA"].Value.ToString();
                txt_OptionB.Text = row.Cells["OptionB"].Value.ToString();
                txt_OptionC.Text = row.Cells["OptionC"].Value.ToString();
                txt_OptionD.Text = row.Cells["OptionD"].Value.ToString();
                cbb_Subject.SelectedValue = row.Cells["SubjectID"].Value.ToString();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Xử lý khi người dùng chọn một dòng trong DataGridView, lấy thông tin của câu hỏi đó và hiển thị trong các trường nhập liệu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grv_DataUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            rowIndex = e.RowIndex;
            ShowDetailData(rowIndex);
        }

        private void UpdateQuestion()
        {
            var editUser = GetQuestionInfor();
            if (!IsValidQuestion(editUser))
                return; // thoát
            try
            {
                BQuestion.UpdateQuestion(editUser);
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
            txt_QuestionId.ReadOnly = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_QuestionId.Text, out int userId);
            if (userId == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn câu hỏi cần xóa!", "Thông báo");
                return;
            }

            try
            {
                string fullname = txt_QContent.Text.Trim();
                if (DevExpress.XtraEditors.XtraMessageBox.Show($"Bạn có chắc muốn xóa câu hỏi \"{fullname}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BQuestion.DeleteQuestion(userId);
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
                grv_DataUser.DataSource = BQuestion.Search(keyword);
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
                AddNewQuestion();
            }
            else
            {
                UpdateQuestion();
            }
            ShowHideButton(false);
            SetEnableControl(false);
        }
    }
}
