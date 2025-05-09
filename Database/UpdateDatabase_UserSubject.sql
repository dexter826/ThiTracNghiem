USE QL_THITRACNGHIEM2
GO

-- 1. Tạo bảng UserSubject để lưu trữ thông tin gán môn học cho người dùng
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserSubject]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[UserSubject] (
        [ID] INT IDENTITY(1,1) NOT NULL,
        [UserID] INT NOT NULL,
        [SubjectID] VARCHAR(50) NOT NULL,
        [CreatedBy] VARCHAR(50) NULL,
        [CreatedAt] DATETIME NULL,
        [ModifiedBy] VARCHAR(50) NULL,
        [ModifiedAt] DATETIME NULL,
        CONSTRAINT [PK_UserSubject] PRIMARY KEY CLUSTERED ([ID] ASC),
        CONSTRAINT [FK_UserSubject_UserAccount] FOREIGN KEY ([UserID]) REFERENCES [dbo].[UserAccount] ([UserID]),
        CONSTRAINT [FK_UserSubject_Subject] FOREIGN KEY ([SubjectID]) REFERENCES [dbo].[Subject] ([SubjectID])
    );
END
GO

-- 2. Tạo stored procedure để gán môn học cho người dùng
CREATE OR ALTER PROCEDURE [dbo].[UserSubject_Insert]
    @UserID INT,
    @SubjectID VARCHAR(50),
    @CreatedBy VARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem đã tồn tại bản ghi này chưa
    IF EXISTS (SELECT 1 FROM [dbo].[UserSubject] WHERE [UserID] = @UserID AND [SubjectID] = @SubjectID)
    BEGIN
        RAISERROR('Người dùng đã được gán môn học này!', 16, 1)
        RETURN
    END

    INSERT INTO [dbo].[UserSubject]
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

-- 3. Tạo stored procedure để hủy gán môn học cho người dùng
CREATE OR ALTER PROCEDURE [dbo].[UserSubject_Delete]
    @UserID INT,
    @SubjectID VARCHAR(50)
AS
BEGIN
    DELETE FROM [dbo].[UserSubject]
    WHERE [UserID] = @UserID AND [SubjectID] = @SubjectID
END
GO

-- 4. Tạo stored procedure để lấy danh sách môn học của người dùng
CREATE OR ALTER PROCEDURE [dbo].[UserSubject_GetByUser]
    @UserID INT
AS
BEGIN
    SELECT us.[ID]
          ,us.[UserID]
          ,us.[SubjectID]
          ,s.[SubjectName]
          ,us.[CreatedBy]
          ,us.[CreatedAt]
          ,us.[ModifiedBy]
          ,us.[ModifiedAt]
      FROM [dbo].[UserSubject] us
      INNER JOIN [dbo].[Subject] s ON us.[SubjectID] = s.[SubjectID]
      WHERE us.[UserID] = @UserID
END
GO

-- 5. Tạo stored procedure để lấy danh sách người dùng được gán vào môn học
CREATE OR ALTER PROCEDURE [dbo].[UserSubject_GetBySubject]
    @SubjectID VARCHAR(50)
AS
BEGIN
    SELECT us.[ID]
          ,us.[UserID]
          ,ua.[Username]
          ,ua.[Fullname]
          ,us.[SubjectID]
          ,us.[CreatedBy]
          ,us.[CreatedAt]
          ,us.[ModifiedBy]
          ,us.[ModifiedAt]
      FROM [dbo].[UserSubject] us
      INNER JOIN [dbo].[UserAccount] ua ON us.[UserID] = ua.[UserID]
      WHERE us.[SubjectID] = @SubjectID
END
GO

-- 6. Tạo stored procedure để lấy danh sách tất cả các bản ghi UserSubject
CREATE OR ALTER PROCEDURE [dbo].[UserSubject_GetAll]
AS
BEGIN
    SELECT us.[ID]
          ,us.[UserID]
          ,ua.[Username]
          ,ua.[Fullname]
          ,us.[SubjectID]
          ,s.[SubjectName]
          ,us.[CreatedBy]
          ,us.[CreatedAt]
          ,us.[ModifiedBy]
          ,us.[ModifiedAt]
      FROM [dbo].[UserSubject] us
      INNER JOIN [dbo].[UserAccount] ua ON us.[UserID] = ua.[UserID]
      INNER JOIN [dbo].[Subject] s ON us.[SubjectID] = s.[SubjectID]
END
GO

-- 7. Cập nhật stored procedure ExamSession_GetByUser để chỉ trả về các kỳ thi có môn học mà người dùng được phép thi
CREATE OR ALTER PROCEDURE [dbo].[ExamSession_GetByUser]
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
          ,e.[ExamID]
          ,e.[ExamName]
          ,e.[SubjectID]
          ,s.[SubjectName]
      FROM [dbo].[ExamSession] es
      INNER JOIN [dbo].[UserExamSession] ues ON es.[SessionID] = ues.[SessionID]
      INNER JOIN [dbo].[ExamSessionDetail] esd ON es.[SessionID] = esd.[SessionID]
      INNER JOIN [dbo].[Exam] e ON esd.[ExamID] = e.[ExamID]
      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
      INNER JOIN [dbo].[UserSubject] us ON us.[UserID] = @UserID AND us.[SubjectID] = e.[SubjectID]
      WHERE ues.[UserID] = @UserID
        AND es.[Status] IN ('Scheduled', 'InProgress')
        AND GETDATE() BETWEEN es.[StartTime] AND es.[EndTime]
END
GO

-- 8. Cập nhật stored procedure để lấy danh sách người dùng có thể tham gia kỳ thi (dựa trên môn học)
CREATE OR ALTER PROCEDURE [dbo].[UserAccount_GetBySubject]
    @SubjectID VARCHAR(50)
AS
BEGIN
    SELECT ua.[UserID]
          ,ua.[Username]
          ,ua.[Fullname]
          ,ua.[Email]
          ,ua.[RoleID]
          ,r.[RoleName]
      FROM [dbo].[UserAccount] ua
      INNER JOIN [dbo].[UserRole] r ON ua.[RoleID] = r.[RoleID]
      INNER JOIN [dbo].[UserSubject] us ON ua.[UserID] = us.[UserID]
      WHERE us.[SubjectID] = @SubjectID
        AND ua.[RoleID] = 3 -- Chỉ lấy người dùng có vai trò là User
END
GO
