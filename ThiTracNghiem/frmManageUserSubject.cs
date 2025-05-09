using BusinessLogicLayer;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    public partial class frmManageUserSubject : UserControl
    {
        private DataTable dtUsers;
        private DataTable dtSubjects;
        private DataTable dtUserSubjects;
        private int selectedUserId = 0;
        private string selectedSubjectId = "";

        public frmManageUserSubject()
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

        private void frmManageUserSubject_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadSubjects();
            LoadUserSubjects();
            UpdateButtonStatus();
        }

        private void LoadUsers()
        {
            try
            {
                // Lấy danh sách người dùng có vai trò là User
                dtUsers = BUserAccount.GetByRole("User");

                // Cấu hình các cột trong DataGridView
                grv_Users.AutoGenerateColumns = false;

                // Cấu hình cột UserID
                if (grv_Users.Columns["colUserID"] != null)
                {
                    grv_Users.Columns["colUserID"].DataPropertyName = "UserID";
                    grv_Users.Columns["colUserID"].Visible = false;
                }

                // Cấu hình cột Username
                if (grv_Users.Columns["colUsername"] != null)
                {
                    grv_Users.Columns["colUsername"].DataPropertyName = "Username";
                }

                // Cấu hình cột Fullname
                if (grv_Users.Columns["colFullname"] != null)
                {
                    grv_Users.Columns["colFullname"].DataPropertyName = "Fullname";
                }

                grv_Users.DataSource = dtUsers;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách người dùng: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjects()
        {
            try
            {
                // Lấy danh sách môn học
                dtSubjects = BSubject.GetAll();

                // Cấu hình các cột trong DataGridView
                grv_Subjects.AutoGenerateColumns = false;

                // Cấu hình cột SubjectID
                if (grv_Subjects.Columns["colSubjectID"] != null)
                {
                    grv_Subjects.Columns["colSubjectID"].DataPropertyName = "SubjectID";
                    grv_Subjects.Columns["colSubjectID"].Visible = false;
                }

                // Cấu hình cột SubjectName
                if (grv_Subjects.Columns["colSubjectName"] != null)
                {
                    grv_Subjects.Columns["colSubjectName"].DataPropertyName = "SubjectName";
                }

                grv_Subjects.DataSource = dtSubjects;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách môn học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserSubjects()
        {
            try
            {
                // Lấy danh sách gán môn học cho người dùng
                dtUserSubjects = BUserSubject.GetAll();

                // Cấu hình các cột trong DataGridView
                grv_UserSubjects.AutoGenerateColumns = false;

                // Cấu hình cột ID
                if (grv_UserSubjects.Columns["colID"] != null)
                {
                    grv_UserSubjects.Columns["colID"].DataPropertyName = "ID";
                    grv_UserSubjects.Columns["colID"].Visible = false;
                }

                // Cấu hình cột UserID
                if (grv_UserSubjects.Columns["colUserID2"] != null)
                {
                    grv_UserSubjects.Columns["colUserID2"].DataPropertyName = "UserID";
                    grv_UserSubjects.Columns["colUserID2"].Visible = false;
                }

                // Cấu hình cột SubjectID
                if (grv_UserSubjects.Columns["colSubjectID2"] != null)
                {
                    grv_UserSubjects.Columns["colSubjectID2"].DataPropertyName = "SubjectID";
                    grv_UserSubjects.Columns["colSubjectID2"].Visible = false;
                }

                // Cấu hình cột Username
                if (grv_UserSubjects.Columns["colUsername2"] != null)
                {
                    grv_UserSubjects.Columns["colUsername2"].DataPropertyName = "Username";
                }

                // Cấu hình cột Fullname
                if (grv_UserSubjects.Columns["colFullname2"] != null)
                {
                    grv_UserSubjects.Columns["colFullname2"].DataPropertyName = "Fullname";
                }

                // Cấu hình cột SubjectName
                if (grv_UserSubjects.Columns["colSubjectName2"] != null)
                {
                    grv_UserSubjects.Columns["colSubjectName2"].DataPropertyName = "SubjectName";
                }

                grv_UserSubjects.DataSource = dtUserSubjects;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách gán môn học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grv_Users_SelectionChanged(object sender, EventArgs e)
        {
            if (grv_Users.SelectedRows.Count > 0)
            {
                selectedUserId = Convert.ToInt32(grv_Users.SelectedRows[0].Cells["colUserID"].Value);
                UpdateButtonStatus();
            }
            else
            {
                selectedUserId = 0;
                UpdateButtonStatus();
            }
        }

        private void grv_Subjects_SelectionChanged(object sender, EventArgs e)
        {
            if (grv_Subjects.SelectedRows.Count > 0)
            {
                selectedSubjectId = grv_Subjects.SelectedRows[0].Cells["colSubjectID"].Value.ToString();
                UpdateButtonStatus();
            }
            else
            {
                selectedSubjectId = "";
                UpdateButtonStatus();
            }
        }

        private void UpdateButtonStatus()
        {
            btn_Assign.Enabled = selectedUserId > 0 && !string.IsNullOrEmpty(selectedSubjectId);
            btn_Remove.Enabled = grv_UserSubjects.SelectedRows.Count > 0;
        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId <= 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(selectedSubjectId))
                {
                    XtraMessageBox.Show("Vui lòng chọn môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem đã tồn tại bản ghi này chưa
                bool exists = false;
                foreach (DataRow row in dtUserSubjects.Rows)
                {
                    if (Convert.ToInt32(row["UserID"]) == selectedUserId && row["SubjectID"].ToString() == selectedSubjectId)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    XtraMessageBox.Show("Người dùng đã được gán môn học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gán môn học cho người dùng
                BUserSubject.Insert(selectedUserId, selectedSubjectId, Session.LogonUser.Username);

                XtraMessageBox.Show("Gán môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới dữ liệu
                LoadUserSubjects();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi gán môn học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_UserSubjects.SelectedRows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn bản ghi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = Convert.ToInt32(grv_UserSubjects.SelectedRows[0].Cells["colUserID2"].Value);
                string subjectId = grv_UserSubjects.SelectedRows[0].Cells["colSubjectID2"].Value.ToString();

                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                // Xóa bản ghi
                BUserSubject.Delete(userId, subjectId);

                XtraMessageBox.Show("Xóa bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới dữ liệu
                LoadUserSubjects();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi xóa bản ghi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
            LoadSubjects();
            LoadUserSubjects();
            UpdateButtonStatus();
        }
    }
}
