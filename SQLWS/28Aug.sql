/*
TRIGGER

Kulanýcý tarafýndan yapýlmak istenen iþlemleri otomatik olarak yapmamýzý saðlayan
bir yapýdýr. Triggerlar AFTER (Sonra) ve INSTEAD OF (Yerine) instead of olarak  türlü yapýlardýr.

AFTER: Bir iþlem yapýldýktan sonra yapýlmasý gereken iþlemleri yapar
*/

--AFTER TRIGGER 

creat trigger CategoryAdd-- Trigger oluþturulup isim verildi.
on Categories --Trigger hangi tablo üzerinde tanýmlý 
after insert-- Trigger modu
as
select * from Categories where CategoryID=(select CategoryID from inserted)

insert into Categories (categoryName, Description) values ('Cep Telefonu', 'Cep Telefonu Modelleri')

--Ürün Adý    -Fiyatý  -Category   -IDeleted
--  TV-15TV1242 15000   3               1


/*
FUNCTIONS 

--Fonksiyonlar sadece select etiketi altýnda çalýþýr.
--MTODLAR RETURN ÝLE BÝTER DEÐER DÖNDÜRÜYORSA