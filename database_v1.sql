
create database databasev1

use databasev1

-- Table Staff --------------------------
--

CREATE TABLE [Staff]
(
    [staff_id] [bigint] NOT NULL IDENTITY(1,1),
    [username] [varchar] (100) NOT NULL,
    [password] [varchar] (100) NOT NULL,
    [staff_name] [nvarchar] (100) NOT NULL,
    [staff_birthday] [date] NOT NULL,
    [staff_phone] [varchar] (10) NOT NULL,
    [staff_address] [nvarchar] (100) NOT NULL,
    [staff_email] [varchar] (100) NOT NULL,
    [staff_gender] [nvarchar] (10) NOT NULL,
    [staff_start] [date] NOT NULL,
    [staff_end] [date] NOT NULL,
    [staff_image] [varchar] (100) NOT NULL,
    [stafftype_id] [int] NOT NULL,
	[staff_enable] [int] NOT NULL,
    CONSTRAINT PK_Staff PRIMARY KEY (username)  
)
GO



-- Table StaffType --------------------------
--

CREATE TABLE [StaffType]
(
    [stafftype_id] [int] NOT NULL IDENTITY(1,1),
    [stafftype_name] [nvarchar] (50) NOT NULL,
    CONSTRAINT PK_Staff_Type PRIMARY KEY (stafftype_id) 
)
GO


-- Table StaffRelatives --------------------------
--

CREATE TABLE [StaffRelatives]
(
    [staffrelatives_id] [bigint] NOT NULL IDENTITY(1,1),
    [staffrelatives_name] [nvarchar] (100) NOT NULL,
    [staffrelatives_address] [nvarchar] (100) NOT NULL,
    [staffrelatives_phone] [varchar] (10) NOT NULL,
    [staffrelatives_info] [nvarchar] (20) NOT NULL,
    [username] [varchar] (100) NOT NULL,
    CONSTRAINT PK_Staff_Relatives PRIMARY KEY (staffrelatives_id)   
)
GO


-- Table Customer --------------------------
--

CREATE TABLE [Customer]
(
    [customer_id] [bigint] NOT NULL IDENTITY(1,1),
    [customer_name] [nvarchar] (100) NOT NULL,
    [customer_address] [nvarchar] (100) NOT NULL,
    [customer_email] [varchar] (100) NOT NULL,
    [customer_phone] [varchar] (10) NOT NULL,
    [customer_tichdiem] [bigint] NOT NULL,
    [customer_image] [varchar] (100) NOT NULL,
    CONSTRAINT PK_Customer PRIMARY KEY (customer_id)    
)
GO


-- Table OrderOnline --------------------------
--

CREATE TABLE [OrderOnline]
(
    [order_id] [bigint] NOT NULL IDENTITY(1,1),
    [customer_id] [bigint] NOT NULL,
    [order_name] [nvarchar] (100) NOT NULL,
    [order_address] [nvarchar] (100) NOT NULL,
    [order_phone] [varchar] (10) NOT NULL,
    [order_status] [nvarchar] (50) NOT NULL,
    [order_total_before] [int] NOT NULL,
    [order_total_after] [int] NOT NULL,
	[order_date] datetime NOT NULL,
    [order_paycheck] [nvarchar] (50) NOT NULL,
    CONSTRAINT PK_Order_Online PRIMARY KEY (order_id)   
)
GO



-- Table Bill --------------------------
--

CREATE TABLE [Bill]
(
    [bill_id] [bigint] NOT NULL IDENTITY(1,1),
    [bill_no] [varchar] (100) NOT NULL,
    [bill_date] [datetime] NOT NULL,
    [bill_total_before] [int] NOT NULL,
    [bill_total_after] [int] NOT NULL,
    [paymentmethod_id] [int] NOT NULL,
    [customer_id] [bigint] NULL,
    [username] [varchar] (100) NOT NULL,
    CONSTRAINT PK_Bill PRIMARY KEY (bill_id)    
)
GO




-- Table PaymentMethod --------------------------
--

