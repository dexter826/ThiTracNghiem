# HỆ THỐNG THI TRẮC NGHIỆM

## Giới thiệu

Hệ thống Thi Trắc Nghiệm là một ứng dụng Windows Forms được phát triển trên nền tảng .NET Framework 4.8.1, cho phép tổ chức và quản lý các bài thi trắc nghiệm trực tuyến.  
Ứng dụng được thiết kế với ba vai trò chính:

- **Quản trị viên (Admin)**
- **Giáo viên (Teacher)**
- **Sinh viên (User)**

Mỗi vai trò có quyền truy cập và chức năng riêng biệt trong hệ thống, giúp quản lý quá trình thi một cách hiệu quả và minh bạch.

## Thông tin đồ án

- **Chủ sở hữu:** Trần Công Minh
- **Khoa:** Công nghệ thông tin (CNTT)
- **Trường:** Đại học Công Thương TP.HCM (HUIT)

## Tính năng chính

### Dành cho Sinh viên (User)

- Đăng nhập hệ thống với tài khoản được cấp
- Đăng ký tham gia kỳ thi
- Thực hiện bài thi trắc nghiệm với giao diện thân thiện
- Hỗ trợ phím tắt để chọn đáp án (A, B, C, D) và di chuyển giữa các câu hỏi
- Hiển thị thời gian làm bài còn lại theo thời gian thực
- Xem kết quả thi và đánh giá ngay sau khi hoàn thành bài thi
- Xem bảng xếp hạng điểm thi theo môn học

### Dành cho Giáo viên (Teacher)

- Quản lý danh sách môn học được phân công
- Tạo, sửa, xóa câu hỏi trắc nghiệm cho môn học
- Nhập câu hỏi từ file Excel
- Tạo đề thi với các tùy chọn về số lượng câu hỏi, thời gian làm bài
- Quản lý các đề thi đã tạo
- Xem báo cáo điểm thi theo môn học
- Xuất báo cáo điểm thi ra file PDF

### Dành cho Quản trị viên (Admin)

- Quản lý danh sách người dùng (thêm, sửa, xóa, phân quyền)
- Quản lý danh sách môn học (thêm, sửa, xóa, phân công giáo viên)
- Quản lý kỳ thi (lên lịch, phân công đề thi, đăng ký thí sinh)
- Duyệt đề thi do giáo viên tạo
- Xem thống kê kỳ thi theo nhiều tiêu chí
- Xuất báo cáo điểm thi theo môn học và khoảng thời gian
- In và xuất báo cáo dưới dạng PDF
- Sao lưu và phục hồi cơ sở dữ liệu

## Cấu trúc hệ thống

### Cấu trúc cơ sở dữ liệu

1. **UserRole**: Lưu trữ thông tin về vai trò người dùng trong hệ thống (Admin, Teacher, User)
2. **UserAccount**: Quản lý thông tin tài khoản người dùng, liên kết với UserRole
3. **Subject**: Quản lý thông tin về môn học
4. **Question**: Lưu trữ ngân hàng câu hỏi trắc nghiệm, liên kết với Subject
5. **Exam**: Quản lý đề thi với thông tin về thời gian, số lượng câu hỏi, tình trạng duyệt
6. **ExamQuestion**: Bảng liên kết giữa đề thi và các câu hỏi thuộc đề thi
7. **TeacherSubject**: Quản lý phân công giảng dạy, liên kết giáo viên với môn học
8. **ExamSession**: Quản lý kỳ thi với thông tin về thời gian bắt đầu, kết thúc, trạng thái
9. **ExamSessionDetail**: Liên kết kỳ thi với đề thi được sử dụng
10. **UserExamSession**: Quản lý thông tin đăng ký tham gia kỳ thi của sinh viên
11. **TestHistory**: Lưu trữ lịch sử và kết quả thi của sinh viên

### Quy trình hoạt động

1. **Tạo đề thi**:

   - Giáo viên tạo đề thi từ ngân hàng câu hỏi
   - Admin duyệt đề thi trước khi sử dụng
   - Đề thi có thể được tạo thủ công hoặc tự động từ ngân hàng câu hỏi

2. **Tổ chức kỳ thi**:

   - Admin tạo kỳ thi và gán đề thi vào kỳ thi
   - Sinh viên đăng ký tham gia kỳ thi
   - Hệ thống tự động cập nhật trạng thái kỳ thi theo thời gian thực

3. **Thực hiện bài thi**:

   - Sinh viên thực hiện bài thi trong thời gian quy định
   - Hệ thống giám sát thời gian và tự động nộp bài khi hết giờ
   - Kết quả được tính toán và hiển thị ngay sau khi hoàn thành bài thi

4. **Báo cáo và thống kê**:
   - Hệ thống tự động lưu trữ kết quả thi
   - Giáo viên và Admin có thể xem thống kê và xuất báo cáo
   - Hỗ trợ nhiều định dạng báo cáo khác nhau

