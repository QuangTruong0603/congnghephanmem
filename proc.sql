﻿use seven_eleven
go
--StaffType
CREATE PROCEDURE Insert_StaffType 
	@stafftype_name NVARCHAR(50)
AS
BEGIN
    INSERT INTO StaffType (stafftype_name) VALUES (@stafftype_name)
END
GO
--delete
CREATE PROCEDURE Delete_StaffType
    @stafftype_id INT
AS
BEGIN
    DELETE FROM StaffType
    WHERE stafftype_id = @stafftype_id
END
GO
--update

CREATE PROCEDURE Update_StaffType
    @stafftype_id INT,
    @new_stafftype_name NVARCHAR(50)
AS
BEGIN
    
    UPDATE StaffType
    SET stafftype_name = @new_stafftype_name
    WHERE stafftype_id = @stafftype_id
END
go



go

go
 --Category
-- Thêm dữ liệu vào bảng Category
CREATE PROCEDURE Insert_Category 
	@cate_name NVARCHAR(50)
AS
BEGIN
    INSERT INTO Category (cate_name) VALUES (@cate_name)
END
GO

-- Xóa dữ liệu từ bảng Category
CREATE PROCEDURE Delete_Category
    @cate_id INT
AS
BEGIN
    DELETE FROM Category
    WHERE cate_id = @cate_id
END
GO

-- Sửa dữ liệu trong bảng Category
CREATE PROCEDURE Update_Category
    @cate_id INT,
    @new_cate_name NVARCHAR(50)
AS
BEGIN
    UPDATE Category
    SET cate_name = @new_cate_name
    WHERE cate_id = @cate_id
END
GO



--PaymentMethods
-- Thêm dữ liệu vào bảng PaymentMethod
CREATE PROCEDURE Insert_PaymentMethod 
	@paymentmethod_name NVARCHAR(30)
AS
BEGIN
    INSERT INTO PaymentMethod (paymentmethod_name) VALUES (@paymentmethod_name)
END
GO

-- Xóa dữ liệu từ bảng PaymentMethod
CREATE PROCEDURE Delete_PaymentMethod
    @paymentmethod_id INT
AS
BEGIN
    DELETE FROM PaymentMethod
    WHERE paymentmethod_id = @paymentmethod_id
END
GO

-- Sửa dữ liệu trong bảng PaymentMethod
CREATE PROCEDURE Update_PaymentMethod
    @paymentmethod_id INT,
    @new_paymentmethod_name NVARCHAR(30)
AS
BEGIN
    UPDATE PaymentMethod
    SET paymentmethod_name = @new_paymentmethod_name
    WHERE paymentmethod_id = @paymentmethod_id
END
GO

-- Thêm dữ liệu vào bảng Unit
CREATE PROCEDURE Insert_Unit 
	@unit_name NVARCHAR(20)
AS
BEGIN
    INSERT INTO Unit (unit_name) VALUES (@unit_name)
END
GO

-- Xóa dữ liệu từ bảng Unit
CREATE PROCEDURE Delete_Unit
    @unit_id INT
AS
BEGIN
    DELETE FROM Unit
    WHERE unit_id = @unit_id
END
GO

-- Sửa dữ liệu trong bảng Unit
CREATE PROCEDURE Update_Unit
    @unit_id INT,
    @new_unit_name NVARCHAR(20)
AS
BEGIN
    UPDATE Unit
    SET unit_name = @new_unit_name
    WHERE unit_id = @unit_id
END
GO


--Discount

--Thêm
CREATE PROCEDURE Insert_Discount 
	@discount_start DATE,
	@discount_end DATE,
	@discount_percent INT,
	@product_id BIGINT
AS
BEGIN
    INSERT INTO Discount (discount_start, discount_end, discount_percent, product_id)
    VALUES (@discount_start, @discount_end, @discount_percent, @product_id)
END
go
 -- Xóa
CREATE PROCEDURE Delete_Discount
    @discount_id BIGINT
AS
BEGIN
    DELETE FROM Discount
    WHERE discount_id = @discount_id
END
go
--Sửa
CREATE PROCEDURE Update_Discount
    @discount_id BIGINT,
    @new_discount_start DATE,
    @new_discount_end DATE,
    @new_discount_percent INT
AS
BEGIN
    UPDATE Discount
    SET 
        discount_start = @new_discount_start,
        discount_end = @new_discount_end,
        discount_percent = @new_discount_percent
    WHERE discount_id = @discount_id
