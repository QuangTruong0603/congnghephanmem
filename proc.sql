use seven_eleven
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
	@product_name NVARCHAR(150),
	@product_barcode VARCHAR(20),
	@product_price INT,
	@product_image varchar(100),
	@product_status int,
	@unit_id INT,
	@cate_id INT,
	@inven_id BIGINT
AS
BEGIN
    INSERT INTO Product (product_name, product_barcode, product_price, unit_id, cate_id, inven_id,product_image,product_status)
    VALUES (@product_name, @product_barcode, @product_price, @unit_id, @cate_id, @inven_id,@product_image,@product_status)
END

go
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
	@new_product_image varchar(100)
AS
BEGIN
    UPDATE Product
    SET 
        product_name = @new_product_name,
        product_barcode = @new_product_barcode,
        product_price = @new_product_price,
        unit_id = @new_unit_id,
        cate_id = @new_cate_id,
        product_image= @new_product_image
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

CREATE PROCEDURE GetAllBill
AS
BEGIN
    select Bill.bill_no as N'Mã hóa đơn', bill_date as N'Thời gian' , bill_total_after as N'Số tiền' ,PaymentMethod.paymentmethod_name as N'Phương thức thanh toán',Staff.staff_name as N'Nhân viên bán hàng'  from Bill, PaymentMethod, Staff
	where Bill.paymentmethod_id = PaymentMethod.paymentmethod_id and Bill.username = Staff.username
END
go

CREATE PROCEDURE GetOneBill (@bill_no varchar (100))
AS
BEGIN
    select Bill.bill_no as N'Mã hóa đơn', bill_date as N'Thời gian' , bill_total_after as N'Số tiền' ,PaymentMethod.paymentmethod_name as N'Phương thức thanh toán',Staff.staff_name as N'Nhân viên bán hàng'  from Bill, PaymentMethod, Staff
	where Bill.paymentmethod_id = PaymentMethod.paymentmethod_id and Bill.username = Staff.username and Bill.bill_no = @bill_no
END
go


CREATE PROCEDURE GetBillByNoBill (@bill_no varchar (100))
AS
BEGIN
     select Bill.bill_no as N'Mã hóa đơn', bill_date as N'Thời gian' , bill_total_after as N'Số tiền' ,PaymentMethod.paymentmethod_name as N'Phương thức thanh toán',Staff.staff_name as N'Nhân viên bán hàng', Bill.bill_total_before as N'Số tiền ban đầu'  from Bill, PaymentMethod, Staff
	where Bill.paymentmethod_id = PaymentMethod.paymentmethod_id and Bill.username = Staff.username and Bill.bill_no = @bill_no and Bill.bill_no = @bill_no
END
go





CREATE PROCEDURE GetCustomerOfBill (@bill_no varchar (100))
AS
BEGIN
     select  Customer.customer_name, Customer.customer_phone from Bill, Customer where Bill.customer_id = Customer.customer_id and Bill.bill_no = @bill_no
END
go


--Bill detail

CREATE PROCEDURE GetListProductOfBill (@bill_no varchar (100))
AS
BEGIN
     select Product.product_name as N'Tên sản phẩm', Product.product_barcode as N'Mã sản phẩm', Bill_detail.quantity as N'Số lượng', Bill_detail.size as N'Size' , Bill_detail.price as N'Số tiền' from Bill, Product, Bill_detail

	 where Bill.bill_no = @bill_no and Bill.bill_id = Bill_detail.bill_id and Bill_detail.product_id = Product.product_id
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
    @new_order_name NVARCHAR(100),
    @new_order_address NVARCHAR(100),
    @new_order_phone VARCHAR(10),
    @new_order_status NVARCHAR(50),
    @new_order_paycheck NVARCHAR(50),
	@delivery int
AS
BEGIN
    UPDATE OrderOnline
    SET 
        order_name = @new_order_name,
        order_address = @new_order_address,
        order_phone = @new_order_phone,
        order_status = @new_order_status,
        order_total_after = order_total_before + @delivery,
        order_paycheck = @new_order_paycheck
    WHERE order_id = @order_id
END
go


--get all
--0 : cho lay hang / 1: dang van chuyen /2: dang giao cho KH / 3: giao thanh cong /...

