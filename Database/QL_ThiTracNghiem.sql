create database QL_THITRACNGHIEM2
go

use QL_THITRACNGHIEM2
go

-- Tạo bảng Question
CREATE TABLE [dbo].[Question] (
    [QuestionID] INT IDENTITY(1,1) NOT NULL,
    [SubjectID] VARCHAR(50) NOT NULL,
    [QContent] NVARCHAR(500) NULL,
    [OptionA] NVARCHAR(500) NULL,
    [OptionB] NVARCHAR(500) NULL,
    [OptionC] NVARCHAR(500) NULL,
    [OptionD] NVARCHAR(500) NULL,
    [Answer] NVARCHAR(500) NULL,
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL,
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([QuestionID] ASC)
);

-- Tạo bảng Subject
CREATE TABLE [dbo].[Subject] (
    [SubjectID] VARCHAR(50) NOT NULL,
    [SubjectName] NVARCHAR(50) NULL,
	[QuesQuantity] INT NULL,
	[TimeLimit] INT NULL,
    [Description] NVARCHAR(50) NULL,
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL,
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED ([SubjectID] ASC)
);

-- Tạo bảng TestHistory
CREATE TABLE [dbo].[TestHistory] (
    [TestId] INT IDENTITY(1,1) NOT NULL,
    [UserID] INT NOT NULL,
    [SubjectID] VARCHAR(50) NOT NULL,
    [TestDate] DATETIME NULL,
    [CorrectAnswer] INT NULL,
    [TotalQuestion] INT NULL,
    [Mark] INT NULL,
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL, 
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    CONSTRAINT [PK_TestHistory] PRIMARY KEY CLUSTERED ([TestId] ASC)
);

-- Tạo bảng UserAccount
CREATE TABLE [dbo].[UserAccount] (
    [UserID] INT IDENTITY(1,1) NOT NULL,
    [RoleID] VARCHAR(50) NOT NULL,
    [Username] NVARCHAR(50) NULL,
    [Password] VARCHAR(50) NULL,
    [Fullname] NVARCHAR(50) NULL,
    [Email] VARCHAR(50) NULL,
    [PhoneNumber] VARCHAR(50) NULL,
    [Address] NVARCHAR(150) NULL,
    [Birthday] DATETIME NULL,
    [Note] NVARCHAR(50) NULL,
	[Image] image,
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL,
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED ([UserID] ASC)
)

-- Tạo bảng UserRole
CREATE TABLE [dbo].[UserRole] (
    [RoleID] VARCHAR(50) NOT NULL,
    [RoleName] NVARCHAR(50) NULL,
    [Description] NVARCHAR(50) NULL,
    [CreatedBy] VARCHAR(50) NULL,
    [CreatedAt] DATETIME NULL,
    [ModifiedBy] VARCHAR(50) NULL,
    [ModifiedAt] DATETIME NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([RoleID] ASC)
)

-- Thiết lập các giá trị mặc định cho bảng Question
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [DF_Question_CreatedBy] DEFAULT (user_name()) FOR [CreatedBy];
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [DF_Question_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt];
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [DF_Question_ModifiedBy] DEFAULT (user_name()) FOR [ModifiedBy];
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [DF_Question_ModifiedAt] DEFAULT (getdate()) FOR [ModifiedAt];

-- Thiết lập các giá trị mặc định cho bảng Subject
ALTER TABLE [dbo].[Subject] ADD CONSTRAINT [DF_Subject_CreatedBy] DEFAULT (user_name()) FOR [CreatedBy];
ALTER TABLE [dbo].[Subject] ADD CONSTRAINT [DF_Subject_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt];
ALTER TABLE [dbo].[Subject] ADD CONSTRAINT [DF_Subject_ModifiedBy] DEFAULT (user_name()) FOR [ModifiedBy];
ALTER TABLE [dbo].[Subject] ADD CONSTRAINT [DF_Subject_ModifiedAt] DEFAULT (getdate()) FOR [ModifiedAt];

-- Thiết lập các giá trị mặc định cho bảng TestHistory
ALTER TABLE [dbo].[TestHistory] ADD CONSTRAINT [DF_TestHistory_CreatedBy] DEFAULT (user_name()) FOR [CreatedBy];
ALTER TABLE [dbo].[TestHistory] ADD CONSTRAINT [DF_TestHistory_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt];
ALTER TABLE [dbo].[TestHistory] ADD CONSTRAINT [DF_TestHistory_ModifiedBy] DEFAULT (user_name()) FOR [ModifiedBy];
ALTER TABLE [dbo].[TestHistory] ADD CONSTRAINT [DF_TestHistory_ModifiedAt] DEFAULT (getdate()) FOR [ModifiedAt];

