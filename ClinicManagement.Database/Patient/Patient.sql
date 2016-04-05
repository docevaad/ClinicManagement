CREATE TABLE [Patient].[Patient]
(
	[PatientId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[PersonId] INT FOREIGN KEY REFERENCES [Person].[Person]([PersonId]) NOT NULL,
	[ModifiedDate] DATETIME NOT NULL
)
