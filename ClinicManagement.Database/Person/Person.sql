CREATE TABLE [Person].[Person]
(
	[PersonId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Title] NVARCHAR(10),
	[FirstName] NVARCHAR(50) NOT NULL,
	[MiddleName] NVARCHAR(50),
	[LastName] NVARCHAR(50) NOT NULL,
	[Suffix] NVARCHAR(10),
	[ModifiedDate] DATETIME NOT NULL,
)
