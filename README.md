# TestDomeTests

My answers and improvements to the public tests found here https://www.testdome.com/

Methods will be refactored, rewritten for modern .NET, packages will be updated and coding issues in the public tests will be fixed.

## C#

### /AccountTest

C#, Unit Tests

https://www.testdome.com/questions/c-sharp/account-test/146077

#### Code smells / concerns

At the time of writing the code under test includes ```this.x``` statements where Visual Studio has been suggesting these should be removed for a long time?

**NUnit 3.12** was released in 2019, this code test seems out of date.

Deposits and withdrawls of zero are nonsensical.

```double.MinValue``` and ```double.MaxValue``` are preferred.

## SQL

Simple scripts will be included inline below, more complicated solutions have their own sub-folder.

### /Database

General purpose Microsoft SQL Server Database Project for use with SQL coding challenges.

### SQLWorkers

https://www.testdome.com/questions/sql/workers/102293

```
TBC
```

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

##### SQL script

*INT* can be used instead of *INTEGER*.

 We could use INT IDENTITY(1, 1) for the primary key but this is "good enough".

It's good practice to enclose column names with [] braces, particularly for reserved words like ```[name]```.

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

### SQLSessions

Microsoft SQL Server / TSQL

https://www.testdome.com/questions/sql/sessions/147182

There is a file ```sessionsSolution.sql``` with the same content in the sub directory but perhaps it would be simpler to just paste the SQL here! More discoverable in this README or in a file? 😊

```
SELECT [userId], AVG([duration]) FROM [sessions]
GROUP BY [userId] 
HAVING count(1) > 1
```

