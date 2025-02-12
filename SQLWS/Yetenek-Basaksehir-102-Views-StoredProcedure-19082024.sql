use LibraryDb 


insert into Categories values
('Roman'),('Þiir'),('Deneme'),('Biyorafi'),('Söyleþi')

select * from Categories

insert into Authors values
('Victor','Hugo'),
('Ali','Kýlýç'),
('Matt','Haig'),
('Jack','London'),
('Ýclal','Aydýn'),
('Ayþe','Kulin')

select * from Authors

insert into Books values
('Sefiller',1,9,1),
('Beser Hatun',1,5,1),
('Gece Yarýsý Kütüphanesi',1,7,1),
('Martin Eden',1,4,1),
('Salkým Sokak No:3',1,7,1),
('Bir Ýdam Mahkumunun Son Günü',1,8,1),
('4 Gün 3 Gece',1,6,1)

select * from Books
select * from Authors

insert into AuthorsAndBooks values
(1,1),(2,2),(3,3),(4,4),(5,6),(6,5)

insert into PublishingHouses values
('Can Yayýnlarý'),('Ýþ Bankasý Kültür Yayýnlarý'),('Alfa Yayýnlarý'),('Ýletiþim Yayýnlarý')

select * from PublishingHouses
select * from Books

insert into BooksAndPublishingHouses values
(1,4),(2,1),(3,4),(4,2),(5,3),(6,2)

insert into Members values
('12345678901','Ali','Eren','2000-08-23','02581473698','alieren@xyz.com',GETDATE()),
('12345678901','Ayþe Eda','Esen','2001-08-23','02524473698','ayseeda@xyz.com',GETDATE()),
('12345678901','Büþra','Aknar','2002-08-23','02581473612','busraaknar@xyz.com',GETDATE()),
('12345678901','Ebru','Dinç','1999-08-23','02581473634','ebrudinc@xyz.com',GETDATE()),
('12345678901','Emirhan Hüseyin','Emek','1997-08-23','02581473636','emirhanhuseyin@xyz.com',GETDATE()),
('12345678901','Erkan','Hayta','1995-08-23','02581473693','erkanhayta@xyz.com',GETDATE()),
('12345678901','Fatma','Karpýnar','2000-08-23','02581473698','fatmakarpinar@xyz.com',GETDATE()),
('12345678901','Harun','Özdemir','2000-08-23','02581473698','harunozdemir@xyz.com',GETDATE()),
('12345678901','Meryem','Yavuz','2000-08-23','02581473698','meryemyavuz@xyz.com',GETDATE()),
('12345678901','Metinhan','Han','2000-08-23','02581473698','metinhan@xyz.com',GETDATE())

select * from Members

select * from Borrowings

insert into Borrowings values
('2023-5-3',15,6,4,0),
('2024-5-3',15,5,3,0),
('2023-5-3',15,4,2,0),
('2023-5-3',15,7,1,0),
('2023-5-3',15,11,5,0),
('2023-5-3',15,8,6,0)

select * from Authors
select * from Books

--1-Kitaplarý kategori adýyla birlikte getirin
--2-Kitaplarý yazarlarýyla birlikte getirin
--3-Kitaplarý yazarlarý ve kategorileri ile birlikte getirin
--4-Kitaplarý yayýnevleri ile birlikte getirin
--5-Kitaplarý yazarlarý, yayýn evleri ve kategorileri ile birlikte getirin

SELECT B.Title, C.Name FROM Books B
INNER JOIN Categories C ON C.Id = B.CategoryId

SELECT B.Title, A.FirstName, A.LastName FROM Books B
INNER JOIN AuthorsAndBooks AB ON B.Id = AB.BookId
INNER JOIN Authors A ON A.Id = AB.AuthorId

SELECT B.Title,C.Name, A.FirstName, A.LastName FROM Books B
INNER JOIN Categories C ON C.Id = B.CategoryId
INNER JOIN AuthorsAndBooks AB ON B.Id = AB.BookId
INNER JOIN Authors A ON A.Id = AB.AuthorId


