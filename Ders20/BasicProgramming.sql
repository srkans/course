--DEÐÝÞKEN TANIMLAMA

DECLARE @no int --deðiþken tanýmladýk
SET @no=10 --deðiþkene bir deðer atadýk.

SELECT @no--mesaj kýsmýna yazmak için
PRINT CAST(@no AS varchar(10)) + ' kayit' --mesaj kýsmýna yazmak için +cast ile tip dönüþüme

--Þart Ýfadesi

DECLARE @sayi int
SET @sayi=10
IF (@sayi<=10)
begin
PRINT 'sayi 10 yada küçük ' 
end

else begin
PRINT 'sayi 10 dan büyük'
end

SELECT * FROM sys.databases -- database leri görmek için

IF NOT EXISTS (SELECT * FROM sys.tables -- tablolarý görmek için
WHERE name='Kitap') --not exists ile yoksa srogu sonucundaki eleman
begin 
CREATE TABLE Kitap(KitapID int IDENTITY PRIMARY KEY,
					KitapAdi varchar(50)) --o isimde bir tablo oluþtur dedik.
end -- burada süslü parantez aç kapa yerine begin ve end komutlarý kullanýlýyor.

--exists komutunu kullanmak önemli !!!

--Döngü tsql de yalnýzca while döngüsü var

DECLARE @sayac int 
SET	@sayac= 0
WHILE (@sayac<10)
begin
INSERT INTO Kitap VALUES('Kitap Adi')
SET @sayac =@sayac+1
end

TRUNCATE TABLE Kitap --deletes data inside table

SELECT * FROM Kitap

--CASE KULLANIMI
--1)

SELECT *FROM AdvUrunler

SELECT ÜrünID,ÜrünAdi, CASE Renk
						when 'Red' Then 'Kýrmýzý'
						when 'Black' Then 'Siyah'
						when 'Blue' Then 'Mavi'
						when 'Silver' Then 'Gümüþ'
						end

 FROM AdvUrunler  --DATABASE DE deðiþiklik yapmadan veriyi deðiþtirip raporda bu þekilde gösterdim

 --2)

 SELECT ÜrünID,ÜrünAdi,BirimFiyat,
					    CASE 
						when BirimFiyat<500 Then 'Ucuz'
						when BirimFiyat>500 and BirimFiyat<=1500 Then 'Normal'
						when BirimFiyat>1500 Then 'Pahalý'						
						end

 FROM AdvUrunler --yeni bir satýr ekleyip ürünle ilgili not düþtük.

 --*******************Fonksiyonlar**********************************--------
 --1)Scalar

CREATE FUNCTION kdv(@tutar money , @oran tinyint)
RETURNS money --hangi tipte deðer döndüreleceðini genel olarak belirtiyor
AS
begin
RETURN (@tutar*@oran)/100 --döndüreceði deðerin ne oldugunu belirtiyor.
end
--returns ve return !!!!

SELECT dbo.Kdv(1000,18) AS KDV --scalar fonksiyon cagrýlýrken schema ismiyle birlikte kullanýlýyor.dbo

--2) TABLE 

SELECT * FROM AdvUrunler

CREATE FUNCTION AdvUrunRenk(@renk varchar(10))
RETURNS TABLE
AS
RETURN(SELECT * FROM AdvUrunler WHERE Renk= @renk)


SELECT *FROM AdvUrunRenk('Black')

------
CREATE TABLE fnDetay(UrunID int IDENTITY PRIMARY KEY,
					 BirimFiyat money,
					 Adet smallint,
					 KdvOrani tinyint,
					 Tutar AS (BirimFiyat*Adet),--COMPUTED FIELDS OLARAK GEÇÝYOR LÝTERATÜRDE
					 KDV AS dbo.kdv(BirimFiyat*Adet,kdvorani)) -- SCALAR FONKSÝYON BÝR TÝP GÝBÝ KULLANILDI
--YUKARIDAKÝ ÞEKÝLDE USER DEFÝNE TYPE LAR OLUÞTURULABÝLÝR.
--kdv fonksiyonu yukarýda tanýmlanmýþtý. deðiþken olarak tutar ve kdv oraný istiyor.


SELECT * FROM fnDetay
-----

SELECT PerID,UPPER(PerAd),LOWER(PerSoyad)
 FROM Personel

SELECT PerID,LEN(PerAd) -- LEN STRÝNG ÝFADENÝN BOYUTUNU VERÝYOR.
 FROM Personel

 SELECT PerID,RIGHT(PerAd,3) --SAGDAN ITIBAREN 3 HARF GETIR
 FROM Personel

  SELECT PerID,LEFT(PerAd,3) --SOLDAN ITIBAREN 3 HARF GETIR
 FROM Personel

 ----

 CREATE TABLE Deneme(ID int IDENTITY,
					 Ad char(20))


INSERT INTO Deneme VALUES('CEVDET'),('Selami'),('Kemal')

SELECT LEFT(AD,3) , RIGHT(RTRIM(AD),3) FROM Deneme --RTRIM SAGDAN BOSLUKLARI BUDA DEMEK...LTRIM SOLDAN BUDA.

---
SELECT ÜrünID,ÜrünAdi,ISNULL(Renk,'Tanýmsýz') FROM AdvUrunler --null olan renk deðerlerine tanýmsýz yazdýk.

---TARIHLE ILGILI FONKSIYONLAR

SELECT GETDATE()
SELECT DAY(GETDATE())
SELECT MONTH(GETDATE())
SELECT YEAR(GETDATE())


SELECT DATEADD(d,10,GETDATE()) --10 GUN EKLEDIK  D YAZINCA,M,Y VS DENENEBÝLÝR.

SELECT DATEDIFF(d,10,GETDATE())

USE AdventureWorks2016CTP3

SELECT ProductID,Name,DATEDIFF(d,SellStartDate,SellEndDate) FROM Production.Product  --DATEDIFF YINE YIL AY GUN VS OLARAK TARÝH FARKINI VERÝYOR.