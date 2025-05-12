using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ThiTracNghiem.Common;
using Entities;

namespace ThiTracNghiem.Common
{
    public static class ReportHelper
    {
        /// <summary>
        /// Hiển thị báo cáo kỳ thi
        /// </summary>
        /// <param name="examSession">Thông tin kỳ thi</param>
        /// <param name="userExamSessions">Danh sách người dùng trong kỳ thi</param>
        public static void ShowExamSessionReport(ExamSession examSession, DataTable userExamSessions)
        {
            try
            {
                // Tạo form báo cáo
                Form reportForm = new Form();
                reportForm.Text = "Báo cáo kỳ thi";
                reportForm.Size = new System.Drawing.Size(800, 600);
                reportForm.StartPosition = FormStartPosition.CenterScreen;

                // Tạo ReportViewer
                ReportViewer reportViewer = new ReportViewer();
                reportViewer.Dock = DockStyle.Fill;
                reportViewer.ProcessingMode = ProcessingMode.Local;

                // Thiết lập báo cáo
                string reportPath = Path.Combine(Application.StartupPath, "Reports", "ExamSessionReport.rdlc");
                reportViewer.LocalReport.ReportPath = reportPath;

                // Tạo nguồn dữ liệu
                ReportDataSource dataSource = new ReportDataSource("UserExamSessionDataSet", userExamSessions);
                reportViewer.LocalReport.DataSources.Add(dataSource);

                // Thiết lập tham số
                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("SessionName", examSession.SessionName));
                parameters.Add(new ReportParameter("StartTime", examSession.StartTime.ToString("dd/MM/yyyy HH:mm")));
                parameters.Add(new ReportParameter("EndTime", examSession.EndTime.ToString("dd/MM/yyyy HH:mm")));
                parameters.Add(new ReportParameter("Status", examSession.Status));

                DateTime dtNow = DateTime.Now;
                string reportPalace = string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", dtNow.Day, dtNow.Month, dtNow.Year);
                parameters.Add(new ReportParameter("ReportPalace", reportPalace));
                parameters.Add(new ReportParameter("CreatedBy", Session.LogonUser.Fullname));

                reportViewer.LocalReport.SetParameters(parameters);

                // Thêm ReportViewer vào form
                reportForm.Controls.Add(reportViewer);

                // Hiển thị báo cáo
                reportViewer.RefreshReport();
                reportForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hiển thị báo cáo theo môn học
        /// </summary>
        /// <param name="subjectName">Tên môn học</param>
        /// <param name="subjectReport">Dữ liệu báo cáo</param>
        public static void ShowSubjectReport(string subjectName, DataTable subjectReport)
        {
            try
            {
                // Tạo form báo cáo
                Form reportForm = new Form();
                reportForm.Text = "Báo cáo theo môn học";
                reportForm.Size = new System.Drawing.Size(800, 600);
                reportForm.StartPosition = FormStartPosition.CenterScreen;

                // Tạo ReportViewer
                ReportViewer reportViewer = new ReportViewer();
                reportViewer.Dock = DockStyle.Fill;
                reportViewer.ProcessingMode = ProcessingMode.Local;

                // Thiết lập báo cáo
                string reportPath = Path.Combine(Application.StartupPath, "Reports", "SubjectReport.rdlc");
                reportViewer.LocalReport.ReportPath = reportPath;

                // Tạo nguồn dữ liệu
                ReportDataSource dataSource = new ReportDataSource("SubjectReportDataSet", subjectReport);
                reportViewer.LocalReport.DataSources.Add(dataSource);

                // Thiết lập tham số
                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("SubjectName", subjectName));

                DateTime dtNow = DateTime.Now;
                string reportPalace = string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", dtNow.Day, dtNow.Month, dtNow.Year);
                parameters.Add(new ReportParameter("ReportPalace", reportPalace));
                parameters.Add(new ReportParameter("CreatedBy", Session.LogonUser.Fullname));

                reportViewer.LocalReport.SetParameters(parameters);

                // Thêm ReportViewer vào form
                reportForm.Controls.Add(reportViewer);

                // Hiển thị báo cáo
                reportViewer.RefreshReport();
                reportForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hiển thị báo cáo theo thời gian
        /// </summary>
        /// <param name="timePeriod">Khoảng thời gian</param>
        /// <param name="timeReport">Dữ liệu báo cáo</param>
        public static void ShowTimeReport(string timePeriod, DataTable timeReport)
        {
            try
            {
                // Tạo form báo cáo
                Form reportForm = new Form();
                reportForm.Text = "Báo cáo theo thời gian";
                reportForm.Size = new System.Drawing.Size(800, 600);
                reportForm.StartPosition = FormStartPosition.CenterScreen;

                // Tạo ReportViewer
                ReportViewer reportViewer = new ReportViewer();
                reportViewer.Dock = DockStyle.Fill;
                reportViewer.ProcessingMode = ProcessingMode.Local;

                // Thiết lập báo cáo
                string reportPath = Path.Combine(Application.StartupPath, "Reports", "TimeReport.rdlc");
                reportViewer.LocalReport.ReportPath = reportPath;

                // Tạo nguồn dữ liệu
                ReportDataSource dataSource = new ReportDataSource("TimeReportDataSet", timeReport);
                reportViewer.LocalReport.DataSources.Add(dataSource);

                // Thiết lập tham số
                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("TimePeriod", timePeriod));

                DateTime dtNow = DateTime.Now;
                string reportPalace = string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", dtNow.Day, dtNow.Month, dtNow.Year);
                parameters.Add(new ReportParameter("ReportPalace", reportPalace));
                parameters.Add(new ReportParameter("CreatedBy", Session.LogonUser.Fullname));

                reportViewer.LocalReport.SetParameters(parameters);

                // Thêm ReportViewer vào form
                reportForm.Controls.Add(reportViewer);

                // Hiển thị báo cáo
                reportViewer.RefreshReport();
                reportForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xuất báo cáo ra file PDF
        /// </summary>
        /// <param name="reportPath">Đường dẫn file báo cáo</param>
        /// <param name="dataSource">Nguồn dữ liệu</param>
        /// <param name="dataSourceName">Tên nguồn dữ liệu</param>
        /// <param name="parameters">Tham số báo cáo</param>
        /// <param name="outputPath">Đường dẫn file xuất</param>
        public static void ExportToPdf(string reportPath, DataTable dataSource, string dataSourceName, List<ReportParameter> parameters, string outputPath)
        {
            try
            {
                // Tạo báo cáo
                LocalReport report = new LocalReport();
                report.ReportPath = reportPath;

                // Tạo nguồn dữ liệu
                ReportDataSource reportDataSource = new ReportDataSource(dataSourceName, dataSource);
                report.DataSources.Add(reportDataSource);

                // Thiết lập tham số
                report.SetParameters(parameters);

                // Xuất báo cáo ra file PDF
                byte[] bytes = report.Render("PDF", null, out string mimeType, out string encoding, out string extension, out string[] streamIds, out Warning[] warnings);

                // Lưu file
                using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
