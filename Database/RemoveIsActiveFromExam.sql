USE QL_THITRACNGHIEM2
GO

-- Loại bỏ ràng buộc mặc định trên trường IsActive
DECLARE @ConstraintName NVARCHAR(200)
SELECT @ConstraintName = dc.name
FROM sys.default_constraints dc
JOIN sys.columns c ON dc.parent_object_id = c.object_id AND dc.parent_column_id = c.column_id
WHERE c.name = 'IsActive' AND OBJECT_NAME(dc.parent_object_id) = 'Exam'

IF @ConstraintName IS NOT NULL
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'ALTER TABLE [dbo].[Exam] DROP CONSTRAINT ' + @ConstraintName
    EXEC sp_executesql @SQL
END

-- Loại bỏ trường IsActive trong bảng Exam
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('dbo.Exam') AND name = 'IsActive')
BEGIN
    ALTER TABLE [dbo].[Exam]
    DROP COLUMN [IsActive];
END
GO
