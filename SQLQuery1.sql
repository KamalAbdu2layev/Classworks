<<<<<<< HEAD
CREATE DATABASE ViewPractice

USE ViewPractice

CREATE TABLE Actors(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(100),
Surname NVARCHAR(100)
)

CREATE TABLE Genres(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(100)
)

CREATE TABLE Directors(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(100),
Surname NVARCHAR(100)
)

CREATE TABLE Movies(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(100),
[Description] NVARCHAR(100),
Duration TIME,
IMDBPoint FLOAT,
DirectorId INT CONSTRAINT FK_DirectorId FOREIGN KEY REFERENCES Directors(Id)
)

CREATE TABLE MoviesActors(
Id INT PRIMARY KEY IDENTITY,
ActorId INT CONSTRAINT FK_ActorId FOREIGN KEY REFERENCES Actors(Id),
MovieId INT CONSTRAINT FK_MovieId FOREIGN KEY REFERENCES Movies(Id)
)

CREATE TABLE MoviesGenres(
Id INT PRIMARY KEY IDENTITY,
GenreId INT CONSTRAINT FK_GenreId FOREIGN KEY REFERENCES Genres(Id),
MovieId INT CONSTRAINT FK_MovieGenresId FOREIGN KEY REFERENCES Movies(Id)
)

SELECT * FROM Movies

SELECT m.Name, m.IMDBPoint  FROM Movies m

CREATE VIEW V_GetMovieInfo AS
SELECT m.Name  'MovieName', m.IMDBPoint, g.Name AS Genre,d.Name AS DirectorName, a.Name AS ActorName
FROM Movies m
JOIN Directors d
ON m.Name = d.Name
JOIN MoviesActors ms
ON m.Id = ms.MovieId
JOIN Actors a
On a.Id = ms.ActorId
JOIN MoviesGenres mg
ON m.Id = mg.MovieId
JOIN Genres g
ON mg.GenreId = g.Id

SELECT * FROM V_GetMovieInfo

CREATE VIEW V_MovieNameGenre AS
SELECT m.Name, LEN(g.Name) 'Movies Genre'
FROM Movies m
JOIN MoviesGenres mg
ON m.Id = mg.MovieId
JOIN Genres g
ON mg.GenreId = g.Id
GROUP BY g.Name	
=======
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

DROP DATABASE Course;
>>>>>>> b3a86d4b3e319052f247ce48b0569eeb1d4dec55
