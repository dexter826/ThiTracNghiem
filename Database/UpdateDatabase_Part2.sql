USE QL_THITRACNGHIEM2
GO

-- 7. Tạo các stored procedure cho Exam

-- 7.1 Thêm mới đề thi
CREATE PROCEDURE [dbo].[Exam_Insert]
    @ExamName NVARCHAR(200),
    @SubjectID VARCHAR(50),
    @TimeLimit INT,
    @TotalQuestion INT,
    @CreatedBy VARCHAR(50),
    @ExamID INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Exam]
           ([ExamName]
           ,[SubjectID]
           ,[TimeLimit]
           ,[TotalQuestion]
           ,[Status]
           ,[CreatedBy]
           ,[CreatedAt]
           ,[ModifiedBy]
           ,[ModifiedAt])
     VALUES
           (@ExamName
           ,@SubjectID
           ,@TimeLimit
           ,@TotalQuestion
           ,'Draft'
           ,@CreatedBy
           ,GETDATE()
           ,@CreatedBy
           ,GETDATE())

    SET @ExamID = SCOPE_IDENTITY()
END
GO

-- 7.2 Cập nhật đề thi
CREATE PROCEDURE [dbo].[Exam_Update]
    @ExamID INT,
    @ExamName NVARCHAR(200),
    @SubjectID VARCHAR(50),
    @TimeLimit INT,
    @TotalQuestion INT,
    @ModifiedBy VARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[Exam]
    SET [ExamName] = @ExamName
        ,[SubjectID] = @SubjectID
        ,[TimeLimit] = @TimeLimit
        ,[TotalQuestion] = @TotalQuestion
        ,[ModifiedBy] = @ModifiedBy
        ,[ModifiedAt] = GETDATE()
    WHERE [ExamID] = @ExamID
END
GO

-- 7.3 Xóa đề thi
CREATE PROCEDURE [dbo].[Exam_Delete]
    @ExamID INT
AS
BEGIN
    -- Xóa các câu hỏi trong đề thi
    DELETE FROM [dbo].[ExamQuestion]
    WHERE [ExamID] = @ExamID

    -- Xóa đề thi
    DELETE FROM [dbo].[Exam]
    WHERE [ExamID] = @ExamID
END
GO

-- 7.4 Lấy danh sách đề thi
CREATE PROCEDURE [dbo].[Exam_SelectAll]
AS
BEGIN
    SELECT e.[ExamID]
          ,e.[ExamName]
          ,e.[SubjectID]
          ,s.[SubjectName]
          ,e.[TimeLimit]
          ,e.[TotalQuestion]
          ,e.[Status]
          ,e.[CreatedBy]
          ,e.[CreatedAt]
          ,e.[ModifiedBy]
          ,e.[ModifiedAt]
          ,e.[ApprovedBy]
          ,e.[ApprovedAt]
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
END
GO

-- 7.5 Lấy danh sách đề thi theo giáo viên
CREATE PROCEDURE [dbo].[Exam_GetByTeacher]
    @UserID INT
AS
BEGIN
    SELECT e.[ExamID]
          ,e.[ExamName]
          ,e.[SubjectID]
          ,s.[SubjectName]
          ,e.[TimeLimit]
          ,e.[TotalQuestion]
          ,e.[Status]
          ,e.[CreatedBy]
          ,e.[CreatedAt]
          ,e.[ModifiedBy]
          ,e.[ModifiedAt]
          ,e.[ApprovedBy]
          ,e.[ApprovedAt]
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      INNER JOIN [dbo].[UserAccount] u ON e.[CreatedBy] = u.[Username]
      WHERE u.[UserID] = @UserID
END
GO

-- 7.6 Lấy danh sách đề thi theo trạng thái
CREATE PROCEDURE [dbo].[Exam_GetByStatus]
    @Status NVARCHAR(50)
AS
BEGIN
    SELECT e.[ExamID]
          ,e.[ExamName]
          ,e.[SubjectID]
          ,s.[SubjectName]
          ,e.[TimeLimit]
          ,e.[TotalQuestion]
          ,e.[Status]
          ,e.[CreatedBy]
          ,e.[CreatedAt]
          ,e.[ModifiedBy]
          ,e.[ModifiedAt]
          ,e.[ApprovedBy]
          ,e.[ApprovedAt]
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE e.[Status] = @Status
END
GO

-- 7.7 Cập nhật trạng thái đề thi
CREATE PROCEDURE [dbo].[Exam_UpdateStatus]
    @ExamID INT,
    @Status NVARCHAR(50),
    @ApprovedBy VARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[Exam]
    SET [Status] = @Status
        ,[ApprovedBy] = @ApprovedBy
        ,[ApprovedAt] = GETDATE()
    WHERE [ExamID] = @ExamID
END
GO

-- 7.8 Lấy thông tin đề thi theo ID
CREATE PROCEDURE [dbo].[Exam_GetById]
    @ExamID INT
