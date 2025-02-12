use LibraryDb
------TRIGGER(TETÝKLEYÝCÝ)-----
--Bir tabloda yapýlan herhangi bir iþlem diðer tabloda bir deðiþiklik yapýlmasýný 
--gerektiriyorsa bu durumlarda trigger kullanýlýr.

--Yapýlacak iþlem türüne göre insert- update-delete olarak adlandýrýlýr.
select * from Books
select * from Borrowings

--create trigger TrigerIsmi
--on TabloAdi
--after insert,update,delete
--as
--begin
--sql komutlarý (update from Books set Stock-1 where BookId=5)
--end

--ÖRNEK
create trigger BorrowingInsert
on Borrowings
after insert
as
begin
	update Books set @Stock -=1 where 
end
