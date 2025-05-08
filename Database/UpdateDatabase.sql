USE QL_THITRACNGHIEM2
GO

-- 1. Thêm trường Chapter vào bảng Question
ALTER TABLE [dbo].[Question]
ADD [Chapter] NVARCHAR(100) NULL;
GO

-- 2. Tạo bảng TeacherSubject để lưu trữ thông tin phân công môn học cho giáo viên
CREATE TABLE [dbo].[TeacherSubject] (
    [ID] INT IDENTITY(1,1) NOT NULL,
    [UserID] INT NOT NULL,
    [SubjectID] VARCHAR(50) NOT NULL,
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL,
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    CONSTRAINT [PK_TeacherSubject] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TeacherSubject_UserAccount] FOREIGN KEY ([UserID]) REFERENCES [dbo].[UserAccount] ([UserID]),
    CONSTRAINT [FK_TeacherSubject_Subject] FOREIGN KEY ([SubjectID]) REFERENCES [dbo].[Subject] ([SubjectID])
);
GO

-- 3. Tạo bảng Exam để lưu trữ thông tin đề thi
CREATE TABLE [dbo].[Exam] (
    [ExamID] INT IDENTITY(1,1) NOT NULL,
    [ExamName] NVARCHAR(200) NOT NULL,
    [SubjectID] VARCHAR(50) NOT NULL,
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL,
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    [TimeLimit] INT NOT NULL,
    [TotalQuestion] INT NOT NULL,
    [Status] NVARCHAR(50) NOT NULL, -- 'Draft', 'Pending', 'Approved', 'Rejected'
    [ApprovedBy] VARCHAR(50) NULL,
    [ApprovedAt] DATETIME NULL,
    CONSTRAINT [PK_Exam] PRIMARY KEY CLUSTERED ([ExamID] ASC),
    CONSTRAINT [FK_Exam_Subject] FOREIGN KEY ([SubjectID]) REFERENCES [dbo].[Subject] ([SubjectID])
);
GO

-- 4. Tạo bảng ExamQuestion để lưu trữ các câu hỏi trong đề thi
CREATE TABLE [dbo].[ExamQuestion] (
    [ID] INT IDENTITY(1,1) NOT NULL,
    [ExamID] INT NOT NULL,
    [QuestionID] INT NOT NULL,
    CONSTRAINT [PK_ExamQuestion] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ExamQuestion_Exam] FOREIGN KEY ([ExamID]) REFERENCES [dbo].[Exam] ([ExamID]),
    CONSTRAINT [FK_ExamQuestion_Question] FOREIGN KEY ([QuestionID]) REFERENCES [dbo].[Question] ([QuestionID])
);
GO

-- 5. Cập nhật các stored procedure liên quan

-- 5.1 Cập nhật stored procedure Question_Insert để thêm trường Chapter
CREATE OR ALTER PROCEDURE [dbo].[Question_Insert]
    @SubjectID VARCHAR(50),
    @QContent NVARCHAR(500),
    @OptionA NVARCHAR(500),
    @OptionB NVARCHAR(500),
    @OptionC NVARCHAR(500),
    @OptionD NVARCHAR(500),
    @Answer NVARCHAR(500),
    @Chapter NVARCHAR(100),
    @CreatedBy VARCHAR(50)
AS
BEGIN
    INSERT INTO [dbo].[Question]
           ([SubjectID]
           ,[QContent]
           ,[OptionA]
           ,[OptionB]
           ,[OptionC]
           ,[OptionD]
           ,[Answer]
           ,[Chapter]
           ,[CreatedBy]
           ,[CreatedAt]
           ,[ModifiedBy]
           ,[ModifiedAt])
     VALUES
           (@SubjectID
           ,@QContent
           ,@OptionA
           ,@OptionB
           ,@OptionC
           ,@OptionD
           ,@Answer
           ,@Chapter
           ,@CreatedBy
           ,GETDATE()
           ,@CreatedBy
           ,GETDATE())
END
GO

-- 5.2 Cập nhật stored procedure Question_Update để thêm trường Chapter
CREATE OR ALTER PROCEDURE [dbo].[Question_Update]
    @QuestionID INT,
    @SubjectID VARCHAR(50),
    @QContent NVARCHAR(500),
    @OptionA NVARCHAR(500),
    @OptionB NVARCHAR(500),
    @OptionC NVARCHAR(500),
    @OptionD NVARCHAR(500),
    @Answer NVARCHAR(500),
    @Chapter NVARCHAR(100),
    @ModifiedBy VARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[Question]
    SET [SubjectID] = @SubjectID
        ,[QContent] = @QContent
        ,[OptionA] = @OptionA
        ,[OptionB] = @OptionB
        ,[OptionC] = @OptionC
        ,[OptionD] = @OptionD
        ,[Answer] = @Answer
        ,[Chapter] = @Chapter
        ,[ModifiedBy] = @ModifiedBy
        ,[ModifiedAt] = GETDATE()
    WHERE [QuestionID] = @QuestionID
