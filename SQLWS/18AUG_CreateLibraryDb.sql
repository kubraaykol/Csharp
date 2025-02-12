--KÜTÜPHANE VERÝTABANI--
----TABLOLAR
--Kitaplar
--Yazarlar
--Üyeler
--Kategoriler
--Yayýnevleri
--Kiralama Ýþlemleri(borrowing)+


--KÝTAPLAR TABLOSU
--Id
--Baþlýk/Title
--Mevcut mu/IsAvailable
--Stok .adedi/Stock

--YAZARLAR TABLOSU
--AUTHORS
--Id
--Adý/FirstName
--Soyadý/LastName

--YAZARLAR(Authors) VE KÝTAPLAR TABLOSU
--AuthorsAndBooks/BookAuthors/AuthorBooks
--Id
--AuthorId
--BookId

--YAYINEVLERÝ TABLOSU
--PublishingHouses
--Id
--BookId
--PublishingHouseId



--ÜYELER TABLOSU
--Members
--Id
--FirstName
--LastName
--Telefon
--Email
--MemberDate
--BirthDate
--TCKimlikNo

--KÝRALAMA ÝÞLEMLERÝ TABLOSU
--RentProcess
--Id
--Kiralama Tarihi/StartDate
--KiralamaSüresi/DateCount
--Computed/Ýade Tarihi/ReturnDate
--MemberId
--BookId
--Durum/IsState


create database LibraryDb
go
use LibraryDb

--KATEGORÝLER TABLOSU
--Categories
--Id
--Name
create table Categories(
Id int primary key identity(1,1),
[Name] nvarchar(50) not null
)
--1:44:49/18Aug