END
go




--Consigemnt
--Thêm
CREATE PROCEDURE Insert_Consignment 
	@consi_date DATETIME,
	@consi_quantity_product INT,
	@consi_mgfdate DATE,
	@consi_expdate DATE,
	@consi_price_one_product INT,
	@consi_total INT,
	@product_id BIGINT,
	@supplier_id BIGINT,
	@username VARCHAR(100)
AS
BEGIN
    INSERT INTO Consignment (consi_date, consi_quantity_product, consi_mgfdate, consi_expdate, consi_price_one_product, consi_total, product_id, supplier_id, username)
    VALUES (@consi_date, @consi_quantity_product, @consi_mgfdate, @consi_expdate, @consi_price_one_product, @consi_total, @product_id, @supplier_id, @username)
END
go
--Xóa
CREATE PROCEDURE Delete_Consignment
    @consi_id BIGINT
AS
BEGIN
    DELETE FROM Consignment
    WHERE consi_id = @consi_id
END

go
--Sửa
CREATE PROCEDURE Update_Consignment
    @consi_id BIGINT,
    @new_consi_date DATETIME,
    @new_consi_quantity_product INT,
    @new_consi_mgfdate DATE,
    @new_consi_expdate DATE,
    @new_consi_price_one_product INT,
    @new_consi_total INT,
    @new_product_id BIGINT,
    @new_supplier_id BIGINT,
    @new_username VARCHAR(100)
AS
BEGIN
    UPDATE Consignment
    SET 
        consi_date = @new_consi_date,
        consi_quantity_product = @new_consi_quantity_product,
        consi_mgfdate = @new_consi_mgfdate,
        consi_expdate = @new_consi_expdate,
        consi_price_one_product = @new_consi_price_one_product,
        consi_total = @new_consi_total,
        product_id = @new_product_id,
        supplier_id = @new_supplier_id,
        username = @new_username
    WHERE consi_id = @consi_id
END
go
EXEC Insert_Consignment '2023-09-27', 100, '2023-09-27', '2023-09-27', 50, 5000, 1, 1, 'viet';
Exec Update_Consignment 1, '2023-09-25', 150, '2023-09-27', '2023-09-27', 50, 5000, 1, 1, 'nhu';
Exec Delete_Consignment 2;
select * from Consignment;
drop procedure Update_Consignment

go
--Product
--Thêm
CREATE PROCEDURE Insert_Product 
	@product_name NVARCHAR(50),
	@product_barcode VARCHAR(20),
	@product_price INT,
	@unit_id INT,
	@cate_id INT,
	@inven_id BIGINT
AS
BEGIN
    INSERT INTO Product (product_name, product_barcode, product_price, unit_id, cate_id, inven_id)
    VALUES (@product_name, @product_barcode, @product_price, @unit_id, @cate_id, @inven_id)
END
--Xóa
go
CREATE PROCEDURE Delete_Product
    @product_id BIGINT
AS
BEGIN
    DELETE FROM Product
    WHERE product_id = @product_id
END
--Sửa
go
CREATE PROCEDURE Update_Product
    @product_id BIGINT,
    @new_product_name NVARCHAR(50),
    @new_product_barcode VARCHAR(20),
    @new_product_price INT,
    @new_unit_id INT,
    @new_cate_id INT,
    @new_inven_id BIGINT
AS
BEGIN
    UPDATE Product
    SET 
        product_name = @new_product_name,
        product_barcode = @new_product_barcode,
        product_price = @new_product_price,
        unit_id = @new_unit_id,
        cate_id = @new_cate_id,
        inven_id = @new_inven_id
    WHERE product_id = @product_id
END

--Inventory
go
--Thêm
CREATE PROCEDURE Insert_Inventory 
	@inven_quantity BIGINT,
	@inven_latest_date DATE,
	@inven_update_quantity BIGINT
AS
BEGIN
    INSERT INTO Inventory (inven_quantity, inven_latest_date, inven_update_quantity)
    VALUES (@inven_quantity, @inven_latest_date, @inven_update_quantity)
END
go
--Xóa
CREATE PROCEDURE Delete_Inventory
    @inven_id BIGINT
AS
BEGIN
    DELETE FROM Inventory
    WHERE inven_id = @inven_id
END
go
--Sửa
CREATE PROCEDURE Update_Inventory
    @inven_id BIGINT,
    @new_inven_quantity BIGINT,
    @new_inven_latest_date DATE,
    @new_inven_update_quantity BIGINT
