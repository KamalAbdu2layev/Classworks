CREATE DATABASE Course;

USE Course;

CREATE TABLE Students(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(50) NOT NULL,
Surname nvarchar(50) DEFAULT 'xxx',
Age int NOT NULL,
Point int NOT NULL
)

INSERT INTO Students
VALUES 
('Name2','Surname',20,99),
('Name3','Surname',21,49),
('Name4','Surname',50,79),
('Name5','Surname',10,81),
('Name6','Surname',18,85)

SELECT * FROM Students;

INSERT INTO Students ([Name], Age, Point)
VALUES ('Name8',20,99)

--DROP TABLE Students

INSERT INTO Students 
VALUES ('Name8', NULL,20,99)

UPDATE Students SET Surname = 'Hello Worlds' WHERE Surname = 'xxx'

SELECT * FROM Students 
WHERE Point >= 70 AND Point <= 90 
ORDER BY Point DESC

SELECT * FROM Students 
WHERE Point >= 70 AND Point <= 90 
ORDER BY Name DESC

SELECT * FROM Students;

SELECT Name,Surname FROM Students 
WHERE Age < 21

ALTER TABLE Students 
ADD AvaragePoint float CHECK(AvaragePoint >=0 AND AvaragePoint <=100)

INSERT INTO Students 
VALUES ('Name8','sadsa',20,99,199.198)