-- Thiết lập các giá trị mặc định cho bảng UserAccount
ALTER TABLE [dbo].[UserAccount] ADD CONSTRAINT [DF_UserAccount_CreatedBy] DEFAULT (user_name()) FOR [CreatedBy];
ALTER TABLE [dbo].[UserAccount] ADD CONSTRAINT [DF_UserAccount_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt];
ALTER TABLE [dbo].[UserAccount] ADD CONSTRAINT [DF_UserAccount_ModifiedBy] DEFAULT (user_name()) FOR [ModifiedBy];
ALTER TABLE [dbo].[UserAccount] ADD CONSTRAINT [DF_UserAccount_ModifiedAt] DEFAULT (getdate()) FOR [ModifiedAt];

-- Thiết lập các giá trị mặc định cho bảng UserRole
ALTER TABLE [dbo].[UserRole] ADD CONSTRAINT [DF_Role_CreatedBy] DEFAULT (user_name()) FOR [CreatedBy];
ALTER TABLE [dbo].[UserRole] ADD CONSTRAINT [DF_Role_CreatedAt] DEFAULT (getdate()) FOR [CreatedAt];
ALTER TABLE [dbo].[UserRole] ADD CONSTRAINT [DF_Role_ModifiedBy] DEFAULT (user_name()) FOR [ModifiedBy];
ALTER TABLE [dbo].[UserRole] ADD CONSTRAINT [DF_Role_ModifiedAt] DEFAULT (getdate()) FOR [ModifiedAt];

-- Thêm khóa ngoại vào bảng Question tham chiếu bảng Subject
ALTER TABLE [dbo].[Question] WITH CHECK ADD CONSTRAINT [FK_Question_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
ON UPDATE CASCADE
ON DELETE CASCADE;
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Subject];

-- Thêm khóa ngoại vào bảng TestHistory tham chiếu bảng Subject
ALTER TABLE [dbo].[TestHistory] WITH CHECK ADD CONSTRAINT [FK_TestHistory_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
ON UPDATE CASCADE
ON DELETE CASCADE;
ALTER TABLE [dbo].[TestHistory] CHECK CONSTRAINT [FK_TestHistory_Subject];

-- Thêm khóa ngoại vào bảng TestHistory tham chiếu bảng UserAccount
ALTER TABLE [dbo].[TestHistory] WITH CHECK ADD CONSTRAINT [FK_TestHistory_UserAccount] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserAccount] ([UserID])
ON UPDATE CASCADE
ON DELETE CASCADE;
ALTER TABLE [dbo].[TestHistory] CHECK CONSTRAINT [FK_TestHistory_UserAccount];

-- Thêm khóa ngoại vào bảng UserAccount tham chiếu bảng UserRole
ALTER TABLE [dbo].[UserAccount] WITH CHECK ADD CONSTRAINT [FK_UserAccount_UserRole] FOREIGN KEY([RoleID])
REFERENCES [dbo].[UserRole] ([RoleID])
ON UPDATE CASCADE
ON DELETE CASCADE;
ALTER TABLE [dbo].[UserAccount] CHECK CONSTRAINT [FK_UserAccount_UserRole];
Go

--------------------------------------------------insert------------------------------------------
INSERT INTO [dbo].[Subject] ([SubjectID], [SubjectName],[QuesQuantity],[TimeLimit] [Description]) VALUES 
(N'ATTT', N'An toàn thông tin', 10, 20, N'Học về bảo mật và an toàn thông tin'),
(N'CSDL', N'Cơ sở dữ liệu', 10,20,N'Nghiên cứu về hệ thống quản lý cơ sở dữ liệu'),
(N'CTDLGT', N'Cấu trúc dữ liệu và Giải thuật', 20,30,N'Nghiên cứu về cấu trúc dữ liệu và thuật toán')

INSERT INTO [dbo].[UserRole] ([RoleID], [RoleName], [Description]) VALUES 
(N'Admin', N'Admin', N'Quản trị hệ thống'),
(N'Teacher', N'Giáo viên', N'Quản lý lớp học và nội dung bài thi'),
(N'User', N'Sinh viên', N'Người dùng thực hiện bài thi');

INSERT INTO [dbo].[UserAccount] ([RoleID], [Username], [Password], [Fullname], [Email], [PhoneNumber], [Address], [Birthday], [Note], [Image]) VALUES 
(N'Admin', N'admin', N'123', N'Admin', N'admin@gmail.com', N'0777999496', N'Hà Nội', '2004-03-09', N'Quản lý hệ thống',null),
(N'Teacher', N'teacher', N'123', N'Nguyễn Phương Nhi', N'nhinho@gmail.com', N'0987654321', N'TP.HCM', '1980-04-01', N'Giáo viên Khoa CNTT',null),
(N'User', N'2001222641', N'123', N'Trần Công Minh', N'tcongminh1604@gmail.com', N'0777999496', N'TP.HCM', '2004-04-25', N'Sinh viên lớp KTPM',null),
(N'User', N'2001225676', N'123', N'Lê Đức Trung', N'leductrungd2x@gmail.com', N'0902792548', N'TP.HCM', '2004-04-25', N'Sinh viên lớp ATTT',null),
(N'User', N'2001202264', N'123', N'Vương Cường Thuận', N'cuongthuan22@gmail.com', N'0902850644', N'TP.HCM', '2004-04-25', N'Sinh viên lớp CNPM',null)


INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào mã hóa dữ liệu từ đầu đến cuối?', N'TLS', N'FTP', N'HTTP', N'SSH', N'SSH')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào sử dụng cổng 443 để truyền tải dữ liệu an toàn?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào không mã hóa dữ liệu khi truyền tải?', N'TLS', N'FTP', N'HTTP', N'SSH', N'HTTP')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng phổ biến cho các giao dịch ngân hàng trực tuyến?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào đảm bảo tính toàn vẹn và bảo mật của dữ liệu khi truyền tải?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào thường được sử dụng để truyền tải tệp tin lớn qua mạng?', N'TLS', N'FTP', N'HTTP', N'SSH', N'FTP')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào sử dụng cổng 22 để truyền tải dữ liệu an toàn?', N'TLS', N'FTP', N'HTTP', N'SSH', N'SSH')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng để truy cập từ xa vào máy chủ một cách an toàn?', N'TLS', N'FTP', N'HTTP', N'SSH', N'SSH')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng để bảo vệ thông tin đăng nhập khi truy cập vào các trang web?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào không đảm bảo an toàn khi truyền tải dữ liệu?', N'TLS', N'FTP', N'HTTP', N'SSH', N'HTTP')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng để mã hóa email?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng để truyền tải dữ liệu giữa các máy chủ web và trình duyệt?', N'TLS', N'FTP', N'HTTP', N'SSH', N'HTTP')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào đảm bảo an toàn khi truyền tải dữ liệu qua mạng không dây?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng để truyền tải dữ liệu trong mạng nội bộ một cách an toàn?', N'TLS', N'FTP', N'HTTP', N'SSH', N'SSH')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng để bảo vệ dữ liệu khi truyền tải qua mạng công cộng?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng để truyền tải dữ liệu giữa các ứng dụng web?', N'TLS', N'FTP', N'HTTP', N'SSH', N'HTTP')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào đảm bảo an toàn khi truyền tải dữ liệu trong các giao dịch thương mại điện tử?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng để truyền tải dữ liệu trong các hệ thống quản lý cơ sở dữ liệu?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào được sử dụng để truyền tải dữ liệu trong các ứng dụng di động?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Giao thức nào đảm bảo an toàn khi truyền tải dữ liệu trong các hệ thống IoT?', N'TLS', N'FTP', N'HTTP', N'SSH', N'TLS')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Tiện ích nào sau đây là một phương thức bảo mật truy cập từ xa tốt hơn telnet ?', N'SSL', N'SSH', N'IPSec', N'VPN', N'SSH')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Thiết bị nào được sử dụng để cho phép các máy trạm không dây truy cập vào một mạng LAN rộng ?', N'802.11b', N'Tường lửa', N'Điểm truy cập không dây (Wiless Access Point)', N'VPN', N'VPN')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Kỹ thuật tìm kiếm lỗ hổng Acunetix  Web Vulnerability Scanner ra đời năm nào?', N'2004', N'2005', N'2006', N'2007', N'2004')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'ATTT', N'Một số lỗ hổng bảo mật trên di động là gì?', N'Native apps', N'Web apps', N'Hybrid apps', N'tất cả đều đúng', N'tất cả đều đúng')


INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để thêm dữ liệu vào bảng?', N'INSERT', N'UPDATE', N'DELETE', N'SELECT', N'INSERT')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để cập nhật dữ liệu trong bảng?', N'INSERT', N'UPDATE', N'DELETE', N'SELECT', N'UPDATE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để xóa dữ liệu trong bảng?', N'INSERT', N'UPDATE', N'DELETE', N'SELECT', N'DELETE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để truy vấn dữ liệu từ bảng?', N'INSERT', N'UPDATE', N'DELETE', N'SELECT', N'SELECT')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để tạo bảng mới?', N'CREATE TABLE', N'ALTER TABLE', N'DROP TABLE', N'TRUNCATE TABLE', N'CREATE TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để thay đổi cấu trúc bảng?', N'CREATE TABLE', N'ALTER TABLE', N'DROP TABLE', N'TRUNCATE TABLE', N'ALTER TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để xóa bảng?', N'CREATE TABLE', N'ALTER TABLE', N'DROP TABLE', N'TRUNCATE TABLE', N'DROP TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để xóa toàn bộ dữ liệu trong bảng nhưng giữ lại cấu trúc bảng?', N'CREATE TABLE', N'ALTER TABLE', N'DROP TABLE', N'TRUNCATE TABLE', N'TRUNCATE TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để thêm cột vào bảng?', N'ADD COLUMN', N'ALTER TABLE', N'INSERT COLUMN', N'UPDATE COLUMN', N'ALTER TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để xóa cột khỏi bảng?', N'DROP COLUMN', N'ALTER TABLE', N'DELETE COLUMN', N'UPDATE COLUMN', N'ALTER TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để thêm chỉ mục vào bảng?', N'CREATE INDEX', N'ALTER INDEX', N'DROP INDEX', N'TRUNCATE INDEX', N'CREATE INDEX')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để xóa chỉ mục khỏi bảng?', N'DROP INDEX', N'ALTER INDEX', N'CREATE INDEX', N'TRUNCATE INDEX', N'DROP INDEX')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để thêm khóa ngoại vào bảng?', N'ADD FOREIGN KEY', N'ALTER TABLE', N'INSERT FOREIGN KEY', N'UPDATE FOREIGN KEY', N'ALTER TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để xóa khóa ngoại khỏi bảng?', N'DROP FOREIGN KEY', N'ALTER TABLE', N'DELETE FOREIGN KEY', N'UPDATE FOREIGN KEY', N'ALTER TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để thêm khóa chính vào bảng?', N'ADD PRIMARY KEY', N'ALTER TABLE', N'INSERT PRIMARY KEY', N'UPDATE PRIMARY KEY', N'ALTER TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để xóa khóa chính khỏi bảng?', N'DROP PRIMARY KEY', N'ALTER TABLE', N'DELETE PRIMARY KEY', N'UPDATE PRIMARY KEY', N'ALTER TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để thêm ràng buộc vào bảng?', N'ADD CONSTRAINT', N'ALTER TABLE', N'INSERT CONSTRAINT', N'UPDATE CONSTRAINT', N'ALTER TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để xóa ràng buộc khỏi bảng?', N'DROP CONSTRAINT', N'ALTER TABLE', N'DELETE CONSTRAINT', N'UPDATE CONSTRAINT', N'ALTER TABLE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Lệnh nào được dùng để sao lưu cơ sở dữ liệu?', N'BACKUP DATABASE', N'RESTORE DATABASE', N'SAVE DATABASE', N'COPY DATABASE', N'BACKUP DATABASE')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Mệnh đề HAVING chỉ có thể được sử dụng với:', N'INSERT', N'JOIN', N'DELETE', N'SELECT', N'SELECT')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Hàm nào dưới đây là hàm tập hợp trong SQL?', N'AVG', N'LEN', N'JOIN', N'LEFT', N'AVG')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Nếu không chỉ định ASC hoặc DESC sau mệnh đề ORDER BY thì từ khóa nào được sử dụng theo mặc định?', N'ASC', N'DESC', N'DOWN', N'Không có giá trị mặc định', N'ASC')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Đâu không phải là một từ khóa hoặc mệnh đề trong SQL?', N'INSERT', N'DESC', N'DELETE', N'INVERT', N'INVERT')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Trong các hàm dưới đây, đâu là hàm tập hợp trong SQL?', N'CURDATE()', N'COUNT', N'AVERAGE', N'MAXIMUM', N'COUNT')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CSDL', N'Từ khóa SQL nào được sử dụng để chỉ truy xuất các giá trị duy nhất?', N'DISTINCTIVE', N'UNIQUE', N'DISTINCT', N'DIFFERENT', N'DISTINCT')

INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp trung bình là O(n log n)?', N'Quick Sort', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'Quick Sort')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(n^2)?', N'Bubble Sort', N'Quick Sort', N'Merge Sort', N'Heap Sort', N'Bubble Sort')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào sử dụng phương pháp chia để trị?', N'Merge Sort', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'Merge Sort')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(n)?', N'Linear Search', N'Binary Search', N'Quick Sort', N'Merge Sort', N'Linear Search')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào sử dụng cấu trúc dữ liệu heap?', N'Heap Sort', N'Quick Sort', N'Merge Sort', N'Bubble Sort', N'Heap Sort')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(log n)?', N'Binary Search', N'Linear Search', N'Quick Sort', N'Merge Sort', N'Binary Search')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào sử dụng phương pháp đệ quy?', N'Quick Sort', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'Quick Sort')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(n^3)?', N'Matrix Multiplication', N'Quick Sort', N'Merge Sort', N'Heap Sort', N'Matrix Multiplication')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào sử dụng phương pháp tham lam?', N'Kruskal', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'Kruskal')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(2^n)?', N'Tower of Hanoi', N'Quick Sort', N'Merge Sort', N'Heap Sort', N'Tower of Hanoi')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào sử dụng cấu trúc dữ liệu cây?', N'Binary Search Tree', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'Binary Search Tree')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(n!)?', N'Traveling Salesman', N'Quick Sort', N'Merge Sort', N'Heap Sort', N'Traveling Salesman')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào sử dụng phương pháp quay lui?', N'N-Queens', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'N-Queens')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(n log n)?', N'Merge Sort', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'Merge Sort')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào sử dụng cấu trúc dữ liệu đồ thị?', N'Dijkstra', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'Dijkstra')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(n^2 log n)?', N'FFT', N'Quick Sort', N'Merge Sort', N'Heap Sort', N'FFT')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào sử dụng phương pháp động?', N'Floyd-Warshall', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'Floyd-Warshall')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(n^2)?', N'Selection Sort', N'Quick Sort', N'Merge Sort', N'Heap Sort', N'Selection Sort')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào sử dụng cấu trúc dữ liệu hàng đợi?', N'Breadth-First Search', N'Bubble Sort', N'Selection Sort', N'Insertion Sort', N'Breadth-First Search')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Thuật toán nào có độ phức tạp thời gian là O(n^3)?', N'Floyd-Warshall', N'Quick Sort', N'Merge Sort', N'Heap Sort', N'Floyd-Warshall')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Danh sách tuyến tính dạng ngăn xếp làm việc theo nguyên tắc:', N'FIFO', N'LILO', N'LIFO', N'FOLO', N'LIFO')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Để thêm một đối tượng x bất kỳ vào Stack, thao tác thường dùng là:', N'EMPTY(x)', N'TOP(x)', N'PUSH(x)', N'POP(x)', N'PUSH(x)')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Để lấy loại bỏ một đối tượng ra khỏi Stack, thao tác thường dùng là:', N'FULL(x)', N'EMPTY(x)', N'POP(x)', N'PUSH(x)', N'POP(x)')
INSERT [dbo].[Question] ([SubjectID], [QContent], [OptionA], [OptionB], [OptionC], [OptionD], [Answer]) VALUES (N'CTDLGT', N'Để biểu diễn Stack, ta thường sử dụng kiểu dữ liệu nào sau đây?', N'Kiểu bản ghi', N'Danh sách móc nối và mảng dữ liệu', N'Danh sách móc nối', N'Mảng dữ liệu', N'Danh sách móc nối và mảng dữ liệu')

