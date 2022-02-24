/*******************************************************************************
   Drop database if it exists
********************************************************************************/

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'MarvelUniverseDb')
BEGIN
	ALTER DATABASE [MarvelUniverseDb] SET OFFLINE WITH ROLLBACK IMMEDIATE;
	ALTER DATABASE [MarvelUniverseDb] SET ONLINE;
	DROP DATABASE [MarvelUniverseDb];
END

GO

/*******************************************************************************
   Create database
********************************************************************************/

CREATE DATABASE [MarvelUniverseDb];
GO

USE [MarvelUniverseDb];
GO