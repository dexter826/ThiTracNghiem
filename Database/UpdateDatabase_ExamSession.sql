USE QL_THITRACNGHIEM2
GO

-- 1. Loại bỏ trường IsActive trong bảng Exam
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('dbo.Exam') AND name = 'IsActive')
BEGIN
    ALTER TABLE [dbo].[Exam]
    DROP COLUMN [IsActive];
END
GO

-- 2. Tạo bảng ExamSession (Kỳ thi)
CREATE TABLE [dbo].[ExamSession] (
    [SessionID] INT IDENTITY(1,1) NOT NULL,
    [SessionName] NVARCHAR(200) NOT NULL,
    [StartTime] DATETIME NOT NULL,
    [EndTime] DATETIME NOT NULL,
    [Status] NVARCHAR(50) NOT NULL, -- 'Scheduled', 'InProgress', 'Completed', 'Cancelled'
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL,
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    CONSTRAINT [PK_ExamSession] PRIMARY KEY CLUSTERED ([SessionID] ASC)
);
GO

-- 3. Tạo bảng ExamSessionDetail (Chi tiết kỳ thi)
CREATE TABLE [dbo].[ExamSessionDetail] (
    [DetailID] INT IDENTITY(1,1) NOT NULL,
    [SessionID] INT NOT NULL,
    [ExamID] INT NOT NULL,
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL,
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    CONSTRAINT [PK_ExamSessionDetail] PRIMARY KEY CLUSTERED ([DetailID] ASC),
    CONSTRAINT [FK_ExamSessionDetail_ExamSession] FOREIGN KEY ([SessionID]) REFERENCES [dbo].[ExamSession] ([SessionID]),
    CONSTRAINT [FK_ExamSessionDetail_Exam] FOREIGN KEY ([ExamID]) REFERENCES [dbo].[Exam] ([ExamID])
);
GO

-- 4. Tạo bảng UserExamSession (Người dùng tham gia kỳ thi)
CREATE TABLE [dbo].[UserExamSession] (
    [UserSessionID] INT IDENTITY(1,1) NOT NULL,
    [UserID] INT NOT NULL,
    [SessionID] INT NOT NULL,
    [Status] NVARCHAR(50) NOT NULL, -- 'Registered', 'Started', 'Completed', 'Absent'
    [StartTime] DATETIME NULL,
    [EndTime] DATETIME NULL,
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL,
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    CONSTRAINT [PK_UserExamSession] PRIMARY KEY CLUSTERED ([UserSessionID] ASC),
    CONSTRAINT [FK_UserExamSession_UserAccount] FOREIGN KEY ([UserID]) REFERENCES [dbo].[UserAccount] ([UserID]),
    CONSTRAINT [FK_UserExamSession_ExamSession] FOREIGN KEY ([SessionID]) REFERENCES [dbo].[ExamSession] ([SessionID])
);
GO

-- 5. Tạo Stored Procedure để thêm kỳ thi mới
CREATE PROCEDURE [dbo].[ExamSession_Insert]
    @SessionName NVARCHAR(200),
    @StartTime DATETIME,
    @EndTime DATETIME,
    @Status NVARCHAR(50),
    @CreatedBy VARCHAR(50),
    @SessionID INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[ExamSession]
           ([SessionName]
           ,[StartTime]
           ,[EndTime]
           ,[Status]
           ,[CreatedBy]
           ,[CreatedAt]
           ,[ModifiedBy]
           ,[ModifiedAt])
     VALUES
           (@SessionName
           ,@StartTime
           ,@EndTime
           ,@Status
           ,@CreatedBy
           ,GETDATE()
           ,@CreatedBy
           ,GETDATE())

    SET @SessionID = SCOPE_IDENTITY()
END
GO

-- 6. Tạo Stored Procedure để thêm chi tiết kỳ thi
CREATE PROCEDURE [dbo].[ExamSessionDetail_Insert]
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

-- 7. Tạo Stored Procedure để gán người dùng vào kỳ thi
CREATE PROCEDURE [dbo].[UserExamSession_Insert]
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

-- 8. Tạo Stored Procedure để lấy danh sách kỳ thi đang diễn ra
CREATE PROCEDURE [dbo].[ExamSession_GetCurrent]
AS
BEGIN
    SELECT es.[SessionID]
          ,es.[SessionName]
          ,es.[StartTime]
          ,es.[EndTime]
          ,es.[Status]
          ,es.[CreatedBy]
          ,es.[CreatedAt]
          ,es.[ModifiedBy]
          ,es.[ModifiedAt]
      FROM [dbo].[ExamSession] es
      WHERE es.[Status] = 'InProgress'
        AND GETDATE() BETWEEN es.[StartTime] AND es.[EndTime]
END
GO

-- 9. Tạo Stored Procedure để lấy danh sách kỳ thi của người dùng
CREATE PROCEDURE [dbo].[ExamSession_GetByUser]
    @UserID INT
AS
BEGIN
    SELECT es.[SessionID]
          ,es.[SessionName]
          ,es.[StartTime]
          ,es.[EndTime]
          ,es.[Status]
          ,ues.[Status] AS UserStatus
          ,ues.[StartTime] AS UserStartTime
          ,ues.[EndTime] AS UserEndTime
      FROM [dbo].[ExamSession] es
      INNER JOIN [dbo].[UserExamSession] ues ON es.[SessionID] = ues.[SessionID]
      WHERE ues.[UserID] = @UserID
        AND es.[Status] IN ('Scheduled', 'InProgress')
        AND GETDATE() BETWEEN es.[StartTime] AND es.[EndTime]
END
GO

-- 10. Tạo Stored Procedure để cập nhật trạng thái kỳ thi
CREATE PROCEDURE [dbo].[ExamSession_UpdateStatus]
    @SessionID INT,
    @Status NVARCHAR(50),
    @ModifiedBy VARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[ExamSession]
    SET [Status] = @Status,
        [ModifiedBy] = @ModifiedBy,
        [ModifiedAt] = GETDATE()
    WHERE [SessionID] = @SessionID
END
GO

-- 11. Tạo Stored Procedure để cập nhật trạng thái người dùng trong kỳ thi
CREATE PROCEDURE [dbo].[UserExamSession_UpdateStatus]
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

-- 12. Tạo Stored Procedure để lấy tất cả kỳ thi
CREATE PROCEDURE [dbo].[ExamSession_SelectAll]
AS
BEGIN
    SELECT [SessionID]
          ,[SessionName]
          ,[StartTime]
          ,[EndTime]
          ,[Status]
          ,[CreatedBy]
          ,[CreatedAt]
          ,[ModifiedBy]
          ,[ModifiedAt]
      FROM [dbo].[ExamSession]
END
GO

-- 13. Tạo Stored Procedure để lấy chi tiết kỳ thi
CREATE PROCEDURE [dbo].[ExamSessionDetail_GetBySession]
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

-- 14. Tạo Stored Procedure để lấy danh sách người dùng trong kỳ thi
CREATE PROCEDURE [dbo].[UserExamSession_GetBySession]
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

-- 15. Tạo Stored Procedure để lấy kỳ thi theo ID
CREATE PROCEDURE [dbo].[ExamSession_GetById]
    @SessionID INT
AS
BEGIN
    SELECT [SessionID]
          ,[SessionName]
          ,[StartTime]
          ,[EndTime]
          ,[Status]
          ,[CreatedBy]
          ,[CreatedAt]
          ,[ModifiedBy]
          ,[ModifiedAt]
      FROM [dbo].[ExamSession]
      WHERE [SessionID] = @SessionID
END
GO
