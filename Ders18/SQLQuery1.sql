USE AdventureWorks2016CTP3

SELECT * FROM Production.Product; SELECT * FROM Production.ProductCategory; SELECT * FROM Production.ProductSubcategory

SELECT * FROM Production.Product AS p , Production.ProductSubcategory AS s
WHERE p.ProductSubcategoryID=s.ProductSubcategoryID
--**--
--Hangi kategoride kaç ürün var
SELECT c.Name AS Kategori, COUNT(c.Name) AS Adet FROM Production.Product AS p , Production.ProductSubcategory AS s , Production.ProductCategory AS c
WHERE p.ProductSubcategoryID=s.ProductSubcategoryID AND s.ProductCategoryID=c.ProductCategoryID
GROUP BY c.Name

SELECT c.Name,COUNT(c.Name) AS Adet FROM Production.ProductCategory c INNER JOIN Production.ProductSubcategory AS s
ON c.ProductCategoryID=s.ProductCategoryID INNER JOIN Production.Product AS p
ON s.ProductSubcategoryID=p.ProductSubcategoryID
GROUP BY c.Name
--***--
--Rengi kýrmýzý olan ürünler hangi alt kategorideler
SELECT p.Name AS Urun, s.Name AS AltKategori, p.Color AS Renk FROM Production.Product AS p, Production.ProductSubcategory AS s
WHERE p.ProductSubcategoryID = s.ProductSubcategoryID AND p.Color = 'Red' 

SELECT Production.Product.Name, Production.ProductSubcategory.Name AS AltKategori, Production.Product.Color
FROM Production.Product INNER JOIN Production.ProductSubcategory
ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
WHERE (Production.Product.Color = N'Red')
--**--
--Alt kategorisinde 10 dan fazla ürün olanlar

SELECT s.Name AS AltKategori , COUNT(*) AS Adet 
FROM Production.Product AS p , Production.ProductSubcategory AS s
WHERE p.ProductSubcategoryID=s.ProductSubcategoryID
GROUP BY s.Name 
HAVING COUNT(*)>10
ORDER BY Adet DESC 

SELECT Production.ProductSubcategory.Name, COUNT(*) AS Adet
FROM Production.Product INNER JOIN Production.ProductSubcategory 
ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
GROUP BY Production.ProductSubcategory.Name
HAVING (COUNT(*) > 10)
ORDER BY Adet DESC

--**--