go
-------------------------------THủ Tục------------------------------------
Create procedure [dbo].[Question_Delete]
@QuestionID int
as
delete from Question
 WHERE QuestionID = @QuestionID
go


create proc [dbo].[Question_GetById]
@QuestionID int
As
SELECT [QuestionID]
      ,[SubjectID]
      ,[QContent]
      ,[OptionA]
      ,[OptionB]
      ,[OptionC]
      ,[OptionD]
      ,[Answer]
      ,[CreatedBy]
      ,[CreatedAt]
      ,[ModifiedBy]
      ,[ModifiedAt]
  FROM [dbo].[Question]
  where QuestionID = @QuestionID
Go

CREATE proc [dbo].[Question_GetQuestionForTest]
@NumberOfQuestion int,
@SubjectID varchar(50)
as
Select *,N'Câu ' + CONVERT(varchar(20), ROW_NUMBER() over(order by QuestionID)) QuestionIndex
From(
SELECT top(@NumberOfQuestion)
		[QuestionID]
      ,[SubjectID]
      ,[QContent]
      ,[OptionA]
      ,[OptionB]
      ,[OptionC]
      ,[OptionD]
      ,[Answer]
  FROM [dbo].[Question]
  where SubjectID = @SubjectID
  Order By NEWID() 
) as TempQuestion
Go

CREATE procedure [dbo].[Question_Insert]
	@SubjectID varchar(50)
	,@QContent nvarchar(500)
	,@OptionA nvarchar(500)
	,@OptionB nvarchar(500)
	,@OptionC nvarchar(500)
	,@OptionD nvarchar(500)
	,@Answer nvarchar(500)
	,@CreatedBy varchar(50)
as
INSERT INTO [dbo].[Question]
           ([SubjectID]
           ,[QContent]
           ,[OptionA]
           ,[OptionB]
           ,[OptionC]
           ,[OptionD]
           ,[Answer]
           ,[CreatedBy]
           ,[CreatedAt]
           ,[ModifiedBy]
           ,[ModifiedAt])
     VALUES
           (@SubjectID
           ,@QContent
           ,@OptionA
           ,@OptionB
           ,@OptionC
           ,@OptionD
           ,@Answer
           ,@CreatedBy
           ,GETDATE()
           ,@CreatedBy
           ,GETDATE())
GO

Create procedure [dbo].[Question_Search]
@Keyword nvarchar(200)
as
SELECT [QuestionID]
      ,[SubjectID]
      ,[QContent]
      ,[OptionA]
      ,[OptionB]
      ,[OptionC]
      ,[OptionD]
      ,[Answer]
      ,[CreatedBy]
      ,[CreatedAt]
      ,[ModifiedBy]
      ,[ModifiedAt]
  FROM [dbo].[Question]
  where QContent like N'%' + @Keyword + '%'
  or QuestionID like N'%' + @Keyword + '%'
  or SubjectID like N'%' + @Keyword + '%'
  or Answer like N'%' + @Keyword + '%'
GO

Create procedure [dbo].[Question_SelectAll]
as
SELECT [QuestionID]
      ,[SubjectID]
      ,[QContent]
      ,[OptionA]
      ,[OptionB]
      ,[OptionC]
      ,[OptionD]
      ,[Answer]
      ,[CreatedBy]
      ,[CreatedAt]
      ,[ModifiedBy]
      ,[ModifiedAt]
  FROM [dbo].[Question]
GO