CREATE TABLE [PaymentMethod]
(
    [paymentmethod_id] [int] NOT NULL IDENTITY(1,1),
    [paymentmethod_name] [nvarchar] (30) NOT NULL,
    CONSTRAINT PK_Payment_Method PRIMARY KEY (paymentmethod_id) 
)
GO


-- Table Role --------------------------
--

CREATE TABLE [Role]
(
    [role_id] [int] NOT NULL IDENTITY(1,1),
    [role_name] [nvarchar] (30) NOT NULL,
    CONSTRAINT PK_Role PRIMARY KEY (role_id)    
)
GO


-- Table Staff_Role --------------------------
--

CREATE TABLE [Staff_Role]
(
    [username] [varchar] (100) NOT NULL,
    [role_id] [int] NOT NULL,
    CONSTRAINT PK_Staff_Role PRIMARY KEY (username, role_id)    
)
GO


-- Table Shift --------------------------
--

CREATE TABLE [Shift]
(
    [shift_id] [bigint] NOT NULL IDENTITY(1,1),
    [shift_start] [datetime] NOT NULL,
    [shift_end] [datetime] NOT NULL,
    [username] [varchar] (100) NOT NULL,
    [shiftdetail_id] [bigint] NOT NULL,
    CONSTRAINT PK_Shift PRIMARY KEY (shift_id)  
)
GO


-- Table ShiftDetail --------------------------
--

CREATE TABLE [ShiftDetail]
(
    [shiftdetail_id] [bigint] NOT NULL IDENTITY(1,1),
    [shiftdetail_onshift] [varchar] (100) NULL,
    [shiftdetail_closeshift] [varchar] (100) NULL,
    [shiftdetail_start] [datetime] NULL,
    [shiftdetail_end] [datetime] NULL,
    [shiftdetail_note] [nvarchar] (100) NULL,
    [shift_id] [bigint] NOT NULL,
    CONSTRAINT PK_Shift_Detail PRIMARY KEY (shiftdetail_id) 
)
GO


-- Table Tich_diem --------------------------
--

CREATE TABLE [Tich_diem]
(
    [history_id] [bigint] NOT NULL IDENTITY(1,1),
    [history_datetime] [datetime] NOT NULL,
    [history_diem] [int] NOT NULL,
    [customer_id] [bigint] NOT NULL,
    CONSTRAINT PK_Tich_diem PRIMARY KEY (history_id)    
)
GO


-- Table DiscountCode --------------------------
--

CREATE TABLE [DiscountCode]
(
    [code_id] [bigint] NOT NULL IDENTITY(1,1),
    [code_exp] [date] NOT NULL,
    [code_price] [int] NOT NULL,
    [code_status] [int] NOT NULL,
    [code_string] [varchar] (20) NOT NULL,
    CONSTRAINT PK_Discount_code PRIMARY KEY (code_id)   
)
GO


-- Table Product --------------------------
--

CREATE TABLE [Product]
(
    [product_id] [bigint] NOT NULL IDENTITY(1,1),
    [product_name] [nvarchar] (150) NOT NULL,
    [product_barcode] [varchar] (20) NOT NULL,
    [product_price] [int] NOT NULL,
	[product_status] [int] NOT NULL,
	[product_image] [varchar](100) NULL,
    [unit_id] [int] NOT NULL,
    [cate_id] [int] NOT NULL,
    [inven_id] [bigint] NOT NULL,
    CONSTRAINT PK_Product PRIMARY KEY (product_id)  
)
GO


-- Table Bill_detail --------------------------
--

CREATE TABLE [Bill_detail]
(
    [quantity] [int] NOT NULL,
    [price] [int] NOT NULL,
    [size] [varchar] (10) NOT NULL,
    [bill_id] [bigint] NOT NULL,
    [product_id] [bigint] NOT NULL,
    CONSTRAINT PK_Bill_detail PRIMARY KEY (bill_id, product_id) 
)
GO


