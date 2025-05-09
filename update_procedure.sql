USE QL_THITRACNGHIEM2
GO

-- Cập nhật stored procedure để bao gồm cả các câu hỏi có Chapter là NULL
CREATE OR ALTER PROCEDURE [dbo].[Question_GetChaptersBySubject]
    @SubjectID VARCHAR(50)
AS
BEGIN
    SELECT DISTINCT [Chapter]
    FROM [dbo].[Question]
    WHERE [SubjectID] = @SubjectID
    ORDER BY [Chapter]
END
GO
