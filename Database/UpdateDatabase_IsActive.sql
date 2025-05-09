USE QL_THITRACNGHIEM2
GO

-- 1. Thêm trường IsActive vào bảng Exam
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('dbo.Exam') AND name = 'IsActive')
BEGIN
    ALTER TABLE [dbo].[Exam]
    ADD [IsActive] BIT NOT NULL DEFAULT 0;
END
GO

-- 2. Tạo Stored Procedure để kích hoạt/hủy kích hoạt đề thi
CREATE OR ALTER PROCEDURE [dbo].[Exam_SetActive]
    @ExamID INT,
    @IsActive BIT,
    @ModifiedBy VARCHAR(50)
AS
BEGIN
    -- Kiểm tra đề thi có tồn tại và đã được duyệt chưa
    IF NOT EXISTS (SELECT 1 FROM [dbo].[Exam] WHERE [ExamID] = @ExamID AND [Status] = 'Approved')
    BEGIN
        RAISERROR('Đề thi không tồn tại hoặc chưa được duyệt!', 16, 1)
        RETURN
    END

    -- Nếu kích hoạt đề thi, hủy kích hoạt tất cả các đề thi khác cùng môn học
    IF @IsActive = 1
    BEGIN
        DECLARE @SubjectID VARCHAR(50)
        SELECT @SubjectID = [SubjectID] FROM [dbo].[Exam] WHERE [ExamID] = @ExamID

        UPDATE [dbo].[Exam]
        SET [IsActive] = 0,
            [ModifiedBy] = @ModifiedBy,
            [ModifiedAt] = GETDATE()
        WHERE [SubjectID] = @SubjectID AND [ExamID] <> @ExamID
    END

    -- Cập nhật trạng thái kích hoạt cho đề thi
    UPDATE [dbo].[Exam]
    SET [IsActive] = @IsActive,
        [ModifiedBy] = @ModifiedBy,
        [ModifiedAt] = GETDATE()
    WHERE [ExamID] = @ExamID
END
GO

-- 3. Tạo Stored Procedure để lấy đề thi đang kích hoạt theo môn học
CREATE OR ALTER PROCEDURE [dbo].[Exam_GetActiveBySubject]
    @SubjectID VARCHAR(50)
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
          ,e.[IsActive]
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE e.[SubjectID] = @SubjectID
        AND e.[Status] = 'Approved'
        AND e.[IsActive] = 1
END
GO

-- 4. Tạo Stored Procedure để lấy môn học có đề thi đã kích hoạt
CREATE OR ALTER PROCEDURE [dbo].[Subject_GetWithActiveExams]
AS
BEGIN
    SELECT DISTINCT s.[SubjectID]
          ,s.[SubjectName]
          ,s.[Description]
          ,s.[CreatedBy]
          ,s.[CreatedAt]
          ,s.[ModifiedBy]
          ,s.[ModifiedAt]
    FROM [dbo].[Subject] s
    INNER JOIN [dbo].[Exam] e ON s.[SubjectID] = e.[SubjectID]
    WHERE e.[Status] = 'Approved'
      AND e.[IsActive] = 1
END
GO

-- 5. Cập nhật Stored Procedure Exam_SelectAll để bao gồm trường IsActive
CREATE OR ALTER PROCEDURE [dbo].[Exam_SelectAll]
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
          ,e.[IsActive]
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
END
GO

-- 6. Cập nhật Stored Procedure Exam_GetByStatus để bao gồm trường IsActive
CREATE OR ALTER PROCEDURE [dbo].[Exam_GetByStatus]
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
          ,e.[IsActive]
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE e.[Status] = @Status
END
GO

-- 7. Cập nhật Stored Procedure Exam_GetById để bao gồm trường IsActive
CREATE OR ALTER PROCEDURE [dbo].[Exam_GetById]
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
          ,e.[IsActive]
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE e.[ExamID] = @ExamID
END
GO
