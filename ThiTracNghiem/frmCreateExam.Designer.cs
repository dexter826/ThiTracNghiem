namespace ThiTracNghiem
{
    partial class frmCreateExam
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_ExamName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbb_Subject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_TimeLimit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbb_Chapter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_SearchKeyword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grv_Questions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddToExam = new Guna.UI2.WinForms.Guna2Button();
            this.btn_RemoveFromExam = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Submit = new Guna.UI2.WinForms.Guna2Button();
            this.grv_SelectedQuestions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSelectedSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedQuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedQContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedChapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedOptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedOptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedOptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedOptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_TotalQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_SelectedQuestions)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            //
            // txt_ExamName
            //
            this.txt_ExamName.BorderRadius = 5;
            this.txt_ExamName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ExamName.DefaultText = "";
            this.txt_ExamName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ExamName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ExamName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExamName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ExamName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExamName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExamName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ExamName.Location = new System.Drawing.Point(108, 52);
            this.txt_ExamName.Name = "txt_ExamName";
            this.txt_ExamName.PasswordChar = '\0';
            this.txt_ExamName.PlaceholderText = "";
            this.txt_ExamName.SelectedText = "";
            this.txt_ExamName.Size = new System.Drawing.Size(200, 36);
            this.txt_ExamName.TabIndex = 0;
            //
            // guna2HtmlLabel1
            //
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(28, 63);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(52, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Tên đề thi";
            //
            // cbb_Subject
            //
            this.cbb_Subject.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Subject.BorderRadius = 5;
            this.cbb_Subject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Subject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Subject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Subject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Subject.ItemHeight = 30;
            this.cbb_Subject.Location = new System.Drawing.Point(108, 109);
            this.cbb_Subject.Name = "cbb_Subject";
            this.cbb_Subject.Size = new System.Drawing.Size(200, 36);
            this.cbb_Subject.TabIndex = 2;
            this.cbb_Subject.SelectedIndexChanged += new System.EventHandler(this.cbb_Subject_SelectedIndexChanged);
            //
            // guna2HtmlLabel2
            //
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(28, 119);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Môn học";
            //
            // guna2HtmlLabel3
            //
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(337, 63);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(61, 15);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Thời gian thi";
            //
            // txt_TimeLimit
            //
            this.txt_TimeLimit.AutoRoundedCorners = true;
            this.txt_TimeLimit.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimeLimit.BorderRadius = 5;
            this.txt_TimeLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimeLimit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeLimit.Location = new System.Drawing.Point(449, 52);
            this.txt_TimeLimit.Name = "txt_TimeLimit";
            this.txt_TimeLimit.Size = new System.Drawing.Size(100, 36);
            this.txt_TimeLimit.TabIndex = 6;
            //
            // guna2HtmlLabel4
            //
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(337, 120);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(83, 15);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Số lượng câu hỏi";
            //
            // cbb_Chapter
            //
            this.cbb_Chapter.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Chapter.BorderRadius = 5;
            this.cbb_Chapter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Chapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Chapter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Chapter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Chapter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Chapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Chapter.ItemHeight = 30;
            this.cbb_Chapter.Location = new System.Drawing.Point(691, 52);
            this.cbb_Chapter.Name = "cbb_Chapter";
            this.cbb_Chapter.Size = new System.Drawing.Size(200, 36);
            this.cbb_Chapter.TabIndex = 9;
            //
            // guna2HtmlLabel5
            //
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(578, 63);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(40, 15);
            this.guna2HtmlLabel5.TabIndex = 10;
            this.guna2HtmlLabel5.Text = "Chương";
            //
            // btn_Search
            //
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderRadius = 8;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(925, 110);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.BorderRadius = 20;
            this.btn_Search.ShadowDecoration.Depth = 10;
            this.btn_Search.ShadowDecoration.Enabled = true;
            this.btn_Search.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Search.Size = new System.Drawing.Size(121, 35);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            //
            // txt_SearchKeyword
            //
            this.txt_SearchKeyword.BorderRadius = 5;
            this.txt_SearchKeyword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchKeyword.DefaultText = "";
            this.txt_SearchKeyword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchKeyword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchKeyword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchKeyword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchKeyword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchKeyword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchKeyword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchKeyword.Location = new System.Drawing.Point(691, 109);
            this.txt_SearchKeyword.Name = "txt_SearchKeyword";
            this.txt_SearchKeyword.PasswordChar = '\0';
            this.txt_SearchKeyword.PlaceholderText = "Nhập từ khóa tìm kiếm...";
            this.txt_SearchKeyword.SelectedText = "";
            this.txt_SearchKeyword.Size = new System.Drawing.Size(200, 36);
            this.txt_SearchKeyword.TabIndex = 12;
            //
            // guna2HtmlLabel6
            //
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(578, 120);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(84, 15);
            this.guna2HtmlLabel6.TabIndex = 13;
            this.guna2HtmlLabel6.Text = "Từ khóa tìm kiếm";
            //
            // grv_Questions
            //
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            this.grv_Questions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_Questions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Questions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_Questions.ColumnHeadersHeight = 40;
            this.grv_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Questions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.QuestionID,
            this.SubjectID,
            this.QContent,
            this.Chapter,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.Answer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Questions.DefaultCellStyle = dataGridViewCellStyle3;
            this.grv_Questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_Questions.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_Questions.Location = new System.Drawing.Point(0, 0);
            this.grv_Questions.Name = "grv_Questions";
            this.grv_Questions.ReadOnly = true;
            this.grv_Questions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_Questions.RowHeadersVisible = false;
            this.grv_Questions.RowTemplate.Height = 40;
            this.grv_Questions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_Questions.MultiSelect = true;
            this.grv_Questions.AutoGenerateColumns = false;
            this.grv_Questions.Size = new System.Drawing.Size(658, 396);
            this.grv_Questions.TabIndex = 12;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Questions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_Questions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grv_Questions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_Questions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Questions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Questions.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_Questions.ThemeStyle.ReadOnly = true;
            this.grv_Questions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Questions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Questions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_Questions.ThemeStyle.RowsStyle.Height = 40;
            this.grv_Questions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.grv_Questions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            //
            // STT
            //
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            //
            // QuestionID
            //
            this.QuestionID.DataPropertyName = "QuestionID";
            this.QuestionID.HeaderText = "Mã câu hỏi";
            this.QuestionID.Name = "QuestionID";
            this.QuestionID.ReadOnly = true;
            this.QuestionID.Visible = false;
            //
            // SubjectID
            //
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "Mã môn học";
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            this.SubjectID.Visible = false;
            //
            // QContent
            //
            this.QContent.DataPropertyName = "QContent";
            this.QContent.HeaderText = "Nội dung câu hỏi";
            this.QContent.Name = "QContent";
            this.QContent.ReadOnly = true;
            //
            // Chapter
            //
            this.Chapter.DataPropertyName = "Chapter";
            this.Chapter.HeaderText = "Chương";
            this.Chapter.Name = "Chapter";
            this.Chapter.ReadOnly = true;
            //
            // OptionA
            //
            this.OptionA.DataPropertyName = "OptionA";
            this.OptionA.HeaderText = "Đáp án A";
            this.OptionA.Name = "OptionA";
            this.OptionA.ReadOnly = true;
            //
            // OptionB
            //
            this.OptionB.DataPropertyName = "OptionB";
            this.OptionB.HeaderText = "Đáp án B";
            this.OptionB.Name = "OptionB";
            this.OptionB.ReadOnly = true;
            //
            // OptionC
            //
            this.OptionC.DataPropertyName = "OptionC";
            this.OptionC.HeaderText = "Đáp án C";
            this.OptionC.Name = "OptionC";
            this.OptionC.ReadOnly = true;
            //
            // OptionD
            //
            this.OptionD.DataPropertyName = "OptionD";
            this.OptionD.HeaderText = "Đáp án D";
            this.OptionD.Name = "OptionD";
            this.OptionD.ReadOnly = true;
            //
            // Answer
            //
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Đáp án đúng";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            //
            // btn_AddToExam
            //
            this.btn_AddToExam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_AddToExam.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddToExam.BorderRadius = 8;
            this.btn_AddToExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddToExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddToExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddToExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddToExam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToExam.ForeColor = System.Drawing.Color.White;
            this.btn_AddToExam.Location = new System.Drawing.Point(540, 590);
            this.btn_AddToExam.Name = "btn_AddToExam";
            this.btn_AddToExam.ShadowDecoration.BorderRadius = 20;
            this.btn_AddToExam.ShadowDecoration.Depth = 10;
            this.btn_AddToExam.ShadowDecoration.Enabled = true;
            this.btn_AddToExam.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_AddToExam.Size = new System.Drawing.Size(121, 35);
            this.btn_AddToExam.TabIndex = 14;
            this.btn_AddToExam.Text = "Thêm câu hỏi";
            this.btn_AddToExam.Click += new System.EventHandler(this.btn_AddToExam_Click);
            //
            // btn_RemoveFromExam
            //
            this.btn_RemoveFromExam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_RemoveFromExam.BackColor = System.Drawing.Color.Transparent;
            this.btn_RemoveFromExam.BorderRadius = 8;
            this.btn_RemoveFromExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_RemoveFromExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_RemoveFromExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_RemoveFromExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_RemoveFromExam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveFromExam.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveFromExam.Location = new System.Drawing.Point(667, 590);
            this.btn_RemoveFromExam.Name = "btn_RemoveFromExam";
            this.btn_RemoveFromExam.ShadowDecoration.BorderRadius = 20;
            this.btn_RemoveFromExam.ShadowDecoration.Depth = 10;
            this.btn_RemoveFromExam.ShadowDecoration.Enabled = true;
            this.btn_RemoveFromExam.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_RemoveFromExam.Size = new System.Drawing.Size(121, 35);
            this.btn_RemoveFromExam.TabIndex = 15;
            this.btn_RemoveFromExam.Text = "Xóa câu hỏi";
            this.btn_RemoveFromExam.Click += new System.EventHandler(this.btn_RemoveFromExam_Click);
            //
            // btn_Save
            //
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BorderRadius = 8;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(1058, 590);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ShadowDecoration.BorderRadius = 20;
            this.btn_Save.ShadowDecoration.Depth = 10;
            this.btn_Save.ShadowDecoration.Enabled = true;
            this.btn_Save.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Save.Size = new System.Drawing.Size(121, 35);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            //
            // btn_Submit
            //
            this.btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Submit.BorderRadius = 8;
            this.btn_Submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(1185, 590);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.ShadowDecoration.BorderRadius = 20;
            this.btn_Submit.ShadowDecoration.Depth = 10;
            this.btn_Submit.ShadowDecoration.Enabled = true;
            this.btn_Submit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Submit.Size = new System.Drawing.Size(121, 35);
            this.btn_Submit.TabIndex = 17;
            this.btn_Submit.Text = "Gửi";
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            //
            // grv_SelectedQuestions
            //
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            this.grv_SelectedQuestions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grv_SelectedQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_SelectedQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grv_SelectedQuestions.ColumnHeadersHeight = 40;
            this.grv_SelectedQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_SelectedQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelectedSTT,
            this.colSelectedQuestionID,
            this.colSelectedSubjectID,
            this.colSelectedQContent,
            this.colSelectedChapter,
            this.colSelectedOptionA,
            this.colSelectedOptionB,
            this.colSelectedOptionC,
            this.colSelectedOptionD,
            this.colSelectedAnswer});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_SelectedQuestions.DefaultCellStyle = dataGridViewCellStyle6;
            this.grv_SelectedQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_SelectedQuestions.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_SelectedQuestions.Location = new System.Drawing.Point(0, 0);
            this.grv_SelectedQuestions.Name = "grv_SelectedQuestions";
            this.grv_SelectedQuestions.ReadOnly = true;
            this.grv_SelectedQuestions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_SelectedQuestions.RowHeadersVisible = false;
            this.grv_SelectedQuestions.RowTemplate.Height = 40;
            this.grv_SelectedQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_SelectedQuestions.MultiSelect = true;
            this.grv_SelectedQuestions.AutoGenerateColumns = false;
            this.grv_SelectedQuestions.Size = new System.Drawing.Size(663, 396);
            this.grv_SelectedQuestions.TabIndex = 18;
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_SelectedQuestions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_SelectedQuestions.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_SelectedQuestions.ThemeStyle.ReadOnly = true;
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.Height = 40;
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            //
            // colSelectedSTT
            //
            this.colSelectedSTT.DataPropertyName = "STT";
            this.colSelectedSTT.HeaderText = "STT";
            this.colSelectedSTT.Name = "colSelectedSTT";
            this.colSelectedSTT.ReadOnly = true;
            //
            // colSelectedQuestionID
            //
            this.colSelectedQuestionID.DataPropertyName = "QuestionID";
            this.colSelectedQuestionID.HeaderText = "Mã câu hỏi";
            this.colSelectedQuestionID.Name = "colSelectedQuestionID";
            this.colSelectedQuestionID.ReadOnly = true;
            this.colSelectedQuestionID.Visible = false;
            //
            // colSelectedSubjectID
            //
            this.colSelectedSubjectID.HeaderText = "Mã môn học";
            this.colSelectedSubjectID.Name = "colSelectedSubjectID";
            this.colSelectedSubjectID.ReadOnly = true;
            this.colSelectedSubjectID.Visible = false;
            //
            // colSelectedQContent
            //
            this.colSelectedQContent.DataPropertyName = "QContent";
            this.colSelectedQContent.HeaderText = "Nội dung câu hỏi";
            this.colSelectedQContent.Name = "colSelectedQContent";
            this.colSelectedQContent.ReadOnly = true;
            //
            // colSelectedChapter
            //
            this.colSelectedChapter.DataPropertyName = "Chapter";
            this.colSelectedChapter.HeaderText = "Chương";
            this.colSelectedChapter.Name = "colSelectedChapter";
            this.colSelectedChapter.ReadOnly = true;
            //
            // colSelectedOptionA
            //
            this.colSelectedOptionA.DataPropertyName = "OptionA";
            this.colSelectedOptionA.HeaderText = "Đáp án A";
            this.colSelectedOptionA.Name = "colSelectedOptionA";
            this.colSelectedOptionA.ReadOnly = true;
            //
            // colSelectedOptionB
            //
            this.colSelectedOptionB.DataPropertyName = "OptionB";
            this.colSelectedOptionB.HeaderText = "Đáp án B";
            this.colSelectedOptionB.Name = "colSelectedOptionB";
            this.colSelectedOptionB.ReadOnly = true;
            //
            // colSelectedOptionC
            //
            this.colSelectedOptionC.DataPropertyName = "OptionC";
            this.colSelectedOptionC.HeaderText = "Đáp án C";
            this.colSelectedOptionC.Name = "colSelectedOptionC";
            this.colSelectedOptionC.ReadOnly = true;
            //
            // colSelectedOptionD
            //
            this.colSelectedOptionD.DataPropertyName = "OptionD";
            this.colSelectedOptionD.HeaderText = "Đáp án D";
            this.colSelectedOptionD.Name = "colSelectedOptionD";
            this.colSelectedOptionD.ReadOnly = true;
            //
            // colSelectedAnswer
            //
            this.colSelectedAnswer.DataPropertyName = "Answer";
            this.colSelectedAnswer.HeaderText = "Đáp án đúng";
            this.colSelectedAnswer.Name = "colSelectedAnswer";
            this.colSelectedAnswer.ReadOnly = true;
            //
            // guna2GroupBox1
            //
            this.guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2GroupBox1.BorderRadius = 8;
            this.guna2GroupBox1.Controls.Add(this.txt_TotalQuestion);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.cbb_Subject);
            this.guna2GroupBox1.Controls.Add(this.txt_ExamName);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.txt_TimeLimit);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.btn_Search);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox1.Controls.Add(this.cbb_Chapter);
            this.guna2GroupBox1.Controls.Add(this.txt_SearchKeyword);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(127, 13);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1074, 169);
            this.guna2GroupBox1.TabIndex = 19;
            this.guna2GroupBox1.Text = "Thông tin đề thi";
            //
            // txt_TotalQuestion
            //
            this.txt_TotalQuestion.BorderRadius = 5;
            this.txt_TotalQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TotalQuestion.DefaultText = "";
            this.txt_TotalQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TotalQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TotalQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TotalQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TotalQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TotalQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TotalQuestion.Location = new System.Drawing.Point(449, 109);
            this.txt_TotalQuestion.Name = "txt_TotalQuestion";
            this.txt_TotalQuestion.PasswordChar = '\0';
            this.txt_TotalQuestion.PlaceholderText = "";
            this.txt_TotalQuestion.ReadOnly = true;
            this.txt_TotalQuestion.SelectedText = "";
            this.txt_TotalQuestion.Size = new System.Drawing.Size(100, 36);
            this.txt_TotalQuestion.TabIndex = 14;
            //
            // splitContainer1
            //
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 188);
            this.splitContainer1.Name = "splitContainer1";
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.grv_Questions);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.grv_SelectedQuestions);
            this.splitContainer1.Size = new System.Drawing.Size(1325, 396);
            this.splitContainer1.SplitterDistance = 658;
            this.splitContainer1.TabIndex = 20;
            //
            // frmCreateExam
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btn_AddToExam);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_RemoveFromExam);
            this.Controls.Add(this.btn_Save);
            this.Name = "frmCreateExam";
            this.Size = new System.Drawing.Size(1328, 647);
            this.Load += new System.EventHandler(this.frmCreateExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Questions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_SelectedQuestions)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_ExamName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Subject;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_TimeLimit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Chapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2DataGridView grv_Questions;
        private Guna.UI2.WinForms.Guna2Button btn_AddToExam;
        private Guna.UI2.WinForms.Guna2Button btn_RemoveFromExam;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI2.WinForms.Guna2Button btn_Submit;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchKeyword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionB;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private Guna.UI2.WinForms.Guna2DataGridView grv_SelectedQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedQuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedSubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedQContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedChapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedOptionA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedOptionB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedOptionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedOptionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedAnswer;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2TextBox txt_TotalQuestion;
    }
}
