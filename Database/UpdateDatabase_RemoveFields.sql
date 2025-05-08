USE QL_THITRACNGHIEM2
GO

-- 1. Loại bỏ các trường không cần thiết trong bảng Subject
ALTER TABLE [dbo].[Subject]
DROP COLUMN [QuesQuantity], [TimeLimit];
GO

-- 2. Cập nhật các stored procedure liên quan đến Subject

-- 2.1 Cập nhật stored procedure Subject_Insert
CREATE OR ALTER PROCEDURE [dbo].[Subject_Insert]
    @SubjectID VARCHAR(50),
    @SubjectName NVARCHAR(50),
    @Description NVARCHAR(50),
    @CreatedBy VARCHAR(50),
    @ModifiedBy VARCHAR(50)
AS
BEGIN
    INSERT INTO [dbo].[Subject]
           ([SubjectID],
           [SubjectName],
           [Description],
           [CreatedBy],
           [CreatedAt],
           [ModifiedBy],
           [ModifiedAt])
     VALUES
           (@SubjectID,
           @SubjectName,
           @Description,
           @CreatedBy,
           GETDATE(),
           @ModifiedBy,
           GETDATE())
END
GO

-- 2.2 Cập nhật stored procedure Subject_Update
CREATE OR ALTER PROCEDURE [dbo].[Subject_Update]
    @SubjectID VARCHAR(50),
    @SubjectName NVARCHAR(50),
    @Description NVARCHAR(50),
    @ModifiedBy VARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[Subject]
    SET [SubjectName] = @SubjectName,
        [Description] = @Description,
        [ModifiedBy] = @ModifiedBy,
        [ModifiedAt] = GETDATE()
    WHERE [SubjectID] = @SubjectID
END
GO

-- 2.3 Cập nhật stored procedure Subject_SelectAll
CREATE OR ALTER PROCEDURE [dbo].[Subject_SelectAll]
AS
BEGIN
    SELECT [SubjectID],
           [SubjectName],
           [Description],
           [CreatedBy],
           [CreatedAt],
           [ModifiedBy],
           [ModifiedAt]
    FROM [dbo].[Subject]
END
GO

-- 2.4 Cập nhật stored procedure Subject_Search
CREATE OR ALTER PROCEDURE [dbo].[Subject_Search]
    @Keyword NVARCHAR(200)
AS
BEGIN
    SELECT [SubjectID],
           [SubjectName],
           [Description],
           [CreatedBy],
           [CreatedAt],
           [ModifiedBy],
           [ModifiedAt]
    FROM [dbo].[Subject]
    WHERE SubjectName LIKE N'%'+@Keyword+'%'
        OR Description LIKE N'%'+@Keyword+'%'
END
GO

-- 3. Cập nhật stored procedure Question_GetQuestionForTest để chỉ lấy câu hỏi từ đề thi
CREATE OR ALTER PROCEDURE [dbo].[Question_GetQuestionForTest]
    @SubjectID VARCHAR(50),
    @ExamID INT
AS
BEGIN
    -- Lấy câu hỏi từ đề thi đã được tạo
    SELECT q.*,N'Câu ' + CONVERT(VARCHAR(20), ROW_NUMBER() OVER(ORDER BY q.QuestionID)) QuestionIndex
    FROM [dbo].[ExamQuestion] eq
    INNER JOIN [dbo].[Question] q ON eq.[QuestionID] = q.[QuestionID]
    WHERE eq.[ExamID] = @ExamID
END
GO
