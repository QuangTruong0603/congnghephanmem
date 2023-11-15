use seven_eleven
INSERT INTO PaymentMethod (paymentmethod_name) 
VALUES (N'Tiền mặt'),
(N'Chuyển khoản ngân hàng'),
(N'momo'),
(N'Zalo pay'),
(N'VN pay');

--

INSERT INTO Category (cate_id,cate_name) 
VALUES (1,N'Nước ngọt không có ga'),
(2,N'Nước ngọt có ga'),
(3,N'Nước lọc'),
(4,N'Bánh snack'),
(5,N'Bánh mì ngọt');


--
INSERT INTO Unit (unit_name) 
VALUES (N'chai'),
(N'hộp'),
(N'kg'),
(N'gam'),
(N'túi'),
(N'cái'),
(N'lít'),
(N'gói'),(N'lon');

--
INSERT INTO StaffType (stafftype_name) 
VALUES (N'Nhân viên bán hàng'),
(N'Thu ngân'),
(N'Lao công'),
(N'Quản lí kho'),
(N'Quản lí cửa hàng');

-- Thêm các loại nhân viên khác nếu cần

INSERT INTO Supplier (supplier_name, supplier_address, supplier_email, supplier_phone, supplier_image) 
VALUES ('cocacola', N'Xa lộ Hà Nội, Phường Linh Trung, Quận Thủ Đức, Thành phố Hồ Chí Minh, Việt Nam', 'trucle@coca-cola.com', '19005555', 'image1.jpg'),
('Pepsi', N'Địa chỉ Pepsi', 'email@pepsi.com', '1234567890', 'pepsi.jpg'),
('Sprite', N'Địa chỉ Sprite', 'email@sprite.com', '555-55555', 'sprite.jpg'),
('Fanta', N'Địa chỉ Fanta', 'email@fanta.com', '987654321', 'fanta.jpg'),
('Frito-Lay', N'789 Oak Lane, Chicago, USA', 'sales@fritolay.com', '188855567', 'fritolay.jpg'),
('Nestlé', N'101 Chestnut Road, London, UK', 'info@nestle.com', '442023456', 'nestle.jpg'),
('Lays',N'Địa chỉ lays','email@lays.com','0123456789','lays.jpg'),
('Maggi', N'Địa chỉ Maggi', 'email@maggi.com', '7776665555', 'maggi.jpg'),
('Top Ramen', N'Địa chỉ Top Ramen', 'email@topramen.com', '8887776666', 'topramen.jpg');
-- Thêm các nhà cung cấp khác nếu cần


INSERT INTO Customer (customer_name, customer_address, customer_email, customer_phone, customer_tichdiem, customer_image)
VALUES (N'Quang Trường', N'Nhà Bè', 'tranhuuquangtruong2003@gmail.com', '1234567890', 0, 'image1.jpg'),

    (N'Hoàng Đắc Bình', N'Nhà Bè', 'hoangbacbinh@gmail.com', '1234567890', 1, 'image1.jpg'),
    (N'Lê Văn Cường', N'Quận 7', 'levancuong@gmail.com', '0987654321', 2, 'image2.jpg'),
    (N'Trần Quang Đãng', N'Quận 12', 'trandang@gmail.com', '0123456789', 3, 'image3.jpg'),
    (N'Nguyễn Trọng Đạt', N'Quận 3', 'nguyendat@gmail.com', '0987123456', 4, 'image4.jpg'),
    (N'Phạm Tiến Đạt', N'Quận 5', 'phamdat@gmail.com', '0909090909', 5, 'image5.jpg'),
    (N'Lê Gia Điền', N'Quận 10', 'ledien@gmail.com', '0123456789', 6, 'image6.jpg'),
    (N'Nguyễn Thị Mỹ Hân', N'Quận 2', 'myhan@gmail.com', '0909090909', 7, 'image7.jpg'),
    (N'Nguyễn Khánh Huân', N'Quận Thủ Đức', 'khanhhuan@gmail.com', '0123456789', 8, 'image8.jpg'),
    (N'Trương Thái Đan Huy', N'Quận 4', 'danhuynh@gmail.com', '0909090909', 9, 'image9.jpg'),
    (N'Kiều Ngọc Như Huỳnh', N'Quận 1', 'ngochuynh@gmail.com', '0123456789', 10, 'image10.jpg'),
    (N'Võ Đạt Công Khanh', N'Quận 11', 'datkhanh@gmail.com', '0909090909', 11, 'image11.jpg'),
    (N'Trần Nam Đăng Khoa', N'Quận 6', 'dangkhoa@gmail.com', '0123456789', 12, 'image12.jpg'),
    (N'Phan Đăng Khôi', N'Quận Bình Tân', 'dangkhoi@gmail.com', '0909090909', 13, 'image13.jpg'),
    (N'Nguyễn Tuấn Kiệt', N'Quận Tân Bình', 'tuan_kiet@gmail.com', '0123456789', 14, 'image14.jpg'),
    (N'Triệu Gia Kỳ', N'Quận Gò Vấp', 'giaky@gmail.com', '0909090909', 15, 'image15.jpg'),
    (N'Đặng Quốc Lộc', N'Quận Tân Phú', 'quocloc@gmail.com', '0123456789', 16, 'image16.jpg'),
    (N'Trần Quang Luân', N'Quận 8', 'quanluan@gmail.com', '0909090909', 17, 'image17.jpg'),
    (N'Dương Hải Minh', N'Quận 9', 'haiminh@gmail.com', '0123456789', 18, 'image18.jpg'),
    (N'Đinh Thanh Phát', N'Quận Bình Thạnh', 'thanhphat@gmail.com', '0909090909', 19, 'image19.jpg'),
    (N'Đinh Hoàng Phúc', N'Quận Phú Nhuận', 'hoangphuc@gmail.com', '0123456789', 20, 'image20.jpg'),
    (N'Nguyễn Nhật Quang', N'Quận Bình Chánh', 'nhatquang@gmail.com', '0909090909', 1, 'image21.jpg'),
    (N'Trần Nhựt Quang', N'Quận Cần Giờ', 'nhutquang@gmail.com', '0123456789', 2, 'image22.jpg');

