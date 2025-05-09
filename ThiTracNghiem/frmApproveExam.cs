using BusinessLogicLayer;
using DevExpress.XtraEditors;
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
            // Khởi tạo ComboBox trạng thái - loại bỏ tùy chọn "Draft" vì đây là trang duyệt đề thi
            var statusList = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("All", "Tất cả"),
                new KeyValuePair<string, string>("Pending", "Chờ duyệt"),
                new KeyValuePair<string, string>("Approved", "Đã duyệt"),
                new KeyValuePair<string, string>("Rejected", "Từ chối")
                // Đã loại bỏ "Draft" vì không cần hiển thị trong trang duyệt đề thi
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
                    // Lấy tất cả đề thi trừ các đề thi có trạng thái "Draft"
                    dtExams = BExam.GetAll();

                    // Lọc bỏ các đề thi có trạng thái "Draft"
                    if (dtExams != null && dtExams.Rows.Count > 0)
                    {
                        // Sử dụng DataView để lọc dữ liệu
                        DataView dv = new DataView(dtExams);
                        dv.RowFilter = "Status <> 'Draft'";
                        dtExams = dv.ToTable();
                    }
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

                    // Đặt AutoGenerateColumns = false để tránh tạo cột tự động
                    grv_Exams.AutoGenerateColumns = false;
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
                XtraMessageBox.Show("Lỗi khi tải danh sách đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButtonStatus()
        {
            bool hasSelectedRow = grv_Exams.SelectedRows.Count > 0;
            btn_ViewDetail.Enabled = hasSelectedRow;
            btn_ToggleActive.Enabled = hasSelectedRow;

            if (hasSelectedRow)
            {
                string status = grv_Exams.SelectedRows[0].Cells["Status"].Value.ToString();
                bool isActive = Convert.ToBoolean(grv_Exams.SelectedRows[0].Cells["IsActive"].Value);

                btn_Approve.Enabled = status == "Pending";
                btn_Reject.Enabled = status == "Pending";
                btn_ToggleActive.Enabled = status == "Approved";

                // Cập nhật text cho nút kích hoạt
                btn_ToggleActive.Text = isActive ? "Hủy kích hoạt" : "Kích hoạt";
                btn_ToggleActive.Visible = true;
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

        private void grv_Exams_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                // Chỉ cập nhật STT cho các dòng dữ liệu thực sự, không phải dòng mới
                if (e.RowIndex < grv_Exams.Rows.Count && !grv_Exams.Rows[e.RowIndex].IsNewRow)
                {
                    // Cập nhật số thứ tự (STT) của mỗi hàng trong bảng
                    grv_Exams["Column1", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu cần
                Console.WriteLine("Lỗi khi cập nhật STT: " + ex.Message);
            }
        }

        private void btn_ViewDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExamId <= 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn đề thi cần xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mở form chi tiết đề thi
                frmExamDetail frmDetail = new frmExamDetail(selectedExamId);
                frmDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi xem chi tiết đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExamId <= 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn đề thi cần duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận duyệt đề thi
                if (XtraMessageBox.Show("Bạn có chắc chắn muốn duyệt đề thi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                // Cập nhật trạng thái đề thi
                BExam.UpdateStatus(selectedExamId, "Approved", Session.LogonUser.Username);

                XtraMessageBox.Show("Duyệt đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách đề thi
                LoadExams();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi duyệt đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reject_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExamId <= 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn đề thi cần từ chối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận từ chối đề thi
                if (XtraMessageBox.Show("Bạn có chắc chắn muốn từ chối đề thi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                // Cập nhật trạng thái đề thi
                BExam.UpdateStatus(selectedExamId, "Rejected", Session.LogonUser.Username);

                XtraMessageBox.Show("Từ chối đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách đề thi
                LoadExams();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi từ chối đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ToggleActive_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExamId <= 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn đề thi cần kích hoạt/hủy kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy trạng thái kích hoạt hiện tại
                bool isActive = Convert.ToBoolean(grv_Exams.SelectedRows[0].Cells["IsActive"].Value);
                string action = isActive ? "hủy kích hoạt" : "kích hoạt";

                // Xác nhận kích hoạt/hủy kích hoạt đề thi
                if (XtraMessageBox.Show($"Bạn có chắc chắn muốn {action} đề thi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                // Cập nhật trạng thái kích hoạt đề thi
                BExam.SetActive(selectedExamId, !isActive, Session.LogonUser.Username);

                XtraMessageBox.Show($"{char.ToUpper(action[0]) + action.Substring(1)} đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách đề thi
                LoadExams();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi kích hoạt/hủy kích hoạt đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
