# BDE_AZUBI_LEXIKON
Zum üben der wichtigsten Grundbegriffe für Azubis und Praktikanten im Bereich Betriebsdatenerfassung


Zum erstellen der für LEXUBI benötigten Datenbank:
(Merke, dass für das funktionieren aller gepl. Funktionen der Datensatz in beide Richtungen für jeden Anwender erreichbar sein muss (für interne Verwendung reicht erstmal der Server, ansonsten könnte man das über HighTechLowLife machen?))
===============================================================================================================================================================================================================================================================================================
CREATE DATABASE LEXUBI_DB;
DROP TABLE IF EXISTS LEXUBI_DB.dbo.Lex;
CREATE TABLE Lex (
    Lex_Id smallint IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Kat_Id smallint ,
    Lex_Name varchar(42) NOT NULL,
	Lex_Longname varchar(69),
    Lex_Description varchar(2077),
    Lex_Commentary varchar(1001),
    Lex_Ind1 varchar(23)
);
DROP TABLE IF EXISTS LEXUBI_DB.dbo.Kat;
CREATE TABLE Kat (
    Kat_Id smallint IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Kat_Name varchar(42) NOT NULL,
    Kat_Description varchar(2077),
    Kat_Ind1 varchar(23)
);
================================================================================================================================================================================================================================================================================================
USE [LEXUBI_DB]
GO

INSERT INTO [dbo].[Kat]
           ([Kat_Name]
           ,[Kat_Description]
           ,[Kat_Ind1])
     VALUES
           ('Test Kat_Name'
           , 'Test Kat_Despription'
           , 'Test Kat_Ind1')
GO
====
INSERT INTO LEXUBI_DB.dbo.Lex (Lex_Id, Kat_Id, Lex_Name, Lex_Longname, Lex_Description, Lex_Commentary, Lex_Ind1)
VALUES (1, 'Test Lex_Name', 'Test Lex_Longname', 'Test Lex_Description', 'Test Lex_Commentary', 'Test Lex_Ind1');