select * from Customer

-- Thêm các khách hàng khác nếu cần


INSERT INTO Role (role_name) VALUES ('Admin'),
('Employee'),
('Manager'),
('Customer'),
('Supervisor'),
('Vendor');
-- Thêm các vai trò khác nếu cần

INSERT INTO Staff (username, password, staff_name, staff_birthday, staff_phone, staff_address, staff_email, staff_gender, staff_start, staff_end, staff_image, stafftype_id)
VALUES ('Username1', 'Password1', 'Staff1', '2000-01-01', '1234567890', 'Address1', 'staff1@email.com', 'Male', '2023-09-27', '2023-09-27', 'image1.jpg', 1),
('Phan Trần Nhật Việt', '2000-01-01', '1234567890', 'Address1', 'viet@example.com', 'Male', '2023-01-01', '2023-12-31', 'image1.jpg', 2, 'viet', 'password1'),
('Nguyễn Thị Ngọc Hương', '1995-02-15', '9876543210', 'Address2', 'huong@example.com', 'Female', '2023-02-01', '2023-12-31', 'image2.jpg', 2, 'huong', 'password2'),
('Nguyễn Thị Thu Trang', '1993-03-10', '1111111111', 'Address3', 'trang@example.com', 'Female', '2023-03-01', '2023-12-31', 'image3.jpg', 2, 'trang', 'password3'),
('Nguyễn Phương Nhu', '1997-04-20', '2222222222', 'Address4', 'nhu@example.com', 'Female', '2023-04-01', '2023-12-31', 'image4.jpg', 2, 'nhu', 'password4'),
('Hoàng Thị Viên', '1992-05-25', '3333333333', 'Address5', 'vien@example.com', 'Female', '2023-05-01', '2023-12-31', 'image5.jpg', 2, 'vien', 'password5'),
('Cao Thị Linh', '1994-06-30', '4444444444', 'Address6', 'linh@example.com', 'Female', '2023-06-01', '2023-12-31', 'image6.jpg', 2, 'linh', 'password6'),
('Nguyễn Thị Kim Trang', '1991-07-05', '5555555555', 'Address7', 'kimtrang@example.com', 'Female', '2023-07-01', '2023-12-31', 'image7.jpg', 2, 'kimtrang', 'password7'),
('Trần Thị Thúy Vi', '1996-08-10', '6666666666', 'Address8', 'thuyvi@example.com', 'Female', '2023-08-01', '2023-12-31', 'image8.jpg', 2, 'thuyvi', 'password8'),
('Hồ Đăng Tiến Đạt', '1989-09-15', '7777777777', 'Address9', 'dat@example.com', 'Male', '2023-09-01', '2023-12-31', 'image9.jpg', 2, 'dat', 'password9'),
('Phan Thị Lợi', '1998-10-20', '8888888888', 'Address10', 'loi@example.com', 'Female', '2023-10-01', '2023-12-31', 'image10.jpg', 2, 'loi', 'password10'),
('Ngô Đức Ý', '1990-11-25', '9999999999', 'Address11', 'y@example.com', 'Male', '2023-11-01', '2023-12-31', 'image11.jpg', 2, 'y', 'password11'),
('Phạm Thị Như Ý', '1997-12-30', '1010101010', 'Address12', 'nhuy@example.com', 'Female', '2023-12-01', '2023-12-31', 'image12.jpg', 2, 'nhuy', 'password12'),
('Phạm Thị Lựu', '1993-01-05', '1111111111', 'Address13', 'luu@example.com', 'Female', '2024-01-01', '2024-12-31', 'image13.jpg', 2, 'luu', 'password13'),
('Tô Đông Trung', '1995-02-10', '1212121212', 'Address14', 'trung@example.com', 'Male', '2024-02-01', '2024-12-31', 'image14.jpg', 2, 'trung', 'password14'),
('Lê Thị Thùy Diên', '1991-03-15', '1313131313', 'Address15', 'dien@example.com', 'Female', '2024-03-01', '2024-12-31', 'image15.jpg', 2, 'dien', 'password15'),
('Vương Hưng Đạt', '1998-04-20', '1414141414', 'Address16', 'datvuong@example.com', 'Male', '2024-04-01', '2024-12-31', 'image16.jpg', 2, 'datvuong', 'password16'),
('Đinh Viết Đạt', '1992-05-25', '1515151515', 'Address17', 'datdin@example.com', 'Male', '2024-05-01', '2024-12-31', 'image17.jpg', 2, 'datdin', 'password17'),
('Dương Thị Trà My', '1996-06-30', '1616161616', 'Address18', 'tramy@example.com', 'Female', '2024-06-01', '2024-12-31', 'image18.jpg', 2, 'tramy', 'password18'),
('Dương Thị Ái Diễm', '1994-07-05', '1717171717', 'Address19', 'aidiem@example.com', 'Female', '2024-07-01', '2024-12-31', 'image19.jpg', 2, 'aidiem', 'password19'),
('Nguyễn Võ Hùng Đài', '1999-08-10', '1818181818', 'Address20', 'dai@example.com', 'Male', '2024-08-01', '2024-12-31', 'image20.jpg', 2, 'dai', 'password20'),
('Võ Hữu Chờ', '1993-09-15', '1919191919', 'Address21', 'cho@example.com', 'Male', '2024-09-01', '2024-12-31', 'image21.jpg', 2, 'cho', 'password21');
-- Thêm các nhân viên khác nếu cần

