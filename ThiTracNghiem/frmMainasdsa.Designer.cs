namespace ThiTracNghiem
{
    partial class FluentDesignForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FluentDesignForm1));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mn_ChangePassword = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mn_ManageUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mn_ManageSubject = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mn_ManageQuestion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mn_StartExam = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mn_ReportBySubject = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mn_ReportByStudent = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.mnExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(406, 39);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(749, 677);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(406, 677);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mn_ChangePassword,
            this.mn_ManageUser,
            this.mnExit});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Hệ thống";
            // 
            // mn_ChangePassword
            // 
            this.mn_ChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.mn_ChangePassword.Name = "mn_ChangePassword";
            this.mn_ChangePassword.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mn_ChangePassword.Text = "Thay đổi mật khẩu";
            this.mn_ChangePassword.Click += new System.EventHandler(this.mn_ChangePassword_Click);
            // 
            // mn_ManageUser
            // 
            this.mn_ManageUser.Name = "mn_ManageUser";
            this.mn_ManageUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mn_ManageUser.Text = "Quản lí người dùng";
            this.mn_ManageUser.Click += new System.EventHandler(this.mn_ManageUser_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barCheckItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1155, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barCheckItem1});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mn_ManageSubject,
            this.mn_ManageQuestion});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Danh mục";
            // 
            // mn_ManageSubject
            // 
            this.mn_ManageSubject.Name = "mn_ManageSubject";
            this.mn_ManageSubject.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mn_ManageSubject.Text = "Quản lí môn học";
            this.mn_ManageSubject.Click += new System.EventHandler(this.mn_ManageSubject_Click);
            // 
            // mn_ManageQuestion
            // 
            this.mn_ManageQuestion.Name = "mn_ManageQuestion";
            this.mn_ManageQuestion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mn_ManageQuestion.Text = "Quản lí câu hỏi";
            this.mn_ManageQuestion.Click += new System.EventHandler(this.mn_ManageQuestion_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mn_StartExam});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Chức năng";
            // 
            // mn_StartExam
            // 
            this.mn_StartExam.Name = "mn_StartExam";
            this.mn_StartExam.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mn_StartExam.Text = "Làm bài thi";
            this.mn_StartExam.Click += new System.EventHandler(this.mn_StartExam_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mn_ReportBySubject,
            this.mn_ReportByStudent});
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Báo cáo - thống kê";
            // 
            // mn_ReportBySubject
            // 
            this.mn_ReportBySubject.Name = "mn_ReportBySubject";
            this.mn_ReportBySubject.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mn_ReportBySubject.Text = "Báo cáo điểm theo môn";
            this.mn_ReportBySubject.Click += new System.EventHandler(this.mn_ReportBySubject_Click);
            // 
            // mn_ReportByStudent
            // 
            this.mn_ReportByStudent.Name = "mn_ReportByStudent";
            this.mn_ReportByStudent.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mn_ReportByStudent.Text = "Báo cáo điểm theo thời gian";
            this.mn_ReportByStudent.Click += new System.EventHandler(this.mn_ReportByStudent_Click);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 0;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnExit.Text = "Thoát";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // FluentDesignForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 716);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "FluentDesignForm1";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Hệ thống quản lí thi trắc nghiệm";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mn_ChangePassword;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mn_ManageUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mn_ManageSubject;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mn_ManageQuestion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mn_StartExam;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mn_ReportBySubject;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mn_ReportByStudent;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnExit;
    }
}