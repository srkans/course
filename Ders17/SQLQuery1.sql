USE Calisma;

CREATE TABLE myTable(id int, objName varchar(20), objDescription varchar(200));

ALTER TABLE myTable ADD quantity int;

INSERT INTO myTable VALUES(1, 'maketTramvay', 'it has come from portugal', 1);

DROP TABLE Personel; --also can be used as DROP DATABASE and it deletes database

--IDENTITY

CREATE TABLE Musteri(MusteriID int IDENTITY(10,2), MusteriAdi varchar(20), Adres varchar(200)); --(10-seed, 2-increment)

INSERT INTO Musteri VALUES ('SERKAN', 'KADIKOY');

SELECT * FROM Musteri;

--JOIN--

CREATE TABLE Personel(PerID int IDENTITY(1,1), 
                      PerAd varchar(20),
					  PerSoyad varchar(20),
					  BolumID smallint) 

CREATE TABLE Bolum(BolumID smallint IDENTITY(10,1),
		           BolumAdi varchar(50) )

INSERT INTO Bolum VALUES('Muhasebe')
INSERT INTO Bolum VALUES('Satis')
INSERT INTO Bolum VALUES('IT')

INSERT INTO Personel VALUES('Cevdet', 'Korkmaz', 10)
INSERT INTO Personel VALUES('Selami', 'Bayrak', 11)
INSERT INTO Personel VALUES('Dursun', 'Durmasýn', 12)
INSERT INTO Personel VALUES('Kemal', 'Kendir', 11)
INSERT INTO Personel VALUES('Deniz', 'Okyanus', 12)

SELECT* FROM Personel
SELECT * FROM Bolum

--CROSS JOIN
SELECT * FROM Personel, Bolum
--CROSS JOIN Microsoft
SELECT * FROM Personel CROSS JOIN Bolum

--INNER JOIN
SELECT PerAd, PerSoyad, BolumAdi FROM Personel AS Employee, Bolum AS Department WHERE Department.BolumID = Employee.BolumID
--INNER JOIN Microsoft
SELECT PerAd, PerSoyad, BolumAdi FROM Personel AS p INNER JOIN Bolum AS b ON b.BolumID = p.BolumID

--
INSERT INTO Bolum VALUES ('IK')
INSERT INTO Personel VALUES('Abuzer', 'Kadayýf',15)
--

--OUTER JOIN 
SELECT * FROM Personel LEFT JOIN Bolum
ON Personel.BolumID=Bolum.BolumID

SELECT * FROM Personel RIGHT JOIN Bolum
ON Personel.BolumID=Bolum.BolumID

SELECT * FROM Personel FULL JOIN Bolum
ON Personel.BolumID=Bolum.BolumID