--StaffRelative
INSERT INTO StaffRelatives (staffrelatives_name, staffrelatives_address, staffrelatives_phone, staffrelatives_info, username)
VALUES
(N'Trần Văn A', 'Relative Address 1', '1234567890', 'Info1', 'dai'),
(N'Nguyễn Văn B', 'Relative Address 2', '9876543210', 'Info2', 'viet');


--Bill
INSERT INTO Bill (bill_no, bill_date, bill_total_before, bill_total_after, paymentmethod_id, customer_id, username)
VALUES
('B003', '2023-10-01', 15000, 14000, 3, 1, 'vien'),
('B004', '2023-10-02', 50000, 50000, 4, 2, 'nhu');

--Staffrole
INSERT INTO Staff_Role (username, role_id)
VALUES ('vien', 1),
('nhu',2),
('dat',3);


--Shift

INSERT INTO Shift (shift_start, shift_end, username, shiftdetail_id)
VALUES
('2023-10-01 08:00:00', '2023-10-01 16:00:00', 'nhu', 1),
('2023-10-02 08:00:00', '2023-10-02 16:00:00', 'dai', 2);


--ShiftDetail

INSERT INTO ShiftDetail (shiftdetail_onshift, shiftdetail_closeshift, shiftdetail_start, shiftdetail_end, shiftdetail_note, shift_id)
VALUES
('08:00:00', '16:00:00', '2023-10-01 08:00:00', '2023-10-01 16:00:00', 'Note1', 3),
('08:00:00', '16:00:00', '2023-10-02 08:00:00', '2023-10-02 16:00:00', 'Note2', 4);


--Tich diem

INSERT INTO Tich_diem (history_datetime, history_diem, customer_id)
VALUES
('2023-10-01 10:00:00', 10, 1),
('2023-10-02 11:00:00', 20, 2);

--Discount code
INSERT INTO DiscountCode (code_exp, code_price, code_status, code_string)
VALUES
('2023-12-31', 10, 1, 'DISC10'),
('2023-12-31', 20, 1, 'DISC20');



