using BusinessLogicLayer;
using Entities;
using System;
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
        private Subject GetSubjectInfor()
        {
            Subject subject = new Subject();
            subject.SubjectId = txt_SubjectId.Text.Trim();
            subject.SubjectName = txt_SubjectName.Text.Trim();
            subject.Description = txt_SubjectDesb.Text.Trim();

            subject.CreatedAt = DateTime.Now;
            subject.CreatedBy = Session.LogonUser.Username; ;
            subject.ModifiedAt = DateTime.Now;
            subject.ModifiedBy = Session.LogonUser.Username; ;
            return subject;
        }
        private bool IsValidInfor(Subject subject)
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
                MessageBox.Show(strMessage, "Lỗi nhập liệu!\n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AddNewSubject()
        {
            var newSubject = GetSubjectInfor();
            if (!IsValidInfor(newSubject))
                return; // thoát
            try
            {
                BSubject.AddNewSubject(newSubject);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
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
            txt_SubjectId.Clear();
            txt_SubjectName.Clear();
            txt_SubjectDesb.Clear();
            txt_SubjectId.ReadOnly = false;
            txt_SubjectId.Enabled = true;
        }

        private void frmManageSubject_Load(object sender, EventArgs e)
        {
            LoadData();
            SetEnableControl(false);
        }
        private void LoadData()
        {
            try
            {
                grv_DataUser.AutoGenerateColumns = false;
                grv_DataUser.DataSource = BSubject.GetAll();
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
                txt_SubjectId.Text = row.Cells["SubjectID"].Value.ToString();
                txt_SubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                txt_SubjectDesb.Text = row.Cells["Description"].Value.ToString();
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
        private void UpdateSubject()
        {
            var editSubject = GetSubjectInfor();
            if (!IsValidInfor(editSubject))
                return; // thoát
            try
            {
                BSubject.UpdateSubject(editSubject);
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
            txt_SubjectId.ReadOnly = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string subjectId = txt_SubjectId.Text.Trim();
            if (string.IsNullOrEmpty(subjectId) || rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn thi cần xóa!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            try
            {
                string fullname = txt_SubjectName.Text.Trim();
                if (MessageBox.Show($"Bạn có chắc muốn xóa môn thi \"{fullname}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BSubject.DeleteSubject(subjectId);
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
                grv_DataUser.DataSource = BSubject.Search(keyword);
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
            if (isAddNew)
            {
                AddNewSubject();
            }
            else
            {
                UpdateSubject();
            }
            ShowHideButton(false);
            SetEnableControl(false);
        }
    }
}
