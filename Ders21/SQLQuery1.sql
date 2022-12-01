 ---*** ERROR HANDLING ***---
 begin try
	RAISERROR('HATA',16,1)-- hata öncelikleri 15e kadar sql serverda sen tanýmlarsan 16dan baþlýyorsun.
end try

begin catch
	print 'Bir HATA oluþtu....'
end catch

USE Calisma

CREATE PROCEDURE StokGuncelle @ID int, @adet int
AS
DECLARE @stok int
SELECT @stok=StokAdedi FROM Stok.Urunler WHERE UrunID=@ID
IF(@stok< ABS(@adet))
begin
	begin try
		RAISERROR('Stokta HATA',16,1)
	end try

	begin catch
		print 'stokta yeterli urun yok'
	end catch
end
else
UPDATE Stok.Urunler SET StokAdedi = StokAdedi + @adet
WHERE  UrunID=@ID


select * from Stok.Urunler
execute StokGuncelle 1002,-250

----------------------------------
--TRANSACTION
--Parcalanamaz yapý olusturur. Hata durumunda ROLLBACK yapýlýr. COMMIT olursa islem gecerlidir.
CREATE SCHEMA Banka

CREATE TABLE Banka.Musteri(MusID int IDENTITY PRIMARY KEY,
                           MusAdi varchar(20),
						   MusSoyad varchar(20),
						   Bakiye Money)

CREATE TABLE Banka.Hareket(HID int IDENTITY PRIMARY KEY,
                           KimdenID int,
						   KimeID int,
						   Miktar money,
						   islemTarihi smalldatetime)

INSERT INTO Banka.Musteri VALUES('Cevdet','Korkmaz',1000),('Selami','Bayrak',2200),('Dursun','Durmasin',3000)


SELECT * FROM Banka.Musteri
SELECT * FROM Banka.Hareket

ALTER PROCEDURE BankaHavale @Kimden int, @Kime int, @Miktar money
AS
DECLARE @bakiye money
SELECT @bakiye = Bakiye FROM Banka.Musteri 
WHERE MusteriID = @Kimden
if(@bakiye > @Miktar)
begin
begin try
begin transaction
INSERT INTO Banka.Hareket VALUES(@Kimden,@Kime,@Miktar,GETDATE())  --instead of trigger
UPDATE Banka.Musteri SET Bakiye = Bakiye - @Miktar
WHERE MusteriID = @Kimden
--raiserror('HATA',16,1)
UPDATE Banka.Musteri SET Bakiye = Bakiye + @Miktar
WHERE MusteriID = @Kime
COMMIT --Problem yoksa islemi tamamla
end try
begin catch
 ROLLBACK --hata oluncaya kadar yapýlan tüm iþlemleri geri al
 PRINT 'Gecersiz islem yürütüldü...'
end catch
end --if
else
print 'Yetersiz Bakiye...'

exec BankaHavale 3,1,5000
exec BankaHavale 3,1,100

exec BankaHavale 2,1,200 

SELECT * FROM Banka.Musteri
SELECT * FROM BAnka.Hareket

----------------------------------------
CREATE SCHEMA Kume

CREATE TABLE Kume.Musteriler(MusID int IDENTITY PRIMARY KEY,
							 MusAdi varchar(20),
							 MusSoyad varchar(20))


CREATE TABLE Kume.Personeller(PerID int IDENTITY PRIMARY KEY,
							 PerAdi varchar(20),
							 PerSoyad varchar(20))


INSERT INTO Kume.Musteriler VALUES ('Cevdet','Korkmaz'),('Selami','Bayrak'),('Dursun','Durmasýn')
INSERT INTO Kume.Personeller VALUES ('Kemal','Kendir'),('Selami','Sancak'),('Temel','Durak')

SELECT * FROM Kume.Musteriler
SELECT * FROM Kume.Personeller

----------------------------
SELECT MusAdi AS AD, MusSoyad AS SOYAD FROM Kume.Musteriler --ayný sütun sayýsýna sahip ve foreign key içermeyen
UNION      --iki tabloyu UNION komutuyla birleþtirebiliyoruz.
SELECT PerAdi AS AD, PerSoyad AS SOYAD FROM Kume.Personeller
---------------------------------
SELECT MusAdi AS AD FROM Kume.Musteriler 
INTERSECT      --kesiþim
SELECT PerAdi AS AD FROM Kume.Personeller
-------------------------------------------
SELECT MusAdi AS AD FROM Kume.Musteriler 
EXCEPT     --A-B iþlemini yapýyor
SELECT PerAdi AS AD FROM Kume.Personeller

SELECT PerAdi AS AD FROM Kume.Personeller
EXCEPT  --B-A iþemini yapýyor. except kümelerde fark iþlemini yapýyor.
SELECT MusAdi AS AD FROM Kume.Musteriler
---------------------------------------------------------

select ROW_NUMBER() OVER(ORDER BY BolumAdi) AS SIRA_NO,BolumAdi from Bolum--satýrlarý 1den baþlayarak numaralandýrdýk.

---------------------------------------------------------
USE AdventureWorks2016CTP3

----NestedSelects----
--join kullanmadan tablo birleþtirme ?

SELECT * FROM Sales.SalesOrderHeader
SELECT * FROM Sales.SalesOrderDetail


--1) column kýsmýna (*'ýn yazýldýðý kýsma) bir sorgu daha yazýlabiliyor.
SELECT SalesOrderID,
 (SELECT COUNT(*) FROM Sales.SalesOrderDetail WHERE SalesOrderID=SOH.SalesOrderID) AS Kalem
 FROM Sales.SalesOrderHeader AS SOH
 ORDER BY Kalem DESC

 --2) WHERE'den sonra bir sorgu daha yazýlabiliyor.

 SELECT * FROM Sales.SalesOrderHeader
 WHERE SalesOrderID=64111 OR SalesOrderID= 71033


  SELECT * FROM Sales.SalesOrderHeader
 WHERE SalesOrderID IN (64111,71033) -- yukarýdakini daha kolay þekilde yapabilmek için kullaným.


  SELECT * FROM Sales.SalesOrderHeader
 WHERE SalesOrderID IN (SELECT SalesOrderID FROM Sales.SalesOrderDetail
 WHERE OrderQty>10 ) --2. select deki adresle 1.deki ayný olmalý salesorderID...)


 --3)FROM dan sonra select cümlesi yazýlabilir.

 SELECT * FROM (SELECT *FROM Sales.SalesOrderDetail
 WHERE UnitPrice <100 ) AS TBL --isim vermezsen hata veriyor.
