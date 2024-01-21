-- Çalýþan rolünü oluþturun
CREATE ROLE Calisan;

-- Categories tablosuna eriþim izni verin
GRANT SELECT, INSERT ON Categories TO Calisan;

-- Customers tablosuna eriþim izni verin (CustomerPassword sütunu hariç)
GRANT SELECT (CustomerUsername, FirstName, LastName, Email, Phone) ON Customers TO Calisan;

-- Employee tablosuna eriþim izni verin (Tablo düzeyinde)
GRANT SELECT,INSERT, UPDATE ON Employee TO Calisan;

-- Employee tablosundaki belirli sütunlara eriþim izni verin (Sütun düzeyinde)
GRANT SELECT (EmployeeUsername, EmployeePassword, FirstName, LastName, Email, Phone) ON Employee TO Calisan;


-- Products tablosuna eriþim izni verin
GRANT SELECT, INSERT, UPDATE, DELETE ON Products TO Calisan;

-- Orders tablosuna eriþim izni verin
GRANT SELECT, UPDATE, DELETE ON Orders TO Calisan;

-- OrderHistory tablosuna eriþim izni verin
GRANT SELECT ON OrderHistory TO Calisan;

