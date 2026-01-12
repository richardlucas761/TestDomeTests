SELECT e1.[name] FROM [dbo].Employees e1 
LEFT JOIN [dbo].[Employees] e2 ON e1.[id] = e2.[ManagerId]
WHERE e2.ManagerId IS NULL

/*
-- Sandbox scripts

-- A sub-select like this is probably not efficient
SELECT [Id]
      ,[ManagerId]
      ,[Name]
      ,(select count(1) from employees e2 where e1.id = e2.ManagerId) as [IsManager]
  FROM [dbo].[Employees] e1

select * from [database]..Employees
*/