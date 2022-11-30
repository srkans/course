USE Film

CREATE TABLE Filmler(FilmID int IDENTITY PRIMARY KEY,
					 FilmAd varchar(30),
					 Yapimci varchar(30),
					 Turu varchar(20),
					 IzlenmeSayisi int,
					 KategoriID int REFERENCES Kategori(KategoriID),
					 YapimciID int REFERENCES Yapimcilar(YapimciID))

CREATE TABLE Oyuncular(OyuncuID int IDENTITY PRIMARY KEY,
					   OyuncuAd varchar(30))

CREATE TABLE Kategori(KategoriID int IDENTITY PRIMARY KEY,
					  KategoriAdi varchar(20))

CREATE TABLE Yapimcilar(YapimciID int IDENTITY PRIMARY KEY,
						YapimciAdi varchar(30) )

CREATE TABLE FilmOyuncu(KarakterID int IDENTITY PRIMARY KEY,
						KarakterAdi varchar(30),
						FilmID int,
						OyuncuID int)

--1) Bir filmin ad�, yap�mc�s�, kategorisi, izlenme say�s�n� g�steriniz.
SELECT Filmler.FilmAd, Yapimcilar.YapimciAdi, Filmler.IzlenmeSayisi
FROM Filmler INNER JOIN Kategori ON Filmler.KategoriID = Kategori.KategoriID INNER JOIN
Yapimcilar ON Filmler.YapimciID = Yapimcilar.YapimciID
WHERE Filmler.FilmAd = 'Run Forest Run'


--2)Bir filmde oynayan oyuncular ve karakter adlar�n� g�ster.
SELECT Filmler.FilmAdi, Oyuncular.OyuncuAdi
FROM Film_Oyuncu INNER JOIN
Filmler ON Film_Oyuncu.FilmID = Filmler.FilmID INNER JOIN
Oyuncular ON Film_Oyuncu.OyuncuID = Oyuncular.OyuncuID
WHERE (Filmler.FilmAd = '�yi K�t� �irkin')

--3) Bir oyuncunun oyand��� t�m filmler ? 
SELECT Oyuncular.OyuncuAdi, Filmler.FilmAd, Film_Oyuncu.KarakterAdi
FROM Film_Oyuncu INNER JOIN Filmler ON Film_Oyuncu.FilmID = Filmler.FilmID INNER JOIN Oyuncular
ON Film_Oyuncu.OyuncuID = Oyuncular.OyuncuID
WHERE(Oyuncular.OyuncuAdi = 'Morgan Freeman')

--4) Her kategoride ka� film var?

SELECT Kategori.KategoriAdi AS Expr1, COUNT(*) AS FilmSayisi
FROM Filmler INNER JOIN Kategori ON Filmler.KategoriID = Kategori.KategoriID 
GROUP BY Kategori.KategoriAdi

--5)En fazla izlenen 3 film?

SELECT  TOP 3 FilmAd, IzlenmeSayisi
FROM Filmler
ORDER BY IzlenmeSayisi DESC

--6)Yap�mc�lar�n ka� adet filmleri var

SELECT Yapimcilar.YapimciAdi, COUNT(*) AS FilmSayisi
FROM Filmler INNER JOIN
Yapimcilar ON Filmler.YapimciID = Yapimcilar.YapimciID
GROUP BY Yapimcilar.YapimciAdi

--7)En fazla filme sahip  yap�mc�?

SELECT TOP 1 Yapimcilar.YapimciAdi, COUNT(*) AS FilmSayisi
FROM Filmler INNER JOIN
Yapimcilar ON Filmler.YapimciID = Yapimcilar.YapimciID
GROUP BY Yapimcilar.YapimciAdi
ORDER BY FilmSayisi DESC

--8)En fazla oyuncuyla �ekilen 3 film? 

SELECT TOP (3) Filmler.FilmAd, COUNT(Film_Oyuncu.OyuncuID) AS [oyuncu sayisi]
FROM Film_Oyuncu INNER JOIN
Filmler ON Film_Oyuncu.FilmID = Filmler.FilmID
GROUP BY Filmler.FilmAd
ORDER BY [oyuncu sayisi] DESC