/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/* Employees */

TRUNCATE TABLE [Employees]
GO

INSERT INTO [dbo].[Employees] ([Id], [ManagerId], [Name]) VALUES (1, NULL, 'John')
INSERT INTO [dbo].[Employees] ([Id], [ManagerId], [Name]) VALUES (2, 1, 'Mike')
GO

