USE QL_THITRACNGHIEM2
GO

-- Cập nhật stored procedure để xử lý trường hợp Chapter là NULL
CREATE OR ALTER PROCEDURE [dbo].[Question_GetByChapter]
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
      AND (@Chapter = 'All' OR ([Chapter] = @Chapter OR (@Chapter IS NULL AND [Chapter] IS NULL)))
END
GO
