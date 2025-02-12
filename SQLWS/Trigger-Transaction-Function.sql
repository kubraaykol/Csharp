/*
	TRIGGER

	Kullanýcý tarafýdan yapýlmak istenen iþlemleri otomatik olarak yapmamýzý saðlayan bir yapýdýr. Triggerlar AFTER (Sonra) ve INSTEAD OF (YERÝNE)instead of olarak 2 türlü yapýlardýr.
	AFTER	: Bir iþlem yapýldýktan sonra yapýlmasý gereken iþlemleri yapar
*/

--AFTER TRIGGER

--Kategori tablosuna kayýt ekledikten sonra eklediðimiz kaydý gösteren trigger

create trigger CategoryAdd -- Trigger oluþturulup isim verildi
on Categories --Trigger hangi tablo üzerinde tanýmlý
after insert --Trigger modu
as
select * from Categories where CategoryID=(select CategoryID from inserted)

insert into Categories (CategoryName, Description) values ('Cep Telefonu','Cep Telefon Modelleri')

--ÜrünAdý		  - Fiyatý - Category - IsDeleted
-- TV-15TV1242		15000		3			1

select * from Products

--Products tablosundan bir ürün silmek istediðimde o ürünü silmesin Discontinued alanýný true yapsýn

create trigger DeleteProduct
on Products
instead of delete
as
update Products set Discontinued=1 where ProductID=(select ProductID from deleted)

delete from Products where ProductID=1
select * from Products

--Products tablosuna yeni ürün kaydý yapýldýktan sonra eklenen kaydýn bilgilerini gösteren trigger

create trigger AddProduct
on Products
after insert
as
declare @id int --deðiþken tanýmlýyoruz
select @id=ProductID from inserted
select * from Products where ProductID=@id

insert into Products (ProductName,UnitPrice,UnitsInStock,Discontinued) values ('DenemeTrigger',26,17,0)

use BankDb
select * from Accounts

create proc sp_MoneyTransfer
(
	@sender char(11),
	@recipient char(11),
	@amount decimal(18,2)
)
as
begin try
	update Accounts set Balance-=@amount where IdentityNumber=@sender

	update Accounts set Balance+=@amount where IdentityNumber=@recipient
end try
begin catch
	print 'Ýþlem sýrasýnda bir hata meydana geldi'
end catch



exec sp_MoneyTransfer '12345678901','11223344556',500

exec sp_MoneyTransfer '11111111111','11223344556',500

create proc sp_MoneyTransferWithTransaction
(
	@sender char(11),
	@recipient char(11),
	@amount decimal(18,2)
) as
begin try
	begin transaction
		update Accounts set Balance-=@amount where IdentityNumber=@sender
		if(@@ROWCOUNT=0)
		begin
			raiserror('Yanlýþ Gönderici No',16,1)
		end
		update Accounts set Balance+=@amount where IdentityNumber=@recipient
		if(@@ROWCOUNT=0)
		begin
			raiserror('Yanlýþ Alýcý No',16,1)
		end
	commit transaction
end try
begin catch
	rollback transaction
	print 'Error : ' + Error_Message()
end catch

create proc sp_MoneyTransferWithSaveTransaction
(	@identityNumber char(11),
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@balance decimal(18,2),
	@sender char(11),
	@recipient char(11),
	@amount decimal(18,2)
) as
begin try
	begin transaction
		insert into Accounts values (@identityNumber,@firstName,@lastName,@balance)
		save transaction AccountAdded
		if exists(select 1 from Accounts where IdentityNumber=@sender)
		begin
			update Accounts set Balance-=@amount where IdentityNumber=@sender
		end
		else
		begin
			raiserror('Yanlýþ Gönderici No',16,1)
		end
		if exists(select 1 from Accounts where IdentityNumber=@recipient)
		begin
			update Accounts set Balance+=@amount where IdentityNumber=@recipient
		end
		else
		begin
			raiserror('Yanlýþ Alýcý No',16,1)
		end
	commit transaction
end try
begin catch
	rollback transaction AccountAdded
	print 'Error : ' + Error_Message()
end catch

exec sp_MoneyTransferWithTransaction '11223344556','12345678901',500
exec sp_MoneyTransfer '11223344556','12345678901',500

exec sp_MoneyTransferWithTransaction '111111111111','11223344556',500
exec sp_MoneyTransferWithTransaction '11223344556','111111111111',500

select * from Accounts where Id=9
exec sp_MoneyTransferWithSaveTransaction '99988877766','Sergen','Yalçýn',16575,'11223344556','111111111111',500
exec sp_MoneyTransferWithSaveTransaction '99988877766','Ergün','Pembe',12575,'111111111111','11223344556',500
exec sp_MoneyTransferWithSaveTransaction '99888777666','Ferdi','Kadýoðlu',12575,'11223344556','10987654321',1000


/**

--------------	FUNCTIONS   -------------------

1-Scalar Valued -> Tek bir deðer döndüren fonksiyonlar
2-Table Valued  -> Tablo döndüren fonksiyonlar


*/


select * from Accounts
select sum(Balance) from Accounts --Scalar Function

select avg(Balance) from Accounts

select COUNT(*) from Accounts 

create function AddedNumbers
(
	@number1 int,
	@number2 int
)
returns int
as
begin
	return @number1+@number2
end

select dbo.AddedNumbers(7,5) as Total

create function FullName
(
	@firstName nvarchar(50),
	@lastName nvarchar(50)
)
returns nvarchar(100)
as
begin
return @firstName + ' ' + @lastName
end

create function CreateEmail
(
	@firstName nvarchar(50),
	@lastName nvarchar(50)
)
returns nvarchar(200)
as
begin
return (lower(left(@firstName,1))+'.' + lower(@lastName)+'@istanbulegitimakademi.com')
end

select FirstName,LastName,IdentityNumber, dbo.CreateEmail(FirstName,LastName) from Accounts

alter function UnitPriceWithTax
(
	@unitPrice decimal(18,2),
	@tax int
)
returns decimal(18,2)
as
begin
	return @unitPrice + (@unitPrice * @tax / 100)
end

select dbo.FullName('Akýn','Cengiz') as FullName
select IdentityNumber,FirstName,LastName,dbo.FullName(FirstName,LastName),Balance from Accounts
select dbo.UnitPriceWithTax(1000,18)

/*
	public int AddedNumbers(int number1,int number2)
	{
	
		cw('dfdgfgdfgfdgfdgfdgdf');

	}


*/

use Northwind

--Table Valued Function -> Tablo döndüren function

create function GetAllProducts
(
)
returns table
as
return (select * from Products)

select * from GetAllProducts()

create function GetProductsByCategory
(
	@categoryId int
)
returns table
as
return (select ProductID, ProductName,UnitPrice,UnitsInStock,CategoryID from Products where CategoryID=@categoryId)

select * from GetProductsByCategory(2)

create function GetCustomersByCountry
(
	@country nvarchar(15)
)
returns table
as
return (select * from Customers where Country=@country)

select * from GetCustomersByCountry('Germany')