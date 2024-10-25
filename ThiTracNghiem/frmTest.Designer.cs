namespace ThiTracNghiem
{
    partial class frmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.lsb_Question = new System.Windows.Forms.ListBox();
            this.grb_Infor = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CountQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Subject = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Birthday = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.btn_FirstQuestion = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.rdb_OptionA = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdb_OptionC = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdb_OptionD = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdb_OptionB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btn_NopBai = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.rtxt_Question = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Time = new Guna.UI2.WinForms.Guna2TextBox();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.lb_socau = new DevExpress.XtraEditors.LabelControl();
            this.btn_NextQuestion = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_LastQuestion = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_PreviousQuestion = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.grb_Infor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_Question
            // 
            this.lsb_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsb_Question.FormattingEnabled = true;
            this.lsb_Question.ItemHeight = 18;
            this.lsb_Question.Location = new System.Drawing.Point(0, 0);
            this.lsb_Question.Margin = new System.Windows.Forms.Padding(4);
            this.lsb_Question.Name = "lsb_Question";
            this.lsb_Question.Size = new System.Drawing.Size(261, 652);
            this.lsb_Question.TabIndex = 0;
            this.lsb_Question.SelectedIndexChanged += new System.EventHandler(this.lsb_Question_SelectedIndexChanged);
            // 
            // grb_Infor
            // 
            this.grb_Infor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Infor.BackColor = System.Drawing.Color.Transparent;
            this.grb_Infor.Controls.Add(this.label5);
            this.grb_Infor.Controls.Add(this.txt_CountQuestion);
            this.grb_Infor.Controls.Add(this.label4);
            this.grb_Infor.Controls.Add(this.txt_Subject);
            this.grb_Infor.Controls.Add(this.label3);
            this.grb_Infor.Controls.Add(this.txt_Birthday);
            this.grb_Infor.Controls.Add(this.label2);
            this.grb_Infor.Controls.Add(this.txt_Name);
            this.grb_Infor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Infor.Location = new System.Drawing.Point(269, 15);
            this.grb_Infor.Margin = new System.Windows.Forms.Padding(4);
            this.grb_Infor.Name = "grb_Infor";
            this.grb_Infor.Padding = new System.Windows.Forms.Padding(4);
            this.grb_Infor.Size = new System.Drawing.Size(623, 140);
            this.grb_Infor.TabIndex = 1;
            this.grb_Infor.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng câu hỏi";
            // 
            // txt_CountQuestion
            // 
            this.txt_CountQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_CountQuestion.BackColor = System.Drawing.Color.Transparent;
            this.txt_CountQuestion.BorderRadius = 5;
            this.txt_CountQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CountQuestion.DefaultText = "";
            this.txt_CountQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CountQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CountQuestion.Location = new System.Drawing.Point(449, 86);
            this.txt_CountQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CountQuestion.Name = "txt_CountQuestion";
            this.txt_CountQuestion.PasswordChar = '\0';
            this.txt_CountQuestion.PlaceholderText = "";
            this.txt_CountQuestion.ReadOnly = true;
            this.txt_CountQuestion.SelectedText = "";
            this.txt_CountQuestion.Size = new System.Drawing.Size(156, 33);
            this.txt_CountQuestion.TabIndex = 7;
            this.txt_CountQuestion.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Môn thi";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Subject.BackColor = System.Drawing.Color.Transparent;
            this.txt_Subject.BorderRadius = 5;
            this.txt_Subject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Subject.DefaultText = "";
            this.txt_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Subject.Location = new System.Drawing.Point(85, 85);
            this.txt_Subject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.PasswordChar = '\0';
            this.txt_Subject.PlaceholderText = "";
            this.txt_Subject.ReadOnly = true;
            this.txt_Subject.SelectedText = "";
            this.txt_Subject.Size = new System.Drawing.Size(230, 33);
            this.txt_Subject.TabIndex = 5;
            this.txt_Subject.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // txt_Birthday
            // 
            this.txt_Birthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Birthday.BackColor = System.Drawing.Color.Transparent;
            this.txt_Birthday.BorderRadius = 5;
            this.txt_Birthday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Birthday.DefaultText = "";
            this.txt_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Birthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Birthday.Location = new System.Drawing.Point(449, 33);
            this.txt_Birthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Birthday.Name = "txt_Birthday";
            this.txt_Birthday.PasswordChar = '\0';
            this.txt_Birthday.PlaceholderText = "";
            this.txt_Birthday.ReadOnly = true;
            this.txt_Birthday.SelectedText = "";
            this.txt_Birthday.Size = new System.Drawing.Size(156, 33);
            this.txt_Birthday.TabIndex = 3;
            this.txt_Birthday.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Name.BackColor = System.Drawing.Color.Transparent;
            this.txt_Name.BorderRadius = 5;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Name.Location = new System.Drawing.Point(85, 32);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(230, 33);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TabStop = false;
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Question.Location = new System.Drawing.Point(292, 168);
            this.lbl_Question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(56, 18);
            this.lbl_Question.TabIndex = 4;
            this.lbl_Question.Text = "Câu hỏi";
            // 
            // btn_FirstQuestion
            // 
            this.btn_FirstQuestion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_FirstQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_FirstQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btn_FirstQuestion.BorderRadius = 5;
            this.btn_FirstQuestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_FirstQuestion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_FirstQuestion.FocusedColor = System.Drawing.Color.DarkBlue;
            this.btn_FirstQuestion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FirstQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_FirstQuestion.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_FirstQuestion.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_FirstQuestion.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_FirstQuestion.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_FirstQuestion.Location = new System.Drawing.Point(297, 585);
            this.btn_FirstQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FirstQuestion.Name = "btn_FirstQuestion";
            this.btn_FirstQuestion.PressedColor = System.Drawing.Color.Transparent;
            this.btn_FirstQuestion.ShadowDecoration.BorderRadius = 5;
            this.btn_FirstQuestion.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btn_FirstQuestion.ShadowDecoration.Depth = 10;
            this.btn_FirstQuestion.ShadowDecoration.Enabled = true;
            this.btn_FirstQuestion.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_FirstQuestion.Size = new System.Drawing.Size(126, 40);
            this.btn_FirstQuestion.TabIndex = 10;
            this.btn_FirstQuestion.Text = "<< Câu đầu";
            this.btn_FirstQuestion.Click += new System.EventHandler(this.btn_FirstQuestion_Click);
            // 
            // rdb_OptionA
            // 
            this.rdb_OptionA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdb_OptionA.AutoSize = true;
            this.rdb_OptionA.BackColor = System.Drawing.Color.Transparent;
            this.rdb_OptionA.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rdb_OptionA.CheckedState.BorderThickness = 3;
            this.rdb_OptionA.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(151)))));
            this.rdb_OptionA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_OptionA.Location = new System.Drawing.Point(299, 348);
            this.rdb_OptionA.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_OptionA.Name = "rdb_OptionA";
            this.rdb_OptionA.Size = new System.Drawing.Size(118, 23);
            this.rdb_OptionA.TabIndex = 6;
            this.rdb_OptionA.Text = "radioButton1";
            this.rdb_OptionA.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.rdb_OptionA.UncheckedState.BorderThickness = 0;
            this.rdb_OptionA.UseVisualStyleBackColor = false;
            this.rdb_OptionA.CheckedChanged += new System.EventHandler(this.rdb_OptionA_CheckedChanged);
            // 
            // rdb_OptionC
            // 
            this.rdb_OptionC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdb_OptionC.AutoSize = true;
            this.rdb_OptionC.BackColor = System.Drawing.Color.Transparent;
            this.rdb_OptionC.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rdb_OptionC.CheckedState.BorderThickness = 3;
            this.rdb_OptionC.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(151)))));
            this.rdb_OptionC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_OptionC.Location = new System.Drawing.Point(299, 474);
            this.rdb_OptionC.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_OptionC.Name = "rdb_OptionC";
            this.rdb_OptionC.Size = new System.Drawing.Size(118, 23);
            this.rdb_OptionC.TabIndex = 8;
            this.rdb_OptionC.Text = "radioButton2";
            this.rdb_OptionC.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.rdb_OptionC.UncheckedState.BorderThickness = 0;
            this.rdb_OptionC.UseVisualStyleBackColor = false;
            this.rdb_OptionC.CheckedChanged += new System.EventHandler(this.rdb_OptionC_CheckedChanged);
            // 
            // rdb_OptionD
            // 
            this.rdb_OptionD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdb_OptionD.AutoSize = true;
            this.rdb_OptionD.BackColor = System.Drawing.Color.Transparent;
            this.rdb_OptionD.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rdb_OptionD.CheckedState.BorderThickness = 3;
            this.rdb_OptionD.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(151)))));
            this.rdb_OptionD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_OptionD.Location = new System.Drawing.Point(299, 537);
            this.rdb_OptionD.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_OptionD.Name = "rdb_OptionD";
            this.rdb_OptionD.Size = new System.Drawing.Size(118, 23);
            this.rdb_OptionD.TabIndex = 9;
            this.rdb_OptionD.Text = "radioButton3";
            this.rdb_OptionD.UncheckedState.BorderThickness = 0;
            this.rdb_OptionD.UseVisualStyleBackColor = false;
            this.rdb_OptionD.CheckedChanged += new System.EventHandler(this.rdb_OptionD_CheckedChanged);
            // 
            // rdb_OptionB
            // 
            this.rdb_OptionB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdb_OptionB.AutoSize = true;
            this.rdb_OptionB.BackColor = System.Drawing.Color.Transparent;
            this.rdb_OptionB.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rdb_OptionB.CheckedState.BorderThickness = 3;
            this.rdb_OptionB.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(151)))));
            this.rdb_OptionB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_OptionB.Location = new System.Drawing.Point(299, 411);
            this.rdb_OptionB.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_OptionB.Name = "rdb_OptionB";
            this.rdb_OptionB.Size = new System.Drawing.Size(118, 23);
            this.rdb_OptionB.TabIndex = 7;
            this.rdb_OptionB.Text = "radioButton4";
            this.rdb_OptionB.UncheckedState.BorderThickness = 0;
            this.rdb_OptionB.UseVisualStyleBackColor = false;
            this.rdb_OptionB.CheckedChanged += new System.EventHandler(this.rdb_OptionB_CheckedChanged);
            // 
            // btn_NopBai
            // 
            this.btn_NopBai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_NopBai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NopBai.BackColor = System.Drawing.Color.Transparent;
            this.btn_NopBai.BorderRadius = 5;
            this.btn_NopBai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_NopBai.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_NopBai.FocusedColor = System.Drawing.Color.DarkBlue;
            this.btn_NopBai.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NopBai.ForeColor = System.Drawing.Color.White;
            this.btn_NopBai.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_NopBai.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_NopBai.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_NopBai.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_NopBai.Location = new System.Drawing.Point(877, 585);
            this.btn_NopBai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NopBai.Name = "btn_NopBai";
            this.btn_NopBai.PressedColor = System.Drawing.Color.Transparent;
            this.btn_NopBai.ShadowDecoration.BorderRadius = 5;
            this.btn_NopBai.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btn_NopBai.ShadowDecoration.Depth = 10;
            this.btn_NopBai.ShadowDecoration.Enabled = true;
            this.btn_NopBai.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_NopBai.Size = new System.Drawing.Size(133, 40);
            this.btn_NopBai.TabIndex = 14;
            this.btn_NopBai.Text = "Nộp bài";
            this.btn_NopBai.Click += new System.EventHandler(this.btn_NopBai_Click);
            // 
            // rtxt_Question
            // 
            this.rtxt_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxt_Question.BackColor = System.Drawing.Color.Transparent;
            this.rtxt_Question.BorderRadius = 5;
            this.rtxt_Question.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxt_Question.DefaultText = "";
            this.rtxt_Question.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxt_Question.Location = new System.Drawing.Point(269, 198);
            this.rtxt_Question.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxt_Question.Name = "rtxt_Question";
            this.rtxt_Question.PasswordChar = '\0';
            this.rtxt_Question.PlaceholderText = "";
            this.rtxt_Question.ReadOnly = true;
            this.rtxt_Question.SelectedText = "";
            this.rtxt_Question.Size = new System.Drawing.Size(739, 126);
            this.rtxt_Question.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(896, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thời gian còn lại";
            // 
            // txt_Time
            // 
            this.txt_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Time.BackColor = System.Drawing.Color.Transparent;
            this.txt_Time.BorderRadius = 5;
            this.txt_Time.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_Time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Time.DefaultText = "10:00";
            this.txt_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Time.ForeColor = System.Drawing.Color.Red;
            this.txt_Time.Location = new System.Drawing.Point(900, 87);
            this.txt_Time.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.PasswordChar = '\0';
            this.txt_Time.PlaceholderText = "";
            this.txt_Time.ReadOnly = true;
            this.txt_Time.SelectedText = "";
            this.txt_Time.Size = new System.Drawing.Size(110, 40);
            this.txt_Time.TabIndex = 3;
            this.txt_Time.TabStop = false;
            this.txt_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerTest
            // 
            this.timerTest.Interval = 1000;
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // lb_socau
            // 
            this.lb_socau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_socau.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_socau.Appearance.ForeColor = System.Drawing.Color.White;
            this.lb_socau.Appearance.Options.UseFont = true;
            this.lb_socau.Appearance.Options.UseForeColor = true;
            this.lb_socau.Location = new System.Drawing.Point(873, 169);
            this.lb_socau.Name = "lb_socau";
            this.lb_socau.Size = new System.Drawing.Size(86, 17);
            this.lb_socau.TabIndex = 15;
            this.lb_socau.Text = "Số câu đã làm";
            // 
            // btn_NextQuestion
            // 
            this.btn_NextQuestion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_NextQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_NextQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btn_NextQuestion.BorderRadius = 5;
            this.btn_NextQuestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_NextQuestion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_NextQuestion.FocusedColor = System.Drawing.Color.DarkBlue;
            this.btn_NextQuestion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_NextQuestion.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_NextQuestion.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_NextQuestion.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_NextQuestion.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_NextQuestion.Location = new System.Drawing.Point(575, 585);
            this.btn_NextQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NextQuestion.Name = "btn_NextQuestion";
            this.btn_NextQuestion.PressedColor = System.Drawing.Color.Transparent;
            this.btn_NextQuestion.ShadowDecoration.BorderRadius = 5;
            this.btn_NextQuestion.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btn_NextQuestion.ShadowDecoration.Depth = 10;
            this.btn_NextQuestion.ShadowDecoration.Enabled = true;
            this.btn_NextQuestion.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_NextQuestion.Size = new System.Drawing.Size(112, 40);
            this.btn_NextQuestion.TabIndex = 12;
            this.btn_NextQuestion.Text = "Câu sau >";
            this.btn_NextQuestion.Click += new System.EventHandler(this.btn_NextQuestion_Click);
            // 
            // btn_LastQuestion
            // 
            this.btn_LastQuestion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_LastQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_LastQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btn_LastQuestion.BorderRadius = 5;
            this.btn_LastQuestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_LastQuestion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_LastQuestion.FocusedColor = System.Drawing.Color.DarkBlue;
            this.btn_LastQuestion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LastQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_LastQuestion.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_LastQuestion.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_LastQuestion.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_LastQuestion.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_LastQuestion.Location = new System.Drawing.Point(704, 585);
            this.btn_LastQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LastQuestion.Name = "btn_LastQuestion";
            this.btn_LastQuestion.PressedColor = System.Drawing.Color.Transparent;
            this.btn_LastQuestion.ShadowDecoration.BorderRadius = 5;
            this.btn_LastQuestion.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btn_LastQuestion.ShadowDecoration.Depth = 10;
            this.btn_LastQuestion.ShadowDecoration.Enabled = true;
            this.btn_LastQuestion.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_LastQuestion.Size = new System.Drawing.Size(120, 40);
            this.btn_LastQuestion.TabIndex = 13;
            this.btn_LastQuestion.Text = "Câu cuối >>";
            this.btn_LastQuestion.Click += new System.EventHandler(this.btn_LastQuestion_Click);
            // 
            // btn_PreviousQuestion
            // 
            this.btn_PreviousQuestion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_PreviousQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_PreviousQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousQuestion.BorderRadius = 5;
            this.btn_PreviousQuestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_PreviousQuestion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_PreviousQuestion.FocusedColor = System.Drawing.Color.DarkBlue;
            this.btn_PreviousQuestion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PreviousQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_PreviousQuestion.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_PreviousQuestion.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.btn_PreviousQuestion.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_PreviousQuestion.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(82)))), ((int)(((byte)(152)))));
            this.btn_PreviousQuestion.Location = new System.Drawing.Point(440, 585);
            this.btn_PreviousQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PreviousQuestion.Name = "btn_PreviousQuestion";
            this.btn_PreviousQuestion.PressedColor = System.Drawing.Color.Transparent;
            this.btn_PreviousQuestion.ShadowDecoration.BorderRadius = 5;
            this.btn_PreviousQuestion.ShadowDecoration.Color = System.Drawing.Color.White;
            this.btn_PreviousQuestion.ShadowDecoration.Depth = 10;
            this.btn_PreviousQuestion.ShadowDecoration.Enabled = true;
            this.btn_PreviousQuestion.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_PreviousQuestion.Size = new System.Drawing.Size(118, 40);
            this.btn_PreviousQuestion.TabIndex = 11;
            this.btn_PreviousQuestion.Text = "< Câu trước";
            this.btn_PreviousQuestion.Click += new System.EventHandler(this.btn_PreviousQuestion_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 647);
            this.Controls.Add(this.btn_LastQuestion);
            this.Controls.Add(this.btn_PreviousQuestion);
            this.Controls.Add(this.btn_NextQuestion);
            this.Controls.Add(this.lb_socau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxt_Question);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.btn_NopBai);
            this.Controls.Add(this.rdb_OptionB);
            this.Controls.Add(this.rdb_OptionD);
            this.Controls.Add(this.rdb_OptionC);
            this.Controls.Add(this.rdb_OptionA);
            this.Controls.Add(this.btn_FirstQuestion);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.grb_Infor);
            this.Controls.Add(this.lsb_Question);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1037, 686);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm bài thi trắc nghiệm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTest_FormClosing);
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.grb_Infor.ResumeLayout(false);
            this.grb_Infor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_Question;
        private System.Windows.Forms.GroupBox grb_Infor;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_CountQuestion;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_Subject;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Birthday;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Question;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_FirstQuestion;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_OptionA;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_OptionC;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_OptionD;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_OptionB;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_NopBai;
        private Guna.UI2.WinForms.Guna2TextBox rtxt_Question;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_Time;
        private System.Windows.Forms.Timer timerTest;
        private DevExpress.XtraEditors.LabelControl lb_socau;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_NextQuestion;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_LastQuestion;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_PreviousQuestion;
    }
}