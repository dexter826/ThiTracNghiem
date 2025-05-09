namespace ThiTracNghiem
{
    partial class newFrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newFrmMain));
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.mn_TeacherSubject = new DevExpress.XtraBars.BarButtonItem();
            this.mn_CreateExam = new DevExpress.XtraBars.BarButtonItem();
            this.mn_ApproveExam = new DevExpress.XtraBars.BarButtonItem();
            this.mn_ManageExamSession = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mn_ReportBySubject = new DevExpress.XtraBars.BarButtonItem();
            this.mn_ReportByStudent = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mn_StartExam = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mn_ManageQuestion = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mn_ManageSubject = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mn_ChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.mn_ManageUser = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mn_SignOut = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mn_Restore = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lbl_HelloUser = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            //
            // barButtonItem3
            //
            this.barButtonItem3.Caption = "Làm bài thi";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            //
            // barButtonItem4
            //
            this.barButtonItem4.Caption = "Báo cáo điểm theo môn";
            this.barButtonItem4.Name = "barButtonItem4";
            //
            // barButtonItem5
            //
            this.barButtonItem5.Name = "barButtonItem5";
            //
            // ribbonPage4
            //
            this.ribbonPage4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage4.Appearance.Options.UseFont = true;
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.ImageOptions.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = " Báo cáo - thống kê";
            //
            // ribbonPageGroup4
            //
            this.ribbonPageGroup4.ItemLinks.Add(this.mn_ReportBySubject);
            this.ribbonPageGroup4.ItemLinks.Add(this.mn_ReportByStudent);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "........................................";
            //
            // mn_ReportBySubject
            //
            this.mn_ReportBySubject.Caption = "Báo cáo theo môn";
            this.mn_ReportBySubject.Id = 9;
            this.mn_ReportBySubject.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mn_ReportBySubject.ImageOptions.SvgImage")));
            this.mn_ReportBySubject.Name = "mn_ReportBySubject";
            this.mn_ReportBySubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_ReportBySubject_ItemClick);
            //
            // mn_ReportByStudent
            //
            this.mn_ReportByStudent.Caption = "Báo cáo theo thời gian";
            this.mn_ReportByStudent.Id = 10;
            this.mn_ReportByStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mn_ReportByStudent.ImageOptions.SvgImage")));
            this.mn_ReportByStudent.Name = "mn_ReportByStudent";
            this.mn_ReportByStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_ReportByStudent_ItemClick);
            //
            // ribbonPage3
            //
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage3.Appearance.Options.UseFont = true;
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = " Chức năng";
            //
            // ribbonPageGroup3
            //
            this.ribbonPageGroup3.ItemLinks.Add(this.mn_StartExam);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "....................";
            //
            // mn_StartExam
            //
            this.mn_StartExam.Caption = "Làm bài thi";
            this.mn_StartExam.Id = 11;
            this.mn_StartExam.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mn_StartExam.ImageOptions.SvgImage")));
            this.mn_StartExam.Name = "mn_StartExam";
            this.mn_StartExam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_StartExam_ItemClick);
            //
            // ribbonPage2
            //
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup7});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = " Danh mục";
            //
            // ribbonPageGroup2
            //
            this.ribbonPageGroup2.ItemLinks.Add(this.mn_ManageQuestion);
            this.ribbonPageGroup2.ItemLinks.Add(this.mn_TeacherSubject);
            this.ribbonPageGroup2.ItemLinks.Add(this.mn_CreateExam);
            this.ribbonPageGroup2.ItemLinks.Add(this.mn_ApproveExam);
            this.ribbonPageGroup2.ItemLinks.Add(this.mn_ManageExamSession);
            this.ribbonPageGroup2.ItemLinks.Add(this.mn_ManageUserSubject);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "....................";
            //
            // mn_ManageQuestion
            //
            this.mn_ManageQuestion.Caption = "Quản lí câu hỏi";
            this.mn_ManageQuestion.Id = 3;
            this.mn_ManageQuestion.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mn_ManageQuestion.ImageOptions.LargeImage")));
            this.mn_ManageQuestion.Name = "mn_ManageQuestion";
            this.mn_ManageQuestion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_ManageQuestion_ItemClick);
            //
            // ribbonPageGroup7
            //
            this.ribbonPageGroup7.ItemLinks.Add(this.mn_ManageSubject);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "....................";
            //
            // mn_ManageSubject
            //
            this.mn_ManageSubject.Caption = "Quản lí môn thi";
            this.mn_ManageSubject.Id = 15;
            this.mn_ManageSubject.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mn_ManageSubject.ImageOptions.SvgImage")));
            this.mn_ManageSubject.Name = "mn_ManageSubject";
            this.mn_ManageSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_ManageSubject_ItemClick);
            //
            // ribbonPage1
            //
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup8,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup12});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = " Hệ thống";
            //
            // ribbonPageGroup1
            //
            this.ribbonPageGroup1.ItemLinks.Add(this.mn_ChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.mn_ManageUser);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = ".......................................";
            //
            // mn_ChangePassword
            //
            this.mn_ChangePassword.Caption = "Thay đổi mật khẩu";
            this.mn_ChangePassword.Id = 1;
            this.mn_ChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mn_ChangePassword.ImageOptions.LargeImage")));
            this.mn_ChangePassword.Name = "mn_ChangePassword";
            this.mn_ChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_ChangePassword_ItemClick);
            //
            // mn_ManageUser
            //
            this.mn_ManageUser.Caption = "Quản lí người dùng";
            this.mn_ManageUser.Id = 12;
            this.mn_ManageUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mn_ManageUser.ImageOptions.LargeImage")));
            this.mn_ManageUser.Name = "mn_ManageUser";
            this.mn_ManageUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_ManageUser_ItemClick);
            //
            // ribbonPageGroup8
            //
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "....................";
            //
            // barButtonItem1
            //
            this.barButtonItem1.Caption = "Sao lưu dữ liệu";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            //
            // ribbonPageGroup5
            //
            this.ribbonPageGroup5.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup5.ItemLinks.Add(this.mn_Exit);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "....................";
            //
            // mn_Exit
            //
            this.mn_Exit.Caption = "       Thoát";
            this.mn_Exit.Id = 13;
            this.mn_Exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mn_Exit.ImageOptions.LargeImage")));
            this.mn_Exit.Name = "mn_Exit";
            this.mn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_Exit_ItemClick);
            //
            // ribbonPageGroup6
            //
            this.ribbonPageGroup6.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup6.ItemLinks.Add(this.mn_SignOut);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "....................";
            //
            // mn_SignOut
            //
            this.mn_SignOut.Caption = "       Đăng xuất";
            this.mn_SignOut.Id = 14;
            this.mn_SignOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mn_SignOut.ImageOptions.SvgImage")));
            this.mn_SignOut.Name = "mn_SignOut";
            this.mn_SignOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_SignOut_ItemClick);
            //
            // ribbonPageGroup12
            //
            this.ribbonPageGroup12.ItemLinks.Add(this.mn_Restore);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "....................";
            //
            // mn_Restore
            //
            this.mn_Restore.Caption = "Phục hồi dữ liệu";
            this.mn_Restore.Id = 17;
            this.mn_Restore.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mn_Restore.ImageOptions.SvgImage")));
            this.mn_Restore.Name = "mn_Restore";
            this.mn_Restore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_Restore_ItemClick);
            //
            // mn_TeacherSubject
            //
            this.mn_TeacherSubject.Caption = "Phân công môn học";
            this.mn_TeacherSubject.Id = 24;
            this.mn_TeacherSubject.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mn_ManageSubject.ImageOptions.SvgImage")));
            this.mn_TeacherSubject.Name = "mn_TeacherSubject";
            this.mn_TeacherSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_TeacherSubject_ItemClick);
            //
            // mn_CreateExam
            //
            this.mn_CreateExam.Caption = "Tạo đề thi";
            this.mn_CreateExam.Id = 25;
            this.mn_CreateExam.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mn_ManageQuestion.ImageOptions.LargeImage")));
            this.mn_CreateExam.Name = "mn_CreateExam";
            this.mn_CreateExam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_CreateExam_ItemClick);
            //
            // mn_ApproveExam
            //
            this.mn_ApproveExam.Caption = "Duyệt đề thi";
            this.mn_ApproveExam.Id = 26;
            this.mn_ApproveExam.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mn_ManageUser.ImageOptions.LargeImage")));
            this.mn_ApproveExam.Name = "mn_ApproveExam";
            this.mn_ApproveExam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_ApproveExam_ItemClick);
            //
            // mn_ManageExamSession
            //
            this.mn_ManageExamSession.Caption = "Quản lý kỳ thi";
            this.mn_ManageExamSession.Id = 27;
            this.mn_ManageExamSession.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mn_ManageUser.ImageOptions.LargeImage")));
            this.mn_ManageExamSession.Name = "mn_ManageExamSession";
            this.mn_ManageExamSession.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_ManageExamSession_ItemClick);

            //
            // mn_ManageUserSubject
            //
            this.mn_ManageUserSubject.Caption = "Gán môn học cho người thi";
            this.mn_ManageUserSubject.Id = 28;
            this.mn_ManageUserSubject.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mn_ManageUser.ImageOptions.LargeImage")));
            this.mn_ManageUserSubject.Name = "mn_ManageUserSubject";
            this.mn_ManageUserSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mn_ManageUserSubject_ItemClick);

            //
            // ribbonControl1
            //
            this.ribbonControl1.BackColor = System.Drawing.Color.ForestGreen;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(339);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.mn_ChangePassword,
            this.mn_ManageQuestion,
            this.mn_ReportBySubject,
            this.mn_ReportByStudent,
            this.mn_StartExam,
            this.mn_ManageUser,
            this.mn_Exit,
            this.mn_SignOut,
            this.mn_ManageSubject,
            this.barButtonItem1,
            this.mn_Restore,
            this.mn_TeacherSubject,
            this.mn_CreateExam,
            this.mn_ApproveExam,
            this.mn_ManageExamSession,
            this.mn_ManageUserSubject});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(38);
            this.ribbonControl1.MaxItemId = 29;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 3836;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1540, 145);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            //
            // lbl_HelloUser
            //
            this.lbl_HelloUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            //
            //
            //
            this.lbl_HelloUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_HelloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HelloUser.ForeColor = System.Drawing.Color.White;
            this.lbl_HelloUser.Location = new System.Drawing.Point(1247, 4);
            this.lbl_HelloUser.Name = "lbl_HelloUser";
            this.lbl_HelloUser.Size = new System.Drawing.Size(250, 35);
            this.lbl_HelloUser.TabIndex = 3;
            this.lbl_HelloUser.Text = "<b><font size=\"+6\"><i>Dev</i><font color=\"#B02B2C\">Components</font></font></b>";
            //
            // ribbonPageGroup9
            //
            this.ribbonPageGroup9.ItemLinks.Add(this.mn_Exit);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "....................";
            //
            // ribbonPageGroup10
            //
            this.ribbonPageGroup10.ItemLinks.Add(this.mn_Exit);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "....................";
            //
            // ribbonPageGroup11
            //
            this.ribbonPageGroup11.ItemLinks.Add(this.mn_Exit);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "....................";
            //
            // xtraTabControl1
            //
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.BackgroundImage = global::ThiTracNghiem.Properties.Resources._11317256;
            this.xtraTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 145);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Size = new System.Drawing.Size(1540, 700);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            this.xtraTabControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabControl1_Paint);
            //
            // lblTime
            //
            this.lblTime.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.lblTime.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTime.Appearance.Options.UseBackColor = true;
            this.lblTime.Appearance.Options.UseFont = true;
            this.lblTime.Appearance.Options.UseForeColor = true;
            this.lblTime.Location = new System.Drawing.Point(634, 6);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 17);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time";
            //
            // timer1
            //
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // lblDate
            //
            this.lblDate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.lblDate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblDate.Appearance.Options.UseBackColor = true;
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Appearance.Options.UseForeColor = true;
            this.lblDate.Location = new System.Drawing.Point(634, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 17);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date";
            //
            // pictureEdit1
            //
            this.pictureEdit1.EditValue = global::ThiTracNghiem.Properties.Resources.Cat2;
            this.pictureEdit1.Location = new System.Drawing.Point(969, -80);
            this.pictureEdit1.MenuManager = this.ribbonControl1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(272, 120);
            this.pictureEdit1.TabIndex = 12;
            //
            // newFrmMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.lbl_HelloUser);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1534, 862);
            this.Name = "newFrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lí thi trắc nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.newFrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem mn_ReportBySubject;
        private DevExpress.XtraBars.BarButtonItem mn_ReportByStudent;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem mn_StartExam;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem mn_ManageQuestion;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem mn_ChangePassword;
        private DevExpress.XtraBars.BarButtonItem mn_ManageUser;
        private DevExpress.XtraBars.BarButtonItem mn_ManageExamSession;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem mn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem mn_SignOut;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lbl_HelloUser;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem mn_ManageSubject;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.BarButtonItem mn_Restore;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.BarButtonItem mn_TeacherSubject;
        private DevExpress.XtraBars.BarButtonItem mn_CreateExam;
        private DevExpress.XtraBars.BarButtonItem mn_ApproveExam;
        private DevExpress.XtraBars.BarButtonItem mn_ManageUserSubject;
    }
}