CREATE procedure [dbo].[Question_GetBySubject]
@SubjectID varchar(50)
as
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
  WHERE SubjectID = @SubjectID
GO

CREATE procedure [dbo].[Question_Update]
@QuestionID int,
		@SubjectID varchar(50)
           ,@QContent nvarchar(500)
           ,@OptionA nvarchar(500)
           ,@OptionB nvarchar(500)
           ,@OptionC nvarchar(500)
           ,@OptionD nvarchar(500)
           ,@Answer nvarchar(500)
           ,@ModifiedBy varchar(50)
as
UPDATE [dbo].[Question]
   SET [SubjectID] = @SubjectID
      ,[QContent] = @QContent 
      ,[OptionA] = @OptionA
      ,[OptionB] = @OptionB
      ,[OptionC] = @OptionC
      ,[OptionD] = @OptionD
      ,[Answer] = @Answer
      ,[ModifiedBy] = @ModifiedBy
      ,[ModifiedAt] = GETDATE()
 WHERE QuestionID = @QuestionID
GO

--Kiểm tra số lượng câu hỏi của SubjectID
CREATE PROCEDURE [dbo].[Question_GetTotalQuestionsBySubject]
    @SubjectID VARCHAR(50), -- Mã môn học đầu vào
    @TotalQuestions INT OUTPUT -- Tổng số câu hỏi (giá trị trả về)
AS
BEGIN
    -- Đếm số lượng câu hỏi theo SubjectID
    SELECT @TotalQuestions = COUNT(*)
    FROM Question
    WHERE SubjectID = @SubjectID;
END;
GO

create procedure [dbo].[Subject_Delete]
@SubjectID varchar(50)
as
delete from Subject
 WHERE [SubjectID] = @SubjectID 

GO

create procedure [dbo].[Subject_Insert]
@SubjectID varchar(50),
@SubjectName nvarchar(50),
@QuesQuantity int,
@TimeLimit int,
@Description nvarchar(50),
@CreatedBy varchar(50),
@ModifiedBy varchar(50)
as
INSERT INTO [dbo].[Subject]
           ([SubjectID],
           [SubjectName],
		   [QuesQuantity],
		   [TimeLimit],
           [Description],
           [CreatedBy],
           [CreatedAt],
           [ModifiedBy],
           [ModifiedAt])
     VALUES
           (@SubjectID,
           @SubjectName,
		   @QuesQuantity,
		   @TimeLimit,
           @Description,
           @CreatedBy,
           Getdate(),
           @ModifiedBy,
           Getdate())
GO

CREATE procedure [dbo].[Subject_Search]
@Keyword nvarchar(200)
as
SELECT [SubjectID]
      ,[SubjectName]
	  ,[QuesQuantity]
	  ,[TimeLimit]
      ,[Description]
      ,[CreatedBy]
      ,[CreatedAt]
      ,[ModifiedBy]
      ,[ModifiedAt]
  FROM [dbo].[Subject]
where SubjectName like N'%'+@Keyword+'%'
	or Description like N'%'+@Keyword+'%'

GO

Create procedure [dbo].[Subject_SelectAll]
As
SELECT [SubjectID]
      ,[SubjectName]
	  ,[QuesQuantity]
	  ,[TimeLimit]
      ,[Description]
      ,[CreatedBy]
      ,[CreatedAt]
      ,[ModifiedBy]
      ,[ModifiedAt]
  FROM [dbo].[Subject]

GO

create procedure [dbo].[Subject_Update]
@SubjectID varchar(50),
@SubjectName nvarchar(50),
@QuesQuantity int,
@TimeLimit int,
@Description nvarchar(50),
@ModifiedBy varchar(50)
as

UPDATE [dbo].[Subject]
   SET [SubjectName] = @SubjectName 
		,[QuesQuantity] = @QuesQuantity
		,[TimeLimit] = @TimeLimit
      ,[Description] = @Description
      ,[ModifiedBy] = @ModifiedBy 
      ,[ModifiedAt] = GETDATE()
 WHERE [SubjectID] = @SubjectID 

GO

CREATE PROCEDURE [dbo].[Subject_IsSubjectExist]
    @SubjectID VARCHAR(50),
    @IsExist BIT OUTPUT
AS
BEGIN
    SET @IsExist = CASE WHEN EXISTS (SELECT 1 FROM Subject WHERE SubjectID = @SubjectID) THEN 1 ELSE 0 END
END
GO


create proc [dbo].[TestHistory_Insert]
	@UserID int
    ,@SubjectID varchar(50)
    ,@TestDate datetime
    ,@CorrectAnswer int
    ,@TotalQuestion int
    ,@Mark int
    ,@CreatedBy varchar(50)
as
INSERT INTO [dbo].[TestHistory]
           ([UserID]
           ,[SubjectID]
           ,[TestDate]
           ,[CorrectAnswer]
           ,[TotalQuestion]
           ,[Mark]
           ,[CreatedBy]
           ,[CreatedAt]
           ,[ModifiedBy]
           ,[ModifiedAt])
     VALUES
           (@UserID
           ,@SubjectID
           ,@TestDate
           ,@CorrectAnswer
           ,@TotalQuestion
           ,@Mark
           ,@CreatedBy
           ,GETDATE()
           ,@CreatedBy
           ,GETDATE())