AS
BEGIN
    UPDATE Inventory
    SET 
        inven_quantity = @new_inven_quantity,
        inven_latest_date = @new_inven_latest_date,
        inven_update_quantity = @new_inven_update_quantity
    WHERE inven_id = @inven_id
END
go
--DiscountCode

--Thêm

CREATE PROCEDURE Insert_DiscountCode 
	@code_exp DATE,
	@code_price INT,
	@code_status INT,
	@code_string VARCHAR(20)
AS
BEGIN
    INSERT INTO DiscountCode (code_exp, code_price, code_status, code_string)
    VALUES (@code_exp, @code_price, @code_status, @code_string)
END
go 

--Xóa
CREATE PROCEDURE Delete_DiscountCode
    @code_id BIGINT
AS
BEGIN
    DELETE FROM DiscountCode
    WHERE code_id = @code_id
END
go
--Sửa
CREATE PROCEDURE Update_DiscountCode
    @code_id BIGINT,
    @new_code_exp DATE,
    @new_code_price INT,
    @new_code_status INT,
    @new_code_string VARCHAR(20)
AS
BEGIN
    UPDATE DiscountCode
    SET 
        code_exp = @new_code_exp,
        code_price = @new_code_price,
        code_status = @new_code_status,
        code_string = @new_code_string
    WHERE code_id = @code_id
END
go
 
--Tich diem

--thêm
CREATE PROCEDURE Insert_Tich_diem 
	@history_datetime DATETIME,
	@history_diem INT,
	@customer_id BIGINT
AS
BEGIN
    INSERT INTO Tich_diem (history_datetime, history_diem, customer_id)
    VALUES (@history_datetime, @history_diem, @customer_id)
END
go

--Xóa

CREATE PROCEDURE Delete_Tich_diem
    @history_id BIGINT
AS
BEGIN
    DELETE FROM Tich_diem
    WHERE history_id = @history_id
END
go
--Sửa
CREATE PROCEDURE Update_Tich_diem
    @history_id BIGINT,
    @new_history_datetime DATETIME,
    @new_history_diem INT,
    @new_customer_id BIGINT
AS
BEGIN
    UPDATE Tich_diem
    SET 
        history_datetime = @new_history_datetime,
        history_diem = @new_history_diem,
        customer_id = @new_customer_id
    WHERE history_id = @history_id
END
go
 --Shift Detail

 --Thêm
 CREATE PROCEDURE Insert_ShiftDetail 
	@shiftdetail_onshift VARCHAR(100),
	@shiftdetail_closeshift VARCHAR(100),
	@shiftdetail_start DATETIME,
	@shiftdetail_end DATETIME,
	@shiftdetail_note NVARCHAR(100),
	@shift_id BIGINT
AS
BEGIN
    INSERT INTO ShiftDetail (shiftdetail_onshift, shiftdetail_closeshift, shiftdetail_start, shiftdetail_end, shiftdetail_note, shift_id)
    VALUES (@shiftdetail_onshift, @shiftdetail_closeshift, @shiftdetail_start, @shiftdetail_end, @shiftdetail_note, @shift_id)
END
go
--Xóa
CREATE PROCEDURE Delete_ShiftDetail
    @shiftdetail_id BIGINT
AS
BEGIN
    DELETE FROM ShiftDetail
    WHERE shiftdetail_id = @shiftdetail_id
END
go
--Sửa
CREATE PROCEDURE Update_ShiftDetail
    @shiftdetail_id BIGINT,
    @new_shiftdetail_onshift VARCHAR(100),
    @new_shiftdetail_closeshift VARCHAR(100),
    @new_shiftdetail_start DATETIME,
    @new_shiftdetail_end DATETIME,
    @new_shiftdetail_note NVARCHAR(100),
    @new_shift_id BIGINT
AS
BEGIN
    UPDATE ShiftDetail
    SET 
        shiftdetail_onshift = @new_shiftdetail_onshift,
        shiftdetail_closeshift = @new_shiftdetail_closeshift,
        shiftdetail_start = @new_shiftdetail_start,
        shiftdetail_end = @new_shiftdetail_end,
        shiftdetail_note = @new_shiftdetail_note,
        shift_id = @new_shift_id
    WHERE shiftdetail_id = @shiftdetail_id
END
go

