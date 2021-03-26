Use Sales
GO

-- Обучение

-- Создание, обновление и удаление представления
--CREATE VIEW Part1 AS SELECT LastName, FirstName, City From Customers;
--ALTER VIEW Part1 AS SELECT LastName, FirstName FROM Customers;
--ALTER VIEW Part1 AS SELECT LastName, FirstName, City FROM Customers;
--DROP VIEW Part1

-- Создание представления и вставка записи с его помощью
-- При создание представления можно добавить в него проверку WITH CHECK OPTION, иначе можно будет вставить любую запись 
/*
CREATE VIEW Part2 AS SELECT *FROM Customers 
GO 
INSERT INTO Part2 VALUES ('51job', '51', 'job', 'USA, Sacramento, CA 964888876', 'Sacramento', '888111', '+1111342544441', '51job@gmail.com');
*/

-- Удаление внесенной записи с помощью представления
/*
DBCC CHECKIDENT ('Customers', RESEED, 18)
Go
DELETE FROM Customers WHERE IdCustomer in(SELECT MAX(IdCustomer) FROM Customers)
*/

--DROP VIEW Part2

-- Процесс выполнения ЛР4

--Пункт 3. Создать любое простое представление и запросить с помощью него данные.
--CREATE VIEW Part3 AS SELECT * From Customers;

--Пункт 4. Проверить соответствие данных прямым запросом.
--SELECT *FROM Customers

--Пункт 5. Изменить созданное представление с помощью команды ALTER VIEW, добавив псевдонимы полям и условие.
--ALTER VIEW Part3 AS SELECT CompanyName AS [Компании на букву А], [E-mail] AS [Почта] FROM Customers WHERE CompanyName LIKE 'A%'
--Вернуть назад, если потребуется
--ALTER VIEW Part3 AS SELECT * FROM Customers

--Пункт 6. Вставить данные с помощью представления.
/*
CREATE VIEW Part4 AS SELECT *FROM Customers 
GO 
INSERT INTO Part4 VALUES ('51job', '51', 'job', 'USA, Sacramento, CA 964888876', 'Sacramento', '888111', '+1111342544441', '51job@gmail.com');
*/

--Удалить последнюю вставленную строку 
--DELETE FROM Customers WHERE IdCustomer in(SELECT MAX(IdCustomer) FROM Customers)

--Пункт 7. Создать представление с опцией WITH CHECK OPTION.
/*
CREATE VIEW Part5 AS SELECT *FROM Customers WHERE IdCustomer > 0 WITH CHECK OPTION
GO 
INSERT INTO Part5 VALUES ('51job', '51', 'job', 'USA, Sacramento, CA 964888876', 'Sacramento', '8885111', '+1111342544441', '51job@gmail.com');
*/

--Пункт 8. Удалить представление.
--DROP VIEW Part3
--DROP VIEW Part4
--DROP VIEW Part5