GO

/****** Object:  StoredProcedure [dbo].[TestHistory_ReportBySubject]    Script Date: 06/11/2024 12:58:46 CH ******/
CREATE proc [dbo].[TestHistory_ReportBySubject]
@SubjectID varchar(50)
as
begin
SELECT [TestId]
      ,[UserID]
	  ,(Select Fullname from UserAccount where UserID = T.UserID) Fullname
      ,[SubjectID]
      ,[TestDate]
      ,[CorrectAnswer]
      ,[TotalQuestion]
      ,[Mark]
      ,[CreatedBy]
      ,[CreatedAt]
      ,[ModifiedBy]
      ,[ModifiedAt]
  FROM [dbo].[TestHistory] T
  where SubjectID = @SubjectID
  AND NOT EXISTS (
            SELECT 1 
            FROM UserAccount UA 
            WHERE UA.UserID = T.UserID 
              AND UA.RoleID IN ('Admin', 'Teacher')
        );
end
GO

/****** Object:  StoredProcedure [dbo].[TestHistory_ReportBySubject]    Script Date: 06/11/2024 12:58:46 CH ******/
CREATE proc [dbo].[TestHistory_LeaderBoard]
@SubjectID varchar(50)
as
begin
	with CteLeaderBoard
as
(
	SELECT [TestId]
		  ,U.Username
		  ,U.Fullname
		  ,S.[SubjectID]
		  ,S.SubjectName
		  ,[TestDate]
		  ,[CorrectAnswer]
		  ,[TotalQuestion]
		  ,[Mark]
		  ,ROW_NUMBER() over(order by Mark Desc) MarkIndex
	  FROM [dbo].[TestHistory] T 
	  INNER JOIN UserAccount U on T.UserID=U.UserID
	  inner join Subject S on S.SubjectID = T.SubjectID
	  where T.SubjectID = @SubjectID
)


select * from CteLeaderBoard CRoot
where CRoot.MarkIndex = (select min(MarkIndex) 
						from CteLeaderBoard CChild
						where CChild.Username = CRoot.Username)
						order by CRoot.Mark DESC
end
GO

CREATE PROC [dbo].[TestHistory_ReportByTime]
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SELECT 
        [TestId],
        (SELECT Fullname FROM UserAccount WHERE UserID = T.UserID) AS Fullname,
        (SELECT SubjectName FROM Subject WHERE SubjectID = T.SubjectID) AS SubjectName,
        CONVERT(VARCHAR(10), [TestDate], 103) AS TestDate,
        [CorrectAnswer],
        [TotalQuestion],
        [Mark]
    FROM 
        [dbo].[TestHistory] T
    WHERE 
        DATEDIFF(DAY, @StartDate, TestDate) >= 0
        AND DATEDIFF(DAY, TestDate, @EndDate) >= 0
        AND NOT EXISTS (
            SELECT 1 
            FROM UserAccount UA 
            WHERE UA.UserID = T.UserID 
              AND UA.RoleID IN ('Admin', 'Teacher')
        );
END;
GO

/****** Object:  StoredProcedure [dbo].[TestHistory_SelectAll]    Script Date: 06/11/2024 12:58:46 CH ******/
create proc [dbo].[TestHistory_SelectAll]
as
SELECT [TestId]
      ,[UserID]
      ,[SubjectID]
      ,[TestDate]
      ,[CorrectAnswer]
      ,[TotalQuestion]
      ,[Mark]
      ,[CreatedBy]
      ,[CreatedAt]
      ,[ModifiedBy]
      ,[ModifiedAt]
  FROM [dbo].[TestHistory]

GO

/****** Object:  StoredProcedure [dbo].[UserAccount_ChangePassword]    Script Date: 06/11/2024 12:58:46 CH ******/
Create procedure [dbo].[UserAccount_ChangePassword]
@username varchar(50),
@newPassword varchar(50)
AS
begin
	update UserAccount
	set Password = @newPassword
	where Username = @username
end
GO

/****** Object:  StoredProcedure [dbo].[UserAccount_CheckExist]    Script Date: 06/11/2024 12:58:46 CH ******/
CREATE PROCEDURE [dbo].[UserAccount_CheckExist]
	@Username varchar(50),
	@Password varchar(50)
As
Begin
	Select UserID
	From UserAccount
	Where Username = @Username And Password = @Password
end

GO

/****** Object:  StoredProcedure [dbo].[UserAccount_Delete]    Script Date: 06/11/2024 12:58:46 CH ******/

create procedure [dbo].[UserAccount_Delete]
@UserId int
AS

DELETE FROM [dbo].[UserAccount]
where UserID = @UserId

GO

/****** Object:  StoredProcedure [dbo].[UserAccount_GetInforUser]    Script Date: 06/11/2024 12:58:46 CH ******/
create proc [dbo].[UserAccount_GetInforUser]
@Username nvarchar(200)
as
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
  where Username = @Username