CREATE PROCEDURE GetAllOrder
AS
BEGIN
    select order_id as N'Mã đơn hàng', order_name as N'Tên người nhận' ,order_address as N'Địa chỉ', order_phone as N'SDT', order_total_after as N'Số tiền' , order_status as N'Trạng thái', order_paycheck as N'Thanh toán'
	from OrderOnline
END
go


CREATE PROCEDURE GetOneOrderById (@order_id int)
AS
BEGIN
    select order_id as N'Mã đơn hàng', order_name as N'Tên người nhận' ,order_address as N'Địa chỉ', order_phone as N'SDT', order_total_after as N'Số tiền' , order_status as N'Trạng thái', order_paycheck as N'Thanh toán'
	from OrderOnline where OrderOnline.order_id = @order_id
END
go



CREATE PROCEDURE GetOrderByStatus(@order_status nvarchar(100))
AS
BEGIN
    select order_id as N'Mã đơn hàng', order_name as N'Tên người nhận' ,order_address as N'Địa chỉ', order_phone as N'SDT', order_total_after as N'Số tiền' , order_status as N'Trạng thái', order_paycheck as N'Thanh toán'
	from OrderOnline where order_status = @order_status
END
go




CREATE PROCEDURE GetOrderById (@order_id int)
AS
BEGIN
    select order_id as N'Mã đơn hàng', order_name as N'Tên người nhận' ,order_address as N'Địa chỉ', order_phone as N'SDT', order_total_after as N'Số tiền' , order_status as N'Trạng thái', order_paycheck as N'Thanh toán', Customer.customer_name as N'Tên tài khoản đặt hàng',Customer.customer_phone as N'Số điện thoại TKDH', OrderOnline.order_date as N'Ngày tạo đơn', OrderOnline.order_total_before as N'Số tiền ban đầu'
	from OrderOnline, Customer where OrderOnline.order_id = @order_id  and OrderOnline.customer_id = Customer.customer_id
END
go


CREATE PROCEDURE GetOrderDetailById (@order_id int)
AS
BEGIN
    select Product.product_barcode as N'Mã sản phẩm', Product.product_name as N'Tên sản phẩm', OrderDetail.quantity as N'Số lượng', OrderDetail.size as N'Size', OrderDetail.price as N'Giá tiền'
	from OrderDetail, Product where OrderDetail.order_id = @order_id and OrderDetail.product_id = Product.product_id
END
go



CREATE PROCEDURE GetListProductOfOrder (@order_id varchar (100))
AS
BEGIN
     select Product.product_name as N'Tên sản phẩm', Product.product_barcode as N'Mã sản phẩm', OrderDetail.quantity as N'Số lượng', OrderDetail.size as N'Size' , OrderDetail.price as N'Số tiền' from  Product, OrderDetail

	 where OrderDetail.order_id = @order_id and OrderDetail.product_id = Product.product_id
END
go



CREATE PROCEDURE DeleteOrder (@order_id varchar (100))
AS
BEGIN
     delete OrderOnline where OrderOnline.order_id = @order_id
END
go



CREATE PROCEDURE addProductOrderDetail (@order_id int , @product_id int, @quantity int,@price int, @size varchar(50))
AS
BEGIN
      insert into OrderDetail(order_id, product_id, quantity, size, price) values (@order_id,@product_id,@quantity,@size, @price)
END
go



CREATE PROCEDURE deleteProductOrderDetail (@order_id int , @product_id int)
AS
BEGIN
      delete OrderDetail where order_id = @order_id and product_id = @product_id
END
go


drop procedure addProductOrderDetail 

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

--Xóa
CREATE PROCEDURE Delete_Staff
    @username VARCHAR(100)
AS
BEGIN
    DELETE FROM Staff
    WHERE username = @username
END
go


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


Create Procedure GetRole (@username varchar (50))
as
begin
  select  Staff_Role.role_id,Role.role_name  from Staff_Role, Role where username = @username and Staff_Role.role_id = Role.role_id
end
go


Create Procedure GetStaff(@username varchar (50))
as
begin
	select  * from Staff where username = @username
end
go

Create Procedure GetStaffByEmail(@email varchar (50))
as
begin
	select  * from Staff where staff_email = @email
