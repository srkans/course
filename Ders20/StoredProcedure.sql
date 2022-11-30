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

--sakl� prosed�rler daha �ok update delete insert gibi i�lemlerde kullan�l�r
--Geriye De�er D�nd�ren Sakl�Prosed�r(sp)
--geriye bir tane de�er d�nd�rebilirler onun da tipi integer olur.normal �artlar alt�nda!

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
SELECT @ID=SCOPE_IDENTITY()   --@@IDENTITY DE KULLANILAB�L�YOR AMA KULLANMA
RETURN @ID
-----

DECLARE @newID tinyint
EXECUTE @newID = addEmployee 'Ali', 'Yavru' , '13'
PRINT @newID

----

--Normalin d���nda birden fazla farkl� tiplerde de�er d�nd�rme(sp)

CREATE PROCEDURE searchEmployee @ID int,@adSoyad varchar(50) out --ref out gibi C# daki.
AS
SELECT @adSoyad=(PerAd+ ' ' + PerSoyad)  FROM Personel
WHERE PerID=@ID

DECLARE @isim varchar(50)
EXECUTE searchEmployee 7, @isim out
SELECT @isim

----------------