-- Table OrderDetail --------------------------   CONSTRAINT PK_Order_detail PRIMARY KEY (order_id, product_id) 
CREATE TABLE [OrderDetail]
(
    [quantity] [int] NOT NULL,
    [price] [int] NOT NULL,
    [size] [varchar] (10) NOT NULL,
	[order_id] [bigint] NOT NULL,
    [product_id] [bigint] NOT NULL,
	 CONSTRAINT PK_Order_detail PRIMARY KEY (order_id, product_id) 
)
GO




-- Table Inventory --------------------------
--

CREATE TABLE [Inventory]
(
    [inven_id] [bigint] NOT NULL IDENTITY(1,1),
    [inven_quantity] [bigint] NOT NULL,
    [inven_latest_date] [date] NOT NULL,
    [inven_update_quantity] [bigint] NOT NULL,
    CONSTRAINT PK_Inventory PRIMARY KEY (inven_id)  
)
GO


-- Table Consignment --------------------------
--

CREATE TABLE [Consignment]
(
    [consi_id] [bigint] NOT NULL IDENTITY(1,1),
    [consi_date] [datetime] NOT NULL,
    [consi_quantity_product] [int] NOT NULL,
    [consi_mgfdate] [date] NOT NULL,
    [consi_expdate] [date] NOT NULL,
    [consi_price_one_product] [int] NOT NULL,
    [consi_total] [int] NOT NULL,
    [product_id] [bigint] NOT NULL,
    [supplier_id] [bigint] NOT NULL,
    [username] [varchar] (100) NOT NULL,
    CONSTRAINT PK_Consignment PRIMARY KEY (consi_id)    
)
GO


-- Table Supplier --------------------------
--

CREATE TABLE [Supplier]
(
    [supplier_id] [bigint] NOT NULL IDENTITY(1,1),
    [supplier_name] [nvarchar] (100) NOT NULL,
    [supplier_address] [nvarchar] (100) NOT NULL,
    [supplier_email] [varchar] (50) NOT NULL,
    [supplier_phone] [varchar] (10) NOT NULL,
    [supplier_image] [varchar] (100) NOT NULL,
    CONSTRAINT PK_Supplier PRIMARY KEY (supplier_id)    
)
GO


-- Table Unit --------------------------
--

CREATE TABLE [Unit]
(
    [unit_id] [int] NOT NULL IDENTITY(1,1),
    [unit_name] [nvarchar] (20) NOT NULL,
    CONSTRAINT PK_Unit PRIMARY KEY (unit_id)    
)
GO


-- Table Category --------------------------
--

CREATE TABLE [Category]
(
    [cate_id] [int] NOT NULL IDENTITY(1,1),
    [cate_name] [nvarchar] (100) NOT NULL,
    CONSTRAINT PK_Category PRIMARY KEY (cate_id)    
)
GO



-- Table Discount --------------------------
--

CREATE TABLE [Discount]
(
    [discount_id] [bigint] NOT NULL IDENTITY(1,1),
    [discount_start] [date] NOT NULL,
    [discount_end] [date] NOT NULL,
    [discount_percent] [int] NOT NULL,
    [product_id] [bigint] NOT NULL,
    CONSTRAINT PK_Discount PRIMARY KEY (discount_id)    
)
GO


-- References for Staff --------------------------
ALTER TABLE [Staff]
ADD 
    CONSTRAINT FK_Staff_1c1cd9f3f5bb4fb985ade1090e0029fe FOREIGN KEY (stafftype_id) REFERENCES [StaffType] (stafftype_id)
GO


-- References for StaffRelatives --------------------------
ALTER TABLE [StaffRelatives]
ADD 
    CONSTRAINT FK_StaffRelatives_9f7efe85313e4732894c2fcd1a1d92ad FOREIGN KEY (username) REFERENCES [Staff] (username)
GO


-- References for OrderOnline --------------------------
ALTER TABLE [OrderOnline]
ADD 
    CONSTRAINT FK_OrderOnline_d37e263e4f594a40a26da3233377de99 FOREIGN KEY (customer_id) REFERENCES [Customer] (customer_id)
GO

