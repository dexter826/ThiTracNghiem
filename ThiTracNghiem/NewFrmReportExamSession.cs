using BusinessLogicLayer;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ThiTracNghiem.Common;
using Microsoft.Reporting.WinForms;

namespace ThiTracNghiem
{
    public partial class NewFrmReportExamSession : UserControl
    {
        public NewFrmReportExamSession()
        {
            InitializeComponent();
        }

        private void NewFrmReportExamSession_Load(object sender, EventArgs e)
        {
            LoadExamSessions();
        }

        private void LoadExamSessions()
        {
            try
            {
                cbb_ExamSession.DataSource = BExamSession.GetAll();
                cbb_ExamSession.DisplayMember = "SessionName";
                cbb_ExamSession.ValueMember = "SessionID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!");
            }
        }

        private void btn_ViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_ExamSession.SelectedValue == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn kỳ thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sessionId = Convert.ToInt32(cbb_ExamSession.SelectedValue);

                // Lấy thông tin kỳ thi
                ExamSession examSession = BExamSession.GetById(sessionId);

                // Hiển thị thông tin kỳ thi
                lbl_SessionName.Text = examSession.SessionName;
                lbl_StartTime.Text = examSession.StartTime.ToString("dd/MM/yyyy HH:mm");
                lbl_EndTime.Text = examSession.EndTime.ToString("dd/MM/yyyy HH:mm");
                lbl_Status.Text = examSession.Status;

                // Lấy thống kê người dùng trong kỳ thi
                DataTable dtStatistics = BUserExamSession.GetStatistics(sessionId);

                // Lấy danh sách người dùng trong kỳ thi
                DataTable dtUsers = BUserExamSession.GetBySession(sessionId);

                // Hiển thị dữ liệu trong DataGridView
                grv_Users.DataSource = dtUsers;

                // Hiển thị các điều khiển báo cáo
                pnl_Report.Visible = true;
                btn_ExportPDF.Enabled = true;
                btn_Print.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_ExamSession.SelectedValue == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn kỳ thi và xem báo cáo trước khi in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sessionId = Convert.ToInt32(cbb_ExamSession.SelectedValue);

                // Lấy thông tin kỳ thi
                ExamSession examSession = BExamSession.GetById(sessionId);

                // Không cần lấy thống kê người dùng trong kỳ thi vì không còn sử dụng biểu đồ

                // Lấy danh sách người dùng trong kỳ thi
                DataTable dtUsers = BUserExamSession.GetBySession(sessionId);

                // Hiển thị báo cáo sử dụng ReportHelper
                ReportHelper.ShowExamSessionReport(examSession, dtUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_ExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_ExamSession.SelectedValue == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn kỳ thi và xem báo cáo trước khi xuất PDF!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sessionId = Convert.ToInt32(cbb_ExamSession.SelectedValue);

                // Lấy thông tin kỳ thi
                ExamSession examSession = BExamSession.GetById(sessionId);

                // Không cần lấy thống kê người dùng trong kỳ thi vì không còn sử dụng biểu đồ

                // Lấy danh sách người dùng trong kỳ thi
                DataTable dtUsers = BUserExamSession.GetBySession(sessionId);

                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Lưu báo cáo dưới dạng PDF";
                saveFileDialog.FileName = "BaoCaoKyThi_" + examSession.SessionName.Replace(" ", "_") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Tạo tham số báo cáo
                    List<ReportParameter> parameters = new List<ReportParameter>();
                    parameters.Add(new ReportParameter("SessionName", examSession.SessionName));
                    parameters.Add(new ReportParameter("StartTime", examSession.StartTime.ToString("dd/MM/yyyy HH:mm")));
                    parameters.Add(new ReportParameter("EndTime", examSession.EndTime.ToString("dd/MM/yyyy HH:mm")));
                    parameters.Add(new ReportParameter("Status", examSession.Status));

                    DateTime dtNow = DateTime.Now;
                    string reportPalace = string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", dtNow.Day, dtNow.Month, dtNow.Year);
                    parameters.Add(new ReportParameter("ReportPalace", reportPalace));
                    parameters.Add(new ReportParameter("CreatedBy", Session.LogonUser.Fullname));

                    // Đường dẫn file báo cáo
                    string reportPath = Path.Combine(Application.StartupPath, "Reports", "ExamSessionReport.rdlc");

                    // Xuất báo cáo ra file PDF
                    ReportHelper.ExportToPdf(reportPath, dtUsers, "UserExamSessionDataSet", parameters, saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
