--15--

SELECT COUNT(UserName) as Count_Users
FROM Users 
WHERE Id IN (SELECT AuthorId
			 FROM Posts
			 WHERE Date = '2016-06-14')

--16--

SELECT *
FROM Posts
WHERE Date = '2016-06-14'
ORDER BY AuthorId ASC

--17--

SELECT * 
FROM Posts
WHERE Date = (SELECT MIN(Date)
			  FROM Posts
			  WHERE AuthorId = 2)

--18--

SELECT * FROM Comments
ORDER BY AuthorName ASC, Id DESC
