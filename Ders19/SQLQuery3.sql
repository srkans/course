--Kýsýtlar

--1)Primary Key
--Composite Key (defterde)

--2)Foreign Key

--3)Unique
--ayný kullanýcý adý e-mail adresi gibi bilgilerin alýnamamasý buna örnek olarak verilebilir.


			

CREATE TABLE Uyelik(UyeID int IDENTITY PRIMARY KEY,
					[Üye Adý] varchar(50) NOT NULL,--boþ geçilemez diye belirttik
					[Kullanýcý Adý] varchar(25) UNIQUE,
					Rütbe varchar(20) DEFAULT 'Er',
					Yaþ tinyint CHECK (Yaþ BETWEEN 18 AND 75),
					Kod varchar(3) CHECK(Kod LIKE '[A-Z][0-9][0-9]'))-- 3 haneli bir kod olsun 
					-- ve ilk hane harf, son iki hane nümerik deðer alsýn istedik.