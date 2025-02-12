use Northwind

select * from Categories
select * from Products
select * from Customers

select * from Categories
select ProductId, ProductName, UnitPrice, UnitsInStock from Products where CategoryID=3

select ProductId, ProductName, UnitPrice, UnitsInStock from Products where CategoryID=4 order by ProductName

-- IS Null- Is Not Null---> koþulda belirtilen alanýn boþ (NULL) olanlarýný ya da boþ olmayanlarýný (NOT NULL) getirir.
select * from Customers where Fax is null
select * from Customers where Region is not null
-- bu iki sorgu ayný iþi yapmaktadýr. yani ayný verileri getirmektedir.
select * from Products where UnitsInStock between 20 and 50
select * from Products where UnitsInStock >=20 and UnitsInStock <=50

select * from Customers where Country='Canada'
--36,15 kalýnan sire  08/08/24