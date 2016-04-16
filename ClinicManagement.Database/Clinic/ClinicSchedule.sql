CREATE TABLE [Clinic].[ClinicSchedule]
(
	[ClinicScheduleId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[DayId] INT FOREIGN KEY REFERENCES [Core].[Day]([DayId]) NOT NULL,
	[StartTime] TIME NOT NULL,
	[EndTime] TIME NOT NULL,
)
