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
    public partial class frmApproveExam : UserControl
    {
        private DataTable dtExams;
        private int selectedExamId = 0;

        public frmApproveExam()
        {
            InitializeComponent();
        }

        private void frmApproveExam_Load(object sender, EventArgs e)
        {
            InitializeStatusComboBox();
            LoadExams();
        }

        private void InitializeStatusComboBox()
        {
            // Khởi tạo ComboBox trạng thái
            var statusList = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("All", "Tất cả"),
                new KeyValuePair<string, string>("Pending", "Chờ duyệt"),
                new KeyValuePair<string, string>("Approved", "Đã duyệt"),
                new KeyValuePair<string, string>("Rejected", "Từ chối"),
                new KeyValuePair<string, string>("Draft", "Bản nháp")
            };

            cbb_Status.DataSource = new BindingSource(statusList, null);
            cbb_Status.DisplayMember = "Value";
            cbb_Status.ValueMember = "Key";
        }

        private void LoadExams()
        {
            try
            {
                string status = cbb_Status.SelectedValue.ToString();

                if (status == "All")
                {
                    // Lấy tất cả đề thi
                    dtExams = BExam.GetAll();
                }
                else
                {
                    // Lấy đề thi theo trạng thái
                    dtExams = BExam.GetByStatus(status);
                }

                if (dtExams != null && dtExams.Rows.Count > 0)
                {
                    // Thêm cột STT
                    if (!dtExams.Columns.Contains("STT"))
                    {
                        DataColumn sttColumn = new DataColumn("STT", typeof(int));
                        dtExams.Columns.Add(sttColumn);

                        for (int i = 0; i < dtExams.Rows.Count; i++)
                        {
                            dtExams.Rows[i]["STT"] = i + 1;
                        }

                        // Sắp xếp lại thứ tự cột
                        dtExams.Columns["STT"].SetOrdinal(0);
                    }

                    grv_Exams.DataSource = dtExams;

                    // Ẩn cột ExamID
                    if (grv_Exams.Columns["ExamID"] != null)
                        grv_Exams.Columns["ExamID"].Visible = false;

                    // Cập nhật trạng thái các nút
                    UpdateButtonStatus();
                }
                else
                {
                    grv_Exams.DataSource = null;
                    btn_ViewDetail.Enabled = false;
                    btn_Approve.Enabled = false;
                    btn_Reject.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButtonStatus()
        {
            bool hasSelectedRow = grv_Exams.SelectedRows.Count > 0;
            btn_ViewDetail.Enabled = hasSelectedRow;

            if (hasSelectedRow)
            {
                string status = grv_Exams.SelectedRows[0].Cells["Status"].Value.ToString();
                btn_Approve.Enabled = status == "Pending";
                btn_Reject.Enabled = status == "Pending";
            }
            else
            {
                btn_Approve.Enabled = false;
                btn_Reject.Enabled = false;
            }
        }

        private void cbb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadExams();
        }

        private void grv_Exams_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();

            if (grv_Exams.SelectedRows.Count > 0)
            {
                selectedExamId = Convert.ToInt32(grv_Exams.SelectedRows[0].Cells["ExamID"].Value);
            }
            else
            {
                selectedExamId = 0;
            }
        }

        private void btn_ViewDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExamId <= 0)
                {
                    MessageBox.Show("Vui lòng chọn đề thi cần xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin đề thi
                Exam exam = BExam.GetById(selectedExamId);

                // Lấy danh sách câu hỏi trong đề thi
                DataTable dtQuestions = BExamQuestion.GetByExam(selectedExamId);

                // Hiển thị thông tin chi tiết đề thi
                string message = $"Thông tin đề thi:\n\n" +
                                $"Tên đề thi: {exam.ExamName}\n" +
                                $"Môn học: {exam.SubjectName}\n" +
                                $"Thời gian làm bài: {exam.TimeLimit} phút\n" +
                                $"Số lượng câu hỏi: {exam.TotalQuestion}\n" +
                                $"Trạng thái: {exam.Status}\n" +
                                $"Người tạo: {exam.CreatedBy}\n" +
                                $"Ngày tạo: {exam.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss")}\n\n" +
                                $"Số câu hỏi trong đề thi: {dtQuestions.Rows.Count}";

                MessageBox.Show(message, "Chi tiết đề thi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem chi tiết đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExamId <= 0)
                {
                    MessageBox.Show("Vui lòng chọn đề thi cần duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận duyệt đề thi
                if (MessageBox.Show("Bạn có chắc chắn muốn duyệt đề thi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                // Cập nhật trạng thái đề thi
                BExam.UpdateStatus(selectedExamId, "Approved", Session.LogonUser.Username);

                MessageBox.Show("Duyệt đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách đề thi
                LoadExams();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi duyệt đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reject_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExamId <= 0)
                {
                    MessageBox.Show("Vui lòng chọn đề thi cần từ chối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận từ chối đề thi
                if (MessageBox.Show("Bạn có chắc chắn muốn từ chối đề thi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                // Cập nhật trạng thái đề thi
                BExam.UpdateStatus(selectedExamId, "Rejected", Session.LogonUser.Username);

                MessageBox.Show("Từ chối đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách đề thi
                LoadExams();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi từ chối đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