select * from Category
--Inventory
INSERT INTO Inventory (inven_quantity, inven_latest_date, inven_update_quantity)
VALUES 
(100, '2023-09-27', 0),
(150, '2023-09-28', 10),
(200, '2023-09-29', 5),
(75, '2023-09-30', 8),
(300, '2023-10-01', 15);

-- Thêm các thông tin kho hàng khác nếu cần

--Product

INSERT INTO Product (product_name, product_barcode, product_price,product_status,unit_id, cate_id, inven_id,product_image)
VALUES 
(N'Trà xanh C2 hương chanh 360ml', '8934564600128', 10000,1, 1, 1,1, 'tra-xanh-c2-huong-chanh-360ml.jpg'),
(N'Nước tăng lực Sting hương dâu 330ml', '3128554', 12000,1, 1, 2,2, 'nuoc-tang-luc-sting-huong-dau-330ml.jpg'),
(N'Trà ô long Tea Plus 320ml', '8934588873119', 10000, 1, 1, 1, 3,'tra-o-long-tea-plus-320ml.jpg')

select * from unit
select * from Category

delete from Product where product_id = 15
select * from product

INSERT INTO Consignment (consi_date, consi_quantity_product, consi_mgfdate, consi_expdate, consi_price_one_product, consi_total, product_id, supplier_id, username)
VALUES ('2023-09-27', 100, '2023-09-27', '2023-09-27', 50, 5000, 1, 1, 'cho');
-- Thêm các phiếu nhập khác nếu cần


--Discount
INSERT INTO Discount (discount_start, discount_end, discount_percent, product_id)
VALUES
('2023-10-01', '2023-10-31', 10, 4),
('2023-10-15', '2023-10-31', 20, 5),
('2023-11-01', '2023-11-30', 15, 6),
('2023-11-15', '2023-11-30', 25, 4),
('2023-12-01', '2023-12-31', 12, 5),
('2023-12-15', '2023-12-31', 22, 6),
('2024-01-01', '2024-01-31', 18, 7),
('2024-01-15', '2024-01-31', 28, 8),
('2024-02-01', '2024-02-29', 14, 9),
('2024-02-15', '2024-02-29', 24, 10);


--order online

insert into OrderOnline (customer_id,order_name,order_address,order_phone,order_status,order_total_before,order_total_after,order_paycheck,order_date) 
		values(1,N'Nguyễn Thái Nam',N'24 Nguyễn Chí Thanh, P9, Q5, TPHCM','0909786543',N'Đang vận chuyển',120000,150000,N'Đã thanh toán','2023-11-04 10:56:09')

insert into OrderOnline (customer_id,order_name,order_address,order_phone,order_status,order_total_before,order_total_after,order_paycheck,order_date) 
		values(2,N'Lê Nguyễn Minh Thư',N'110 Nguyễn Thị Thập, P. Tân Quy, Q7, TPHCM','0912722543',N'Đang giao cho khách hàng',100000,120000,N'Đã thanh toán','2023-11-01 12:12:09')


insert into OrderOnline (customer_id,order_name,order_address,order_phone,order_status,order_total_before,order_total_after,order_paycheck,order_date) 
		values(1,N'Nguyễn Thái Minh',N'24 Nguyễn Chí Thanh, P9, Q5, TPHCM','0909786543',N'Chờ lấy hàng',120000,150000,N'Đã thanh toán','2023-08-12 09:56:09')

insert into OrderOnline (customer_id,order_name,order_address,order_phone,order_status,order_total_before,order_total_after,order_paycheck,order_date) 
		values(2,N'Trần Lê Phương Ngọc',N'610 Lê Văn Lương, P. Tân Phong, Q7, TPHCM','0909786543',N'Đã giao thành công',100000,150000,N'Đã thanh toán','2023-10-12 12:56:09')



--orderdetail

insert into OrderDetail(order_id, product_id,quantity, size, price) values (7,8,6,'null',120000)

insert into OrderDetail(order_id, product_id,quantity, size, price) values (8,9,5,'null',100000)



insert into OrderDetail(order_id, product_id,quantity, size, price) values (9,8,6,'null',120000)



insert into OrderDetail(order_id, product_id,quantity, size, price) values (11,8,5,'null',100000)


insert into OrderDetail(order_id, product_id,quantity, size, price) values (10,8,4,'null',80000)

insert into OrderDetail(order_id, product_id,quantity, size, price) values (10,9,1,'null',20000)
