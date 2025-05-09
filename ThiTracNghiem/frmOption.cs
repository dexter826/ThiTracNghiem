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
            if (cbb_Subject.SelectedValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn kỳ thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy thông tin kỳ thi đã chọn
                DataRowView selectedRow = (DataRowView)cbb_Subject.SelectedItem;
                int sessionId = Convert.ToInt32(selectedRow["SessionID"]);
                int examId = Convert.ToInt32(selectedRow["ExamID"]);
                string subjectId = selectedRow["SubjectID"].ToString();
                string subjectName = selectedRow["SubjectName"].ToString();
                int timeLimit = Convert.ToInt32(selectedRow["TimeLimit"]);
                int totalQuestion = Convert.ToInt32(selectedRow["TotalQuestion"]);

                // Cập nhật trạng thái người dùng trong kỳ thi
                BUserExamSession.UpdateStatus(
                    Session.LogonUser.UserID,
                    sessionId,
                    "Started",
                    DateTime.Now,
                    null,
                    Session.LogonUser.Username
                );

                // Lưu thông tin kỳ thi và đề thi
                Session.SessionID = sessionId;
                Session.ExamID = examId;
                Session.SubjectID = subjectId;
                Session.SubjectName = subjectName;
                Session.TestTime = timeLimit;
                Session.NumberOfQuestion = totalQuestion;

                // Mở form làm bài thi
                frmTest fmTest = new frmTest();
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
                    cbb_Subject.DataSource = dtExamSessions;
                    cbb_Subject.DisplayMember = "SessionName";
                    cbb_Subject.ValueMember = "SessionID";

                    // Chọn kỳ thi đầu tiên
                    cbb_Subject.SelectedIndex = 0;
                    // Tải thông tin đề thi của kỳ thi đầu tiên
                    LoadExamInfo();
                }
                else
                {
                    cbb_Subject.DataSource = null;
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

        private void cbb_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Subject.SelectedValue != null)
            {
                LoadExamInfo();
            }
        }

        private void LoadExamInfo()
        {
            try
            {
                if (cbb_Subject.SelectedItem != null)
                {
                    DataRowView selectedRow = (DataRowView)cbb_Subject.SelectedItem;

                    // Hiển thị thông tin đề thi
                    txt_NumberQuestion.Text = selectedRow["TotalQuestion"].ToString();
                    txt_Time.Text = selectedRow["TimeLimit"].ToString();

                    // Kiểm tra trạng thái người dùng trong kỳ thi
                    string userStatus = selectedRow["UserStatus"].ToString();

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
