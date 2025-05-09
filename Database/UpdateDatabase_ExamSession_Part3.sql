USE QL_THITRACNGHIEM2
GO

-- 1. Tạo Stored Procedure để lấy danh sách người dùng theo vai trò
CREATE PROCEDURE [dbo].[UserAccount_GetByRole]
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
