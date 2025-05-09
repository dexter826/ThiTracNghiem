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
            if (dtExamSessions == null || dtExamSessions.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có kỳ thi nào đang diễn ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy thông tin kỳ thi
                DataRow examSession = dtExamSessions.Rows[0];
                int sessionId = Convert.ToInt32(examSession["SessionID"]);
                int examId = Convert.ToInt32(examSession["ExamID"]);
                string subjectId = examSession["SubjectID"].ToString();
                string subjectName = examSession["SubjectName"].ToString();
                int timeLimit = Convert.ToInt32(examSession["TimeLimit"]);
                int totalQuestion = Convert.ToInt32(examSession["TotalQuestion"]);

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
                // Lấy thông tin kỳ thi của người dùng
                // Stored procedure đã được cập nhật để chỉ trả về một kỳ thi duy nhất
                dtExamSessions = BExamSession.GetByUser(Session.LogonUser.UserID);

                if (dtExamSessions != null && dtExamSessions.Rows.Count > 0)
                {
                    // Lấy thông tin kỳ thi
                    DataRow examSession = dtExamSessions.Rows[0];
                    
                    // Hiển thị thông tin kỳ thi
                    lbl_SessionName.Text = examSession["SessionName"].ToString();
                    lbl_SubjectName.Text = examSession["SubjectName"].ToString();
                    lbl_StartTime.Text = Convert.ToDateTime(examSession["StartTime"]).ToString("dd/MM/yyyy HH:mm");
                    lbl_EndTime.Text = Convert.ToDateTime(examSession["EndTime"]).ToString("dd/MM/yyyy HH:mm");
                    
                    // Hiển thị thông tin đề thi
                    txt_NumberQuestion.Text = examSession["TotalQuestion"].ToString();
                    txt_Time.Text = examSession["TimeLimit"].ToString();
                    
                    // Kiểm tra trạng thái người dùng trong kỳ thi
                    string userStatus = examSession["UserStatus"].ToString();
                    
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
                    // Xóa thông tin kỳ thi
                    lbl_SessionName.Text = "";
                    lbl_SubjectName.Text = "";
                    lbl_StartTime.Text = "";
                    lbl_EndTime.Text = "";
                    
                    // Xóa thông tin đề thi
                    txt_NumberQuestion.Text = "";
                    txt_Time.Text = "";
                    
                    // Vô hiệu hóa nút bắt đầu thi
                    btn_Start.Enabled = false;
                    
                    // Hiển thị thông báo
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
    }
}