## Yêu cầu hệ thống

- **Hệ điều hành:** Windows 7/8/10/11
- **.NET Framework:** 4.8.1 trở lên
- **Cơ sở dữ liệu:** Microsoft SQL Server 2014 trở lên
- **Dung lượng ổ đĩa:** Ít nhất 500MB
- **RAM:** Ít nhất 4GB
- **Thư viện bổ sung:** DevExpress, Guna.UI2, DevComponents.DotNetBar2

## Hướng dẫn cài đặt

1. Tải xuống và giải nén tệp cài đặt
2. Chạy tệp `setup.exe` để bắt đầu quá trình cài đặt
3. Làm theo các bước hướng dẫn trên màn hình
4. Cấu hình kết nối cơ sở dữ liệu:
   - Mở tệp cấu hình `App.config` trong thư mục cài đặt
   - Cập nhật chuỗi kết nối đến SQL Server của bạn trong thẻ `<connectionStrings>`
5. Chạy script cơ sở dữ liệu (nằm trong thư mục `Database/QL_ThiTracNghiem.sql`) để tạo cơ sở dữ liệu và dữ liệu ban đầu
6. Khởi động ứng dụng và đăng nhập với tài khoản mặc định:
   - **Admin:** `admin/123`
   - **Giáo viên:** `teacher/123`
   - **Sinh viên:** `2001222641/123`

## Kiến trúc hệ thống

Ứng dụng được xây dựng theo mô hình ba tầng:

1. **Tầng trình bày (Presentation Layer):**

   - Windows Forms với giao diện hiện đại, thân thiện
   - Tích hợp thư viện UI hiệu năng cao: DevExpress UI, Guna.UI2, DevComponents.DotNetBar2
   - Hỗ trợ đa ngôn ngữ (Tiếng Việt, Tiếng Anh)
   - Thiết kế responsive cho các màn hình khác nhau

2. **Tầng logic nghiệp vụ (Business Logic Layer):**

   - Xử lý logic nghiệp vụ tách biệt với giao diện
   - Kiểm tra tính hợp lệ của dữ liệu
   - Triển khai các quy tắc nghiệp vụ theo từng chức năng
   - Xử lý quá trình thi, tính điểm, thống kê

3. **Tầng truy cập dữ liệu (Data Access Layer):**
   - Tương tác với cơ sở dữ liệu thông qua ADO.NET
   - Cung cấp các phương thức CRUD chuẩn hóa
   - Sử dụng Stored Procedures để tối ưu hiệu suất
   - Xử lý các truy vấn phức tạp, báo cáo thống kê

## Công nghệ sử dụng

- **Ngôn ngữ lập trình:** C# 7.3
- **Nền tảng:** .NET Framework 4.8.1
- **Thư viện UI/UX:**
  - DevExpress v22.2.3 (Forms, Reports, Charts)
  - Guna.UI2 v2.0.4.4
  - DevComponents.DotNetBar2 v14.1.0.37
- **Cơ sở dữ liệu:** Microsoft SQL Server 2014+
- **Báo cáo:**
  - Microsoft Reporting Services
  - DevExpress Reports
  - Xuất báo cáo đa định dạng: PDF, Excel, Word
- **Công cụ phát triển:** Visual Studio 2022
- **Thư viện bổ sung:**
  - EPPlus 6.0 (xử lý file Excel)
  - SQLHelper (tối ưu truy vấn dữ liệu)
  - iTextSharp (xử lý file PDF)

## Tính năng bảo mật

1. **Xác thực người dùng:**

   - Đăng nhập bảo mật với nhiều cấp độ quyền
   - Mã hóa mật khẩu người dùng
   - Kiểm soát phiên làm việc

2. **Quản lý quyền truy cập:**

   - Phân quyền chi tiết theo từng chức năng
   - Giới hạn quyền truy cập dựa trên vai trò

3. **Bảo mật dữ liệu:**
   - Lưu trữ dữ liệu an toàn
   - Sao lưu và phục hồi dữ liệu
   - Mã hóa thông tin nhạy cảm

## Các loại báo cáo

Hệ thống cung cấp các loại báo cáo đa dạng:

1. **Báo cáo điểm thi:**

   - Theo môn học
   - Theo khoảng thời gian
   - Theo sinh viên

2. **Báo cáo thống kê:**

   - Tỷ lệ đậu/rớt theo môn học
   - Điểm trung bình theo môn học
   - Phân bố điểm số
   - Đánh giá độ khó của đề thi

3. **Báo cáo quản trị:**

   - Số lượng kỳ thi đã tổ chức
   - Số lượng sinh viên tham gia
   - Thống kê hoạt động hệ thống

4. **Định dạng xuất báo cáo:**
   - PDF (có thể in trực tiếp)
   - Excel (để phân tích dữ liệu)
   - Word (để chỉnh sửa và tùy biến)

