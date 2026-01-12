SELECT [userId], AVG([duration]) FROM [sessions]
GROUP BY [userId] 
HAVING count(1) > 1
