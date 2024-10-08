--
IF NOT EXISTS 
(
	SELECT 11
	FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Person'
	AND TABLE_SCHEMA = 'dbo'
)
BEGIN
	CREATE TABLE dbo.Person 
	(
		  ID 				INT 				IDENTITY(1, 1) NOT NULL PRIMARY KEY
		, CreateDate 		DATETIME 			NOT NULL DEFAULT GETDATE()
		, Creator 			VARCHAR(100)		NOT NULL
		, ModifyDate 		DATETIME 			NULL
		, Modifier 			VARCHAR(20) 		NULL

		, FirstName 		VARCHAR(150) 		NOT NULL
		, LastName 			VARCHAR(1000) 		NOT NULL		
	)
ON [PRIMARY]
END
GO


select * from dbo.Person
/* Data for the `dbo.Person` table  (Records 1 - 15) */
/*
INSERT INTO dbo.Person
(
	Creator, 
	FirstName, 
	LastName
)
VALUES 
(
	'creator 1', 
	'first name 1', 
	'last name 1'
)
, (
	'creator 2', 
	'first name 2', 
	'last name 2'
)
, (
	'creator 3', 
	'first name 3', 
	'last name 3'
)
, (
	'creator 4', 
	'first name 4', 
	'last name 4'
)
, (
	'creator 5', 
	'first name 5', 
	'last name 5'
)
, (
	'creator 6', 
	'first name 6', 
	'last name 6'
)
, (
	'creator 7', 
	'first name 7', 
	'last name 7'
)
, (
	'creator 8', 
	'first name 8', 
	'last name 8'
)
, (
	'creator 9', 
	'first name 9', 
	'last name 9'
)
, (
	'creator 10', 
	'first name 10', 
	'last name 10'
)
, (
	'creator 11', 
	'first name 11', 
	'last name 11'
)
, (
	'creator 12', 
	'first name 12', 
	'last name 12'
)
, (
	'creator 13', 
	'first name 13', 
	'last name 13'
)
, (
	'creator 14', 
	'first name 14', 
	'last name 14'
)
, (
	'creator 15', 
	'first name 15', 
	'last name 15'
)
*/