END
GO

-- 5.3 Cập nhật stored procedure Question_SelectAll để hiển thị trường Chapter
CREATE OR ALTER PROCEDURE [dbo].[Question_SelectAll]
AS
BEGIN
    SELECT [QuestionID]
          ,[SubjectID]
          ,[QContent]
          ,[OptionA]
          ,[OptionB]
          ,[OptionC]
          ,[OptionD]
          ,[Answer]
          ,[Chapter]
          ,[CreatedBy]
          ,[CreatedAt]
          ,[ModifiedBy]
          ,[ModifiedAt]
      FROM [dbo].[Question]
END
GO

-- 5.4 Cập nhật stored procedure Question_GetById để hiển thị trường Chapter
CREATE OR ALTER PROCEDURE [dbo].[Question_GetById]
    @QuestionID INT
AS
BEGIN
    SELECT [QuestionID]
          ,[SubjectID]
          ,[QContent]
          ,[OptionA]
          ,[OptionB]
          ,[OptionC]
          ,[OptionD]
          ,[Answer]
          ,[Chapter]
          ,[CreatedBy]
          ,[CreatedAt]
          ,[ModifiedBy]
          ,[ModifiedAt]
      FROM [dbo].[Question]
      WHERE QuestionID = @QuestionID
END
GO

-- 5.5 Cập nhật stored procedure Question_Search để tìm kiếm theo Chapter
CREATE OR ALTER PROCEDURE [dbo].[Question_Search]
    @Keyword NVARCHAR(200)
AS
BEGIN
    SELECT [QuestionID]
          ,[SubjectID]
          ,[QContent]
          ,[OptionA]
          ,[OptionB]
          ,[OptionC]
          ,[OptionD]
          ,[Answer]
          ,[Chapter]
          ,[CreatedBy]
          ,[CreatedAt]
          ,[ModifiedBy]
          ,[ModifiedAt]
      FROM [dbo].[Question]
      WHERE QContent LIKE N'%' + @Keyword + '%'
      OR QuestionID LIKE N'%' + @Keyword + '%'
      OR SubjectID LIKE N'%' + @Keyword + '%'
      OR Answer LIKE N'%' + @Keyword + '%'
      OR Chapter LIKE N'%' + @Keyword + '%'
END
GO

-- 6. Tạo các stored procedure mới cho TeacherSubject

-- 6.1 Thêm mới phân công môn học cho giáo viên
CREATE PROCEDURE [dbo].[TeacherSubject_Insert]
    @UserID INT,
    @SubjectID VARCHAR(50),
    @CreatedBy VARCHAR(50)
AS
BEGIN
    INSERT INTO [dbo].[TeacherSubject]
           ([UserID]
           ,[SubjectID]
           ,[CreatedBy]
           ,[CreatedAt]
           ,[ModifiedBy]
           ,[ModifiedAt])
     VALUES
           (@UserID
           ,@SubjectID
           ,@CreatedBy
           ,GETDATE()
           ,@CreatedBy
           ,GETDATE())
END
GO

-- 6.2 Lấy danh sách môn học được phân công cho giáo viên
CREATE PROCEDURE [dbo].[TeacherSubject_GetByTeacher]
    @UserID INT
AS
BEGIN
    SELECT ts.[ID]
          ,ts.[UserID]
          ,ts.[SubjectID]
          ,s.[SubjectName]
          ,ts.[CreatedBy]
          ,ts.[CreatedAt]
          ,ts.[ModifiedBy]
          ,ts.[ModifiedAt]
      FROM [dbo].[TeacherSubject] ts
      INNER JOIN [dbo].[Subject] s ON ts.[SubjectID] = s.[SubjectID]
      WHERE ts.[UserID] = @UserID
END
GO

-- 6.3 Xóa phân công môn học cho giáo viên
CREATE PROCEDURE [dbo].[TeacherSubject_Delete]
    @ID INT
AS
BEGIN
    DELETE FROM [dbo].[TeacherSubject]
    WHERE [ID] = @ID
END
GO

-- 6.4 Kiểm tra giáo viên có được phân công môn học không
CREATE PROCEDURE [dbo].[TeacherSubject_IsAssigned]
    @UserID INT,
    @SubjectID VARCHAR(50),
    @IsAssigned BIT OUTPUT
AS
BEGIN
    SET @IsAssigned = CASE WHEN EXISTS (
        SELECT 1 FROM [dbo].[TeacherSubject] 
        WHERE [UserID] = @UserID AND [SubjectID] = @SubjectID
    ) THEN 1 ELSE 0 END
END
GO