## Hướng dẫn sử dụng

### Quản trị viên (Admin)

1. **Quản lý người dùng:**

   - Vào menu "Hệ thống" > "Quản lý người dùng"
   - Thêm, sửa, xóa người dùng, phân quyền vai trò

2. **Quản lý môn học:**

   - Vào menu "Quản lý" > "Quản lý môn học"
   - Thêm, sửa, xóa môn học, phân công giáo viên giảng dạy

3. **Quản lý kỳ thi:**

   - Vào menu "Quản lý" > "Quản lý kỳ thi"
   - Tạo kỳ thi mới, chỉ định đề thi sử dụng, quản lý trạng thái kỳ thi

4. **Duyệt đề thi:**

   - Vào menu "Quản lý" > "Duyệt đề thi"
   - Xem chi tiết và phê duyệt các đề thi do giáo viên tạo

5. **Sao lưu dữ liệu:**
   - Vào menu "Hệ thống" > "Sao lưu dữ liệu"
   - Tạo bản sao lưu cơ sở dữ liệu, khôi phục từ bản sao lưu

### Giáo viên (Teacher)

1. **Quản lý câu hỏi:**

   - Vào menu "Quản lý" > "Quản lý câu hỏi"
   - Thêm, sửa, xóa câu hỏi cho môn học được phân công
   - Nhập câu hỏi từ file Excel với mẫu định dạng có sẵn

2. **Tạo đề thi:**

   - Vào menu "Quản lý" > "Tạo đề thi mới"
   - Chọn môn học, số lượng câu hỏi, thời gian làm bài
   - Chọn câu hỏi từ ngân hàng hoặc để hệ thống tự động chọn ngẫu nhiên

3. **Xem báo cáo:**
   - Vào menu "Báo cáo" > "Báo cáo điểm theo môn học"
   - Chọn môn học và xem thống kê điểm số

### Sinh viên (User)

1. **Tham gia kỳ thi:**

   - Vào menu "Kỳ thi" > "Đăng ký kỳ thi"
   - Chọn kỳ thi muốn tham gia từ danh sách các kỳ thi hiện có

2. **Làm bài thi:**

   - Vào menu "Kỳ thi" > "Kỳ thi đã đăng ký"
   - Chọn kỳ thi và bắt đầu làm bài trong thời gian quy định
   - Sử dụng các phím tắt: A, B, C, D để chọn đáp án, mũi tên trái/phải để di chuyển giữa các câu

3. **Xem kết quả:**

   - Sau khi hoàn thành bài thi, kết quả sẽ hiển thị ngay
   - Vào menu "Kỳ thi" > "Lịch sử thi" để xem lại kết quả các bài thi đã làm

4. **Xem bảng xếp hạng:**
   - Vào menu "Kỳ thi" > "Bảng xếp hạng" để xem thứ hạng điểm thi theo môn học

## Tính năng nổi bật

1. **Giao diện người dùng thân thiện:**

   - Thiết kế hiện đại, dễ sử dụng
   - Hỗ trợ phím tắt để thao tác nhanh
   - Hỗ trợ các tùy chọn hiển thị theo sở thích người dùng

2. **Hệ thống tự động:**

   - Tự động cập nhật trạng thái kỳ thi theo thời gian thực
   - Tự động chấm điểm và hiển thị kết quả ngay sau khi hoàn thành bài thi
   - Tự động sắp xếp bảng xếp hạng điểm thi

3. **Bảo mật và ổn định:**

   - Xác thực người dùng an toàn
   - Bảo vệ dữ liệu bài thi và kết quả
   - Khả năng phục hồi khi gặp sự cố

4. **Hiệu suất cao:**
   - Thời gian phản hồi nhanh
   - Tối ưu hóa việc truy xuất dữ liệu
   - Hỗ trợ nhiều người dùng đồng thời

## Liên hệ và hỗ trợ

- **Email:** tcongminh1604@gmail.com
- **Điện thoại:** (+84) 777999496
- **GitHub:** [github.com/tcongminh](https://github.com/dexter826)

## Đóng góp

Mọi đóng góp cho dự án đều được đánh giá cao.  
Nếu bạn muốn đóng góp, vui lòng:

1. Fork dự án
2. Tạo nhánh tính năng mới (`git checkout -b feature/AmazingFeature`)
3. Commit thay đổi của bạn (`git commit -m 'Add some AmazingFeature'`)
4. Push lên nhánh của bạn (`git push origin feature/AmazingFeature`)
5. Tạo Pull Request mới

## Giấy phép

Dự án này được phát hành theo giấy phép MIT.  
Xem tệp `LICENSE` để biết thêm chi tiết.

---

© 2025 Hệ thống Thi Trắc Nghiệm. Bản quyền thuộc sinh viên Trần Công Minh, khoa CNTT, Đại học Công Thương TP.HCM.
