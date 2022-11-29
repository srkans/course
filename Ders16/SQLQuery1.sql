USE Calisma;

SELECT * FROM Personeller;

SELECT ID, perAd, perSoyad FROM Personeller;

SELECT ID AS perID, perAd, perSoyad FROM Personeller;

SELECT * FROM Personeller ORDER BY Bolum ASC, Maas DESC;

SELECT TOP 4 * FROM Personeller ORDER BY Maas DESC;

SELECT DISTINCT Bolum FROM Personeller; --shows different values