--4-Kitaplarý yayýnevleri ile birlikte getirin
select b.Title,ph.Name from Books as b 
inner join BooksAndPublishingHouses as bph on b.Id=bph.BookId
inner join PublishingHouses as ph on bph.PublishingHouseId=ph.Id 

SELECT B.Title,C.Name,P.Name, A.FirstName, A.LastName FROM Books B
INNER JOIN Categories C ON C.Id = B.CategoryId
INNER JOIN AuthorsAndBooks AB ON B.Id = AB.BookId
INNER JOIN Authors A ON A.Id = AB.AuthorId
INNER JOIN BooksAndPublishingHouses BP ON BP.BookId = B.Id 
INNER JOIN PublishingHouses P ON P.Id = BP.PublishingHouseId


----------------------VÝEWS--------------------------

create view vw_GetBooksWithCategoryName
as
select b.Id,b.Title,b.IsAvailable, b.Stock,c.Name from Books as b 
inner join Categories as c on b.CategoryId=c.Id

select * from vw_GetBooksWithCategoryName


create view vw_GetBooksWithAuthor
as
select b.Id,b.Title,b.IsAvailable, b.Stock, a.FirstName,a.LastName from Books as b 
inner join AuthorsAndBooks as ab on b.Id=ab.BookId
inner join Authors as a on a.Id=ab.AuthorId

select * from vw_GetBooksWithAuthor

select Title,FirstName,LastName from vw_GetBooksWithAuthor


--3-Kitaplarý yazarlarý ve kategorileri ile birlikte getirin
--4-Kitaplarý yayýnevleri ile birlikte getirin
--5-Kitaplarý yazarlarý, yayýn evleri ve kategorileri ile birlikte getirin

CREATE VIEW VW_GetBookWithCategoryPublisherAndAuthor AS
SELECT B.Title, C.Name AS Category, P.Name AS Publisher, A.FirstName, A.LastName FROM Books B
INNER JOIN Categories C ON C.Id = B.CategoryId
INNER JOIN AuthorsAndBooks AB ON B.Id = AB.BookId
INNER JOIN Authors A ON A.Id = AB.AuthorId
INNER JOIN BooksAndPublishingHouses BP ON BP.BookId = B.Id 
INNER JOIN PublishingHouses P ON P.Id = BP.PublishingHouseId

select * from VW_GetBookWithCategoryPublisherAndAuthor

--VIEWS GÜNCELLEME
ALTER VIEW VW_GetBookWithCategoryPublisherAndAuthor AS
SELECT B.Title, C.Name AS Category, P.Name AS Publisher, A.FirstName + ' '+ A.LastName as Yazar FROM Books B
INNER JOIN Categories C ON C.Id = B.CategoryId
INNER JOIN AuthorsAndBooks AB ON B.Id = AB.BookId
INNER JOIN Authors A ON A.Id = AB.AuthorId
INNER JOIN BooksAndPublishingHouses BP ON BP.BookId = B.Id 
INNER JOIN PublishingHouses P ON P.Id = BP.PublishingHouseId

select * from VW_GetBookWithCategoryPublisherAndAuthor

drop view vw_GetBooksWithAuthor

select * from Borrowings


create view vw_GetBorrwings as
select br.Id, m.FirstName + ' ' + m.LastName as Uye,b.Title as Kitap, br.BorrowingDate, br.ReturnDate from Borrowings as br 
inner join Books as b on br.BookId=b.Id
inner join Members as m on br.MemberId=m.Id

select * from vw_GetBorrwings

--Borrowing tablosunda BorrowingDate, ReturnDate, Üye Adý, Kitap adý, kitabýn yazarý ve yayýnevi bilgileriini getiren view oluþturun

select * from Borrowings

create view vw_GetBorrowingsDetails as
select br.BorrowingDate as 'Odunc Alýndýðý Tarih', br.ReturnDate as 'Teslim Edilecek Tarih',m.FirstName + ' ' + m.LastName as Uye, b.Title as Kitap, a.FirstName + ' ' + a.LastName as Yazar, p.Name as 'Yayin Evi' from Borrowings as br
inner join Members as m on br.MemberId=m.Id
inner join Books as b on br.BookId=b.Id
inner join AuthorsAndBooks as ab on b.Id=ab.BookId
inner join Authors as a on a.Id=ab.AuthorId
inner join BooksAndPublishingHouses as bph on b.Id=bph.BookId
inner join PublishingHouses as p on bph.PublishingHouseId=p.Id