end
go



Create Procedure UpdatePassword(@staffemail varchar(100),@newpassword varchar (100))
as
begin
	Update Staff set password = @newpassword where staff_email = @staffemail
end
go


--Product

Create Procedure GetInfoProduct (@product_barcode varchar(100))
as
begin
	select * from Product where Product.product_barcode = @product_barcode
end
go

Create Procedure ManageProduct
as
begin
	select  Product.product_barcode as N'Mã sản phẩm',Product.product_name as N'Tên sản phẩm',Product.product_price as N'Giá' ,Category.cate_name as N'Loại',Inventory.inven_quantity as N'Số lượng trong kho',Product.product_status as N'Trạng thái',Product.product_image as N'Path' from Product, Category, Inventory
	where Product.cate_id = Category.cate_id and Product.inven_id = Inventory.inven_id 
end

go




Create Procedure ManageProductKD
as
begin
	select  Product.product_barcode as N'Mã sản phẩm',Product.product_name as N'Tên sản phẩm',Product.product_price as N'Giá' ,Category.cate_name as N'Loại',Inventory.inven_quantity as N'Số lượng trong kho',Product.product_status as N'Trạng thái',Product.product_image as N'Path' from Product, Category, Inventory
	where Product.cate_id = Category.cate_id and Product.inven_id = Inventory.inven_id and Product.product_status = 1
end

go

Create Procedure ManageProductKKD
as
begin
	select  Product.product_barcode as N'Mã sản phẩm',Product.product_name as N'Tên sản phẩm',Product.product_price as N'Giá' ,Category.cate_name as N'Loại',Inventory.inven_quantity as N'Số lượng trong kho',Product.product_status as N'Trạng thái',Product.product_image as N'Path' from Product, Category, Inventory
	where Product.cate_id = Category.cate_id and Product.inven_id = Inventory.inven_id and Product.product_status = 0
end
go

select * from Product


Create Procedure DisableProduct (@product_barcode varchar(100))
as
begin
	update Product set product_status = 0 where product_barcode = @product_barcode
end

go

Create Procedure EnableProduct (@product_barcode varchar(100))
as
begin
	update Product set product_status = 1 where product_barcode = @product_barcode
end

go



Create Procedure FindProduct (@product_barcode varchar(100))
as
begin
	select  Product.product_barcode as N'Mã sản phẩm',Product.product_name as N'Tên sản phẩm',Product.product_price as N'Giá' ,Category.cate_name as N'Loại',Inventory.inven_quantity as N'Số lượng trong kho',Product.product_status as N'Trạng thái',Product.product_image as N'Path' from Product, Category, Inventory
	where Product.cate_id = Category.cate_id and Product.inven_id = Inventory.inven_id  and Product.product_barcode = @product_barcode
end



Create Procedure FindProduct2 (@product_barcode varchar(100))
as
begin
	select  Product.product_barcode as N'Mã sản phẩm',Product.product_name as N'Tên sản phẩm',Product.product_price as N'Giá' ,Category.cate_name as N'Loại',Inventory.inven_quantity as N'Số lượng trong kho',Product.product_image as N'Path' from Product, Category, Inventory
	where Product.cate_id = Category.cate_id and Product.inven_id = Inventory.inven_id  and  Product.product_status = 1   and Product.product_barcode = @product_barcode 
end

--Category
Create Procedure GetNameCategory
as
begin
	select Category.cate_name from Category
end


Create Procedure GetIdNameCategory (@cate_name nvarchar (100))
as
begin
	select Category.cate_id from Category where Category.cate_name = @cate_name
end

exec  GetIdNameCategory N'Nước ngọt có ga'

Create Procedure GetCategoryById (@cate_id int)
as
begin
	select * from Category where cate_id = @cate_id
end


--Unit
Create Procedure GetNameUnit
as
begin
	select Unit.unit_name from Unit
end

Create Procedure GetIdNameUnit (@unit_name nvarchar (100))
as
begin
	select Unit.unit_id from Unit where Unit.unit_name = @unit_name
end



Create Procedure GetUnitById (@unit_id int)
as
begin
	select * from Unit where unit_id = @unit_id
end



