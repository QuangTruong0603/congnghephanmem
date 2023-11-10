use databasev1
go
--StaffType trong Staff
Create Trigger check_staff_type_in_staff
ON Staff INSTEAD OF Insert, Update
As
	If (select inserted.stafftype_id from inserted) not in (select StaffType.stafftype_id from StaffType)
	begin
		print('Khong ton tai loai nhan vien')
		RollBack transaction
	end
	
go
--StaffType trong Staff
Create Trigger check_staff_in_staff_relative
ON StaffRelatives INSTEAD OF Insert, Update
As
	If (select inserted.username from inserted) not in (select Staff.username from Staff)
	begin
		print('Khong ton tai nhan vien')
		RollBack transaction
	end
	
go

--Product trong Discount
Create Trigger check_product_in_discount
ON Discount INSTEAD OF Insert, Update
As
	If (select inserted.product_id from inserted) not in (select Product.product_id from Product)
	begin
		print('Khong ton tai Product')
		RollBack transaction
	end
	
go
Create Trigger check_orderonline
ON OrderOnline INSTEAD OF Insert, Update
As
	If (select inserted.customer_id from inserted) not in (select Customer.customer_id from Customer)
	begin
		print('Khong ton tai Customer')
		RollBack transaction
	end
	
go

Create Trigger check_Consignment
ON Consignment INSTEAD OF Insert, Update
As
	If (select inserted.username from inserted) not in (select Staff.username from Staff)
	begin
		print('Khong ton tai Staff')
		RollBack transaction
	end
	else if(select inserted.supplier_id from inserted) not in (select Supplier.supplier_id from Supplier)
	begin
		print('Khong ton tai Supplier')
		RollBack transaction
	end
	else if(select inserted.product_id from inserted) not in (select Product.product_id from Product)
	begin
		print('Khong ton tai Product')
		RollBack transaction
	end
go


--Bang product

Create Trigger check_Product
ON Product INSTEAD OF Insert, Update
As
	If (select inserted.inven_id from inserted) not in (select Inventory.inven_id from Inventory)
	begin
		print('Khong ton tai Inventory')
		RollBack transaction
	end
	else if(select inserted.cate_id from inserted) not in (select Category.cate_id from Category)
	begin
		print('Khong ton tai Category')
		RollBack transaction
	end
	else if(select inserted.unit_id from inserted) not in (select Unit.unit_id from Unit)
	begin
		print('Khong ton tai Unit')
		RollBack transaction
	end
go






Create Trigger check_Bill
ON Bill INSTEAD OF Insert, Update
As
	If (select inserted.paymentmethod_id from inserted) not in (select PaymentMethod.paymentmethod_id from PaymentMethod)
	begin
		print('Khong ton tai PaymentMethod')
		RollBack transaction
	end


	else if(select inserted.customer_id from inserted) not in (select Customer.customer_id from Customer)
	begin
		print('Khong ton tai Customer')
		RollBack transaction
	end

	else if(select inserted.username from inserted) not in (select Staff.username from Staff)
	begin
		print('Khong ton tai Nhan Vien')
		RollBack transaction
	end
go





Create Trigger check_BillDetail
ON Bill_detail INSTEAD OF Insert, Update
As
	If (select inserted.bill_id from inserted) not in (select Bill.bill_id from Bill)
	begin
		print('Khong ton tai Bill')
		RollBack transaction
	end


	else if(select inserted.product_id from inserted) not in (select Product.product_id from Product)
	begin
		print('Khong ton tai product')
		RollBack transaction
	end

	

go

Create Trigger check_TichDiem
ON Tich_diem INSTEAD OF Insert, Update
As
	If (select inserted.customer_id from inserted) not in (select Customer.customer_id from Customer)
	begin
		print('Khong ton tai Customer')
		RollBack transaction
	end


go



Create Trigger check_StaffRole
ON Staff_Role INSTEAD OF Insert, Update
As
	If (select inserted.role_id from inserted) not in (select Role.role_id from Role)
	begin
		print('Khong ton tai Role')
		RollBack transaction
	end


	else if(select inserted.username from inserted) not in (select Staff.username from Staff)
	begin
		print('Khong ton tai product')
		RollBack transaction
	end

	

go


Create Trigger check_ShiftDetail
ON ShiftDetail INSTEAD OF Insert, Update
As
	If (select inserted.shiftdetail_id from inserted) not in (select Shift.shiftdetail_id from Shift)
	begin
		print('Khong ton tai Shift')
		RollBack transaction
	end



go

Create Trigger check_Shift
ON Shift INSTEAD OF Insert, Update
As
	If (select inserted.username from inserted) not in (select Staff.username from Staff)
	begin
		print('Khong ton tai Shift')
		RollBack transaction
	end

go


Create Trigger autoAddRole
ON Staff After Insert
As
	Begin
		Declare @username varchar(100)
		Select @username = inserted.[username] from inserted
		Insert into Staff_Role(username, role_id) values (@username, 2)

	End
Go


Create Trigger addInvenIdProduct
on Product After Insert
As
	Begin
		Declare @date Date
		SELECT @date =  CAST( GETDATE() AS Date )
		Insert into Inventory (inven_quantity, inven_latest_date, inven_update_quantity) values (0, @date, 0)
		Declare @invenid int
		select @invenid = Inventory.inven_id from Inventory where Inventory.inven_id = (select top 1 Inventory.inven_id from Inventory ORDER BY Inventory.inven_id DESC)
		Declare @barcode varchar(100)
		select  @barcode  = inserted.[product_barcode] from inserted
		Update Product set inven_id = @invenid where Product.product_barcode = @barcode
	End
Go


--xoa order online

Create trigger deleteWithOrderDetail on OrderOnline
instead of delete
as 
begin

    Declare @id int
	Select @id = deleted.order_id from deleted
	delete OrderDetail where OrderDetail.order_id = @id
	delete OrderOnline where OrderOnline.order_id = @id

End

drop trigger deleteWithOrderDetail

delete OrderOnline where order_id = 8

select * from OrderOnline where order_id = 8

select * from OrderDetail