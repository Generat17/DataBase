Use Sales
GO
-- —оздание, обновление и удаление представлени€
--CREATE VIEW Part1 AS SELECT LastName, FirstName, City From Customers;
--ALTER VIEW Part1 AS SELECT LastName, FirstName FROM Customers;
--ALTER VIEW Part1 AS SELECT LastName, FirstName, City FROM Customers;
--DROP VIEW Part1

-- —оздание представлени€ и вставка записи с его помощью
-- ѕри создание представлени€ можно добавить в него проверку WITH CHECK OPTION, иначе можно будет вставить любую запись 
/*
CREATE VIEW Part2 AS SELECT *FROM Customers GO 
INSERT INTO Part2 VALUES ('51job', '51', 'job', 'USA, Sacramento, CA 964888876', 'Sacramento', '888111', '+1111342544441', '51job@gmail.com');
*/

-- ”даление внесенной записи с помощью представлени€
/*
DBCC CHECKIDENT ('Customers', RESEED, 18)
Go
DELETE FROM Customers WHERE IdCustomer = 19
*/
--DROP VIEW Part2

--SELECT *FROM Customers