USE AdventureWorks2016CTP3

--)En pahalý 15 ürünün adýný kategorisini ve alt kategorisini listeleyiniz.

SELECT TOP 15 p.ListPrice AS Fiyat, p.Name AS Urun, s.Name AS altKategori, c.Name AS Kategori  FROM Production.Product AS p , Production.ProductSubcategory AS s, Production.ProductCategory AS c
WHERE p.ProductSubcategoryID = s.ProductSubcategoryID AND s.ProductCategoryID = c.ProductCategoryID
ORDER BY Fiyat DESC

SELECT TOP(15) Production.Product.ListPrice AS Fiyat, Production.Product.Name AS Urun, Production.ProductSubcategory.Name AS AltKategori, Production.ProductCategory.Name AS Kategori
FROM Production.Product INNER JOIN Production.ProductSubcategory 
ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory 
ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
ORDER BY Fiyat DESC

--)Rengi siyah fiyat aralýðý 100-500 olan ürünleri kategori ve alt kategorileri ile listeleyiniz

SELECT p.Name AS Urun, p.Name AS altKategori, c.Name AS Kategori, p.ListPrice AS Fiyat,p.Color AS Renk FROM Production.Product AS p , Production.ProductSubcategory AS s , Production.ProductCategory AS c
WHERE p.ProductSubcategoryID = s.ProductSubcategoryID AND s.ProductCategoryID = c.ProductCategoryID AND (p.ListPrice>=100 AND p.ListPrice <= 500) AND p.Color = 'Black' 


SELECT Production.Product.ListPrice AS Fiyat, Production.Product.Color AS Renk, Production.Product.Name AS [Ürün Adý], Production.ProductSubcategory.Name AS [Alt Kategori], Production.ProductCategory.Name AS Kategori
FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
WHERE (Production.Product.ListPrice >= 100 AND Production.Product.ListPrice <= 500) AND (Production.Product.Color = N'Black')

--kategorisi "Components" olan ürünleri fiyatýna göre azalan olarak sýralayýnýz

SELECT p.Name AS Urun, c.Name AS Kategori, p.ListPrice AS Fiyat FROM Production.Product as p, Production.ProductSubcategory as s, Production.ProductCategory as c
WHERE p.ProductSubcategoryID = s.ProductSubcategoryID AND s.ProductCategoryID=c.ProductCategoryID AND c.Name = 'Components'
ORDER BY Fiyat DESC

SELECT Production.ProductCategory.Name, Production.Product.Name AS Expr1, Production.Product.ListPrice
FROM Production.ProductSubcategory INNER JOIN Production.Product ON Production.ProductSubcategory.ProductSubcategoryID = Production.Product.ProductSubcategoryID AND 
Production.ProductSubcategory.ProductSubcategoryID = Production.Product.ProductSubcategoryID INNER JOIN
Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID AND 
Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
WHERE (Production.ProductCategory.Name = N'Components')
ORDER BY Production.Product.ListPrice DESC

--kategorisi "bikes" olan ürünlerin toplam fiyatý nedir

SELECT c.Name AS Kategori, SUM(p.listPrice) AS Toplam FROM  Production.Product as p, Production.ProductSubcategory as s, Production.ProductCategory as c
WHERE p.ProductSubcategoryID = s.ProductSubcategoryID AND s.ProductCategoryID=c.ProductCategoryID
GROUP BY c.Name
HAVING c.Name = 'Bikes'

SELECT Production.ProductCategory.Name AS Kategori, SUM(Production.Product.ListPrice) AS Toplam
FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN
Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
GROUP BY Production.ProductCategory.Name
HAVING (Production.ProductCategory.Name = 'Bikes')

--içerisinde "Road" geçen ürünlerin kategorileri ve alt kategorilerini listeleyin

SELECT p.Name AS Urun, s.Name AS altKategori, c.Name AS Kategori FROM Production.Product as p, Production.ProductSubcategory as s, Production.ProductCategory as c
WHERE p.ProductSubcategoryID = s.ProductSubcategoryID AND s.ProductCategoryID=c.ProductCategoryID AND p.Name LIKE '%road%'

SELECT Production.ProductSubcategory.Name, Production.ProductCategory.Name AS Expr1, Production.Product.Name AS Expr2
FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN
Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
WHERE (Production.Product.Name LIKE N'%road%')