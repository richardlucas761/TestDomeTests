CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[ManagerId] INT,
	[Name] VARCHAR(30) NOT NULL,
	FOREIGN KEY ([ManagerId]) REFERENCES [Employees]([Id])
)
