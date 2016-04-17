CREATE VIEW [Patient].[vPatientPerson]
AS
SELECT [pat].[PatientId], [psn].[Title], [psn].[FirstName], [psn].[MiddleName], [psn].[LastName], [psn].[Suffix]
FROM [Patient].[Patient] AS pat
JOIN [Person].[Person] AS psn ON [psn].[PersonId]=[pat].[PersonId]
