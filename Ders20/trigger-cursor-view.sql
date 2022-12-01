					---***SCHEMA***---
USE Calisma

CREATE SCHEMA New

CREATE TABLE New.Urunler(UrunID int IDENTITY,
						  UrunAdi varchar(30))

INSERT INTO New.Urunler VALUES('Kalem')

SELECT * FROM New.Urunler
SELECT * FROM AdvUrunler

----------------TRIGGER-----------------

INSERT INTO AdvUrunler VALUES('aaa','sar�',12,'yeni �r�n')

CREATE TRIGGER t_AdvUrunler
ON AdvUrunler
AFTER INSERT --afterdan sonra insert, update, delete kullan�labilir. hepsi birden de kullan�labilir.
AS 
SELECT*FROM AdvUrunler
--tabloya bir �r�n eklendikten sonra adv�r�nler tablosunu g�ster dedik. after trigger ile.


--=====================================
--Bir stok sistemini trigger kullanarak yaz�n�z.2 tablo kullan�lacak.

CREATE SCHEMA Stok

CREATE TABLE Stok.Urunler(UrunID int IDENTITY PRIMARY KEY,
						  UrunAdi varchar(50),
						  StokAdedi int)

CREATE TABLE Stok.Hareket(HID int IDENTITY PRIMARY KEY,
						  UrunID int REFERENCES Stok.Urunler(UrunID),
						  IslemiYapan varchar(50),
						  IslemAdedi int,
						  IslemTipi varchar(20),
						  Tarih smalldatetime)
						  
INSERT INTO Stok.Urunler VALUES('Kalem',500),('Silgi',200),('Defter',100)


SELECT * FROM Stok.Urunler
SELECT *FROM Stok.Hareket

CREATE TRIGGER t_Stok
ON Stok.Hareket 
AFTER INSERT
AS
DECLARE @urunID int
DECLARE @tip varchar(20)
DECLARE @adet int
SELECT @urunID=UrunID,@adet=IslemAdedi,@tip=IslemTipi FROM inserted--INSERTED TABLOSU INSERT ISLEMINDE DELETED TABLOSU UPDATE VE DELETE ISLEMINDE KULLANILIYOR
IF(@tip='Giris')
begin
UPDATE Stok.Urunler SET StokAdedi = StokAdedi+@adet
WHERE UrunID=@urunID
end															--ARADA GE��C� B�R INSERTED TABLOYU B�LG�LER� YAKALAMAK ���N KULLANIYORUZ.
IF(@tip='C�k�s')
begin
UPDATE Stok.Urunler SET  StokAdedi = StokAdedi-@adet
WHERE UrunID=@urunID
end																					

INSERT INTO Stok.Hareket VALUES(1002,SYSTEM_USER,40,'Giris',GETDATE())
INSERT INTO Stok.Hareket VALUES(1003,SYSTEM_USER,50,'Cikis',GETDATE())
INSERT INTO Stok.Hareket VALUES(1004,SYSTEM_USER,20,'Giris',GETDATE())

--negatif stok �al��mayan halini �rnek olarak yaz!!!
 
 --t_Stok trigger'� triggers menusunden disable edildi ba�lang��ta

CREATE TRIGGER Stok.t_StokPozitif
ON Stok.Hareket
AFTER INSERT
AS
DECLARE @urunID int
DECLARE @tip varchar(20)
DECLARE @adet int
SELECT @urunID=UrunID,@adet=IslemAdedi,@tip=IslemTipi FROM inserted--INSERTED TABLOSU INSERT ISLEMINDE DELETED TABLOSU UPDATE VE DELETE ISLEMINDE KULLANILIYOR
IF(@tip='Giris')
begin
UPDATE Stok.Urunler SET StokAdedi = StokAdedi+@adet
WHERE UrunID=@urunID
end																	--ARADA GE��C� B�R INSERTED TABLOYU B�LG�LER� YAKALAMAK ���N KULLANIYORUZ.
IF(@tip='C�k�s')
begin
DECLARE @stok int
SELECT @stok=StokAdedi FROM Stok.Urunler WHERE UrunID=@urunID
if(@adet<=@stok)
begin
UPDATE Stok.Urunler SET StokAdedi = StokAdedi-@adet
WHERE UrunID=@urunID
end	
else
 print 'Stok Yetersiz....'
end

																			
INSERT INTO Stok.Hareket VALUES(1002,SYSTEM_USER,40,'Giris',GETDATE())
INSERT INTO Stok.Hareket VALUES(1003,SYSTEM_USER,350,'Cikis',GETDATE())
INSERT INTO Stok.Hareket VALUES(1004,SYSTEM_USER,200,'Cikis',GETDATE())
   
   --after trigger kullan�nca izin vermedi�im deneme de hareket tablosuna kaydedildi.
   --instead of trigger'� kullanarak bunun yaz�lmas�n� engelleyebilirdim. yada yaz�p silebilirim.
   
