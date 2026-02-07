# TestDomeTests

My answers and improvements to the public tests found here https://www.testdome.com/

Methods will be refactored, rewritten for modern .NET, packages will be updated and coding issues in the public tests will be fixed.

## C#

#### General Code smells / concerns

At the time of writing the code under test includes ```this.x``` statements where Visual Studio has been suggesting these should be removed for a long time. The C# code seems old?

### /AccountTest

C#, Unit Tests

https://www.testdome.com/questions/c-sharp/account-test/146077

#### Code smells / concerns

**NUnit 3.12** was released in 2019, this code test seems out of date.

Deposits and withdrawls of zero are nonsensical.

```double.MinValue``` and ```double.MaxValue``` are preferred.

### /AlertService

C#, Refactoring

https://www.testdome.com/questions/c-sharp/alert-service/96005

#### Notes

Noted in the new code but we probably want to store any date/times as UTC, simpler to store everything as UTC and then translate it back into the user's time zone for display, etc.

### /GamePlatform

C#

https://www.testdome.com/questions/c-sharp/game-platform/134803

#### Notes

##### Poor choice of data type

```public static double CalculateFinalSpeed(double initialSpeed, int[] inclinations)```

```int``` is a poor choice of variable type here as the inclinations will be in the range 0..90

```sbyte	-128 to 127``` would be a better choice.

##### Issue with the examples provided?

Implementing the test case as described in the image gives the expected final speed.

Implementing the test case as described in the text for the coding challenge does not?

Or there is something more subtle here I'm missing.

## SQL

Simple scripts will be included inline below, more complicated solutions have their own sub-folder.

### /Database

General purpose Microsoft SQL Server Database Project for use with SQL coding challenges.

#### Online Alternative

https://sqliteonline.com

There is an online alternative here, referenced in the Test Demo example script:

https://www.testdome.com/files/question-media/cf228b4f-3fbd-47b6-ac7f-1dbadf35c780/workers.txt

### /SQLWorkers

https://www.testdome.com/questions/sql/workers/102293

Solution SQL is here:

```\SQLWorkers\SQLWorkersSolution.sql```

#### Expected output

```
-- Expected output (in any order):
-- name
-- ----
-- Mike

-- Explanation:
-- In this example.
-- John is Mike's manager. Mike does not manage anyone.
-- Mike is the only employee who does not manage anyone.
```

#### Smells / Concerns

https://www.testdome.com/files/question-media/cf228b4f-3fbd-47b6-ac7f-1dbadf35c780/workers.txt

*INT* can be used instead of *INTEGER*.

It's good practice to enclose column names with [] braces, particularly for reserved words like ```[name]```.

It's good practice to fully qualify the schema; this is better ```[dbo].[Employees]```.

This syntax is fine for ad-hoc queries ```select * from [database]..Employees``` but this may break later if the Employees table moves to a different schema ```[Staff].[Employees]```.

We could use INT IDENTITY(1, 1) rather than explicitly specifying the primary key values here but this is "good enough".

```
CREATE TABLE employees (
  id INTEGER NOT NULL PRIMARY KEY,
  managerId INTEGER, 
  name VARCHAR(30) NOT NULL,
  FOREIGN KEY (managerId) REFERENCES employees(id)
);

INSERT INTO employees(id, managerId, name) VALUES(1, NULL, 'John');
INSERT INTO employees(id, managerId, name) VALUES(2, 1, 'Mike');
```

### SQL Sessions

Microsoft SQL Server / TSQL

https://www.testdome.com/questions/sql/sessions/147182

There is a file ```sessionsSolution.sql``` with the same content in the sub directory but perhaps it would be simpler to just paste the SQL here! More discoverable in this README or in a file? 😊

Solution SQL.

```
SELECT [userId], AVG([duration]) FROM [sessions]
GROUP BY [userId] 
HAVING count(1) > 1
```

### SQL Dictionary Search

Microsoft SQL Server / TSQL

https://www.testdome.com/questions/sql/dictionary-search/139387

Solution SQL.

```
SELECT COUNT(1) FROM [Dictionary] WHERE [Word] LIKE '%bid%'
```

### Enrollment

Microsoft SQL Server / TSQL

https://www.testdome.com/questions/sql/enrollment/148372

Solution SQL.

```
UPDATE [enrollments] SET [year] = 2015
WHERE ID BETWEEN 20 AND 100
```

### Student Name

https://www.testdome.com/questions/sql/student-name/134897

Solution SQL.

```
SELECT COUNT(1) FROM [students]
WHERE [firstName] = 'John'
```