AS
BEGIN
    SELECT e.[ExamID]
          ,e.[ExamName]
          ,e.[SubjectID]
          ,s.[SubjectName]
          ,e.[TimeLimit]
          ,e.[TotalQuestion]
          ,e.[Status]
          ,e.[CreatedBy]
          ,e.[CreatedAt]
          ,e.[ModifiedBy]
          ,e.[ModifiedAt]
          ,e.[ApprovedBy]
          ,e.[ApprovedAt]
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE e.[ExamID] = @ExamID
END
GO

-- 8. Tạo các stored procedure cho ExamQuestion

-- 8.1 Thêm câu hỏi vào đề thi
CREATE PROCEDURE [dbo].[ExamQuestion_Insert]
    @ExamID INT,
    @QuestionID INT
AS
BEGIN
    INSERT INTO [dbo].[ExamQuestion]
           ([ExamID]
           ,[QuestionID])
     VALUES
           (@ExamID
           ,@QuestionID)
END
GO

-- 8.2 Xóa câu hỏi khỏi đề thi
CREATE PROCEDURE [dbo].[ExamQuestion_Delete]
    @ExamID INT,
    @QuestionID INT
AS
BEGIN
    DELETE FROM [dbo].[ExamQuestion]
    WHERE [ExamID] = @ExamID AND [QuestionID] = @QuestionID
END
GO

-- 8.3 Lấy danh sách câu hỏi trong đề thi
CREATE PROCEDURE [dbo].[ExamQuestion_GetByExam]
    @ExamID INT
AS
BEGIN
    SELECT q.[QuestionID]
          ,q.[SubjectID]
          ,q.[QContent]
          ,q.[OptionA]
          ,q.[OptionB]
          ,q.[OptionC]
          ,q.[OptionD]
          ,q.[Answer]
          ,q.[Chapter]
          ,q.[CreatedBy]
          ,q.[CreatedAt]
          ,q.[ModifiedBy]
          ,q.[ModifiedAt]
      FROM [dbo].[ExamQuestion] eq
      INNER JOIN [dbo].[Question] q ON eq.[QuestionID] = q.[QuestionID]
      WHERE eq.[ExamID] = @ExamID
END
GO

-- 8.4 Xóa tất cả câu hỏi trong đề thi
CREATE PROCEDURE [dbo].[ExamQuestion_DeleteAll]
    @ExamID INT
AS
BEGIN
    DELETE FROM [dbo].[ExamQuestion]
    WHERE [ExamID] = @ExamID
END
GO

-- 9. Tạo stored procedure để lấy câu hỏi theo chương
CREATE PROCEDURE [dbo].[Question_GetByChapter]
    @SubjectID VARCHAR(50),
    @Chapter NVARCHAR(100)
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
      WHERE [SubjectID] = @SubjectID
      AND (@Chapter = 'All' OR [Chapter] = @Chapter)
END
GO

-- 10. Tạo stored procedure để lấy danh sách các chương theo môn học
CREATE PROCEDURE [dbo].[Question_GetChaptersBySubject]
    @SubjectID VARCHAR(50)
AS
BEGIN
    SELECT DISTINCT [Chapter]
    FROM [dbo].[Question]
    WHERE [SubjectID] = @SubjectID
    AND [Chapter] IS NOT NULL
    ORDER BY [Chapter]
END
GO

-- 11. Cập nhật stored procedure để lấy câu hỏi ngẫu nhiên cho bài thi
CREATE OR ALTER PROCEDURE [dbo].[Question_GetQuestionForTest]
    @NumberOfQuestion INT,
    @SubjectID VARCHAR(50),
    @ExamID INT = NULL
AS
BEGIN
    IF @ExamID IS NULL
    BEGIN
        -- Lấy câu hỏi ngẫu nhiên từ bảng Question
        SELECT *,N'Câu ' + CONVERT(VARCHAR(20), ROW_NUMBER() OVER(ORDER BY QuestionID)) QuestionIndex
        FROM (
            SELECT TOP(@NumberOfQuestion)
                [QuestionID]
                ,[SubjectID]
                ,[QContent]
                ,[OptionA]
                ,[OptionB]
                ,[OptionC]
                ,[OptionD]
                ,[Answer]
                ,[Chapter]
            FROM [dbo].[Question]
            WHERE SubjectID = @SubjectID
            ORDER BY NEWID()
        ) AS TempQuestion
    END
    ELSE
    BEGIN
        -- Lấy câu hỏi từ đề thi đã được tạo
        SELECT q.*,N'Câu ' + CONVERT(VARCHAR(20), ROW_NUMBER() OVER(ORDER BY q.QuestionID)) QuestionIndex
        FROM [dbo].[ExamQuestion] eq
        INNER JOIN [dbo].[Question] q ON eq.[QuestionID] = q.[QuestionID]
        WHERE eq.[ExamID] = @ExamID
    END
END
GO