select * from vw_GetBorrowingsDetails

--CREATE VIEW VW_GetBorrowingsWithAuthorsAndPublisher AS
--SELECT BO.BorrowingDate, BO.ReturnDate, M.FirstName + ' ' + M.LastName AS Üye, B.Title AS Kitap, A.FirstName + ' ' + A.LastName AS Kitabýn_Yazarý, P.Name AS Yayýnevi FROM Borrowings BO 
--INNER JOIN Members M ON M.Id = BO.MemberId
--INNER JOIN Books B ON B.Id = BO.BookId
--INNER JOIN AuthorsAndBooks AB ON B.Id = AB.BookId
--INNER JOIN Authors A ON A.Id = AB.AuthorId
--INNER JOIN BooksAndPublishingHouses BP ON BP.BookId = B.Id 
--INNER JOIN PublishingHouses P ON P.Id = BP.PublishingHouseId
--GO
 
--SELECT * FROM VW_GetBorrowingsWithAuthorsAndPublisher


----------------STORED PROCEDURE------------------------

--PROCEDURE OLUÞTURMA (PARAMETRESÝZ)

--Yazar tablosunu getiren procedure
create proc sp_GetAuthors 
as
select * from Authors

--Kitap tablosunu listeleyen procedure
create proc sp_GetBooks
as
select * from Books

--Ödünç tablosunu listeleyen procedure
create proc sp_GetBorrowings 
as
select * from Borrowings

--PROCEDURE ÇALIÞTIRMAK
exec sp_GetAuthors
exec sp_GetBooks
exec sp_GetBorrowings


--PROCEDURE OLUÞTURMA (PARAMETRELÝ)

--Yazar tablosuna veri ekleyen parametreli procedure
CREATE PROCEDURE AuthorEkle
@FirstName NVARCHAR(50),
@LastName NVARCHAR(50)
AS
INSERT INTO Authors (FirstName,LastName) VALUES (@FirstName,@LastName)
SELECT * FROM Authors WHERE FirstName = @FirstName AND LastName = @LastName
GO
 
--EXEC AuthorEkle 'Yaþar', 'Kemal'

--Yzara ait kitaplarý listeleyen procedure
create proc sp_GetBooksofAuthor
@AuthorId int
as
select * from Books as b 
inner join AuthorsAndBooks as ab on b.Id=ab.BookId
inner join Authors as a on ab.AuthorId=a.Id 
where a.Id=@AuthorId

exec sp_GetBooksofAuthor 2
exec sp_GetBooksofAuthor 6

--Kitaplar tablosuna veri ekleyen procedure
create proc sp_AddBook
@title nvarchar(100),
@isAvailable bit,
@stock tinyint,
@categoryId int
as
insert into Books values (@title,@isAvailable,@stock,@categoryId)
-----------------------------------------------------------------------

exec sp_AddBook 'Tutunamayanlar',1,3,1
select * from Books

select * from Authors
select * from Books
select * from AuthorsAndBooks

insert into AuthorsAndBooks values (6,7)

CREATE PROCEDURE SP_AddCategory @Name NVARCHAR(50) AS
INSERT INTO Categories ([Name]) VALUES (@Name)
PRINT 'Ekleme iþlemi yapýldý'
SELECT * FROM Categories WHERE [Name] = @Name
PRINT 'Gösterme iþlemi yapýldý'
GO
 
EXEC SP_AddCategory 'Masal'

select * from AuthorsAndBooks

select * from Books

create proc sp_AddAuthorsAndBooks
@authorId int,
@bookId int
as
insert into AuthorsAndBooks values (@authorId,@bookId)
select b.Title,a.FirstName + ' ' + a.LastName as Author from Books as b 
inner join AuthorsAndBooks as ab on b.Id=ab.BookId 
inner join Authors as a on a.Id=ab.AuthorId 
where a.Id=@authorId and b.Id=@bookId

exec AuthorEkle 'Oðuz','Atay'

exec sp_AddAuthorsAndBooks 8,8

select * from Authors