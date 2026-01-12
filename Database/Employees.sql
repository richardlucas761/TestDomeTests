CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[ManagerId] INT,
	[Name] VARCHAR(30) NOT NULL,
	FOREIGN KEY ([ManagerId]) REFERENCES [Employees]([Id])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Employee unique identifier',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Employees',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'If present this indicates who the employee''s manager is',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Employees',
    @level2type = N'COLUMN',
    @level2name = N'ManagerId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Employee full name',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Employees',
    @level2type = N'COLUMN',
    @level2name = N'Name'