-- References for Bill --------------------------
ALTER TABLE [Bill]
ADD 
    CONSTRAINT FK_Bill_08e7dce68c024f32af1b24d0fb34d4a6 FOREIGN KEY (username) REFERENCES [Staff] (username), 
    CONSTRAINT FK_Bill_7af3857f2cae4e6f852879e46ed9d6cd FOREIGN KEY (customer_id) REFERENCES [Customer] (customer_id), 
    CONSTRAINT FK_Bill_fea8dc6adeec406ea5e77f87f5a05cce FOREIGN KEY (paymentmethod_id) REFERENCES [PaymentMethod] (paymentmethod_id)
GO



-- References for Staff_Role --------------------------
ALTER TABLE [Staff_Role]
ADD 
    CONSTRAINT FK_Staff_Role_83634d06645b40c58ecce38a09bea9ef FOREIGN KEY (role_id) REFERENCES [Role] (role_id), 
    CONSTRAINT FK_Staff_Role_edda5e20a47f4a589feb19880b573163 FOREIGN KEY (username) REFERENCES [Staff] (username)
GO

-- References for Shift --------------------------
ALTER TABLE [Shift]
ADD 
    CONSTRAINT FK_Shift_ebe44c85e9ae422da1cbd9c35480af69 FOREIGN KEY (username) REFERENCES [Staff] (username)
GO

-- References for ShiftDetail --------------------------
ALTER TABLE [ShiftDetail]
ADD 
    CONSTRAINT FK_ShiftDetail_a945d07973754c04a8bcf1c2f4011e1d FOREIGN KEY (shift_id) REFERENCES [Shift] (shift_id)
GO

-- References for Tich_diem --------------------------
ALTER TABLE [Tich_diem]
ADD 
    CONSTRAINT FK_Tich_diem_7eed101bb92446f0a782a2b11d6abb24 FOREIGN KEY (customer_id) REFERENCES [Customer] (customer_id)
GO


-- References for Product --------------------------
ALTER TABLE [Product]
ADD 
    CONSTRAINT FK_Product_3604a5ea066a41dfa7d9e69febc6b00a FOREIGN KEY (inven_id) REFERENCES [Inventory] (inven_id), 
    CONSTRAINT FK_Product_be263fe4779a4ec9afb61670379ad114 FOREIGN KEY (unit_id) REFERENCES [Unit] (unit_id), 
    CONSTRAINT FK_Product_dd698c0489fb4b919f4332742daeceb5 FOREIGN KEY (cate_id) REFERENCES [Category] (cate_id)
GO

-- References for Bill_detail --------------------------
ALTER TABLE [Bill_detail]
ADD 
    CONSTRAINT FK_Bill_detail_1c2f86313c9042529b51f05d77976113 FOREIGN KEY (bill_id) REFERENCES [Bill] (bill_id), 
    CONSTRAINT FK_Bill_detail_8dee2bbfc27f41919a1839f1d3581fe3 FOREIGN KEY (product_id) REFERENCES [Product] (product_id)
GO


-- References for Consignment --------------------------
ALTER TABLE [Consignment]
ADD 
    CONSTRAINT FK_Consignment_a6367a965ca24859a913d4a70c9382bf FOREIGN KEY (product_id) REFERENCES [Product] (product_id), 
    CONSTRAINT FK_Consignment_15d9864da4084d5a8bc2e5696586c2ff FOREIGN KEY (supplier_id) REFERENCES [Supplier] (supplier_id), 
    CONSTRAINT FK_Consignment_1f916c71271142fb87903d9156199638 FOREIGN KEY (username) REFERENCES [Staff] (username)
GO




-- References for Discount --------------------------
ALTER TABLE [Discount]
ADD 
    CONSTRAINT FK_Discount_f3f8a04afe944b61acb1ff7b56558909 FOREIGN KEY (product_id) REFERENCES [Product] (product_id)
GO


-- References for Order_detail --------------------------
ALTER Table [OrderDetail]
ADD
	CONSTRAINT FK_orderdetail_product FOREIGN KEY (product_id) References [Product] (product_id),
	CONSTRAINT FK_orderdetail_order FOREIGN KEY (order_id) REFERENCES [OrderOnline] (order_id)
GO



select * from Product