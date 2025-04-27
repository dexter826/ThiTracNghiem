# HỆ THỐNG THI TRẮC NGHIỆM

## Giới thiệu
Hệ thống Thi Trắc Nghiệm là một ứng dụng Windows Forms được phát triển trên nền tảng .NET Framework 4.8.1, cho phép tổ chức và quản lý các bài thi trắc nghiệm.  
Ứng dụng được thiết kế với hai vai trò chính:
- **Người quản trị (Admin)**
- **Người dùng thông thường (User)**

Mỗi vai trò có quyền truy cập vào các chức năng khác nhau của hệ thống.

## Thông tin đồ án
- **Chủ sở hữu:** Trần Công Minh
- **Khoa:** Công nghệ thông tin (CNTT)
- **Trường:** Đại học Công Thương TP.HCM (HUIT)

## Tính năng chính

### Dành cho Người dùng (User)
- Đăng nhập hệ thống với tài khoản được cấp
- Thực hiện bài thi trắc nghiệm
- Xem kết quả thi ngay sau khi hoàn thành bài thi
- Xem bảng xếp hạng điểm thi

### Dành cho Quản trị viên (Admin)
- Quản lý danh sách người dùng
- Quản lý danh sách môn thi
- Quản lý các câu hỏi và đáp án
- Xuất báo cáo điểm thi theo môn học
- Xuất báo cáo điểm thi theo khoảng thời gian
- In và xuất báo cáo dưới dạng PDF
- Sao lưu cơ sở dữ liệu

## Yêu cầu hệ thống
- **Hệ điều hành:** Windows 7/8/10/11
- **.NET Framework:** 4.8.1 trở lên
- **Cơ sở dữ liệu:** Microsoft SQL Server 2014 trở lên
- **Dung lượng ổ đĩa:** Ít nhất 500MB
- **RAM:** Ít nhất 4GB

## Hướng dẫn cài đặt
1. Tải xuống và giải nén tệp cài đặt
2. Chạy tệp `setup.exe` để bắt đầu quá trình cài đặt
3. Làm theo các bước hướng dẫn trên màn hình
4. Cấu hình kết nối cơ sở dữ liệu:
   - Mở tệp cấu hình `App.config`
   - Cập nhật chuỗi kết nối đến SQL Server của bạn
5. Chạy script cơ sở dữ liệu (nằm trong thư mục `Database`) để tạo cơ sở dữ liệu và dữ liệu ban đầu
6. Khởi động ứng dụng và đăng nhập với tài khoản mặc định:
   - **Admin:** `admin/admin123`
   - **User:** `user/user123`

## Kiến trúc hệ thống
Ứng dụng được xây dựng theo mô hình ba tầng:
1. **Tầng trình bày (Presentation Layer):** Windows Forms, DevExpress UI
2. **Tầng logic nghiệp vụ (Business Logic Layer):** Xử lý logic nghiệp vụ
3. **Tầng truy cập dữ liệu (Data Access Layer):** Tương tác với cơ sở dữ liệu

## Công nghệ sử dụng
- **Ngôn ngữ lập trình:** C#
- **Nền tảng:** .NET Framework 4.8.1
- **Thư viện UI/UX:** DevExpress
- **Cơ sở dữ liệu:** SQL Server
- **ORM:** Entity Framework

## Các báo cáo
Hệ thống cung cấp các loại báo cáo:
1. Báo cáo điểm thi theo môn học
2. Báo cáo điểm thi theo khoảng thời gian
3. Xuất báo cáo dưới dạng PDF

## Liên hệ và hỗ trợ
- **Email:** tcongminh1604@gmail.com
- **Điện thoại:** (+84) 777999496

## Đóng góp
Mọi đóng góp cho dự án đều được đánh giá cao.  
Nếu bạn muốn đóng góp, vui lòng tạo pull request hoặc báo cáo các vấn đề qua mục Issues trên GitHub.

## Giấy phép
Dự án này được phát hành theo giấy phép MIT.  
Xem tệp `LICENSE` để biết thêm chi tiết.

---
© 2025 Hệ thống Thi Trắc Nghiệm. Bản quyền thuộc sinh viên Trần Công Minh, khoa CNTT, Đại học Công Thương TP.HCM.
