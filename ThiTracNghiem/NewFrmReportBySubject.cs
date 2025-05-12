using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ThiTracNghiem.Common;
using DevExpress.XtraEditors;
using Entities;
using Microsoft.Reporting.WinForms;


namespace ThiTracNghiem
{
    public partial class NewFrmReportBySubject : UserControl
    {
        public NewFrmReportBySubject()
        {
            InitializeComponent();
            btn_Print.Enabled = false;      // Đặt nút In không khả dụng khi khởi tạo
            btn_ExportPDF.Enabled = false;  // Đặt nút Xuất PDF không khả dụng khi khởi tạo
        }

        private void NewFrmReportBySubject_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                cbb_MonThi.DataSource = BSubject.GetAll();
                cbb_MonThi.DisplayMember = "SubjectName";
                cbb_MonThi.ValueMember = "SubjectID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!");
            }
        }

        // Hàm lấy dữ liệu báo cáo
        private DataTable GetReportData()
        {
            string subjectId = cbb_MonThi.SelectedValue.ToString();
            return BTestHistory.GetReportBySubject(subjectId);
        }

        private void btn_XemBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtData = GetReportData();
                if (dtData == null || dtData.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không có dữ liệu để hiển thị báo cáo.", "Thông báo");
                    return;
                }

                // Lấy tên môn học
                string subjectName = cbb_MonThi.Text;

                // Hiển thị báo cáo sử dụng ReportHelper
                ReportHelper.ShowSubjectReport(subjectName, dtData);
                //xtraReport.ShowPreview();


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
                DataTable dtData = GetReportData();
                string subjectName = cbb_MonThi.Text;

                // Hiển thị báo cáo sử dụng ReportHelper
                ReportHelper.ShowSubjectReport(subjectName, dtData);
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
                DataTable dtData = GetReportData();
                string subjectName = cbb_MonThi.Text;

                // Mở hộp thoại lưu file
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save a PDF File";
                    saveFileDialog.FileName = $"Báo cáo điểm thi môn {subjectName}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Tạo tham số báo cáo
                        List<ReportParameter> parameters = new List<ReportParameter>();
                        parameters.Add(new ReportParameter("SubjectName", subjectName));

                        DateTime dtNow = DateTime.Now;
                        string reportPalace = string.Format("TP.HCM, ngày {0} tháng {1} năm {2}", dtNow.Day, dtNow.Month, dtNow.Year);
                        parameters.Add(new ReportParameter("ReportPalace", reportPalace));
                        parameters.Add(new ReportParameter("CreatedBy", Session.LogonUser.Fullname));

                        // Đường dẫn file báo cáo
                        string reportPath = Path.Combine(Application.StartupPath, "Reports", "SubjectReport.rdlc");

                        // Xuất báo cáo ra file PDF
                        ReportHelper.ExportToPdf(reportPath, dtData, "SubjectReportDataSet", parameters, saveFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Sự kiện thay đổi lựa chọn trong cbb_MonThi
        private void cbb_MonThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vô hiệu hóa nút In và Xuất PDF khi thay đổi môn thi
            btn_Print.Enabled = false;
            btn_ExportPDF.Enabled = false;
        }
    }
}
