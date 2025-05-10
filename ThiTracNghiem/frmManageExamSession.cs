using BusinessLogicLayer;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    public partial class frmManageExamSession : UserControl
    {
        private DataTable dtExamSessions;
        private DataTable dtExams;
        private DataTable dtUsers;

        public frmManageExamSession()
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

        private void frmManageExamSession_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeStatusComboBox();
                LoadExamSessions();

                // Tạm thời tắt sự kiện SelectedIndexChanged để tránh gọi nhiều lần
                cbb_Subject.SelectedIndexChanged -= cbb_Subject_SelectedIndexChanged;

                LoadSubjects();

                // Bật lại sự kiện SelectedIndexChanged
                cbb_Subject.SelectedIndexChanged += cbb_Subject_SelectedIndexChanged;

                // Gọi sự kiện SelectedIndexChanged một cách thủ công nếu có item được chọn
                if (cbb_Subject.SelectedIndex >= 0)
                {
                    cbb_Subject_SelectedIndexChanged(cbb_Subject, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải form: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeStatusComboBox()
        {
            // Khởi tạo ComboBox trạng thái
            var statusList = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Scheduled", "Đã lên lịch"),
                new KeyValuePair<string, string>("InProgress", "Đang diễn ra"),
                new KeyValuePair<string, string>("Completed", "Đã hoàn thành"),
                new KeyValuePair<string, string>("Cancelled", "Đã hủy")
            };

            cbb_Status.DataSource = new BindingSource(statusList, null);
            cbb_Status.DisplayMember = "Value";
            cbb_Status.ValueMember = "Key";
        }

        private void LoadExamSessions()
        {
            try
            {
                dtExamSessions = BExamSession.GetAll();

                // Kiểm tra xem DataTable có null không
                if (dtExamSessions == null)
                {
                    XtraMessageBox.Show("Không thể tải danh sách kỳ thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                grv_ExamSessions.DataSource = dtExamSessions;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjects()
        {
            try
            {
                // Lấy danh sách môn học
                DataTable dtSubjects = BSubject.GetAll();

                if (dtSubjects == null || dtSubjects.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không có môn học nào. Vui lòng thêm môn học trước khi tạo kỳ thi.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem DataTable có chứa các cột cần thiết không
                if (!dtSubjects.Columns.Contains("SubjectID") || !dtSubjects.Columns.Contains("SubjectName"))
                {
                    XtraMessageBox.Show("Cấu trúc dữ liệu không hợp lệ. Không tìm thấy cột SubjectID hoặc SubjectName.",
                        "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo một DataView từ DataTable để đảm bảo dữ liệu được hiển thị đúng cách
                DataView dv = new DataView(dtSubjects);

                // Xóa DataSource hiện tại trước khi thiết lập DataSource mới
                cbb_Subject.DataSource = null;

                // Thiết lập DataSource mới
                cbb_Subject.DataSource = dv;
                cbb_Subject.DisplayMember = "SubjectName";
                cbb_Subject.ValueMember = "SubjectID";

                // Đảm bảo ComboBox được cập nhật
                cbb_Subject.SelectedIndex = -1;
                if (cbb_Subject.Items.Count > 0)
                {
                    cbb_Subject.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách môn học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExams(string subjectId)
        {
            try
            {
                // Lấy danh sách đề thi đã được duyệt theo môn học
                dtExams = BExam.GetApprovedBySubject(subjectId);

                if (dtExams == null || dtExams.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không có đề thi nào được duyệt cho môn học này. Vui lòng duyệt ít nhất một đề thi trước khi tạo kỳ thi.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem DataTable có chứa các cột cần thiết không
                if (!dtExams.Columns.Contains("ExamID") || !dtExams.Columns.Contains("ExamName"))
                {
                    XtraMessageBox.Show("Cấu trúc dữ liệu không hợp lệ. Không tìm thấy cột ExamID hoặc ExamName.",
                        "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo một DataView từ DataTable để đảm bảo dữ liệu được hiển thị đúng cách
                DataView dv = new DataView(dtExams);

                // Xóa DataSource hiện tại trước khi thiết lập DataSource mới
                cbb_Exam.DataSource = null;

                // Thiết lập DataSource mới
                cbb_Exam.DataSource = dv;
                cbb_Exam.DisplayMember = "ExamName";
                cbb_Exam.ValueMember = "ExamID";

                // Đảm bảo ComboBox được cập nhật
                cbb_Exam.SelectedIndex = -1;
                if (cbb_Exam.Items.Count > 0)
                {
                    cbb_Exam.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsers(string subjectId)
        {
            try
            {
                // Lấy danh sách người dùng đã được gán vào môn học
                dtUsers = BUserSubject.GetBySubject(subjectId);

                if (dtUsers == null || dtUsers.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không có người dùng nào được gán vào môn học này. Vui lòng gán người dùng vào môn học trước khi tạo kỳ thi.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl_UserCount.Text = "Số người dùng: 0";
                    return;
                }

                // Kiểm tra xem cột UserID có tồn tại không
                if (!dtUsers.Columns.Contains("UserID"))
                {
                    XtraMessageBox.Show("Cấu trúc dữ liệu không hợp lệ. Không tìm thấy cột UserID.",
                        "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_UserCount.Text = "Số người dùng: 0";
                    return;
                }

                // Hiển thị số lượng người dùng
                lbl_UserCount.Text = $"Số người dùng: {dtUsers.Rows.Count}";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách người dùng: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txt_SessionName.Text))
                {
                    XtraMessageBox.Show("Vui lòng nhập tên kỳ thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbb_Exam.SelectedValue == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn đề thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtp_StartTime.Value >= dtp_EndTime.Value)
                {
                    XtraMessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtUsers == null || dtUsers.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không có người dùng nào được gán vào môn học này. Vui lòng gán người dùng vào môn học trước khi tạo kỳ thi.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo kỳ thi mới
                ExamSession examSession = new ExamSession
                {
                    SessionName = txt_SessionName.Text,
                    StartTime = dtp_StartTime.Value,
                    EndTime = dtp_EndTime.Value,
                    Status = "Scheduled",
                    CreatedBy = Session.LogonUser.Username
                };

                // Thêm kỳ thi vào cơ sở dữ liệu
                int sessionId = BExamSession.AddExamSession(examSession);

                // Thêm chi tiết kỳ thi
                ExamSessionDetail examSessionDetail = new ExamSessionDetail
                {
                    SessionID = sessionId,
                    ExamID = cbb_Exam.SelectedItem is DataRowView
                        ? Convert.ToInt32(((DataRowView)cbb_Exam.SelectedItem)["ExamID"])
                        : Convert.ToInt32(cbb_Exam.SelectedValue),
                    CreatedBy = Session.LogonUser.Username
                };

                BExamSessionDetail.AddExamSessionDetail(examSessionDetail);

                // Thêm tất cả người dùng đã được gán môn học vào kỳ thi
                foreach (DataRow row in dtUsers.Rows)
                {
                    // Đảm bảo chuyển đổi đúng kiểu dữ liệu
                    int userId;
                    if (int.TryParse(row["UserID"].ToString(), out userId))
                    {
                        UserExamSession userExamSession = new UserExamSession
                        {
                            UserID = userId,
                            SessionID = sessionId,
                            Status = "Registered",
                            CreatedBy = Session.LogonUser.Username
                        };

                        BUserExamSession.AddUserExamSession(userExamSession);
                    }
                }

                XtraMessageBox.Show("Thêm kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới dữ liệu
                LoadExamSessions();
                ClearForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txt_SessionName.Text = "";
            dtp_StartTime.Value = DateTime.Now;
            dtp_EndTime.Value = DateTime.Now.AddHours(1);
            cbb_Subject.SelectedIndex = -1;
            cbb_Exam.SelectedIndex = -1;
            lbl_UserCount.Text = "Số người dùng: 0";
            dtUsers = null;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_ExamSessions.SelectedRows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn kỳ thi cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sessionId = Convert.ToInt32(grv_ExamSessions.SelectedRows[0].Cells["SessionID"].Value);
                string status = grv_ExamSessions.SelectedRows[0].Cells["Status"].Value.ToString();

                if (status == "Completed" || status == "Cancelled")
                {
                    XtraMessageBox.Show("Không thể cập nhật kỳ thi đã hoàn thành hoặc đã hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật trạng thái kỳ thi
                string newStatus = cbb_Status.SelectedValue.ToString();
                BExamSession.UpdateStatus(sessionId, newStatus, Session.LogonUser.Username);

                XtraMessageBox.Show("Cập nhật trạng thái kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới dữ liệu
                LoadExamSessions();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi cập nhật kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_ExamSessions.SelectedRows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn kỳ thi cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sessionId = Convert.ToInt32(grv_ExamSessions.SelectedRows[0].Cells["SessionID"].Value);
                string status = grv_ExamSessions.SelectedRows[0].Cells["Status"].Value.ToString();

                if (status == "Completed" || status == "Cancelled")
                {
                    XtraMessageBox.Show("Không thể hủy kỳ thi đã hoàn thành hoặc đã hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn hủy kỳ thi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                // Cập nhật trạng thái kỳ thi
                BExamSession.UpdateStatus(sessionId, "Cancelled", Session.LogonUser.Username);

                XtraMessageBox.Show("Hủy kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới dữ liệu
                LoadExamSessions();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi hủy kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ViewDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_ExamSessions.SelectedRows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn kỳ thi cần xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sessionId = Convert.ToInt32(grv_ExamSessions.SelectedRows[0].Cells["SessionID"].Value);
                LoadSessionUsers(sessionId);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi xem chi tiết kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSessionUsers(int sessionId)
        {
            try
            {
                // Lấy danh sách người dùng trong kỳ thi
                DataTable dtSessionUsers = BUserExamSession.GetBySession(sessionId);
                grv_SessionUsers.DataSource = dtSessionUsers;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi xem chi tiết kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grv_ExamSessions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int sessionId = Convert.ToInt32(grv_ExamSessions.Rows[e.RowIndex].Cells["SessionID"].Value);
                LoadSessionUsers(sessionId);
            }
        }

        private void cbb_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem ComboBox có giá trị được chọn không
                if (cbb_Subject.SelectedItem == null || cbb_Subject.SelectedValue == null)
                {
                    return;
                }

                // Lấy giá trị SubjectID
                string subjectId = cbb_Subject.SelectedValue.ToString();

                // Tải danh sách đề thi theo môn học
                LoadExams(subjectId);

                // Tải danh sách người dùng theo môn học
                LoadUsers(subjectId);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_Exam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Không cần làm gì ở đây vì danh sách người dùng đã được tải khi chọn môn học
        }
    }
}