GO

/****** Object:  StoredProcedure [dbo].[UserAccount_Insert]    Script Date: 06/11/2024 12:58:46 CH ******/
CREATE procedure [dbo].[UserAccount_Insert]
@RoleID varchar(50),
    @Username nvarchar(50),
    @Password varchar(50),
    @Fullname nvarchar(50),
    @Email varchar(50),
    @PhoneNumber varchar(50),
    @Address nvarchar(150),
    @Birthday datetime,
    @Note nvarchar(50),
	@Image image,
    @CreatedBy varchar(50),
    @ModifiedBy varchar(50)
AS
Begin
if(not exists (select * from UserAccount where Username = @Username))
INSERT INTO [dbo].[UserAccount]
           ([RoleID],
           [Username],
           [Password],
           [Fullname],
           [Email],
           [PhoneNumber],
           [Address],
           [Birthday],
           [Note],
		   [Image],
           [CreatedBy],
           [CreatedAt],
           [ModifiedBy],
           [ModifiedAt])
     VALUES
           (@RoleID,
           @Username,
           @Password,
           @Fullname,
           @Email,
           @PhoneNumber,
           @Address,
           @Birthday,
           @Note,
		   @Image,
           @CreatedBy,
		   GETDATE(),
           @ModifiedBy,
		   GETDATE())
end
GO

/****** Object:  StoredProcedure [dbo].[UserAccount_Search]    Script Date: 06/11/2024 12:58:46 CH ******/
CREATE procedure [dbo].[UserAccount_Search]
@Keyword nvarchar(200),
@RoleID varchar(50)
as
SELECT UserID
      ,RoleID
      ,Username
      ,Password
      ,Fullname
      ,Email
      ,PhoneNumber
      ,Address
      ,Birthday
      ,Note
	  ,Image
      ,CreatedBy
      ,CreatedAt
      ,ModifiedBy
      ,ModifiedAt
  FROM dbo.UserAccount
  WHERE 
(
    Username LIKE '%'+@Keyword+'%' 
    OR Fullname LIKE N'%'+@Keyword+'%'
    OR PhoneNumber LIKE '%'+@Keyword+'%'
    OR Email LIKE '%'+@Keyword+'%'
    OR Address LIKE N'%'+@Keyword+'%'
)
AND (@RoleID = 'all' OR RoleID = @RoleID)

GO

/****** Object:  StoredProcedure [dbo].[UserAccount_SelectAll]    Script Date: 06/11/2024 12:58:46 CH ******/
create procedure [dbo].[UserAccount_SelectAll]
as
SELECT UserID
      ,RoleID
      ,Username
      ,Password
      ,Fullname
      ,Email
      ,PhoneNumber
      ,Address
      ,Birthday
      ,Note
	  ,Image
      ,CreatedBy
      ,CreatedAt
      ,ModifiedBy
      ,ModifiedAt
  FROM dbo.UserAccount

GO

/****** Object:  StoredProcedure [dbo].[UserAccount_Update]    Script Date: 06/11/2024 12:58:46 CH ******/
Create procedure [dbo].[UserAccount_Update]
	@UserID int,
	@RoleID varchar(50),
    @Username nvarchar(50),
    @Password varchar(50),
    @Fullname nvarchar(50),
    @Email varchar(50),
    @PhoneNumber varchar(50),
    @Address nvarchar(150),
    @Birthday datetime,
    @Note nvarchar(50),
	@Image image,
    @ModifiedBy varchar(50)
AS
Begin
	UPDATE [dbo].[UserAccount]
   SET [RoleID] = @RoleID
      ,[Username] = @Username
      ,[Password] = @Password
      ,[Fullname] = @Fullname
      ,[Email] = @Email
      ,[PhoneNumber] = @PhoneNumber
      ,[Address] = @Address
      ,[Birthday] = @Birthday
      ,[Note] = @Note
	  ,[Image] = @Image
      ,[ModifiedBy] = @ModifiedBy
      ,[ModifiedAt] = GETDATE()
	  where UserID = @UserID
end


GO
/****** Object:  StoredProcedure [dbo].[UserRole_SelectAll]    Script Date: 06/11/2024 12:58:46 CH ******/
Create procedure [dbo].[UserRole_SelectAll]
As
SELECT [RoleID]
      ,[RoleName]
      ,[Description]
      ,[CreatedBy]
      ,[CreatedAt]
      ,[ModifiedBy]
      ,[ModifiedAt]
  FROM [dbo].[UserRole]

GO

CREATE PROCEDURE GetPasswordByEmail
    @Email NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Password
    FROM UserAccount
    WHERE Email = @Email;
END;
go

CREATE PROCEDURE CheckEmailExists
    @Email NVARCHAR(100)
AS
BEGIN
    SELECT CASE WHEN EXISTS (SELECT 1 FROM UserAccount WHERE Email = @Email) THEN 1 ELSE 0 END AS Exist
END
go
