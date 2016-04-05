﻿CREATE TABLE [Core].[Address]
(
	[AddressId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Line1] VARCHAR(100) NOT NULL,
	[Line2] VARCHAR(100),
	[City] VARCHAR(50),
	[StateId] CHAR(2) FOREIGN KEY REFERENCES [Core].[State]([StateId]) NOT NULL,
	[ZipCode] CHAR(9) NOT NULL,
	[isPrimary] BIT NOT NULL,
)
