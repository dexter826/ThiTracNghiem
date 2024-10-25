using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TestCore.ConnectionString.loadConfig();

            frmLogin fLogin = new frmLogin();
            Application.Run(fLogin);
            if (fLogin.IsLoginSuccess)
            {
                // Hiển thị SplashScreen trước khi hiển thị form đăng nhập
                SplashScreenManager.ShowForm(typeof(frmLoad));

                // Mô phỏng thời gian xử lý với Thread.Sleep (để test hiển thị SplashScreen)
                System.Threading.Thread.Sleep(3000); // Tạm dừng 3 giây

                // Đóng SplashScreen
                SplashScreenManager.CloseForm();

                if (Session.LogonUser.RoldId.Equals("User"))
                    Application.Run(new frmOption());
                else
                    Application.Run(new newFrmMain());
            }
            //Application.Run(new frmTest());
        }
    }
}