CREATE TRIGGER Stok.t_StokPozitifHarKayYok
ON Stok.Hareket
INSTEAD OF INSERT
AS
DECLARE @urunID int
DECLARE @tip varchar(20)
DECLARE @adet int
SELECT @urunID=UrunID,@adet=IslemAdedi,@tip=IslemTipi FROM inserted--INSERTED TABLOSU INSERT ISLEMINDE DELETED TABLOSU UPDATE VE DELETE ISLEMINDE KULLANILIYOR
IF(@tip='Giris')
begin
UPDATE Stok.Urunler SET StokAdedi = StokAdedi+@adet
WHERE UrunID=@urunID
INSERT INTO Stok.Hareket VALUES (@urunID,SYSTEM_USER,@adet,'Giris',GETDATE())
end																	--ARADA GE��C� B�R INSERTED TABLOYU B�LG�LER� YAKALAMAK ���N KULLANIYORUZ.
IF(@tip='C�k�s')
begin
DECLARE @stok int
SELECT @stok=StokAdedi FROM Stok.Urunler WHERE UrunID=@urunID
if(@adet<=@stok)
begin
UPDATE Stok.Urunler SET StokAdedi = StokAdedi-@adet
WHERE UrunID=@urunID
INSERT INTO Stok.Hareket VALUES (@urunID,SYSTEM_USER,@adet,'Cikis',GETDATE())
end	
else
 print 'Stok Yetersiz....'
end    

INSERT INTO Stok.Hareket VALUES(1004,SYSTEM_USER,200,'Cikis',GETDATE())
INSERT INTO Stok.Hareket VALUES(1002,SYSTEM_USER,200,'Cikis',GETDATE())

SELECT * FROM Stok.Urunler
SELECT *FROM Stok.Hareket
--instead of trigger da insert i trigger'in i�erisine de yazmak gerekiyor.   

--Cursor Kullan�m�

DECLARE @kelime varchar(20)
DECLARE crs CURSOR FORWARD_ONLY FOR SELECT Kelime FROM Kelimeler --cursor tan�mlarken @ i�areti kullan�lm�yor.
 
OPEN crs
	FETCH NEXT FROM crs INTO @kelime
	WHILE @@FETCH_STATUS =0
		begin
		SELECT @kelime
		FETCH NEXT FROM crs INTO @kelime
		end	
CLOSE crs
DEALLOCATE crs --i�lem bittikten sonra kullan�lan kaynaklar� bo�alt�yor.

--cursor ile kay�tlara teker teker ula�abiliyoruz.
------------------------------------

--YASAKLI KEL�MELER

CREATE TABLE Kelimeler(ID int IDENTITY PRIMARY KEY,
					   Kelime varchar(20))

CREATE TABLE Mesajlar(MesajID int IDENTITY PRIMARY KEY,
					  Mesaj varchar(100))

INSERT INTO Kelimeler VALUES('aaa'),('bbb'),('ccc')

SELECT *FROM Kelimeler
SELECT * FROM Mesajlar

CREATE TRIGGER t_mesajlar
ON Mesajlar
INSTEAD OF INSERT
AS
DECLARE @kelime varchar(10)
DECLARE @varMi bit = 0 
DECLARE @mesaj varchar(100)
DECLARE _cursor CURSOR FORWARD_ONLY
FOR SELECT Kelime FROM Kelimeler
OPEN _cursor
FETCH NEXT FROM _cursor INTO @kelime
WHILE @@FETCH_STATUS = 0 
begin
		SELECT @mesaj = Mesaj FROM inserted
		IF(CHARINDEX(@kelime,@mesaj,1)>0)
		begin
				SET @varMi = 1
				BREAK
		end
		FETCH NEXT FROM _cursor INTO @kelime
end
IF(@varMi=0)
begin
	INSERT INTO Mesajlar VALUES(@mesaj)
end

CLOSE _cursor
DEALLOCATE _cursor



INSERT INTO Mesajlar VALUES('Bugun hava cok guzel aaa...')
SELECT*FROM Mesajlar

--3)Database Trigger ---ddl trigger

CREATE TRIGGER t_asd --yeni bir tablo olu�turmay� engellemek i�in yaz�ld�
ON DATABASE         --istenirse server i�in v.s de yaz�labilir.
FOR CREATE_TABLE
AS
ROLLBACK TRANSACTION
CREATE TABLE Deneme2 (ID int IDENTITY,ad varchar(100))


CREATE TRIGGER t_dropp --yeni bir tablo d���rmeyi engellemek i�in yaz�ld�
ON DATABASE         --istenirse server i�in v.s de yaz�labilir.
FOR DROP_TABLE
AS
print 'Tablo Silemezsiniz'  --bunlar� programmability-->database triggers dan disable yapmay� unutma yoksa i�lem yapmana izin vermiyor.
ROLLBACK TRANSACTION

drop table Deneme2

-----*****View*****-----

--bant geni�li�i �zerine olumlu etkisi var ve select c�mleleri ile birlikte kullan�labiliyor.
--sorgularda yazarken �al��t�r�rken kullan�l�r.
--joinsiz tablolarda view kullanarak insert yap�labiliyor..

use AdventureWorks2016CTP3


CREATE VIEW v_urunler
AS
SELECT        Production.Product.Name AS �r�n, Production.ProductCategory.Name AS Kategori, Production.ProductSubcategory.Name AS AltKategori
FROM            Production.Product INNER JOIN
                         Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN
                         Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID


SELECT * FROM v_urunler
WHERE Kategori='Components'			

			 --raporlamalar view �zerinden yap�l�r.


use Calisma

CREATE VIEW v_personeller
AS
SELECT * FROM Personeller

INSERT INTO v_personeller VALUES ('HASAN','KOTAN',12,'Satis') --view ismi �zerinden insert yap�labilir.
										--ama tablo joinsiz olmal� kesinlikle.