					---***SCHEMA***---
USE Calisma

CREATE SCHEMA New

CREATE TABLE New.Urunler(UrunID int IDENTITY,
						  UrunAdi varchar(30))

INSERT INTO New.Urunler VALUES('Kalem')

SELECT * FROM New.Urunler
SELECT * FROM AdvUrunler

----------------TRIGGER-----------------

INSERT INTO AdvUrunler VALUES('aaa','sarý',12,'yeni ürün')

CREATE TRIGGER t_AdvUrunler
ON AdvUrunler
AFTER INSERT --afterdan sonra insert, update, delete kullanýlabilir. hepsi birden de kullanýlabilir.
AS 
SELECT*FROM AdvUrunler
--tabloya bir ürün eklendikten sonra advürünler tablosunu göster dedik. after trigger ile.


--=====================================
--Bir stok sistemini trigger kullanarak yazýnýz.2 tablo kullanýlacak.

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
end															--ARADA GEÇÝCÝ BÝR INSERTED TABLOYU BÝLGÝLERÝ YAKALAMAK ÝÇÝN KULLANIYORUZ.
IF(@tip='Cýkýs')
begin
UPDATE Stok.Urunler SET  StokAdedi = StokAdedi-@adet
WHERE UrunID=@urunID
end																					

INSERT INTO Stok.Hareket VALUES(1002,SYSTEM_USER,40,'Giris',GETDATE())
INSERT INTO Stok.Hareket VALUES(1003,SYSTEM_USER,50,'Cikis',GETDATE())
INSERT INTO Stok.Hareket VALUES(1004,SYSTEM_USER,20,'Giris',GETDATE())

--negatif stok çalýþmayan halini örnek olarak yaz!!!
 
 --t_Stok trigger'ý triggers menusunden disable edildi baþlangýçta

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
end																	--ARADA GEÇÝCÝ BÝR INSERTED TABLOYU BÝLGÝLERÝ YAKALAMAK ÝÇÝN KULLANIYORUZ.
IF(@tip='Cýkýs')
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
   
   --after trigger kullanýnca izin vermediðim deneme de hareket tablosuna kaydedildi.
   --instead of trigger'ý kullanarak bunun yazýlmasýný engelleyebilirdim. yada yazýp silebilirim.
   
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
end																	--ARADA GEÇÝCÝ BÝR INSERTED TABLOYU BÝLGÝLERÝ YAKALAMAK ÝÇÝN KULLANIYORUZ.
IF(@tip='Cýkýs')
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
--instead of trigger da insert i trigger'in içerisine de yazmak gerekiyor.   

--Cursor Kullanýmý

DECLARE @kelime varchar(20)
DECLARE crs CURSOR FORWARD_ONLY FOR SELECT Kelime FROM Kelimeler --cursor tanýmlarken @ iþareti kullanýlmýyor.
 
OPEN crs
	FETCH NEXT FROM crs INTO @kelime
	WHILE @@FETCH_STATUS =0
		begin
		SELECT @kelime
		FETCH NEXT FROM crs INTO @kelime
		end	
CLOSE crs
DEALLOCATE crs --iþlem bittikten sonra kullanýlan kaynaklarý boþaltýyor.

--cursor ile kayýtlara teker teker ulaþabiliyoruz.
------------------------------------

--YASAKLI KELÝMELER

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

CREATE TRIGGER t_asd --yeni bir tablo oluþturmayý engellemek için yazýldý
ON DATABASE         --istenirse server için v.s de yazýlabilir.
FOR CREATE_TABLE
AS
ROLLBACK TRANSACTION
CREATE TABLE Deneme2 (ID int IDENTITY,ad varchar(100))


CREATE TRIGGER t_dropp --yeni bir tablo düþürmeyi engellemek için yazýldý
ON DATABASE         --istenirse server için v.s de yazýlabilir.
FOR DROP_TABLE
AS
print 'Tablo Silemezsiniz'  --bunlarý programmability-->database triggers dan disable yapmayý unutma yoksa iþlem yapmana izin vermiyor.
ROLLBACK TRANSACTION

drop table Deneme2

-----*****View*****-----

--bant geniþliði üzerine olumlu etkisi var ve select cümleleri ile birlikte kullanýlabiliyor.
--sorgularda yazarken çalýþtýrýrken kullanýlýr.
--joinsiz tablolarda view kullanarak insert yapýlabiliyor..

use AdventureWorks2016CTP3


CREATE VIEW v_urunler
AS
SELECT        Production.Product.Name AS Ürün, Production.ProductCategory.Name AS Kategori, Production.ProductSubcategory.Name AS AltKategori
FROM            Production.Product INNER JOIN
                         Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN
                         Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID


SELECT * FROM v_urunler
WHERE Kategori='Components'			

			 --raporlamalar view üzerinden yapýlýr.


use Calisma

CREATE VIEW v_personeller
AS
SELECT * FROM Personeller

INSERT INTO v_personeller VALUES ('HASAN','KOTAN',12,'Satis') --view ismi üzerinden insert yapýlabilir.
										--ama tablo joinsiz olmalý kesinlikle.