USE Calisma

--*************************************STORED PROCEDURE*********************************************************--

CREATE PROCEDURE productList
AS
SELECT c.Name AS Kategori, p.Name AS [Urun Adi], s.Name AS altKategori FROM Production.Product AS p, Production.ProductSubcategory AS s, Production.ProductCategory AS c
WHERE p.ProductSubcategoryID = s.ProductSubcategoryID AND s.ProductCategoryID = c.ProductCategoryID

EXECUTE productList

CREATE PROCEDURE employeeList
AS
SELECT * FROM Personel AS p, Bolum AS b
WHERE p.BolumID = b.BolumID

EXECUTE employeeList
EXEC employeeList --2nd way for execute
employeeList --3rd way for execute

--with parameter

CREATE PROCEDURE findEmployee @name varchar(20), @department varchar(20)
AS
SELECT * FROM Personel AS p , Bolum AS b
WHERE p.BolumID = b.BolumID AND p.PerAd = @name AND b.BolumAdi = @department

EXECUTE findEmployee @department ='Muhasebe' , @name = 'Cevdet'
EXECUTE findEmployee 'Cevdet' , 'Muhasebe' --can be use according to parameter order

--saklý prosedürler daha çok update delete insert gibi iþlemlerde kullanýlýr
--Geriye Deðer Döndüren SaklýProsedür(sp)
--geriye bir tane deðer döndürebilirler onun da tipi integer olur.normal þartlar altýnda!

SELECT * FROM Personel

CREATE PROCEDURE addEmployee @ad varchar(20), @soyad varchar(20), @bolumID tinyint
AS
INSERT INTO Personel VALUES(@ad, @soyad, @bolumID)

EXECUTE addEmployee 'Betul','Altu','11'

------
ALTER PROCEDURE addEmployee @ad varchar(20), @soyad varchar(20), @bolumID tinyint
AS
DECLARE @ID tinyint --variable definition
INSERT INTO Personel VALUES(@ad, @soyad, @bolumID)
SELECT @ID=SCOPE_IDENTITY()   --@@IDENTITY DE KULLANILABÝLÝYOR AMA KULLANMA
RETURN @ID
-----

DECLARE @newID tinyint
EXECUTE @newID = addEmployee 'Ali', 'Yavru' , '13'
PRINT @newID

----

--Normalin dýþýnda birden fazla farklý tiplerde deðer döndürme(sp)

CREATE PROCEDURE searchEmployee @ID int,@adSoyad varchar(50) out --ref out gibi C# daki.
AS
SELECT @adSoyad=(PerAd+ ' ' + PerSoyad)  FROM Personel
WHERE PerID=@ID

DECLARE @isim varchar(50)
EXECUTE searchEmployee 7, @isim out
SELECT @isim

----------------
