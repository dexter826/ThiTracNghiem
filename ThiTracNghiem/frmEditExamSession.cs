using BusinessLogicLayer;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Data;
using System.Windows.Forms;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    public partial class frmEditExamSession : Form
    {
        private ExamSession _examSession;

        public frmEditExamSession(ExamSession examSession)
        {
            InitializeComponent();
            _examSession = examSession;
        }

        private void frmEditExamSession_Load(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị thông tin kỳ thi
                txt_SessionName.Text = _examSession.SessionName;
                dtp_StartTime.Value = _examSession.StartTime;
                dtp_EndTime.Value = _examSession.EndTime;

                // Hiển thị thông tin đề thi
                DataTable dtExamSessionDetail = BExamSessionDetail.GetBySession(_examSession.SessionID);
                if (dtExamSessionDetail != null && dtExamSessionDetail.Rows.Count > 0)
                {
                    int examId = Convert.ToInt32(dtExamSessionDetail.Rows[0]["ExamID"]);
                    var exam = BExam.GetById(examId);
                    if (exam != null)
                    {
                        lbl_ExamInfo.Text = $"Đề thi: {exam.ExamName}";
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải thông tin kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txt_SessionName.Text))
                {
                    XtraMessageBox.Show("Vui lòng nhập tên kỳ thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtp_StartTime.Value >= dtp_EndTime.Value)
                {
                    XtraMessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra thời gian bắt đầu phải lớn hơn thời gian hiện tại nếu đã thay đổi
                if (dtp_StartTime.Value != _examSession.StartTime && dtp_StartTime.Value <= DateTime.Now)
                {
                    XtraMessageBox.Show("Thời gian bắt đầu mới phải sau thời gian hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật thông tin kỳ thi
                _examSession.SessionName = txt_SessionName.Text;
                _examSession.StartTime = dtp_StartTime.Value;
                _examSession.EndTime = dtp_EndTime.Value;
                _examSession.ModifiedBy = Session.LogonUser.Username;

                // Cập nhật kỳ thi vào cơ sở dữ liệu
                BExamSession.UpdateExamSession(_examSession);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi cập nhật kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
