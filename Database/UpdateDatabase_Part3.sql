USE QL_THITRACNGHIEM2
GO

-- Cập nhật stored procedure Question_GetByChapter để lấy tất cả câu hỏi khi chọn 'All', bất kể Chapter có giá trị hay không
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
      AND (@Chapter = 'All' OR [Chapter] = @Chapter)
END
GO
