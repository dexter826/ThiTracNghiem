using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    public partial class frmCreateExam : UserControl
    {
        private DataTable dtQuestions;
        private DataTable dtSelectedQuestions;

        public frmCreateExam()
        {
            InitializeComponent();
        }

        private void frmCreateExam_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            InitializeSelectedQuestionsTable();
        }

        private void LoadSubjects()
        {
            try
            {
                // Lấy danh sách môn học được phân công cho giáo viên
                var teacherSubjects = BTeacherSubject.GetByTeacher(Session.LogonUser.UserID);

                if (teacherSubjects != null && teacherSubjects.Rows.Count > 0)
                {
                    cbb_Subject.DataSource = teacherSubjects;
                    cbb_Subject.DisplayMember = "SubjectName";
                    cbb_Subject.ValueMember = "SubjectID";

                    // Tải danh sách chương của môn học đầu tiên
                    LoadChapters(cbb_Subject.SelectedValue.ToString());
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa được phân công môn học nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi tải danh sách môn học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChapters(string subjectId)
        {
            try
            {
                // Lấy danh sách chương của môn học
                var chapters = BQuestion.GetChaptersBySubject(subjectId);

                if (chapters != null && chapters.Rows.Count > 0)
                {
                    // Thêm tùy chọn "Tất cả"
                    DataRow allRow = chapters.NewRow();
                    allRow["Chapter"] = "All";
                    chapters.Rows.InsertAt(allRow, 0);

                    cbb_Chapter.DataSource = chapters;
                    cbb_Chapter.DisplayMember = "Chapter";
                    cbb_Chapter.ValueMember = "Chapter";
                }
                else
                {
                    cbb_Chapter.DataSource = null;
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không có chương nào cho môn học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi tải danh sách chương: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeSelectedQuestionsTable()
        {
            // Tạo DataTable để lưu trữ các câu hỏi đã chọn
            dtSelectedQuestions = new DataTable();
            dtSelectedQuestions.Columns.Add("QuestionID", typeof(int));
            dtSelectedQuestions.Columns.Add("SubjectID", typeof(string));
            dtSelectedQuestions.Columns.Add("QContent", typeof(string));
            dtSelectedQuestions.Columns.Add("Chapter", typeof(string));
            dtSelectedQuestions.Columns.Add("OptionA", typeof(string));
            dtSelectedQuestions.Columns.Add("OptionB", typeof(string));
            dtSelectedQuestions.Columns.Add("OptionC", typeof(string));
            dtSelectedQuestions.Columns.Add("OptionD", typeof(string));
            dtSelectedQuestions.Columns.Add("Answer", typeof(string));

            // Thêm cột STT
            dtSelectedQuestions.Columns.Add("STT", typeof(int));

            // Gán DataTable cho DataGridView
            grv_SelectedQuestions.DataSource = dtSelectedQuestions;

            // Ẩn cột QuestionID
            if (grv_SelectedQuestions.Columns["QuestionID"] != null)
                grv_SelectedQuestions.Columns["QuestionID"].Visible = false;

            // Ẩn cột SubjectID
            if (grv_SelectedQuestions.Columns["SubjectID"] != null)
                grv_SelectedQuestions.Columns["SubjectID"].Visible = false;
        }

        private void cbb_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Subject.SelectedValue != null)
            {
                string subjectId = cbb_Subject.SelectedValue.ToString();
                LoadChapters(subjectId);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_Subject.SelectedValue == null || cbb_Chapter.SelectedValue == null)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn môn học và chương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string subjectId = cbb_Subject.SelectedValue.ToString();
                string chapter = cbb_Chapter.SelectedValue.ToString();

                // Lấy danh sách câu hỏi theo môn học và chương
                dtQuestions = BQuestion.GetByChapter(subjectId, chapter);

                if (dtQuestions != null && dtQuestions.Rows.Count > 0)
                {
                    // Nếu có từ khóa tìm kiếm, lọc kết quả
                    string keyword = txt_SearchKeyword.Text.Trim();
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        // Tạo bảng tạm để lưu kết quả lọc
                        DataTable filteredTable = dtQuestions.Clone();

                        // Tìm kiếm trong các cột
                        foreach (DataRow row in dtQuestions.Rows)
                        {
                            bool match = false;

                            // Tìm trong nội dung câu hỏi
                            if (row["QContent"] != null && row["QContent"].ToString().ToLower().Contains(keyword.ToLower()))
                                match = true;

                            // Tìm trong các đáp án
                            else if (row["OptionA"] != null && row["OptionA"].ToString().ToLower().Contains(keyword.ToLower()))
                                match = true;
                            else if (row["OptionB"] != null && row["OptionB"].ToString().ToLower().Contains(keyword.ToLower()))
                                match = true;
                            else if (row["OptionC"] != null && row["OptionC"].ToString().ToLower().Contains(keyword.ToLower()))
                                match = true;
                            else if (row["OptionD"] != null && row["OptionD"].ToString().ToLower().Contains(keyword.ToLower()))
                                match = true;
                            else if (row["Answer"] != null && row["Answer"].ToString().ToLower().Contains(keyword.ToLower()))
                                match = true;

                            // Nếu tìm thấy, thêm vào bảng kết quả
                            if (match)
                                filteredTable.ImportRow(row);
                        }

                        // Sử dụng bảng đã lọc
                        dtQuestions = filteredTable;
                    }

                    // Thêm cột STT
                    if (!dtQuestions.Columns.Contains("STT"))
                    {
                        DataColumn sttColumn = new DataColumn("STT", typeof(int));
                        dtQuestions.Columns.Add(sttColumn);

                        for (int i = 0; i < dtQuestions.Rows.Count; i++)
                        {
                            dtQuestions.Rows[i]["STT"] = i + 1;
                        }

                        // Sắp xếp lại thứ tự cột
                        dtQuestions.Columns["STT"].SetOrdinal(0);
                    }
                    else
                    {
                        // Cập nhật lại STT nếu đã có cột
                        for (int i = 0; i < dtQuestions.Rows.Count; i++)
                        {
                            dtQuestions.Rows[i]["STT"] = i + 1;
                        }
                    }

                    if (dtQuestions.Rows.Count > 0)
                    {
                        grv_Questions.DataSource = dtQuestions;

                        // Ẩn cột QuestionID
                        if (grv_Questions.Columns["QuestionID"] != null)
                            grv_Questions.Columns["QuestionID"].Visible = false;

                        // Ẩn cột SubjectID
                        if (grv_Questions.Columns["SubjectID"] != null)
                            grv_Questions.Columns["SubjectID"].Visible = false;
                    }
                    else
                    {
                        grv_Questions.DataSource = null;
                        DevExpress.XtraEditors.XtraMessageBox.Show("Không tìm thấy câu hỏi nào phù hợp với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    grv_Questions.DataSource = null;
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không tìm thấy câu hỏi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi tìm kiếm câu hỏi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddToExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_Questions.SelectedRows.Count == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn câu hỏi cần thêm vào đề thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in grv_Questions.SelectedRows)
                {
                    int questionId = Convert.ToInt32(row.Cells["QuestionID"].Value);

                    // Kiểm tra xem câu hỏi đã được thêm vào đề thi chưa
                    bool exists = false;
                    foreach (DataRow dr in dtSelectedQuestions.Rows)
                    {
                        if (Convert.ToInt32(dr["QuestionID"]) == questionId)
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        DataRow newRow = dtSelectedQuestions.NewRow();
                        newRow["QuestionID"] = questionId;
                        newRow["SubjectID"] = row.Cells["SubjectID"].Value;
                        newRow["QContent"] = row.Cells["QContent"].Value;
                        newRow["Chapter"] = row.Cells["Chapter"].Value;
                        newRow["OptionA"] = row.Cells["OptionA"].Value;
                        newRow["OptionB"] = row.Cells["OptionB"].Value;
                        newRow["OptionC"] = row.Cells["OptionC"].Value;
                        newRow["OptionD"] = row.Cells["OptionD"].Value;
                        newRow["Answer"] = row.Cells["Answer"].Value;
                        newRow["STT"] = dtSelectedQuestions.Rows.Count + 1;

                        dtSelectedQuestions.Rows.Add(newRow);
                    }
                }

                // Cập nhật số lượng câu hỏi
                txt_TotalQuestion.Value = dtSelectedQuestions.Rows.Count;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi thêm câu hỏi vào đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RemoveFromExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_SelectedQuestions.SelectedRows.Count == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn câu hỏi cần xóa khỏi đề thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in grv_SelectedQuestions.SelectedRows)
                {
                    int questionId = Convert.ToInt32(row.Cells["QuestionID"].Value);

                    // Tìm và xóa câu hỏi khỏi dtSelectedQuestions
                    foreach (DataRow dr in dtSelectedQuestions.Rows)
                    {
                        if (Convert.ToInt32(dr["QuestionID"]) == questionId)
                        {
                            dr.Delete();
                            break;
                        }
                    }
                }

                dtSelectedQuestions.AcceptChanges();

                // Cập nhật lại STT
                for (int i = 0; i < dtSelectedQuestions.Rows.Count; i++)
                {
                    dtSelectedQuestions.Rows[i]["STT"] = i + 1;
                }

                // Cập nhật số lượng câu hỏi
                txt_TotalQuestion.Value = dtSelectedQuestions.Rows.Count;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi xóa câu hỏi khỏi đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveExam("Draft");
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SaveExam("Pending");
        }

        private void SaveExam(string status)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txt_ExamName.Text))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng nhập tên đề thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbb_Subject.SelectedValue == null)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_TimeLimit.Value <= 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Thời gian làm bài phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtSelectedQuestions.Rows.Count == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng thêm câu hỏi vào đề thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đề thi mới
                Exam exam = new Exam
                {
                    ExamName = txt_ExamName.Text.Trim(),
                    SubjectID = cbb_Subject.SelectedValue.ToString(),
                    TimeLimit = Convert.ToInt32(txt_TimeLimit.Value),
                    TotalQuestion = dtSelectedQuestions.Rows.Count,
                    Status = status,
                    CreatedBy = Session.LogonUser.Username,
                    ModifiedBy = Session.LogonUser.Username
                };

                // Lưu đề thi vào cơ sở dữ liệu
                int examId = BExam.AddExam(exam);

                // Lưu các câu hỏi của đề thi
                foreach (DataRow row in dtSelectedQuestions.Rows)
                {
                    int questionId = Convert.ToInt32(row["QuestionID"]);
                    BExamQuestion.AddExamQuestion(examId, questionId);
                }

                string message = status == "Draft" ? "Lưu đề thi thành công!" : "Gửi đề thi để duyệt thành công!";
                DevExpress.XtraEditors.XtraMessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa dữ liệu đã nhập
                txt_ExamName.Text = "";
                txt_TimeLimit.Value = 0;
                txt_TotalQuestion.Value = 0;
                dtSelectedQuestions.Rows.Clear();
                grv_Questions.DataSource = null;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi lưu đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
