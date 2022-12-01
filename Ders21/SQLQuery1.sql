 ---*** ERROR HANDLING ***---
 begin try
	RAISERROR('HATA',16,1)-- hata �ncelikleri 15e kadar sql serverda sen tan�mlarsan 16dan ba�l�yorsun.
end try

begin catch
	print 'Bir HATA olu�tu....'
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
--Parcalanamaz yap� olusturur. Hata durumunda ROLLBACK yap�l�r. COMMIT olursa islem gecerlidir.
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
 ROLLBACK --hata oluncaya kadar yap�lan t�m i�lemleri geri al
 PRINT 'Gecersiz islem y�r�t�ld�...'
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


INSERT INTO Kume.Musteriler VALUES ('Cevdet','Korkmaz'),('Selami','Bayrak'),('Dursun','Durmas�n')
INSERT INTO Kume.Personeller VALUES ('Kemal','Kendir'),('Selami','Sancak'),('Temel','Durak')

SELECT * FROM Kume.Musteriler
SELECT * FROM Kume.Personeller

----------------------------
SELECT MusAdi AS AD, MusSoyad AS SOYAD FROM Kume.Musteriler --ayn� s�tun say�s�na sahip ve foreign key i�ermeyen
UNION      --iki tabloyu UNION komutuyla birle�tirebiliyoruz.
SELECT PerAdi AS AD, PerSoyad AS SOYAD FROM Kume.Personeller
---------------------------------
SELECT MusAdi AS AD FROM Kume.Musteriler 
INTERSECT      --kesi�im
SELECT PerAdi AS AD FROM Kume.Personeller
-------------------------------------------
SELECT MusAdi AS AD FROM Kume.Musteriler 
EXCEPT     --A-B i�lemini yap�yor
SELECT PerAdi AS AD FROM Kume.Personeller

SELECT PerAdi AS AD FROM Kume.Personeller
EXCEPT  --B-A i�emini yap�yor. except k�melerde fark i�lemini yap�yor.
SELECT MusAdi AS AD FROM Kume.Musteriler
---------------------------------------------------------

select ROW_NUMBER() OVER(ORDER BY BolumAdi) AS SIRA_NO,BolumAdi from Bolum--sat�rlar� 1den ba�layarak numaraland�rd�k.

---------------------------------------------------------
USE AdventureWorks2016CTP3

----NestedSelects----
--join kullanmadan tablo birle�tirme ?

SELECT * FROM Sales.SalesOrderHeader
SELECT * FROM Sales.SalesOrderDetail


--1) column k�sm�na (*'�n yaz�ld��� k�sma) bir sorgu daha yaz�labiliyor.
SELECT SalesOrderID,
 (SELECT COUNT(*) FROM Sales.SalesOrderDetail WHERE SalesOrderID=SOH.SalesOrderID) AS Kalem
 FROM Sales.SalesOrderHeader AS SOH
 ORDER BY Kalem DESC

 --2) WHERE'den sonra bir sorgu daha yaz�labiliyor.

 SELECT * FROM Sales.SalesOrderHeader
 WHERE SalesOrderID=64111 OR SalesOrderID= 71033


  SELECT * FROM Sales.SalesOrderHeader
 WHERE SalesOrderID IN (64111,71033) -- yukar�dakini daha kolay �ekilde yapabilmek i�in kullan�m.


  SELECT * FROM Sales.SalesOrderHeader
 WHERE SalesOrderID IN (SELECT SalesOrderID FROM Sales.SalesOrderDetail
 WHERE OrderQty>10 ) --2. select deki adresle 1.deki ayn� olmal� salesorderID...)


 --3)FROM dan sonra select c�mlesi yaz�labilir.

 SELECT * FROM (SELECT *FROM Sales.SalesOrderDetail
 WHERE UnitPrice <100 ) AS TBL --isim vermezsen hata veriyor.
