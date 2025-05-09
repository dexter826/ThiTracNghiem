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
            LoadExamSessions();
            LoadExams();
            InitializeStatusComboBox();
            // Không tải danh sách người dùng ở đây nữa
            // LoadUsers() sẽ được gọi khi chọn đề thi
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
                grv_ExamSessions.DataSource = dtExamSessions;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExams()
        {
            try
            {
                // Lấy danh sách đề thi đã được duyệt và kích hoạt
                dtExams = BExam.GetAllActive();

                if (dtExams == null || dtExams.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không có đề thi nào được kích hoạt. Vui lòng kích hoạt ít nhất một đề thi trước khi tạo kỳ thi.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                cbb_Exam.DataSource = dtExams;
                cbb_Exam.DisplayMember = "ExamName";
                cbb_Exam.ValueMember = "ExamID";
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
                dtUsers = BUserAccount.GetBySubject(subjectId);

                if (dtUsers == null || dtUsers.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không có người dùng nào được gán vào môn học này. Vui lòng gán người dùng vào môn học trước khi tạo kỳ thi.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    ExamID = Convert.ToInt32(cbb_Exam.SelectedValue),
                    CreatedBy = Session.LogonUser.Username
                };

                BExamSessionDetail.AddExamSessionDetail(examSessionDetail);

                // Thêm tất cả người dùng đã được gán môn học vào kỳ thi
                foreach (DataRow row in dtUsers.Rows)
                {
                    UserExamSession userExamSession = new UserExamSession
                    {
                        UserID = Convert.ToInt32(row["UserID"]),
                        SessionID = sessionId,
                        Status = "Registered",
                        CreatedBy = Session.LogonUser.Username
                    };

                    BUserExamSession.AddUserExamSession(userExamSession);
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

        private void cbb_Exam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbb_Exam.SelectedValue != null)
                {
                    int examId = Convert.ToInt32(cbb_Exam.SelectedValue);
                    // Lấy thông tin đề thi
                    Exam exam = BExam.GetById(examId);
                    if (exam != null)
                    {
                        // Tải danh sách người dùng theo môn học
                        LoadUsers(exam.SubjectID);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách người dùng: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
