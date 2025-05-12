using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ThiTracNghiem.Common;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;


namespace ThiTracNghiem
{
    public partial class NewFrmReportByTime : UserControl
    {
        public NewFrmReportByTime()
        {
            InitializeComponent();
            btn_Print.Enabled = false;      // Đặt nút In không khả dụng khi khởi tạo
            btn_ExportPDF.Enabled = false;  // Đặt nút Xuất PDF không khả dụng khi khởi tạo
        }

        private void NewFrmReportByTime_Load(object sender, EventArgs e)
        {
            dpk_StartDate.Value = DateTime.Now.AddDays(-30);
            dpk_EndDate.Value = DateTime.Now;
        }

        private void btn_XemBaoCao_Click(object sender, EventArgs e)
        {
            //lay du lieu tu store len textbox
            try
            {
                DateTime startDate = dpk_StartDate.Value;
                DateTime endDate = dpk_EndDate.Value;

                DataTable dtData = BTestHistory.GetReportByTime(startDate, endDate);

                if (dtData == null || dtData.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không có dữ liệu để hiển thị báo cáo.", "Thông báo");
                    return;
                }

                string reportTime = string.Format("Từ ngày {0} đến ngày {1}", startDate.ToString("dd/MM/yyyy"), endDate.ToString("dd/MM/yyyy"));

                // Hiển thị báo cáo sử dụng ReportHelper
                ReportHelper.ShowTimeReport(reportTime, dtData);

                // Kích hoạt nút In và Xuất PDF
                btn_Print.Enabled = true;
                btn_ExportPDF.Enabled = true;
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
                DateTime startDate = dpk_StartDate.Value;
                DateTime endDate = dpk_EndDate.Value;

                DataTable dtData = BTestHistory.GetReportByTime(startDate, endDate);
                string reportTime = string.Format("Từ ngày {0} đến ngày {1}", startDate.ToString("dd/MM/yyyy"), endDate.ToString("dd/MM/yyyy"));

                // Hiển thị báo cáo sử dụng ReportHelper
                ReportHelper.ShowTimeReport(reportTime, dtData);
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
                DateTime startDate = dpk_StartDate.Value;
                DateTime endDate = dpk_EndDate.Value;

                DataTable dtData = BTestHistory.GetReportByTime(startDate, endDate);
                string reportTime = string.Format("Từ ngày {0} đến ngày {1}", startDate.ToString("dd/MM/yyyy"), endDate.ToString("dd/MM/yyyy"));

                string DayStart = startDate.ToString("dd-MM-yyyy");
                string DayEnd = endDate.ToString("dd-MM-yyyy");

                // Mở hộp thoại lưu file
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save a PDF File";
                    saveFileDialog.FileName = $"Báo cáo điểm thi từ ngày {DayStart}_{DayEnd}.pdf"; // Đặt tên mặc định cho file

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Tạo tham số báo cáo
                        List<ReportParameter> parameters = new List<ReportParameter>();
                        parameters.Add(new ReportParameter("TimePeriod", reportTime));

                        DateTime dtNow = DateTime.Now;
                        string reportPalace = string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", dtNow.Day, dtNow.Month, dtNow.Year);
                        parameters.Add(new ReportParameter("ReportPalace", reportPalace));
                        parameters.Add(new ReportParameter("CreatedBy", Session.LogonUser.Fullname));

                        // Đường dẫn file báo cáo
                        string reportPath = Path.Combine(Application.StartupPath, "Reports", "TimeReport.rdlc");

                        // Xuất báo cáo ra file PDF
                        ReportHelper.ExportToPdf(reportPath, dtData, "TimeReportDataSet", parameters, saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dpk_StartDate_Click(object sender, EventArgs e)
        {
            // Vô hiệu hóa nút In và Xuất PDF khi thay đổi môn thi
            btn_Print.Enabled = false;
            btn_ExportPDF.Enabled = false;
        }

        private void dpk_EndDate_Click(object sender, EventArgs e)
        {
            // Vô hiệu hóa nút In và Xuất PDF khi thay đổi môn thi
            btn_Print.Enabled = false;
            btn_ExportPDF.Enabled = false;
        }
    }
}
