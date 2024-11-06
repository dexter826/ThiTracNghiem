using BusinessLogicLayer;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;
using ThiTracNghiem.Common;
using DevExpress.XtraEditors;


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

                XtraReportByTime xtraReport = new XtraReportByTime();
                xtraReport.DataSource = dtData;
                xtraReport.DataMember = "";

                string reportTime = string.Format("Từ ngày {0} đến ngày {1}", startDate.ToString("dd/MM/yyyy"), endDate.ToString("dd/MM/yyyy"));
                xtraReport.Parameters["ReportTime"].Value = reportTime;

                DateTime dtNow = DateTime.Now;
                string reportPalace = string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", dtNow.Day, dtNow.Month, dtNow.Year);
                xtraReport.Parameters["ReportPalace"].Value = reportPalace;

                xtraReport.Parameters["CreatedBy"].Value = Session.LogonUser.Fullname;

                // Hiển thị báo cáo trong DocumentViewer
                documentViewer1.DocumentSource = xtraReport;
                xtraReport.CreateDocument();

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
                XtraReportByTime xtraReport = new XtraReportByTime();
                xtraReport.DataSource = dtData;
                xtraReport.DataMember = "";
                xtraReport.ShowPreview();
                //// Mở hộp thoại in
                //using (var printDialog = new PrintDialog())
                //{
                //    if (printDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        xtraReport.PrintDialog();
                //    }
                //}
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
                XtraReportByTime xtraReport = new XtraReportByTime();
                xtraReport.DataSource = dtData;
                xtraReport.DataMember = "";

                // Mở hộp thoại lưu file
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save a PDF File";
                    saveFileDialog.FileName = "Report.pdf"; // Đặt tên mặc định cho file

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Xuất báo cáo ra file PDF
                        xtraReport.ExportToPdf(saveFileDialog.FileName);
                        XtraMessageBox.Show("Xuất file PDF thành công!", "Thông báo");
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
