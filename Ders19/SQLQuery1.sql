USE Calisma

SELECT * FROM Personel
SELECT * FROM Bolum

SELECT p.PerID, p.PerAd,p.PerSoyad, b.BolumAdi, p.BolumID FROM Personel AS p, Bolum AS b
WHERE p.BolumID = b.BolumID



CREATE TABLE Kategoriler(KatID int IDENTITY PRIMARY KEY,
                         KatAdi varchar(30))

CREATE TABLE Urunler(UrunID int IDENTITY PRIMARY KEY,
                     UrunAdi varchar(50),
					 KatID int REFERENCES Kategoriler(KatID))
--CONSTRAINTS--
--Var olan bir tabloya primary key ekleme--
ALTER TABLE Personel
ADD Constraint pk_perID
PRIMARY KEY (PerID)
--****--

USE AdventureWorks2016CTP3

SELECT * FROM Person.Person

SELECT BusinessEntityID AS PerID,
       Title AS Unvan,
	   FirstName Ad,
	   LastName Soyad
INTO AdvPerson
FROM AdventureWorks2016CTP3.Person.Person

SELECT * FROM AdvPerson
WHERE PerID = 15780