--Shift
--Thêm
CREATE PROCEDURE Insert_Shift 
	@shift_start DATETIME,
	@shift_end DATETIME,
	@username VARCHAR(100),
	@shiftdetail_id BIGINT
AS
BEGIN
    INSERT INTO Shift (shift_start, shift_end, username, shiftdetail_id)
    VALUES (@shift_start, @shift_end, @username, @shiftdetail_id)
END
--Xóa
go
CREATE PROCEDURE Delete_Shift
    @shift_id BIGINT
AS
BEGIN
    DELETE FROM Shift
    WHERE shift_id = @shift_id
END
go
--Sửa
CREATE PROCEDURE Update_Shift
    @shift_id BIGINT,
    @new_shift_start DATETIME,
    @new_shift_end DATETIME,
    @new_username VARCHAR(100),
    @new_shiftdetail_id BIGINT
AS
BEGIN
    UPDATE Shift
    SET 
        shift_start = @new_shift_start,
        shift_end = @new_shift_end,
        username = @new_username,
        shiftdetail_id = @new_shiftdetail_id
    WHERE shift_id = @shift_id
END
go

--StaffRole
--Thêm
CREATE PROCEDURE Insert_Staff_Role 
	@username VARCHAR(100),
	@role_id INT
AS
BEGIN
    INSERT INTO Staff_Role (username, role_id)
    VALUES (@username, @role_id)
END
go
--Xóa
CREATE PROCEDURE Delete_Staff_Role
    @username VARCHAR(100),
    @role_id INT
AS
BEGIN
    DELETE FROM Staff_Role
    WHERE username = @username AND role_id = @role_id
END
go
--Sửa
CREATE PROCEDURE Update_Staff_Role
    @username VARCHAR(100),
    @role_id INT,
    @new_username VARCHAR(100),
    @new_role_id INT
AS
BEGIN
    UPDATE Staff_Role
    SET 
        username = @new_username,
        role_id = @new_role_id
    WHERE username = @username AND role_id = @role_id
END



go


--Bill
--Thêm
CREATE PROCEDURE Insert_Bill 
	@bill_no VARCHAR(20),
	@bill_date DATE,
	@bill_total_before INT,
	@bill_total_after INT,
	@paymentmethod_id INT,
	@customer_id BIGINT,
	@username VARCHAR(100)
AS
BEGIN
    INSERT INTO Bill (bill_no, bill_date, bill_total_before, bill_total_after, paymentmethod_id, customer_id, username)
    VALUES (@bill_no, @bill_date, @bill_total_before, @bill_total_after, @paymentmethod_id, @customer_id, @username)
END
go

--Xóa

CREATE PROCEDURE Delete_Bill
    @bill_id BIGINT
AS
BEGIN
    DELETE FROM Bill
    WHERE bill_id = @bill_id
END
go
--Sửa
CREATE PROCEDURE Update_Bill
    @bill_id BIGINT,
    @new_bill_no VARCHAR(20),
    @new_bill_date DATE,
    @new_bill_total_before INT,
    @new_bill_total_after INT,
    @new_paymentmethod_id INT,
    @new_customer_id BIGINT,
    @new_username VARCHAR(100)
AS
BEGIN
    UPDATE Bill
    SET 
        bill_no = @new_bill_no,
        bill_date = @new_bill_date,
        bill_total_before = @new_bill_total_before,
        bill_total_after = @new_bill_total_after,
        paymentmethod_id = @new_paymentmethod_id,
        customer_id = @new_customer_id,
        username = @new_username
    WHERE bill_id = @bill_id
END
go


--OrderOnline
--Thêm
CREATE PROCEDURE Insert_OrderOnline 
	@customer_id BIGINT,
	@order_name NVARCHAR(100),
	@order_address NVARCHAR(100),
	@order_phone VARCHAR(10),
	@order_status INT,
	@order_total_before INT,
	@order_total_after INT,
	@order_paycheck VARCHAR(20)
AS
BEGIN
    INSERT INTO OrderOnline (customer_id, order_name, order_address, order_phone, order_status, order_total_before, order_total_after, order_paycheck)
    VALUES (@customer_id, @order_name, @order_address, @order_phone, @order_status, @order_total_before, @order_total_after, @order_paycheck)
END
go
--Xóa
CREATE PROCEDURE Delete_OrderOnline
    @order_id BIGINT
AS
BEGIN
    DELETE FROM OrderOnline
    WHERE order_id = @order_id
