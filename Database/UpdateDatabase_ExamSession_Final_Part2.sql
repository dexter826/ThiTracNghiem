USE QL_THITRACNGHIEM2
GO

-- 7. Tạo các Stored Procedure cho ExamSessionDetail
-- 7.1 Thêm chi tiết kỳ thi
CREATE OR ALTER PROCEDURE [dbo].[ExamSessionDetail_Insert]
    @SessionID INT,
    @ExamID INT,
    @CreatedBy VARCHAR(50)
AS
BEGIN
    INSERT INTO [dbo].[ExamSessionDetail]
           ([SessionID]
           ,[ExamID]
           ,[CreatedBy]
           ,[CreatedAt]
           ,[ModifiedBy]
           ,[ModifiedAt])
     VALUES
           (@SessionID
           ,@ExamID
           ,@CreatedBy
           ,GETDATE()
           ,@CreatedBy
           ,GETDATE())
END
GO

-- 7.2 Lấy chi tiết kỳ thi theo kỳ thi
CREATE OR ALTER PROCEDURE [dbo].[ExamSessionDetail_GetBySession]
    @SessionID INT
AS
BEGIN
    SELECT esd.[DetailID]
          ,esd.[SessionID]
          ,esd.[ExamID]
          ,e.[ExamName]
          ,e.[SubjectID]
          ,s.[SubjectName]
          ,e.[TimeLimit]
          ,e.[TotalQuestion]
      FROM [dbo].[ExamSessionDetail] esd
      INNER JOIN [dbo].[Exam] e ON esd.[ExamID] = e.[ExamID]
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE esd.[SessionID] = @SessionID
END
GO

-- 8. Tạo các Stored Procedure cho UserExamSession
-- 8.1 Thêm người dùng vào kỳ thi
CREATE OR ALTER PROCEDURE [dbo].[UserExamSession_Insert]
    @UserID INT,
    @SessionID INT,
    @Status NVARCHAR(50),
    @CreatedBy VARCHAR(50)
AS
BEGIN
    INSERT INTO [dbo].[UserExamSession]
           ([UserID]
           ,[SessionID]
           ,[Status]
           ,[CreatedBy]
           ,[CreatedAt]
           ,[ModifiedBy]
           ,[ModifiedAt])
     VALUES
           (@UserID
           ,@SessionID
           ,@Status
           ,@CreatedBy
           ,GETDATE()
           ,@CreatedBy
           ,GETDATE())
END
GO

-- 8.2 Cập nhật trạng thái người dùng trong kỳ thi
CREATE OR ALTER PROCEDURE [dbo].[UserExamSession_UpdateStatus]
    @UserID INT,
    @SessionID INT,
    @Status NVARCHAR(50),
    @StartTime DATETIME = NULL,
    @EndTime DATETIME = NULL,
    @ModifiedBy VARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[UserExamSession]
    SET [Status] = @Status,
        [StartTime] = CASE WHEN @StartTime IS NOT NULL THEN @StartTime ELSE [StartTime] END,
        [EndTime] = CASE WHEN @EndTime IS NOT NULL THEN @EndTime ELSE [EndTime] END,
        [ModifiedBy] = @ModifiedBy,
        [ModifiedAt] = GETDATE()
    WHERE [UserID] = @UserID AND [SessionID] = @SessionID
END
GO

-- 8.3 Lấy danh sách người dùng trong kỳ thi
CREATE OR ALTER PROCEDURE [dbo].[UserExamSession_GetBySession]
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
      FROM [dbo].[UserExamSession] ues
      INNER JOIN [dbo].[UserAccount] ua ON ues.[UserID] = ua.[UserID]
      WHERE ues.[SessionID] = @SessionID
END
GO

-- 8.4 Lấy thông tin người dùng trong kỳ thi
CREATE OR ALTER PROCEDURE [dbo].[UserExamSession_GetByUserAndSession]
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

-- 9. Tạo Stored Procedure để lấy danh sách kỳ thi của người dùng
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

-- 10. Tạo Stored Procedure để lấy thông tin đề thi cho kỳ thi
CREATE OR ALTER PROCEDURE [dbo].[ExamSession_GetExamForUser]
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

-- 11. Tạo Stored Procedure để lấy danh sách người dùng theo vai trò
CREATE OR ALTER PROCEDURE [dbo].[UserAccount_GetByRole]
    @RoleID VARCHAR(50)
AS
BEGIN
    SELECT [UserID]
          ,[RoleID]
          ,[Username]
          ,[Password]
          ,[Fullname]
          ,[Email]
          ,[PhoneNumber]
          ,[Address]
          ,[Birthday]
          ,[Note]
          ,[Image]
          ,[CreatedBy]
          ,[CreatedAt]
          ,[ModifiedBy]
          ,[ModifiedAt]
      FROM [dbo].[UserAccount]
      WHERE [RoleID] = @RoleID
END
GO
