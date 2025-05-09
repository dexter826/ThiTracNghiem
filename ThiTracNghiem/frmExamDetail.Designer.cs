namespace ThiTracNghiem
{
    partial class frmExamDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Print = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Questions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.grv_Questions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_QuestionCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox_QuestionDetail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdb_OptionD = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdb_OptionC = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdb_OptionB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdb_OptionA = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lbl_Chapter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_ChapterTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_CorrectAnswer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_CorrectAnswerTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_OptionATitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rtxt_OptionD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_OptionDTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rtxt_OptionC = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_OptionCTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rtxt_OptionB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_OptionBTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rtxt_OptionA = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rtxt_QuestionContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_QuestionContentTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox_ExamInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_ApprovedAt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_ApprovedAt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_ApprovedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_ApprovedBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_CreatedAt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_CreatedAtTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_CreatedBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_CreatedByTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Status = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_StatusTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_TotalQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TotalQuestionTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_TimeLimit = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TimeLimitTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_SubjectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_SubjectNameTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_ExamName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_ExamNameTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_Questions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Questions)).BeginInit();
            this.groupBox_QuestionDetail.SuspendLayout();
            this.groupBox_ExamInfo.SuspendLayout();
            this.SuspendLayout();
            //
            // frmExamDetail
            //
            this.Load += new System.EventHandler(this.frmExamDetail_Load);
            //
            // btn_Print
            //
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(1208, 512);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(87, 32);
            this.btn_Print.TabIndex = 9;
            this.btn_Print.Text = "In";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            //
            // btn_Close
            //
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(1301, 512);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(87, 32);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            //
            // splitContainer1
            //
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 205);
            this.splitContainer1.Name = "splitContainer1";
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Questions);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_QuestionDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1376, 297);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 7;
            //
            // groupBox_Questions
            //
            this.groupBox_Questions.Controls.Add(this.grv_Questions);
            this.groupBox_Questions.Controls.Add(this.lbl_QuestionCount);
            this.groupBox_Questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Questions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox_Questions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox_Questions.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Questions.Name = "groupBox_Questions";
            this.groupBox_Questions.Size = new System.Drawing.Size(400, 297);
            this.groupBox_Questions.TabIndex = 1;
            this.groupBox_Questions.Text = "Danh sách câu hỏi";
            //
            // grv_Questions
            //
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_Questions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Questions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_Questions.ColumnHeadersHeight = 17;
            this.grv_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Questions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colQuestionID,
            this.colQContent,
            this.colChapter});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Questions.DefaultCellStyle = dataGridViewCellStyle3;
            this.grv_Questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_Questions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Questions.Location = new System.Drawing.Point(0, 40);
            this.grv_Questions.Name = "grv_Questions";
            this.grv_Questions.RowHeadersVisible = false;
            this.grv_Questions.Size = new System.Drawing.Size(400, 257);
            this.grv_Questions.TabIndex = 19;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Questions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Questions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_Questions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_Questions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_Questions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Questions.ThemeStyle.HeaderStyle.Height = 17;
            this.grv_Questions.ThemeStyle.ReadOnly = false;
            this.grv_Questions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Questions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grv_Questions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grv_Questions.ThemeStyle.RowsStyle.Height = 22;
            this.grv_Questions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Questions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_Questions.SelectionChanged += new System.EventHandler(this.grv_Questions_SelectionChanged);
            this.grv_Questions.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grv_Questions_RowPrePaint);
            //
            // colSTT
            //
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            //
            // colQuestionID
            //
            this.colQuestionID.HeaderText = "ID câu hỏi";
            this.colQuestionID.Name = "colQuestionID";
            this.colQuestionID.Visible = false;
            //
            // colQContent
            //
            this.colQContent.HeaderText = "Nội dung câu hỏi";
            this.colQContent.Name = "colQContent";
            //
            // colChapter
            //
            this.colChapter.HeaderText = "Chương";
            this.colChapter.Name = "colChapter";
            //
            // lbl_QuestionCount
            //
            this.lbl_QuestionCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QuestionCount.Location = new System.Drawing.Point(113, 11);
            this.lbl_QuestionCount.Name = "lbl_QuestionCount";
            this.lbl_QuestionCount.Size = new System.Drawing.Size(140, 15);
            this.lbl_QuestionCount.TabIndex = 18;
            this.lbl_QuestionCount.Text = "Số lượng câu hỏi trong đề thi";
            //
            // groupBox_QuestionDetail
            //
            this.groupBox_QuestionDetail.Controls.Add(this.rdb_OptionD);
            this.groupBox_QuestionDetail.Controls.Add(this.rdb_OptionC);
            this.groupBox_QuestionDetail.Controls.Add(this.rdb_OptionB);
            this.groupBox_QuestionDetail.Controls.Add(this.rdb_OptionA);
            this.groupBox_QuestionDetail.Controls.Add(this.lbl_Chapter);
            this.groupBox_QuestionDetail.Controls.Add(this.lbl_ChapterTitle);
            this.groupBox_QuestionDetail.Controls.Add(this.lbl_CorrectAnswer);
            this.groupBox_QuestionDetail.Controls.Add(this.lbl_CorrectAnswerTitle);
            this.groupBox_QuestionDetail.Controls.Add(this.lbl_OptionATitle);
            this.groupBox_QuestionDetail.Controls.Add(this.rtxt_OptionD);
            this.groupBox_QuestionDetail.Controls.Add(this.lbl_OptionDTitle);
            this.groupBox_QuestionDetail.Controls.Add(this.rtxt_OptionC);
            this.groupBox_QuestionDetail.Controls.Add(this.lbl_OptionCTitle);
            this.groupBox_QuestionDetail.Controls.Add(this.rtxt_OptionB);
            this.groupBox_QuestionDetail.Controls.Add(this.lbl_OptionBTitle);
            this.groupBox_QuestionDetail.Controls.Add(this.rtxt_OptionA);
            this.groupBox_QuestionDetail.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox_QuestionDetail.Controls.Add(this.rtxt_QuestionContent);
            this.groupBox_QuestionDetail.Controls.Add(this.lbl_QuestionContentTitle);
            this.groupBox_QuestionDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_QuestionDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox_QuestionDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox_QuestionDetail.Location = new System.Drawing.Point(0, 0);
            this.groupBox_QuestionDetail.Name = "groupBox_QuestionDetail";
            this.groupBox_QuestionDetail.Size = new System.Drawing.Size(972, 297);
            this.groupBox_QuestionDetail.TabIndex = 2;
            this.groupBox_QuestionDetail.Text = "Chi tiết câu hỏi";
            //
            // rdb_OptionD
            //
            this.rdb_OptionD.AutoSize = true;
            this.rdb_OptionD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_OptionD.CheckedState.BorderThickness = 0;
            this.rdb_OptionD.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_OptionD.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdb_OptionD.CheckedState.InnerOffset = -4;
            this.rdb_OptionD.Enabled = false;
            this.rdb_OptionD.Location = new System.Drawing.Point(904, 211);
            this.rdb_OptionD.Name = "rdb_OptionD";
            this.rdb_OptionD.Size = new System.Drawing.Size(54, 19);
            this.rdb_OptionD.TabIndex = 35;
            this.rdb_OptionD.Text = "Đúng";
            this.rdb_OptionD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdb_OptionD.UncheckedState.BorderThickness = 2;
            this.rdb_OptionD.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_OptionD.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            //
            // rdb_OptionC
            //
            this.rdb_OptionC.AutoSize = true;
            this.rdb_OptionC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_OptionC.CheckedState.BorderThickness = 0;
            this.rdb_OptionC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_OptionC.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdb_OptionC.CheckedState.InnerOffset = -4;
            this.rdb_OptionC.Enabled = false;
            this.rdb_OptionC.Location = new System.Drawing.Point(476, 211);
            this.rdb_OptionC.Name = "rdb_OptionC";
            this.rdb_OptionC.Size = new System.Drawing.Size(54, 19);
            this.rdb_OptionC.TabIndex = 34;
            this.rdb_OptionC.Text = "Đúng";
            this.rdb_OptionC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdb_OptionC.UncheckedState.BorderThickness = 2;
            this.rdb_OptionC.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_OptionC.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            //
            // rdb_OptionB
            //
            this.rdb_OptionB.AutoSize = true;
            this.rdb_OptionB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_OptionB.CheckedState.BorderThickness = 0;
            this.rdb_OptionB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_OptionB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdb_OptionB.CheckedState.InnerOffset = -4;
            this.rdb_OptionB.Enabled = false;
            this.rdb_OptionB.Location = new System.Drawing.Point(904, 160);
            this.rdb_OptionB.Name = "rdb_OptionB";
            this.rdb_OptionB.Size = new System.Drawing.Size(54, 19);
            this.rdb_OptionB.TabIndex = 33;
            this.rdb_OptionB.Text = "Đúng";
            this.rdb_OptionB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdb_OptionB.UncheckedState.BorderThickness = 2;
            this.rdb_OptionB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_OptionB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            //
            // rdb_OptionA
            //
            this.rdb_OptionA.AutoSize = true;
            this.rdb_OptionA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_OptionA.CheckedState.BorderThickness = 0;
            this.rdb_OptionA.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_OptionA.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdb_OptionA.CheckedState.InnerOffset = -4;
            this.rdb_OptionA.Enabled = false;
            this.rdb_OptionA.Location = new System.Drawing.Point(476, 164);
            this.rdb_OptionA.Name = "rdb_OptionA";
            this.rdb_OptionA.Size = new System.Drawing.Size(54, 19);
            this.rdb_OptionA.TabIndex = 32;
            this.rdb_OptionA.Text = "Đúng";
            this.rdb_OptionA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdb_OptionA.UncheckedState.BorderThickness = 2;
            this.rdb_OptionA.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_OptionA.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            //
            // lbl_Chapter
            //
            this.lbl_Chapter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Chapter.Location = new System.Drawing.Point(107, 132);
            this.lbl_Chapter.Name = "lbl_Chapter";
            this.lbl_Chapter.Size = new System.Drawing.Size(78, 15);
            this.lbl_Chapter.TabIndex = 31;
            this.lbl_Chapter.Text = "Hiển thị chương";
            //
            // lbl_ChapterTitle
            //
            this.lbl_ChapterTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ChapterTitle.Location = new System.Drawing.Point(21, 132);
            this.lbl_ChapterTitle.Name = "lbl_ChapterTitle";
            this.lbl_ChapterTitle.Size = new System.Drawing.Size(43, 15);
            this.lbl_ChapterTitle.TabIndex = 30;
            this.lbl_ChapterTitle.Text = "Chương:";
            //
            // lbl_CorrectAnswer
            //
            this.lbl_CorrectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CorrectAnswer.Location = new System.Drawing.Point(139, 262);
            this.lbl_CorrectAnswer.Name = "lbl_CorrectAnswer";
            this.lbl_CorrectAnswer.Size = new System.Drawing.Size(104, 15);
            this.lbl_CorrectAnswer.TabIndex = 29;
            this.lbl_CorrectAnswer.Text = "Hiển thị đáp án đúng";
            //
            // lbl_CorrectAnswerTitle
            //
            this.lbl_CorrectAnswerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CorrectAnswerTitle.Location = new System.Drawing.Point(22, 262);
            this.lbl_CorrectAnswerTitle.Name = "lbl_CorrectAnswerTitle";
            this.lbl_CorrectAnswerTitle.Size = new System.Drawing.Size(69, 15);
            this.lbl_CorrectAnswerTitle.TabIndex = 28;
            this.lbl_CorrectAnswerTitle.Text = "Đáp án đúng:";
            //
            // lbl_OptionATitle
            //
            this.lbl_OptionATitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OptionATitle.Location = new System.Drawing.Point(118, 166);
            this.lbl_OptionATitle.Name = "lbl_OptionATitle";
            this.lbl_OptionATitle.Size = new System.Drawing.Size(10, 15);
            this.lbl_OptionATitle.TabIndex = 27;
            this.lbl_OptionATitle.Text = "A";
            //
            // rtxt_OptionD
            //
            this.rtxt_OptionD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxt_OptionD.DefaultText = "";
            this.rtxt_OptionD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rtxt_OptionD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rtxt_OptionD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_OptionD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_OptionD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_OptionD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtxt_OptionD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_OptionD.Location = new System.Drawing.Point(575, 202);
            this.rtxt_OptionD.Name = "rtxt_OptionD";
            this.rtxt_OptionD.PasswordChar = '\0';
            this.rtxt_OptionD.PlaceholderText = "";
            this.rtxt_OptionD.ReadOnly = true;
            this.rtxt_OptionD.SelectedText = "";
            this.rtxt_OptionD.Size = new System.Drawing.Size(324, 36);
            this.rtxt_OptionD.TabIndex = 25;
            //
            // lbl_OptionDTitle
            //
            this.lbl_OptionDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OptionDTitle.Location = new System.Drawing.Point(558, 211);
            this.lbl_OptionDTitle.Name = "lbl_OptionDTitle";
            this.lbl_OptionDTitle.Size = new System.Drawing.Size(11, 15);
            this.lbl_OptionDTitle.TabIndex = 26;
            this.lbl_OptionDTitle.Text = "D";
            //
            // rtxt_OptionC
            //
            this.rtxt_OptionC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxt_OptionC.DefaultText = "";
            this.rtxt_OptionC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rtxt_OptionC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rtxt_OptionC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_OptionC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_OptionC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_OptionC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtxt_OptionC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_OptionC.Location = new System.Drawing.Point(146, 202);
            this.rtxt_OptionC.Name = "rtxt_OptionC";
            this.rtxt_OptionC.PasswordChar = '\0';
            this.rtxt_OptionC.PlaceholderText = "";
            this.rtxt_OptionC.ReadOnly = true;
            this.rtxt_OptionC.SelectedText = "";
            this.rtxt_OptionC.Size = new System.Drawing.Size(324, 36);
            this.rtxt_OptionC.TabIndex = 23;
            //
            // lbl_OptionCTitle
            //
            this.lbl_OptionCTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OptionCTitle.Location = new System.Drawing.Point(118, 211);
            this.lbl_OptionCTitle.Name = "lbl_OptionCTitle";
            this.lbl_OptionCTitle.Size = new System.Drawing.Size(10, 15);
            this.lbl_OptionCTitle.TabIndex = 24;
            this.lbl_OptionCTitle.Text = "C";
            //
            // rtxt_OptionB
            //
            this.rtxt_OptionB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxt_OptionB.DefaultText = "";
            this.rtxt_OptionB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rtxt_OptionB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rtxt_OptionB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_OptionB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_OptionB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_OptionB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtxt_OptionB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_OptionB.Location = new System.Drawing.Point(574, 148);
            this.rtxt_OptionB.Name = "rtxt_OptionB";
            this.rtxt_OptionB.PasswordChar = '\0';
            this.rtxt_OptionB.PlaceholderText = "";
            this.rtxt_OptionB.ReadOnly = true;
            this.rtxt_OptionB.SelectedText = "";
            this.rtxt_OptionB.Size = new System.Drawing.Size(324, 36);
            this.rtxt_OptionB.TabIndex = 21;
            //
            // lbl_OptionBTitle
            //
            this.lbl_OptionBTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OptionBTitle.Location = new System.Drawing.Point(558, 160);
            this.lbl_OptionBTitle.Name = "lbl_OptionBTitle";
            this.lbl_OptionBTitle.Size = new System.Drawing.Size(10, 15);
            this.lbl_OptionBTitle.TabIndex = 22;
            this.lbl_OptionBTitle.Text = "B";
            //
            // rtxt_OptionA
            //
            this.rtxt_OptionA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxt_OptionA.DefaultText = "";
            this.rtxt_OptionA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rtxt_OptionA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rtxt_OptionA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_OptionA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_OptionA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_OptionA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtxt_OptionA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_OptionA.Location = new System.Drawing.Point(146, 155);
            this.rtxt_OptionA.Name = "rtxt_OptionA";
            this.rtxt_OptionA.PasswordChar = '\0';
            this.rtxt_OptionA.PlaceholderText = "";
            this.rtxt_OptionA.ReadOnly = true;
            this.rtxt_OptionA.SelectedText = "";
            this.rtxt_OptionA.Size = new System.Drawing.Size(324, 36);
            this.rtxt_OptionA.TabIndex = 19;
            //
            // guna2HtmlLabel1
            //
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 167);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(79, 15);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "Các phương án:";
            //
            // rtxt_QuestionContent
            //
            this.rtxt_QuestionContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxt_QuestionContent.DefaultText = "";
            this.rtxt_QuestionContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rtxt_QuestionContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rtxt_QuestionContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_QuestionContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtxt_QuestionContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_QuestionContent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtxt_QuestionContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtxt_QuestionContent.Location = new System.Drawing.Point(118, 43);
            this.rtxt_QuestionContent.Name = "rtxt_QuestionContent";
            this.rtxt_QuestionContent.PasswordChar = '\0';
            this.rtxt_QuestionContent.PlaceholderText = "";
            this.rtxt_QuestionContent.ReadOnly = true;
            this.rtxt_QuestionContent.SelectedText = "";
            this.rtxt_QuestionContent.Size = new System.Drawing.Size(839, 81);
            this.rtxt_QuestionContent.TabIndex = 18;
            //
            // lbl_QuestionContentTitle
            //
            this.lbl_QuestionContentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QuestionContentTitle.Location = new System.Drawing.Point(14, 57);
            this.lbl_QuestionContentTitle.Name = "lbl_QuestionContentTitle";
            this.lbl_QuestionContentTitle.Size = new System.Drawing.Size(87, 15);
            this.lbl_QuestionContentTitle.TabIndex = 18;
            this.lbl_QuestionContentTitle.Text = "Nội dung câu hỏi:";
            //
            // groupBox_ExamInfo
            //
            this.groupBox_ExamInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_ExamInfo.Controls.Add(this.txt_ApprovedAt);
            this.groupBox_ExamInfo.Controls.Add(this.lbl_ApprovedAt);
            this.groupBox_ExamInfo.Controls.Add(this.txt_ApprovedBy);
            this.groupBox_ExamInfo.Controls.Add(this.lbl_ApprovedBy);
            this.groupBox_ExamInfo.Controls.Add(this.txt_CreatedAt);
            this.groupBox_ExamInfo.Controls.Add(this.lbl_CreatedAtTitle);
            this.groupBox_ExamInfo.Controls.Add(this.txt_CreatedBy);
            this.groupBox_ExamInfo.Controls.Add(this.lbl_CreatedByTitle);
            this.groupBox_ExamInfo.Controls.Add(this.txt_Status);
            this.groupBox_ExamInfo.Controls.Add(this.lbl_StatusTitle);
            this.groupBox_ExamInfo.Controls.Add(this.txt_TotalQuestion);
            this.groupBox_ExamInfo.Controls.Add(this.lbl_TotalQuestionTitle);
            this.groupBox_ExamInfo.Controls.Add(this.txt_TimeLimit);
            this.groupBox_ExamInfo.Controls.Add(this.lbl_TimeLimitTitle);
            this.groupBox_ExamInfo.Controls.Add(this.txt_SubjectName);
            this.groupBox_ExamInfo.Controls.Add(this.lbl_SubjectNameTitle);
            this.groupBox_ExamInfo.Controls.Add(this.txt_ExamName);
            this.groupBox_ExamInfo.Controls.Add(this.lbl_ExamNameTitle);
            this.groupBox_ExamInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox_ExamInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox_ExamInfo.Location = new System.Drawing.Point(226, 10);
            this.groupBox_ExamInfo.Name = "groupBox_ExamInfo";
            this.groupBox_ExamInfo.Size = new System.Drawing.Size(949, 189);
            this.groupBox_ExamInfo.TabIndex = 6;
            this.groupBox_ExamInfo.Text = "Thông tin tổng quan về đề thi";
            //
            // txt_ApprovedAt
            //
            this.txt_ApprovedAt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ApprovedAt.DefaultText = "";
            this.txt_ApprovedAt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ApprovedAt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ApprovedAt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ApprovedAt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ApprovedAt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ApprovedAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ApprovedAt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ApprovedAt.Location = new System.Drawing.Point(839, 85);
            this.txt_ApprovedAt.Name = "txt_ApprovedAt";
            this.txt_ApprovedAt.PasswordChar = '\0';
            this.txt_ApprovedAt.PlaceholderText = "";
            this.txt_ApprovedAt.ReadOnly = true;
            this.txt_ApprovedAt.SelectedText = "";
            this.txt_ApprovedAt.Size = new System.Drawing.Size(93, 36);
            this.txt_ApprovedAt.TabIndex = 17;
            //
            // lbl_ApprovedAt
            //
            this.lbl_ApprovedAt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ApprovedAt.Location = new System.Drawing.Point(765, 96);
            this.lbl_ApprovedAt.Name = "lbl_ApprovedAt";
            this.lbl_ApprovedAt.Size = new System.Drawing.Size(57, 15);
            this.lbl_ApprovedAt.TabIndex = 16;
            this.lbl_ApprovedAt.Text = "Ngày duyệt";
            //
            // txt_ApprovedBy
            //
            this.txt_ApprovedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ApprovedBy.DefaultText = "";
            this.txt_ApprovedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ApprovedBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ApprovedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ApprovedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ApprovedBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ApprovedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ApprovedBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ApprovedBy.Location = new System.Drawing.Point(839, 43);
            this.txt_ApprovedBy.Name = "txt_ApprovedBy";
            this.txt_ApprovedBy.PasswordChar = '\0';
            this.txt_ApprovedBy.PlaceholderText = "";
            this.txt_ApprovedBy.ReadOnly = true;
            this.txt_ApprovedBy.SelectedText = "";
            this.txt_ApprovedBy.Size = new System.Drawing.Size(93, 36);
            this.txt_ApprovedBy.TabIndex = 15;
            //
            // lbl_ApprovedBy
            //
            this.lbl_ApprovedBy.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ApprovedBy.Location = new System.Drawing.Point(765, 54);
            this.lbl_ApprovedBy.Name = "lbl_ApprovedBy";
            this.lbl_ApprovedBy.Size = new System.Drawing.Size(60, 15);
            this.lbl_ApprovedBy.TabIndex = 14;
            this.lbl_ApprovedBy.Text = "Người duyệt";
            //
            // txt_CreatedAt
            //
            this.txt_CreatedAt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CreatedAt.DefaultText = "";
            this.txt_CreatedAt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CreatedAt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CreatedAt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CreatedAt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CreatedAt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CreatedAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CreatedAt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CreatedAt.Location = new System.Drawing.Point(616, 85);
            this.txt_CreatedAt.Name = "txt_CreatedAt";
            this.txt_CreatedAt.PasswordChar = '\0';
            this.txt_CreatedAt.PlaceholderText = "";
            this.txt_CreatedAt.ReadOnly = true;
            this.txt_CreatedAt.SelectedText = "";
            this.txt_CreatedAt.Size = new System.Drawing.Size(93, 36);
            this.txt_CreatedAt.TabIndex = 13;
            //
            // lbl_CreatedAtTitle
            //
            this.lbl_CreatedAtTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CreatedAtTitle.Location = new System.Drawing.Point(549, 96);
            this.lbl_CreatedAtTitle.Name = "lbl_CreatedAtTitle";
            this.lbl_CreatedAtTitle.Size = new System.Drawing.Size(46, 15);
            this.lbl_CreatedAtTitle.TabIndex = 12;
            this.lbl_CreatedAtTitle.Text = "Ngày tạo";
            //
            // txt_CreatedBy
            //
            this.txt_CreatedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CreatedBy.DefaultText = "";
            this.txt_CreatedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CreatedBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CreatedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CreatedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CreatedBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CreatedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CreatedBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CreatedBy.Location = new System.Drawing.Point(616, 43);
            this.txt_CreatedBy.Name = "txt_CreatedBy";
            this.txt_CreatedBy.PasswordChar = '\0';
            this.txt_CreatedBy.PlaceholderText = "";
            this.txt_CreatedBy.ReadOnly = true;
            this.txt_CreatedBy.SelectedText = "";
            this.txt_CreatedBy.Size = new System.Drawing.Size(93, 36);
            this.txt_CreatedBy.TabIndex = 11;
            //
            // lbl_CreatedByTitle
            //
            this.lbl_CreatedByTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CreatedByTitle.Location = new System.Drawing.Point(542, 54);
            this.lbl_CreatedByTitle.Name = "lbl_CreatedByTitle";
            this.lbl_CreatedByTitle.Size = new System.Drawing.Size(49, 15);
            this.lbl_CreatedByTitle.TabIndex = 10;
            this.lbl_CreatedByTitle.Text = "Người tạo";
            //
            // txt_Status
            //
            this.txt_Status.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Status.DefaultText = "";
            this.txt_Status.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Status.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Status.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Status.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Status.Location = new System.Drawing.Point(423, 85);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.PasswordChar = '\0';
            this.txt_Status.PlaceholderText = "";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.SelectedText = "";
            this.txt_Status.Size = new System.Drawing.Size(93, 36);
            this.txt_Status.TabIndex = 9;
            //
            // lbl_StatusTitle
            //
            this.lbl_StatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StatusTitle.Location = new System.Drawing.Point(334, 96);
            this.lbl_StatusTitle.Name = "lbl_StatusTitle";
            this.lbl_StatusTitle.Size = new System.Drawing.Size(51, 15);
            this.lbl_StatusTitle.TabIndex = 8;
            this.lbl_StatusTitle.Text = "Trạng thái";
            //
            // txt_TotalQuestion
            //
            this.txt_TotalQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TotalQuestion.DefaultText = "";
            this.txt_TotalQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TotalQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TotalQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TotalQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TotalQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TotalQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TotalQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TotalQuestion.Location = new System.Drawing.Point(423, 43);
            this.txt_TotalQuestion.Name = "txt_TotalQuestion";
            this.txt_TotalQuestion.PasswordChar = '\0';
            this.txt_TotalQuestion.PlaceholderText = "";
            this.txt_TotalQuestion.ReadOnly = true;
            this.txt_TotalQuestion.SelectedText = "";
            this.txt_TotalQuestion.Size = new System.Drawing.Size(93, 36);
            this.txt_TotalQuestion.TabIndex = 7;
            //
            // lbl_TotalQuestionTitle
            //
            this.lbl_TotalQuestionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalQuestionTitle.Location = new System.Drawing.Point(325, 54);
            this.lbl_TotalQuestionTitle.Name = "lbl_TotalQuestionTitle";
            this.lbl_TotalQuestionTitle.Size = new System.Drawing.Size(83, 15);
            this.lbl_TotalQuestionTitle.TabIndex = 6;
            this.lbl_TotalQuestionTitle.Text = "Số lượng câu hỏi";
            //
            // txt_TimeLimit
            //
            this.txt_TimeLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimeLimit.DefaultText = "";
            this.txt_TimeLimit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimeLimit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimeLimit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimeLimit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimeLimit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimeLimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimeLimit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimeLimit.Location = new System.Drawing.Point(115, 139);
            this.txt_TimeLimit.Name = "txt_TimeLimit";
            this.txt_TimeLimit.PasswordChar = '\0';
            this.txt_TimeLimit.PlaceholderText = "";
            this.txt_TimeLimit.ReadOnly = true;
            this.txt_TimeLimit.SelectedText = "";
            this.txt_TimeLimit.Size = new System.Drawing.Size(161, 36);
            this.txt_TimeLimit.TabIndex = 5;
            //
            // lbl_TimeLimitTitle
            //
            this.lbl_TimeLimitTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TimeLimitTitle.Location = new System.Drawing.Point(14, 148);
            this.lbl_TimeLimitTitle.Name = "lbl_TimeLimitTitle";
            this.lbl_TimeLimitTitle.Size = new System.Drawing.Size(83, 15);
            this.lbl_TimeLimitTitle.TabIndex = 4;
            this.lbl_TimeLimitTitle.Text = "Thời gian làm bài";
            //
            // txt_SubjectName
            //
            this.txt_SubjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SubjectName.DefaultText = "";
            this.txt_SubjectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SubjectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SubjectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SubjectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SubjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SubjectName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SubjectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SubjectName.Location = new System.Drawing.Point(76, 85);
            this.txt_SubjectName.Name = "txt_SubjectName";
            this.txt_SubjectName.PasswordChar = '\0';
            this.txt_SubjectName.PlaceholderText = "";
            this.txt_SubjectName.ReadOnly = true;
            this.txt_SubjectName.SelectedText = "";
            this.txt_SubjectName.Size = new System.Drawing.Size(200, 36);
            this.txt_SubjectName.TabIndex = 3;
            //
            // lbl_SubjectNameTitle
            //
            this.lbl_SubjectNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SubjectNameTitle.Location = new System.Drawing.Point(18, 96);
            this.lbl_SubjectNameTitle.Name = "lbl_SubjectNameTitle";
            this.lbl_SubjectNameTitle.Size = new System.Drawing.Size(45, 15);
            this.lbl_SubjectNameTitle.TabIndex = 2;
            this.lbl_SubjectNameTitle.Text = "Môn học";
            //
            // txt_ExamName
            //
            this.txt_ExamName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ExamName.DefaultText = "";
            this.txt_ExamName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ExamName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ExamName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExamName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExamName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExamName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ExamName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExamName.Location = new System.Drawing.Point(76, 43);
            this.txt_ExamName.Name = "txt_ExamName";
            this.txt_ExamName.PasswordChar = '\0';
            this.txt_ExamName.PlaceholderText = "";
            this.txt_ExamName.ReadOnly = true;
            this.txt_ExamName.SelectedText = "";
            this.txt_ExamName.Size = new System.Drawing.Size(200, 36);
            this.txt_ExamName.TabIndex = 1;
            //
            // lbl_ExamNameTitle
            //
            this.lbl_ExamNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ExamNameTitle.Location = new System.Drawing.Point(14, 52);
            this.lbl_ExamNameTitle.Name = "lbl_ExamNameTitle";
            this.lbl_ExamNameTitle.Size = new System.Drawing.Size(52, 15);
            this.lbl_ExamNameTitle.TabIndex = 0;
            this.lbl_ExamNameTitle.Text = "Tên đề thi";
            //
            // frmExamDetail
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 554);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox_ExamInfo);
            this.Name = "frmExamDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đề thi";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_Questions.ResumeLayout(false);
            this.groupBox_Questions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Questions)).EndInit();
            this.groupBox_QuestionDetail.ResumeLayout(false);
            this.groupBox_QuestionDetail.PerformLayout();
            this.groupBox_ExamInfo.ResumeLayout(false);
            this.groupBox_ExamInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Print;
        private Guna.UI2.WinForms.Guna2Button btn_Close;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_Questions;
        private Guna.UI2.WinForms.Guna2DataGridView grv_Questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_QuestionCount;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_QuestionDetail;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_OptionD;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_OptionC;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_OptionB;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_OptionA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Chapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ChapterTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_CorrectAnswer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_CorrectAnswerTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_OptionATitle;
        private Guna.UI2.WinForms.Guna2TextBox rtxt_OptionD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_OptionDTitle;
        private Guna.UI2.WinForms.Guna2TextBox rtxt_OptionC;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_OptionCTitle;
        private Guna.UI2.WinForms.Guna2TextBox rtxt_OptionB;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_OptionBTitle;
        private Guna.UI2.WinForms.Guna2TextBox rtxt_OptionA;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox rtxt_QuestionContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_QuestionContentTitle;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_ExamInfo;
        private Guna.UI2.WinForms.Guna2TextBox txt_ApprovedAt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ApprovedAt;
        private Guna.UI2.WinForms.Guna2TextBox txt_ApprovedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ApprovedBy;
        private Guna.UI2.WinForms.Guna2TextBox txt_CreatedAt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_CreatedAtTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_CreatedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_CreatedByTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_Status;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_StatusTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_TotalQuestion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_TotalQuestionTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimeLimit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_TimeLimitTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_SubjectName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_SubjectNameTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_ExamName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ExamNameTitle;
    }
}