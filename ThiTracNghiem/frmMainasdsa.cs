using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThiTracNghiem
{
    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FluentDesignForm1()
        {
            InitializeComponent();
        }

        private void mn_ChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword fmChangePass = new frmChangePassword();
            fmChangePass.ShowDialog();
        }

        private void mn_ManageUser_Click(object sender, EventArgs e)
        {
            frmManageUser fmManageUser = new frmManageUser();
            fmManageUser.ShowDialog();
        }

        private void mn_ManageSubject_Click(object sender, EventArgs e)
        {
            frmManageSubject fmManageSubject = new frmManageSubject();
            fmManageSubject.ShowDialog();
        }

        private void mn_ManageQuestion_Click(object sender, EventArgs e)
        {
            frmManageQuestion fmManageQuestion = new frmManageQuestion();
            fmManageQuestion.ShowDialog();
        }

        private void mn_StartExam_Click(object sender, EventArgs e)
        {
            frmOption frmOption = new frmOption();
            frmOption.ShowDialog();
        }

        private void mn_ReportBySubject_Click(object sender, EventArgs e)
        {
            frmReportBySubject fmReportBySubject = new frmReportBySubject();
            fmReportBySubject.ShowDialog();
        }

        private void mn_ReportByStudent_Click(object sender, EventArgs e)
        {
            frmReportByTime fmReportByTime = new frmReportByTime();
            fmReportByTime.ShowDialog();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
