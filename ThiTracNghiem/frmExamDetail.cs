using BusinessLogicLayer;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    public partial class frmExamDetail : Form
    {
        private int examId;
        private Exam examInfo;
        private DataTable dtQuestions;
        private int selectedQuestionIndex = -1;

        public frmExamDetail(int examId)
        {
            InitializeComponent();
            this.examId = examId;
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

        private void frmExamDetail_Load(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin đề thi
                examInfo = BExam.GetById(examId);
                if (examInfo == null)
                {
                    XtraMessageBox.Show("Không tìm thấy thông tin đề thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Hiển thị thông tin đề thi
                LoadExamInfo();

                // Lấy danh sách câu hỏi trong đề thi
                LoadQuestions();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải thông tin đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExamInfo()
        {
            try
            {
                // Hiển thị thông tin đề thi
                txt_ExamName.Text = examInfo.ExamName;
                txt_SubjectName.Text = examInfo.SubjectName;
                txt_TimeLimit.Text = examInfo.TimeLimit.ToString() + " phút";
                txt_TotalQuestion.Text = examInfo.TotalQuestion.ToString() + " câu";
                txt_Status.Text = examInfo.Status;
                txt_CreatedBy.Text = examInfo.CreatedBy;
                txt_CreatedAt.Text = examInfo.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss");

                // Hiển thị thông tin người duyệt nếu có
                if (!string.IsNullOrEmpty(examInfo.ApprovedBy))
                {
                    txt_ApprovedBy.Text = examInfo.ApprovedBy;
                    txt_ApprovedAt.Text = examInfo.ApprovedAt?.ToString("dd/MM/yyyy HH:mm:ss") ?? "";
                    lbl_ApprovedBy.Visible = true;
                    lbl_ApprovedAt.Visible = true;
                    txt_ApprovedBy.Visible = true;
                    txt_ApprovedAt.Visible = true;
                }
                else
                {
                    lbl_ApprovedBy.Visible = false;
                    lbl_ApprovedAt.Visible = false;
                    txt_ApprovedBy.Visible = false;
                    txt_ApprovedAt.Visible = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi hiển thị thông tin đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadQuestions()
        {
            try
            {
                // Lấy danh sách câu hỏi trong đề thi
                dtQuestions = BExamQuestion.GetByExam(examId);

                if (dtQuestions != null && dtQuestions.Rows.Count > 0)
                {
                    // Cấu hình các cột trong DataGridView
                    grv_Questions.AutoGenerateColumns = false;

                    // Cấu hình cột STT
                    if (grv_Questions.Columns["colSTT"] != null)
                    {
                        grv_Questions.Columns["colSTT"].DataPropertyName = "";
                    }

                    // Cấu hình cột QuestionID
                    if (grv_Questions.Columns["colQuestionID"] != null)
                    {
                        grv_Questions.Columns["colQuestionID"].DataPropertyName = "QuestionID";
                        grv_Questions.Columns["colQuestionID"].Visible = false;
                    }

                    // Cấu hình cột QContent
                    if (grv_Questions.Columns["colQContent"] != null)
                    {
                        grv_Questions.Columns["colQContent"].DataPropertyName = "QContent";
                    }

                    // Cấu hình cột Chapter
                    if (grv_Questions.Columns["colChapter"] != null)
                    {
                        grv_Questions.Columns["colChapter"].DataPropertyName = "Chapter";
                    }

                    // Hiển thị danh sách câu hỏi
                    grv_Questions.DataSource = dtQuestions;

                    // Cập nhật số lượng câu hỏi
                    lbl_QuestionCount.Text = $"Số câu hỏi: {dtQuestions.Rows.Count}";

                    // Chọn câu hỏi đầu tiên
                    if (grv_Questions.Rows.Count > 0)
                    {
                        grv_Questions.Rows[0].Selected = true;
                    }
                }
                else
                {
                    grv_Questions.DataSource = null;
                    lbl_QuestionCount.Text = "Số câu hỏi: 0";
                    ClearQuestionDetail();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải danh sách câu hỏi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grv_Questions_SelectionChanged(object sender, EventArgs e)
        {
            if (grv_Questions.SelectedRows.Count > 0)
            {
                selectedQuestionIndex = grv_Questions.SelectedRows[0].Index;
                ShowQuestionDetail(selectedQuestionIndex);
            }
            else
            {
                selectedQuestionIndex = -1;
                ClearQuestionDetail();
            }
        }

        private void ShowQuestionDetail(int rowIndex)
        {
            try
            {
                if (rowIndex >= 0 && rowIndex < dtQuestions.Rows.Count)
                {
                    DataRow row = dtQuestions.Rows[rowIndex];

                    // Hiển thị nội dung câu hỏi
                    rtxt_QuestionContent.Text = row["QContent"].ToString();

                    // Hiển thị các phương án
                    rtxt_OptionA.Text = row["OptionA"].ToString();
                    rtxt_OptionB.Text = row["OptionB"].ToString();
                    rtxt_OptionC.Text = row["OptionC"].ToString();
                    rtxt_OptionD.Text = row["OptionD"].ToString();

                    // Hiển thị đáp án đúng
                    string answer = row["Answer"].ToString();
                    lbl_CorrectAnswer.Text = answer;

                    // Hiển thị chương (nếu có)
                    string chapter = row["Chapter"] != DBNull.Value ? row["Chapter"].ToString() : "";
                    lbl_Chapter.Text = !string.IsNullOrEmpty(chapter) ? chapter : "Không có";

                    // Đánh dấu đáp án đúng
                    string optionAContent = row["OptionA"].ToString();
                    string optionBContent = row["OptionB"].ToString();
                    string optionCContent = row["OptionC"].ToString();
                    string optionDContent = row["OptionD"].ToString();

                    rdb_OptionA.Checked = answer == optionAContent;
                    rdb_OptionB.Checked = answer == optionBContent;
                    rdb_OptionC.Checked = answer == optionCContent;
                    rdb_OptionD.Checked = answer == optionDContent;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi hiển thị chi tiết câu hỏi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearQuestionDetail()
        {
            rtxt_QuestionContent.Text = "";
            rtxt_OptionA.Text = "";
            rtxt_OptionB.Text = "";
            rtxt_OptionC.Text = "";
            rtxt_OptionD.Text = "";
            lbl_CorrectAnswer.Text = "";
            lbl_Chapter.Text = "";
            rdb_OptionA.Checked = rdb_OptionB.Checked = rdb_OptionC.Checked = rdb_OptionD.Checked = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grv_Questions_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                // Chỉ cập nhật STT cho các dòng dữ liệu thực sự, không phải dòng mới
                if (e.RowIndex < grv_Questions.Rows.Count && !grv_Questions.Rows[e.RowIndex].IsNewRow)
                {
                    // Cập nhật số thứ tự (STT) của mỗi hàng trong bảng
                    grv_Questions["colSTT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu cần
                Console.WriteLine("Lỗi khi cập nhật STT: " + ex.Message);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo báo cáo chi tiết đề thi
                XtraMessageBox.Show("Chức năng in đề thi đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi in đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
