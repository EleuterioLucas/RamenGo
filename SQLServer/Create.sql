CREATE DATABASE RamenGo
GO

USE RamenGo
GO

CREATE TABLE Broth (
	id int IDENTITY(1,1) PRIMARY KEY,
	imageInactive VARCHAR(255),
	imageActive VARCHAR(255),
	name VARCHAR(255),
	description VARCHAR(255),
	price SMALLMONEY
)

CREATE TABLE Protein (
	id int IDENTITY(1,1) PRIMARY KEY,
	imageInactive VARCHAR(255),
	imageActive VARCHAR(255),
	name VARCHAR(255),
	description VARCHAR(255),
	price SMALLMONEY
)

CREATE TABLE OrderRamen (
	id int IDENTITY(1,1) PRIMARY KEY,
	brothID VARCHAR(255),
	proteinId VARCHAR(255),
	price SMALLMONEY
)
