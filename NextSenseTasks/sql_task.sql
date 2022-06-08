SELECT p1.Name AS Name, MIN(p2.Age) AS Age
FROM People p1
INNER JOIN People p2 on p1.Id = p2.MotherId OR p1.Id == p2.FatherId
GROUP by p1.Id