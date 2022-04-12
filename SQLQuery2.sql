CREATE DATABASE CinamaDb

USE CinamaDb

CREATE TABLE Movies(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(255),
Duration Time,
)

CREATE TABLE Genres(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(255),
)

CREATE TABLE MoviesGenres(
Id int PRIMARY KEY IDENTITY,
FOREIGN KEY (Id) REFERENCES Movies(Id), 
FOREIGN KEY (Id) REFERENCES Genres(Id) 
)

CREATE TABLE Actors
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(255),
Surname nvarchar(255),
)

CREATE TABLE MoviesActors(
Id int PRIMARY KEY IDENTITY,
FOREIGN KEY (Id) REFERENCES Movies(Id), 
FOREIGN KEY (Id) REFERENCES Actors(Id) 
)

CREATE TABLE Halls
(
Id int PRIMARY KEY IDENTITY,
[Name] nvarchar(255),
Seats INTEGER,
)

CREATE TABLE [Sessions]
(
Id int PRIMARY KEY IDENTITY,
[start] time,
[end] time
FOREIGN KEY (Id) REFERENCES Movies(Id),
FOREIGN KEY (Id) REFERENCES Halls(Id) 
)

CREATE TABLE Customer
(
Id int PRIMARY KEY IDENTITY,
FullName nvarchar(255),
Phone nvarchar(255),
)

CREATE TABLE Tickets
(
Id int PRIMARY KEY IDENTITY,
[Type] nvarchar(255),
Price float,
FOREIGN KEY (Id) REFERENCES [Sessions](Id),
FOREIGN KEY (Id) REFERENCES Customer(Id) 
)


