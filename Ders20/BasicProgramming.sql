--DE���KEN TANIMLAMA

DECLARE @no int --de�i�ken tan�mlad�k
SET @no=10 --de�i�kene bir de�er atad�k.

SELECT @no--mesaj k�sm�na yazmak i�in
PRINT CAST(@no AS varchar(10)) + ' kayit' --mesaj k�sm�na yazmak i�in +cast ile tip d�n���me

--�art �fadesi

DECLARE @sayi int
SET @sayi=10
IF (@sayi<=10)
begin
PRINT 'sayi 10 yada k���k ' 
end

else begin
PRINT 'sayi 10 dan b�y�k'
end

SELECT * FROM sys.databases -- database leri g�rmek i�in

IF NOT EXISTS (SELECT * FROM sys.tables -- tablolar� g�rmek i�in
WHERE name='Kitap') --not exists ile yoksa srogu sonucundaki eleman
begin 
CREATE TABLE Kitap(KitapID int IDENTITY PRIMARY KEY,
					KitapAdi varchar(50)) --o isimde bir tablo olu�tur dedik.
end -- burada s�sl� parantez a� kapa yerine begin ve end komutlar� kullan�l�yor.

--exists komutunu kullanmak �nemli !!!

--D�ng� tsql de yaln�zca while d�ng�s� var

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

SELECT �r�nID,�r�nAdi, CASE Renk
						when 'Red' Then 'K�rm�z�'
						when 'Black' Then 'Siyah'
						when 'Blue' Then 'Mavi'
						when 'Silver' Then 'G�m��'
						end

 FROM AdvUrunler  --DATABASE DE de�i�iklik yapmadan veriyi de�i�tirip raporda bu �ekilde g�sterdim

 --2)

 SELECT �r�nID,�r�nAdi,BirimFiyat,
					    CASE 
						when BirimFiyat<500 Then 'Ucuz'
						when BirimFiyat>500 and BirimFiyat<=1500 Then 'Normal'
						when BirimFiyat>1500 Then 'Pahal�'						
						end

 FROM AdvUrunler --yeni bir sat�r ekleyip �r�nle ilgili not d��t�k.

 --*******************Fonksiyonlar**********************************--------
 --1)Scalar

CREATE FUNCTION kdv(@tutar money , @oran tinyint)
RETURNS money --hangi tipte de�er d�nd�relece�ini genel olarak belirtiyor
AS
begin
RETURN (@tutar*@oran)/100 --d�nd�rece�i de�erin ne oldugunu belirtiyor.
end
--returns ve return !!!!

SELECT dbo.Kdv(1000,18) AS KDV --scalar fonksiyon cagr�l�rken schema ismiyle birlikte kullan�l�yor.dbo

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
					 Tutar AS (BirimFiyat*Adet),--COMPUTED FIELDS OLARAK GE��YOR L�TERAT�RDE
					 KDV AS dbo.kdv(BirimFiyat*Adet,kdvorani)) -- SCALAR FONKS�YON B�R T�P G�B� KULLANILDI
--YUKARIDAK� �EK�LDE USER DEF�NE TYPE LAR OLU�TURULAB�L�R.
--kdv fonksiyonu yukar�da tan�mlanm��t�. de�i�ken olarak tutar ve kdv oran� istiyor.


SELECT * FROM fnDetay
-----

SELECT PerID,UPPER(PerAd),LOWER(PerSoyad)
 FROM Personel

SELECT PerID,LEN(PerAd) -- LEN STR�NG �FADEN�N BOYUTUNU VER�YOR.
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
SELECT �r�nID,�r�nAdi,ISNULL(Renk,'Tan�ms�z') FROM AdvUrunler --null olan renk de�erlerine tan�ms�z yazd�k.

---TARIHLE ILGILI FONKSIYONLAR

SELECT GETDATE()
SELECT DAY(GETDATE())
SELECT MONTH(GETDATE())
SELECT YEAR(GETDATE())


SELECT DATEADD(d,10,GETDATE()) --10 GUN EKLEDIK  D YAZINCA,M,Y VS DENENEB�L�R.

SELECT DATEDIFF(d,10,GETDATE())

USE AdventureWorks2016CTP3

SELECT ProductID,Name,DATEDIFF(d,SellStartDate,SellEndDate) FROM Production.Product  --DATEDIFF YINE YIL AY GUN VS OLARAK TAR�H FARKINI VER�YOR.