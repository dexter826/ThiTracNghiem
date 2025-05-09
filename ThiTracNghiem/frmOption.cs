using BusinessLogicLayer;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    public partial class frmOption : XtraForm
    {
        private DataTable dtExamSessions;

        public frmOption()
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
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.FromArgb(172, 203, 238), Color.FromArgb(231, 240, 253), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (grv_ExamSessions.SelectedRows.Count == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn kỳ thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy thông tin kỳ thi đã chọn
                DataGridViewRow selectedRow = grv_ExamSessions.SelectedRows[0];
                int sessionId = Convert.ToInt32(selectedRow.Cells["SessionID"].Value);
                int examId = Convert.ToInt32(selectedRow.Cells["ExamID"].Value);
                string subjectId = selectedRow.Cells["SubjectID"].Value.ToString();
                string subjectName = selectedRow.Cells["SubjectName"].Value.ToString();
                int timeLimit = Convert.ToInt32(selectedRow.Cells["TimeLimit"].Value);
                int totalQuestion = Convert.ToInt32(selectedRow.Cells["TotalQuestion"].Value);

                // Cập nhật trạng thái người dùng trong kỳ thi
                BUserExamSession.UpdateStatus(
                    Session.LogonUser.UserID,
                    sessionId,
                    "Started",
                    DateTime.Now,
                    null,
                    Session.LogonUser.Username
                );

                // Mở form làm bài thi với thông tin kỳ thi
                frmTest fmTest = new frmTest(sessionId, examId, subjectId, subjectName, timeLimit, totalQuestion);
                this.Hide();
                fmTest.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  Phương thức này lấy danh sách các kỳ thi đang diễn ra mà người dùng có thể tham gia
        /// </summary>
        private void LoadData()
        {
            try
            {
                // Lấy danh sách kỳ thi của người dùng
                dtExamSessions = BExamSession.GetByUser(Session.LogonUser.UserID);

                if (dtExamSessions != null && dtExamSessions.Rows.Count > 0)
                {
                    // Cấu hình DataGridView
                    ConfigureDataGridView();

                    // Hiển thị danh sách kỳ thi
                    grv_ExamSessions.DataSource = dtExamSessions;

                    // Chọn kỳ thi đầu tiên
                    if (grv_ExamSessions.Rows.Count > 0)
                    {
                        grv_ExamSessions.Rows[0].Selected = true;
                        // Tải thông tin đề thi của kỳ thi đầu tiên
                        LoadExamInfo();
                    }
                }
                else
                {
                    grv_ExamSessions.DataSource = null;
                    txt_NumberQuestion.Text = "";
                    txt_Time.Text = "";
                    btn_Start.Enabled = false;
                    MessageBox.Show("Không có kỳ thi nào đang diễn ra mà bạn có thể tham gia!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!");
            }
        }



        private void frmOption_Load(object sender, EventArgs e)
        {
            LoadData();
            // Người dùng không thể thay đổi thông tin đề thi
            txt_NumberQuestion.Enabled = false;
            txt_Time.Enabled = false;
            txt_Time.ReadOnly = true;
        }

        private void txt_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grv_ExamSessions_SelectionChanged(object sender, EventArgs e)
        {
            if (grv_ExamSessions.SelectedRows.Count > 0)
            {
                LoadExamInfo();
            }
        }

        /// <summary>
        /// Cấu hình DataGridView để hiển thị danh sách kỳ thi
        /// </summary>
        private void ConfigureDataGridView()
        {
            // Xóa tất cả các cột hiện có
            grv_ExamSessions.Columns.Clear();

            // Thêm các cột mới
            DataGridViewTextBoxColumn colSessionID = new DataGridViewTextBoxColumn();
            colSessionID.DataPropertyName = "SessionID";
            colSessionID.HeaderText = "Mã kỳ thi";
            colSessionID.Visible = false;
            grv_ExamSessions.Columns.Add(colSessionID);

            DataGridViewTextBoxColumn colSessionName = new DataGridViewTextBoxColumn();
            colSessionName.DataPropertyName = "SessionName";
            colSessionName.HeaderText = "Tên kỳ thi";
            colSessionName.Width = 200;
            grv_ExamSessions.Columns.Add(colSessionName);

            DataGridViewTextBoxColumn colSubjectName = new DataGridViewTextBoxColumn();
            colSubjectName.DataPropertyName = "SubjectName";
            colSubjectName.HeaderText = "Môn học";
            colSubjectName.Width = 150;
            grv_ExamSessions.Columns.Add(colSubjectName);

            DataGridViewTextBoxColumn colStartTime = new DataGridViewTextBoxColumn();
            colStartTime.DataPropertyName = "StartTime";
            colStartTime.HeaderText = "Thời gian bắt đầu";
            colStartTime.Width = 150;
            colStartTime.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            grv_ExamSessions.Columns.Add(colStartTime);

            DataGridViewTextBoxColumn colEndTime = new DataGridViewTextBoxColumn();
            colEndTime.DataPropertyName = "EndTime";
            colEndTime.HeaderText = "Thời gian kết thúc";
            colEndTime.Width = 150;
            colEndTime.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            grv_ExamSessions.Columns.Add(colEndTime);

            DataGridViewTextBoxColumn colUserStatus = new DataGridViewTextBoxColumn();
            colUserStatus.DataPropertyName = "UserStatus";
            colUserStatus.HeaderText = "Trạng thái";
            colUserStatus.Width = 100;
            grv_ExamSessions.Columns.Add(colUserStatus);

            // Ẩn các cột không cần hiển thị
            foreach (DataGridViewColumn col in grv_ExamSessions.Columns)
            {
                if (col.DataPropertyName == "ExamID" ||
                    col.DataPropertyName == "SubjectID" ||
                    col.DataPropertyName == "UserStartTime" ||
                    col.DataPropertyName == "UserEndTime")
                {
                    col.Visible = false;
                }
            }
        }

        private void LoadExamInfo()
        {
            try
            {
                if (grv_ExamSessions.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = grv_ExamSessions.SelectedRows[0];

                    // Hiển thị thông tin đề thi
                    txt_NumberQuestion.Text = selectedRow.Cells["TotalQuestion"].Value.ToString();
                    txt_Time.Text = selectedRow.Cells["TimeLimit"].Value.ToString();

                    // Kiểm tra trạng thái người dùng trong kỳ thi
                    string userStatus = selectedRow.Cells["UserStatus"].Value.ToString();

                    // Nếu người dùng đã hoàn thành kỳ thi, không cho phép làm lại
                    if (userStatus == "Completed")
                    {
                        btn_Start.Enabled = false;
                        MessageBox.Show("Bạn đã hoàn thành kỳ thi này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        btn_Start.Enabled = true;
                    }
                }
                else
                {
                    // Không có kỳ thi nào được chọn
                    txt_NumberQuestion.Text = "0";
                    txt_Time.Text = "0";
                    btn_Start.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