END
go
--Sửa
CREATE PROCEDURE Update_OrderOnline
    @order_id BIGINT,
    @new_customer_id BIGINT,
    @new_order_name NVARCHAR(100),
    @new_order_address NVARCHAR(100),
    @new_order_phone VARCHAR(10),
    @new_order_status INT,
    @new_order_total_before INT,
    @new_order_total_after INT,
    @new_order_paycheck VARCHAR(20)
AS
BEGIN
    UPDATE OrderOnline
    SET 
        customer_id = @new_customer_id,
        order_name = @new_order_name,
        order_address = @new_order_address,
        order_phone = @new_order_phone,
        order_status = @new_order_status,
        order_total_before = @new_order_total_before,
        order_total_after = @new_order_total_after,
        order_paycheck = @new_order_paycheck
    WHERE order_id = @order_id
END
go



--StaffRelatives

--Thêm
CREATE PROCEDURE Insert_StaffRelatives 
	@staffrelatives_name NVARCHAR(100),
	@staffrelatives_address NVARCHAR(100),
	@staffrelatives_phone VARCHAR(10),
	@staffrelatives_info NVARCHAR(20),
	@username VARCHAR(100)
AS
BEGIN
    INSERT INTO StaffRelatives (staffrelatives_name, staffrelatives_address, staffrelatives_phone, staffrelatives_info, username)
    VALUES (@staffrelatives_name, @staffrelatives_address, @staffrelatives_phone, @staffrelatives_info, @username)
END
go

--Xóa
CREATE PROCEDURE Delete_StaffRelatives
    @staffrelatives_id BIGINT
AS
BEGIN
    DELETE FROM StaffRelatives
    WHERE staffrelatives_id = @staffrelatives_id
END
go
--Sửa
CREATE PROCEDURE Update_StaffRelatives
    @staffrelatives_id BIGINT,
    @new_staffrelatives_name NVARCHAR(100),
    @new_staffrelatives_address NVARCHAR(100),
    @new_staffrelatives_phone VARCHAR(10),
    @new_staffrelatives_info NVARCHAR(20),
    @new_username VARCHAR(100)
AS
BEGIN
    UPDATE StaffRelatives
    SET 
        staffrelatives_name = @new_staffrelatives_name,
        staffrelatives_address = @new_staffrelatives_address,
        staffrelatives_phone = @new_staffrelatives_phone,
        staffrelatives_info = @new_staffrelatives_info,
        username = @new_username
    WHERE staffrelatives_id = @staffrelatives_id
END

go
--Customer
--Thêm
CREATE PROCEDURE Insert_Customer 
	@customer_name NVARCHAR(100),
	@customer_address NVARCHAR(100),
	@customer_email VARCHAR(100),
	@customer_phone VARCHAR(10),
	@customer_tichdiem BIGINT,
	@customer_image VARCHAR(100)
AS
BEGIN
    INSERT INTO Customer (customer_name, customer_address, customer_email, customer_phone, customer_tichdiem, customer_image)
    VALUES (@customer_name, @customer_address, @customer_email, @customer_phone, @customer_tichdiem, @customer_image)
END
go
--Xóa
CREATE PROCEDURE Delete_Customer
    @customer_id BIGINT
AS
BEGIN
    DELETE FROM Customer
    WHERE customer_id = @customer_id
END
go
--Sửa
CREATE PROCEDURE Update_Customer
    @customer_id BIGINT,
    @new_customer_name NVARCHAR(100),
    @new_customer_address NVARCHAR(100),
    @new_customer_email VARCHAR(100),
    @new_customer_phone VARCHAR(10),
    @new_customer_tichdiem BIGINT,
    @new_customer_image VARCHAR(100)
AS
BEGIN
    UPDATE Customer
    SET 
        customer_name = @new_customer_name,
        customer_address = @new_customer_address,
        customer_email = @new_customer_email,
        customer_phone = @new_customer_phone,
        customer_tichdiem = @new_customer_tichdiem,
        customer_image = @new_customer_image
    WHERE customer_id = @customer_id
END
go


--Supplier

--Thêm
CREATE PROCEDURE Insert_Supplier 
	@supplier_name NVARCHAR(100),
	@supplier_address NVARCHAR(100),
	@supplier_email VARCHAR(50),
	@supplier_phone VARCHAR(10),
	@supplier_image VARCHAR(100)
AS
BEGIN
    INSERT INTO Supplier (supplier_name, supplier_address, supplier_email, supplier_phone, supplier_image)
    VALUES (@supplier_name, @supplier_address, @supplier_email, @supplier_phone, @supplier_image)
