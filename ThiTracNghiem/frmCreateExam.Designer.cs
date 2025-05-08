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
            this.txt_TotalQuestion = new Guna.UI2.WinForms.Guna2NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_SelectedQuestions)).BeginInit();
            this.SuspendLayout();
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
            this.txt_ExamName.Location = new System.Drawing.Point(129, 27);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(71, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(52, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Tên đề thi";
            //
            // cbb_Subject
            //
            this.cbb_Subject.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Subject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Subject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Subject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Subject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Subject.ItemHeight = 30;
            this.cbb_Subject.Location = new System.Drawing.Point(129, 81);
            this.cbb_Subject.Name = "cbb_Subject";
            this.cbb_Subject.Size = new System.Drawing.Size(200, 36);
            this.cbb_Subject.TabIndex = 2;
            this.cbb_Subject.SelectedIndexChanged += new System.EventHandler(this.cbb_Subject_SelectedIndexChanged);
            //
            // guna2HtmlLabel2
            //
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(71, 92);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Môn học";
            //
            // guna2HtmlLabel3
            //
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(373, 36);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(61, 15);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Thời gian thi";
            //
            // txt_TimeLimit
            //
            this.txt_TimeLimit.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimeLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimeLimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimeLimit.Location = new System.Drawing.Point(449, 27);
            this.txt_TimeLimit.Name = "txt_TimeLimit";
            this.txt_TimeLimit.Size = new System.Drawing.Size(100, 36);
            this.txt_TimeLimit.TabIndex = 6;
            //
            // txt_TotalQuestion
            //
            this.txt_TotalQuestion.BackColor = System.Drawing.Color.Transparent;
            this.txt_TotalQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TotalQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TotalQuestion.Location = new System.Drawing.Point(449, 81);
            this.txt_TotalQuestion.Name = "txt_TotalQuestion";
            this.txt_TotalQuestion.Size = new System.Drawing.Size(100, 36);
            this.txt_TotalQuestion.TabIndex = 7;
            //
            // guna2HtmlLabel4
            //
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(360, 92);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(83, 15);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Số lượng câu hỏi";
            //
            // cbb_Chapter
            //
            this.cbb_Chapter.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Chapter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Chapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Chapter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Chapter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Chapter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Chapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Chapter.ItemHeight = 30;
            this.cbb_Chapter.Location = new System.Drawing.Point(628, 27);
            this.cbb_Chapter.Name = "cbb_Chapter";
            this.cbb_Chapter.Size = new System.Drawing.Size(200, 36);
            this.cbb_Chapter.TabIndex = 9;
            //
            // guna2HtmlLabel5
            //
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(582, 36);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(40, 15);
            this.guna2HtmlLabel5.TabIndex = 10;
            this.guna2HtmlLabel5.Text = "Chương";
            //
            // btn_Search
            //
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(628, 92);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(121, 28);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);

            // txt_SearchKeyword
            this.txt_SearchKeyword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchKeyword.DefaultText = "";
            this.txt_SearchKeyword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchKeyword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchKeyword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchKeyword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchKeyword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchKeyword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SearchKeyword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchKeyword.Location = new System.Drawing.Point(755, 92);
            this.txt_SearchKeyword.Name = "txt_SearchKeyword";
            this.txt_SearchKeyword.PasswordChar = '\0';
            this.txt_SearchKeyword.PlaceholderText = "Nhập từ khóa tìm kiếm...";
            this.txt_SearchKeyword.SelectedText = "";
            this.txt_SearchKeyword.Size = new System.Drawing.Size(200, 28);
            this.txt_SearchKeyword.TabIndex = 12;

            // guna2HtmlLabel6
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(755, 71);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(83, 15);
            this.guna2HtmlLabel6.TabIndex = 13;
            this.guna2HtmlLabel6.Text = "Từ khóa tìm kiếm";
            //
            // grv_Questions
            //
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_Questions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Questions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_Questions.ColumnHeadersHeight = 54;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Questions.DefaultCellStyle = dataGridViewCellStyle3;
            this.grv_Questions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Questions.Location = new System.Drawing.Point(49, 175);
            this.grv_Questions.Name = "grv_Questions";
            this.grv_Questions.RowHeadersVisible = false;
            this.grv_Questions.Size = new System.Drawing.Size(477, 269);
            this.grv_Questions.TabIndex = 12;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_Questions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Questions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Questions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_Questions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_Questions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Questions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Questions.ThemeStyle.HeaderStyle.Height = 54;
            this.grv_Questions.ThemeStyle.ReadOnly = false;
            this.grv_Questions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Questions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Questions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Questions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_Questions.ThemeStyle.RowsStyle.Height = 22;
            this.grv_Questions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Questions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.QuestionID.Visible = false;
            //
            // SubjectID
            //
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "Mã môn học";
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.Visible = false;
            //
            // QContent
            //
            this.QContent.DataPropertyName = "QContent";
            this.QContent.HeaderText = "Nội dung câu hỏi";
            this.QContent.Name = "QContent";
            //
            // Chapter
            //
            this.Chapter.DataPropertyName = "Chapter";
            this.Chapter.HeaderText = "Chương";
            this.Chapter.Name = "Chapter";
            //
            // OptionA
            //
            this.OptionA.DataPropertyName = "OptionA";
            this.OptionA.HeaderText = "Đáp án A";
            this.OptionA.Name = "OptionA";
            //
            // OptionB
            //
            this.OptionB.DataPropertyName = "OptionB";
            this.OptionB.HeaderText = "Đáp án B";
            this.OptionB.Name = "OptionB";
            //
            // OptionC
            //
            this.OptionC.DataPropertyName = "OptionC";
            this.OptionC.HeaderText = "Đáp án C";
            this.OptionC.Name = "OptionC";
            //
            // OptionD
            //
            this.OptionD.DataPropertyName = "OptionD";
            this.OptionD.HeaderText = "Đáp án D";
            this.OptionD.Name = "OptionD";
            //
            // Answer
            //
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Đáp án đúng";
            this.Answer.Name = "Answer";
            //
            // btn_AddToExam
            //
            this.btn_AddToExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddToExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddToExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddToExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddToExam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddToExam.ForeColor = System.Drawing.Color.White;
            this.btn_AddToExam.Location = new System.Drawing.Point(208, 141);
            this.btn_AddToExam.Name = "btn_AddToExam";
            this.btn_AddToExam.Size = new System.Drawing.Size(121, 28);
            this.btn_AddToExam.TabIndex = 14;
            this.btn_AddToExam.Text = "Thêm câu hỏi";
            this.btn_AddToExam.Click += new System.EventHandler(this.btn_AddToExam_Click);
            //
            // btn_RemoveFromExam
            //
            this.btn_RemoveFromExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_RemoveFromExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_RemoveFromExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_RemoveFromExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_RemoveFromExam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_RemoveFromExam.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveFromExam.Location = new System.Drawing.Point(514, 141);
            this.btn_RemoveFromExam.Name = "btn_RemoveFromExam";
            this.btn_RemoveFromExam.Size = new System.Drawing.Size(121, 28);
            this.btn_RemoveFromExam.TabIndex = 15;
            this.btn_RemoveFromExam.Text = "Xóa câu hỏi";
            this.btn_RemoveFromExam.Click += new System.EventHandler(this.btn_RemoveFromExam_Click);
            //
            // btn_Save
            //
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(172, 483);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(121, 28);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            //
            // btn_Submit
            //
            this.btn_Submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(542, 483);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(121, 28);
            this.btn_Submit.TabIndex = 17;
            this.btn_Submit.Text = "Gửi";
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            //
            // grv_SelectedQuestions
            //
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.grv_SelectedQuestions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_SelectedQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grv_SelectedQuestions.ColumnHeadersHeight = 54;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_SelectedQuestions.DefaultCellStyle = dataGridViewCellStyle6;
            this.grv_SelectedQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_SelectedQuestions.Location = new System.Drawing.Point(542, 175);
            this.grv_SelectedQuestions.Name = "grv_SelectedQuestions";
            this.grv_SelectedQuestions.RowHeadersVisible = false;
            this.grv_SelectedQuestions.Size = new System.Drawing.Size(477, 269);
            this.grv_SelectedQuestions.TabIndex = 18;
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_SelectedQuestions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_SelectedQuestions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_SelectedQuestions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_SelectedQuestions.ThemeStyle.HeaderStyle.Height = 54;
            this.grv_SelectedQuestions.ThemeStyle.ReadOnly = false;
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.Height = 22;
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_SelectedQuestions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //
            // colSelectedSTT
            //
            this.colSelectedSTT.DataPropertyName = "STT";
            this.colSelectedSTT.HeaderText = "STT";
            this.colSelectedSTT.Name = "colSelectedSTT";
            //
            // colSelectedQuestionID
            //
            this.colSelectedQuestionID.DataPropertyName = "QuestionID";
            this.colSelectedQuestionID.HeaderText = "Mã câu hỏi";
            this.colSelectedQuestionID.Name = "colSelectedQuestionID";
            this.colSelectedQuestionID.Visible = false;
            //
            // colSelectedSubjectID
            //
            this.colSelectedSubjectID.HeaderText = "Mã môn học";
            this.colSelectedSubjectID.Name = "colSelectedSubjectID";
            this.colSelectedSubjectID.Visible = false;
            //
            // colSelectedQContent
            //
            this.colSelectedQContent.DataPropertyName = "QContent";
            this.colSelectedQContent.HeaderText = "Nội dung câu hỏi";
            this.colSelectedQContent.Name = "colSelectedQContent";
            //
            // colSelectedChapter
            //
            this.colSelectedChapter.DataPropertyName = "Chapter";
            this.colSelectedChapter.HeaderText = "Chương";
            this.colSelectedChapter.Name = "colSelectedChapter";
            //
            // colSelectedOptionA
            //
            this.colSelectedOptionA.DataPropertyName = "OptionA";
            this.colSelectedOptionA.HeaderText = "Đáp án A";
            this.colSelectedOptionA.Name = "colSelectedOptionA";
            //
            // colSelectedOptionB
            //
            this.colSelectedOptionB.DataPropertyName = "OptionB";
            this.colSelectedOptionB.HeaderText = "Đáp án B";
            this.colSelectedOptionB.Name = "colSelectedOptionB";
            //
            // colSelectedOptionC
            //
            this.colSelectedOptionC.DataPropertyName = "OptionC";
            this.colSelectedOptionC.HeaderText = "Đáp án C";
            this.colSelectedOptionC.Name = "colSelectedOptionC";
            //
            // colSelectedOptionD
            //
            this.colSelectedOptionD.DataPropertyName = "OptionD";
            this.colSelectedOptionD.HeaderText = "Đáp án D";
            this.colSelectedOptionD.Name = "colSelectedOptionD";
            //
            // colSelectedAnswer
            //
            this.colSelectedAnswer.DataPropertyName = "Answer";
            this.colSelectedAnswer.HeaderText = "Đáp án đúng";
            this.colSelectedAnswer.Name = "colSelectedAnswer";
            //
            // frmCreateExam
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grv_SelectedQuestions);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_RemoveFromExam);
            this.Controls.Add(this.btn_AddToExam);
            this.Controls.Add(this.grv_Questions);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchKeyword);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cbb_Chapter);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txt_TotalQuestion);
            this.Controls.Add(this.txt_TimeLimit);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cbb_Subject);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_ExamName);
            this.Name = "frmCreateExam";
            this.Size = new System.Drawing.Size(1090, 578);
            this.Load += new System.EventHandler(this.frmCreateExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Questions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_SelectedQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_ExamName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Subject;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_TimeLimit;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_TotalQuestion;
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
    }
}
