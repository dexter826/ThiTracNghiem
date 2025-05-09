USE QL_THITRACNGHIEM2
GO

-- 1. Loại bỏ các Stored Procedure liên quan đến IsActive
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Exam_SetActive]') AND type in (N'P', N'PC'))
BEGIN
    DROP PROCEDURE [dbo].[Exam_SetActive]
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Exam_GetActiveBySubject]') AND type in (N'P', N'PC'))
BEGIN
    DROP PROCEDURE [dbo].[Exam_GetActiveBySubject]
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subject_GetWithActiveExams]') AND type in (N'P', N'PC'))
BEGIN
    DROP PROCEDURE [dbo].[Subject_GetWithActiveExams]
END
GO

-- 2. Cập nhật các Stored Procedure liên quan đến Exam để loại bỏ trường IsActive
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
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
END
GO

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
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE e.[Status] = @Status
END
GO

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
      FROM [dbo].[Exam] e
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      WHERE e.[ExamID] = @ExamID
END
GO

-- 3. Tạo bảng ExamSession (Kỳ thi)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamSession]') AND type in (N'U'))
BEGIN
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
END
GO

-- 4. Tạo bảng ExamSessionDetail (Chi tiết kỳ thi)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamSessionDetail]') AND type in (N'U'))
BEGIN
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
END
GO

-- 5. Tạo bảng UserExamSession (Người dùng tham gia kỳ thi)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserExamSession]') AND type in (N'U'))
BEGIN
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
END
GO

-- 6. Tạo các Stored Procedure cho ExamSession
-- 6.1 Thêm kỳ thi mới
CREATE OR ALTER PROCEDURE [dbo].[ExamSession_Insert]
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

-- 6.2 Cập nhật trạng thái kỳ thi
CREATE OR ALTER PROCEDURE [dbo].[ExamSession_UpdateStatus]
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

-- 6.3 Lấy tất cả kỳ thi
CREATE OR ALTER PROCEDURE [dbo].[ExamSession_SelectAll]
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

-- 6.4 Lấy kỳ thi theo ID
CREATE OR ALTER PROCEDURE [dbo].[ExamSession_GetById]
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

-- 6.5 Lấy danh sách kỳ thi đang diễn ra
CREATE OR ALTER PROCEDURE [dbo].[ExamSession_GetCurrent]
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