END

go
--Xóa

CREATE PROCEDURE Delete_Supplier
    @supplier_id BIGINT
AS
BEGIN
    DELETE FROM Supplier
    WHERE supplier_id = @supplier_id
END
go
--Sửa
CREATE PROCEDURE Update_Supplier
    @supplier_id BIGINT,
    @new_supplier_name NVARCHAR(100),
    @new_supplier_address NVARCHAR(100),
    @new_supplier_email VARCHAR(50),
    @new_supplier_phone VARCHAR(10),
    @new_supplier_image VARCHAR(100)
AS
BEGIN
    UPDATE Supplier
    SET 
        supplier_name = @new_supplier_name,
        supplier_address = @new_supplier_address,
        supplier_email = @new_supplier_email,
        supplier_phone = @new_supplier_phone,
        supplier_image = @new_supplier_image
    WHERE supplier_id = @supplier_id
END
go

--Staff

--Thêm
CREATE PROCEDURE Insert_Staff 
	@username VARCHAR(100),
	@password VARCHAR(100),
	@staff_name NVARCHAR(100),
	@staff_birthday DATE,
	@staff_phone VARCHAR(10),
	@staff_address NVARCHAR(100),
	@staff_email VARCHAR(100),
	@staff_gender NVARCHAR(10),
	@staff_start DATE,
	@staff_end DATE,
	@staff_image VARCHAR(100),
	@stafftype_id INT,
	@staff_enable INT
AS
BEGIN
    INSERT INTO Staff (username, password, staff_name, staff_birthday, staff_phone, staff_address, staff_email, staff_gender, staff_start, staff_end, staff_image, stafftype_id,staff_enable)
    VALUES (@username, @password, @staff_name, @staff_birthday, @staff_phone, @staff_address, @staff_email, @staff_gender, @staff_start, @staff_end, @staff_image, @stafftype_id,@staff_enable)
END
go

Exec Insert_Staff 'tranloc222','12334','Tran Huu Loc','1000-10-10','Null','Null','loc@gmail.com','null','1000-10-10','1000-10-10','null',1,0

drop procedure Insert_Staff

select * from Staff

--Xóa
CREATE PROCEDURE Delete_Staff
    @username VARCHAR(100)
AS
BEGIN
    DELETE FROM Staff
    WHERE username = @username
END
go

exec Delete_Staff 'tranloc129'

--Sửa
CREATE PROCEDURE Update_Staff
    @username VARCHAR(100),
    @new_password VARCHAR(100),
    @new_staff_name NVARCHAR(100),
    @new_staff_birthday DATE,
    @new_staff_phone VARCHAR(10),
    @new_staff_address NVARCHAR(100),
    @new_staff_email VARCHAR(100),
    @new_staff_gender NVARCHAR(10),
    @new_staff_start DATE,
    @new_staff_end DATE,
    @new_staff_image VARCHAR(100),
    @new_stafftype_id INT
  
AS
BEGIN
    UPDATE Staff
    SET 
        password = @new_password,
        staff_name = @new_staff_name,
        staff_birthday = @new_staff_birthday,
        staff_phone = @new_staff_phone,
        staff_address = @new_staff_address,
        staff_email = @new_staff_email,
        staff_gender = @new_staff_gender,
        staff_start = @new_staff_start,
        staff_end = @new_staff_end,
        staff_image = @new_staff_image,
        stafftype_id = @new_stafftype_id
  
    WHERE username = @username
END
go



Create Procedure CheckLogin (@username varchar (50),@password varchar(50))
as
begin
  select count(*) from Staff where username = @username and password = @password and staff_enable = 1
end
go

drop procedure CheckLogin


Exec CheckLogin 'admin','2OURnkUbjTqJv4XmG6iw5Q=='


select count(*) from Staff



Create Procedure GetRole (@username varchar (50))
as
begin
  select  role_id from Staff_Role where username = @username
end

Exec GetRole 'admin'

Create Procedure GetStaff(@username varchar (50))
as
begin
	select  * from Staff where username = @username
end




drop procedure GetStaff

Exec GetStaff 'admin'

Create Procedure GetStaffByEmail(@email varchar (50))
as
begin
	select  * from Staff where staff_email = @email
end

select * from Staff

Exec GetStaffByEmail 'loctran7129@gmail.com'

select * from Staff

update Staff set staff_enable = 1 where username = 'admin'