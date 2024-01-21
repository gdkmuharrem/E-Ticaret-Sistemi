-- �al��an rol�n� olu�turun
CREATE ROLE Calisan;

-- Categories tablosuna eri�im izni verin
GRANT SELECT, INSERT ON Categories TO Calisan;

-- Customers tablosuna eri�im izni verin (CustomerPassword s�tunu hari�)
GRANT SELECT (CustomerUsername, FirstName, LastName, Email, Phone) ON Customers TO Calisan;

-- Employee tablosuna eri�im izni verin (Tablo d�zeyinde)
GRANT SELECT,INSERT, UPDATE ON Employee TO Calisan;

-- Employee tablosundaki belirli s�tunlara eri�im izni verin (S�tun d�zeyinde)
GRANT SELECT (EmployeeUsername, EmployeePassword, FirstName, LastName, Email, Phone) ON Employee TO Calisan;


-- Products tablosuna eri�im izni verin
GRANT SELECT, INSERT, UPDATE, DELETE ON Products TO Calisan;

-- Orders tablosuna eri�im izni verin
GRANT SELECT, UPDATE, DELETE ON Orders TO Calisan;

-- OrderHistory tablosuna eri�im izni verin
GRANT SELECT ON OrderHistory TO Calisan;

