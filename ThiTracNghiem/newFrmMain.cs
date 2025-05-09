using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI.WebControls;
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
        /// <summary>
        /// Tạo tab page
        /// </summary>
        /// <param name="strTabName"></param>
        /// <param name="ucContent"></param>
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
        /// <summary>
        /// Menu thay đổi mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_ChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword fmChangePass = new frmChangePassword();
            fmChangePass.ShowDialog();
        }
        /// <summary>
        /// Quản lí người dùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_ManageUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManageUser ucfmManageUser = new frmManageUser();
            addNewTab("Quản lí người dùng", ucfmManageUser);
        }
        /// <summary>
        /// Quản lí câu hỏi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_ManageQuestion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManageQuestion ucfmManageQuestion = new frmManageQuestion();
            addNewTab("Quản lí câu hỏi", ucfmManageQuestion);
        }
        /// <summary>
        /// Làm bài thi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_StartExam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOption frmOption = new frmOption();
            frmOption.ShowDialog();
        }
        /// <summary>
        /// Báo cáo theo môn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_ReportBySubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmReportBySubject fmReportBySubject = new frmReportBySubject();
            //fmReportBySubject.ShowDialog();

            NewFrmReportBySubject newFrmReportBySubject = new NewFrmReportBySubject();
            //newFrmReportBySubject.ShowDialog();

            addNewTab("Báo cáo điểm theo môn thi", newFrmReportBySubject);
        }
        /// <summary>
        /// Báo cáo theo thời gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    if (Session.LogonUser.RoleID.Equals("User"))
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
        /// <summary>
        /// Quản lí môn thi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_ManageSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManageSubject ucfmManageSubject = new frmManageSubject();
            addNewTab("Quản lí môn thi", ucfmManageSubject);
        }

        /// <summary>
        /// Sao lưu csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBackUp fmBackUp = new frmBackUp();
            fmBackUp.ShowDialog();
        }

        /// <summary>
        /// Đóng tab đang mở
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            xtraTabControl1.TabPages.Remove(arg.Page as DevExpress.XtraTab.XtraTabPage);
        }

        /// <summary>
        /// Phục hồi csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_Restore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRestore fmRestore = new frmRestore();
            fmRestore.ShowDialog();
        }

        private void newFrmMain_Load(object sender, EventArgs e)
        {
            if (Session.LogonUser.RoleID.Equals("Teacher"))
            {
                mn_ManageUser.Enabled = false;
                mn_Restore.Enabled = false;
                barButtonItem1.Enabled = false;
                mn_TeacherSubject.Enabled = false;
                mn_ApproveExam.Enabled = false;
                mn_ManageSubject.Enabled = false; // Giáo viên không thể truy cập chức năng "Quản lí môn thi"
                mn_ManageExamSession.Enabled = false; // Giáo viên không thể truy cập chức năng "Quản lí kỳ thi"
            }
            else if (Session.LogonUser.RoleID.Equals("Admin"))
            {
                mn_CreateExam.Enabled = false;
            }
        }

        /// <summary>
        /// Phân công môn học cho giáo viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_TeacherSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTeacherSubject ucfmTeacherSubject = new frmTeacherSubject();
            addNewTab("Phân công môn học", ucfmTeacherSubject);
        }

        /// <summary>
        /// Tạo đề thi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_CreateExam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCreateExam ucfmCreateExam = new frmCreateExam();
            addNewTab("Tạo đề thi", ucfmCreateExam);
        }

        /// <summary>
        /// Duyệt đề thi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_ApproveExam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmApproveExam ucfmApproveExam = new frmApproveExam();
            addNewTab("Duyệt đề thi", ucfmApproveExam);
        }

        /// <summary>
        /// Quản lý kỳ thi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mn_ManageExamSession_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManageExamSession ucfmManageExamSession = new frmManageExamSession();
            addNewTab("Quản lý kỳ thi", ucfmManageExamSession);
        }

        private void xtraTabControl1_Paint(object sender, PaintEventArgs e)
        {
            if (xtraTabControl1.TabPages.Count == 0 && xtraTabControl1.BackgroundImage != null)
            {
                // Xác định hình chữ nhật đích là khu vực khách của điều khiển
                Rectangle destRect = xtraTabControl1.ClientRectangle;

                // Vẽ hình nền, kéo dài để phù hợp với toàn bộ vùng khách của điều khiển
                e.Graphics.DrawImage(xtraTabControl1.BackgroundImage, destRect, 0, 0,
                                      xtraTabControl1.BackgroundImage.Width, xtraTabControl1.BackgroundImage.Height,
                                      GraphicsUnit.Pixel);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
