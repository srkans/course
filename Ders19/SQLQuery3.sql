--K�s�tlar

--1)Primary Key
--Composite Key (defterde)

--2)Foreign Key

--3)Unique
--ayn� kullan�c� ad� e-mail adresi gibi bilgilerin al�namamas� buna �rnek olarak verilebilir.


			

CREATE TABLE Uyelik(UyeID int IDENTITY PRIMARY KEY,
					[�ye Ad�] varchar(50) NOT NULL,--bo� ge�ilemez diye belirttik
					[Kullan�c� Ad�] varchar(25) UNIQUE,
					R�tbe varchar(20) DEFAULT 'Er',
					Ya� tinyint CHECK (Ya� BETWEEN 18 AND 75),
					Kod varchar(3) CHECK(Kod LIKE '[A-Z][0-9][0-9]'))-- 3 haneli bir kod olsun 
					-- ve ilk hane harf, son iki hane n�merik de�er als�n istedik.