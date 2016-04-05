CREATE TABLE [Clinic].[Clinic]
(
	[ClinicId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(75),
	[AddressId] INT FOREIGN KEY REFERENCES [Core].[Address]([AddressId]) NOT NULL,
	[MondayStart] DATETIME,
	[MondayEnd] DATETIME,
	[TuesdayStart] DATETIME,
	[TuesdayEnd] DATETIME,
)
