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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
