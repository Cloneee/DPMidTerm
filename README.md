# Drink & Chill server API

## Giới thiệu

Project này là một web server API, cho phép người dùng đặt món và thêm topping vói các option khác nhau, khách hàng có thể lựa chọn giữa việc tự pha chế cho mình một ly nước hoặc gọi một ly theo công thức có sẵn (áp dụng template pattern). Một số chức năng chính:

- Đăng nhập
- Đăng ký
- Xác thực quyền người dùng
- Thêm xóa sửa data
- Đặt hàng online
- Lưu trữ dữ liệu vào Database bằng entity framework

## Yêu cầu

- ASP.Net 6
- MSSQL

## Cách khởi chạy

1. Clone project
2. Mở terminal và đến thư mục DP-Midterm (Nơi chứa các folder như Controllers, Data, Functions, Models,...)
3. Chạy các lệnh sau

```bash
dotnet ef database update
dotnet watch
```

## Kiến thức về pattern

Project này áp dụng các design pattern sau:

- Factory method
- Template method

### Factory method

- Factory method là một design pattern khởi tạo

### Template method templates

- Template Method Pattern là một trong những Pattern thuộc nhóm hành vi (Behavior Pattern). Pattern này nói rằng “Định nghĩa một bộ khung của một thuật toán trong một chức năng, chuyển giao việc thực hiện nó cho các lớp con. Mẫu Template Method cho phép lớp con định nghĩa lại cách thực hiện của một thuật toán, mà không phải thay đổi cấu trúc thuật toán“.
- Điều này có nghĩa là Template method giúp cho chúng ta tạo nên một bộ khung (template) cho một vấn đề đang cần giải quyết. Trong đó các đối tượng cụ thể sẽ có cùng các bước thực hiện, nhưng trong mỗi bước thực hiện đó có thể khác nhau. Điều này sẽ tạo nên một cách thức truy cập giống nhau nhưng có hành động và kết quả khác nhau.
- Trong project này, ta sử dụng template method để tạo ra sản phẩm là một ly nước dựa trên các thành phần có sẵn trong db.

## Chi tiết thông tin ứng dụng

[placeholder](https://google.com)

## Thông tin người phát triển

Nguyễn Thanh Huy - 51800781
