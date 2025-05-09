USE QL_THITRACNGHIEM2
GO

-- 1. Tạo Stored Procedure để lấy thông tin đề thi cho kỳ thi
CREATE PROCEDURE [dbo].[ExamSession_GetExamForUser]
    @UserID INT,
    @SessionID INT
AS
BEGIN
    -- Lấy thông tin kỳ thi
    DECLARE @Status NVARCHAR(50)
    SELECT @Status = [Status]
    FROM [dbo].[UserExamSession]
    WHERE [UserID] = @UserID AND [SessionID] = @SessionID

    -- Kiểm tra trạng thái người dùng trong kỳ thi
    IF @Status IS NULL OR @Status = 'Completed'
    BEGIN
        RAISERROR('Người dùng không có quyền tham gia kỳ thi này hoặc đã hoàn thành kỳ thi!', 16, 1)
        RETURN
    END

    -- Lấy thông tin đề thi trong kỳ thi
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
      FROM [dbo].[ExamSessionDetail] esd
      INNER JOIN [dbo].[Exam] e ON esd.[ExamID] = e.[ExamID]
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE esd.[SessionID] = @SessionID
END
GO

-- 2. Tạo Stored Procedure để lấy thông tin người dùng trong kỳ thi
CREATE PROCEDURE [dbo].[UserExamSession_GetByUserAndSession]
    @UserID INT,
    @SessionID INT
AS
BEGIN
    SELECT ues.[UserSessionID]
          ,ues.[UserID]
          ,ua.[Username]
          ,ua.[Fullname]
          ,ues.[SessionID]
          ,ues.[Status]
          ,ues.[StartTime]
          ,ues.[EndTime]
          ,ues.[CreatedBy]
          ,ues.[CreatedAt]
          ,ues.[ModifiedBy]
          ,ues.[ModifiedAt]
      FROM [dbo].[UserExamSession] ues
      INNER JOIN [dbo].[UserAccount] ua ON ues.[UserID] = ua.[UserID]
      WHERE ues.[UserID] = @UserID AND ues.[SessionID] = @SessionID
END
GO

-- 3. Cập nhật Stored Procedure để lấy danh sách kỳ thi của người dùng
CREATE OR ALTER PROCEDURE [dbo].[ExamSession_GetByUser]
    @UserID INT
AS
BEGIN
    SELECT es.[SessionID]
          ,es.[SessionName]
          ,es.[StartTime]
          ,es.[EndTime]
          ,es.[Status] AS SessionStatus
          ,ues.[Status] AS UserStatus
          ,ues.[StartTime] AS UserStartTime
          ,ues.[EndTime] AS UserEndTime
          ,esd.[ExamID]
          ,e.[ExamName]
          ,e.[SubjectID]
          ,s.[SubjectName]
          ,e.[TimeLimit]
          ,e.[TotalQuestion]
      FROM [dbo].[ExamSession] es
      INNER JOIN [dbo].[UserExamSession] ues ON es.[SessionID] = ues.[SessionID]
      INNER JOIN [dbo].[ExamSessionDetail] esd ON es.[SessionID] = esd.[SessionID]
      INNER JOIN [dbo].[Exam] e ON esd.[ExamID] = e.[ExamID]
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE ues.[UserID] = @UserID
        AND es.[Status] IN ('Scheduled', 'InProgress')
        AND GETDATE() BETWEEN es.[StartTime] AND es.[EndTime]
END
GO
