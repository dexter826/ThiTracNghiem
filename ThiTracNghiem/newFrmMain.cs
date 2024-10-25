using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestCore;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    public partial class newFrmMain : Form
    {
        public newFrmMain()
        {
            InitializeComponent();
            lbl_HelloUser.Text = $"Xin chào, {ThiTracNghiem.Common.Session.LogonUser.Fullname}";

        }

        public void addNewTab(string strTabName, UserControl ucContent)
        {
            // Kiểm tra nếu tab đã tồn tại
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == strTabName)
                {
                    xtraTabControl1.SelectedTabPage = tab; 
                    return;
                }
            }

            DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();
            newTab.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTab.Controls.Add(ucContent);

            xtraTabControl1.TabPages.Add(newTab); 
            xtraTabControl1.SelectedTabPage = newTab; 
        }

        private void mn_ChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword fmChangePass = new frmChangePassword();
            fmChangePass.ShowDialog();
        }

        private void mn_ManageUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManageUser ucfmManageUser = new frmManageUser();
            addNewTab("Quản lí người dùng", ucfmManageUser);
        }

        private void mn_ManageQuestion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManageQuestion ucfmManageQuestion = new frmManageQuestion();
            addNewTab("Quản lí câu hỏi", ucfmManageQuestion);
        }

        private void mn_StartExam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOption frmOption = new frmOption();
            frmOption.ShowDialog();
        }

        private void mn_ReportBySubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmReportBySubject fmReportBySubject = new frmReportBySubject();
            //fmReportBySubject.ShowDialog();

            NewFrmReportBySubject newFrmReportBySubject = new NewFrmReportBySubject();
            //newFrmReportBySubject.ShowDialog();

            addNewTab("Báo cáo điểm theo môn thi", newFrmReportBySubject);
        }

        private void mn_ReportByStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmReportByTime fmReportByTime = new frmReportByTime();
            //fmReportByTime.ShowDialog();

            NewFrmReportByTime newFrmReportByTime = new NewFrmReportByTime();
            //newFrmReportByTime.ShowDialog();
            addNewTab("Báo cáo điểm theo thời gian", newFrmReportByTime);

        }

        private void mn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var exit = XtraMessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void mn_SignOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var exit = XtraMessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                // Xóa thông tin đăng nhập cũ
                Session.LogonUser = null;

                // Ẩn form chính
                this.Hide();

                // Mở form đăng nhập
                frmLogin frmLogin = new frmLogin();

                // Nếu đăng nhập thành công, kiểm tra quyền đăng nhập và khởi động lại ứng dụng
                frmLogin.ShowDialog();
                if (frmLogin.IsLoginSuccess)
                {
                    // Kiểm tra quyền đăng nhập
                    if (Session.LogonUser.RoldId.Equals("User"))
                    {
                        // Mở giao diện cho User
                        frmOption frmUser = new frmOption();
                        frmUser.ShowDialog();
                    }
                    else
                    {
                        // Mở lại frmMain cho quyền Admin
                        newFrmMain frmAdmin = new newFrmMain();
                        frmAdmin.ShowDialog();
                    }
                }

                // Đóng form chính hiện tại
                this.Close();
            }
        }

        private void mn_ManageSubject_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void mn_ManageSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManageSubject ucfmManageSubject = new frmManageSubject();
            addNewTab("Quản lí môn thi", ucfmManageSubject);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            //{
            //    saveFileDialog.Filter = "Backup Files (*.bak)|*.bak";
            //    saveFileDialog.Title = "Chọn vị trí lưu file sao lưu";
            //    saveFileDialog.FileName = "Backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak"; // Đặt tên file mặc định
            //    saveFileDialog.InitialDirectory = @"C:\Backup"; // Đặt thư mục mặc định

            //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string backupFilePath = saveFileDialog.FileName;
            //        string sourceConnectionString = ConnectionString.strCon;

            //        try
            //        {
            //            using (SqlConnection connection = new SqlConnection(sourceConnectionString))
            //            {
            //                connection.Open();
            //                SqlCommand command = new SqlCommand($"BACKUP DATABASE [QL_THITRACNGHIEM] TO DISK = '{backupFilePath}'", connection);
            //                command.ExecuteNonQuery();
            //                XtraMessageBox.Show("Dữ liệu đã được sao lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //        catch (SqlException sqlEx)
            //        {
            //            XtraMessageBox.Show($"Lỗi SQL: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        catch (Exception ex)
            //        {
            //            XtraMessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}

            frmBackUp fmBackUp = new frmBackUp();
            fmBackUp.ShowDialog();
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            xtraTabControl1.TabPages.Remove(arg.Page as DevExpress.XtraTab.XtraTabPage);
        }

        private void mn_Restore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRestore fmRestore = new frmRestore();
            fmRestore.ShowDialog();
        }

        private void newFrmMain_Load(object sender, EventArgs e)
        {
            if (Session.LogonUser.RoldId.Equals("Teacher"))
            {
                mn_ManageUser.Enabled = false;
                mn_Restore.Enabled = false;
                barButtonItem1.Enabled = false;
            }
        }
    }
}
