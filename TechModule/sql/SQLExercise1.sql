SELECT * FROM [Blog].[dbo].[Posts]

SELECT * FROM [Blog].[dbo].[Users]

SELECT 
	title, body
FROM 
	[Blog].[dbo].[Posts];

SELECT
	username, fullname
FROM
	[Blog].[dbo].[Users]
ORDER BY username ASC

SELECT
	username, fullname
FROM
	[Blog].[dbo].[Users]
ORDER BY fullname DESC, username ASC

SELECT *
FROM Users
WHERE id IN (SELECT AuthorID
			FROM Posts)

SELECT u.Username, p.Title
FROM Users u
	JOIN
	Posts p ON u.ID = p.AuthorId

SELECT Username, FullName
FROM Users
WHERE id IN (SELECT	AuthorId
			 FROM Posts
			 WHERE id = 4)

SELECT Username, FullName
FROM Users
WHERE ID IN (SELECT	AuthorId
			 FROM Posts)
ORDER BY ID DESC

INSERT INTO [Blog].[dbo].[Posts] ([AuthorId], [Title], [Body], [Date])
	VALUES (2, 'Random Title', 'Random Content', CAST('2016-07-13T11:30:00' AS DateTime))

UPDATE [Blog].[dbo].[Posts] 
SET Title = 'New Title' 
WHERE Id = 31

DELETE FROM [Blog].[dbo].[Posts]
WHERE Id = 31

SELECT COUNT(*) as Posts_Count
FROM [Blog].[dbo].[Posts]

SELECT COUNT(*) as Posts_Count
FROM [Blog].[dbo].[Posts]
WHERE AuthorId = 2

SELECT MIN(AuthorId) as Min_Value
FROM [Blog].[dbo].[Posts]

SELECT MIN(Date) as Min_Value
FROM [Blog].[dbo].[Posts]

SELECT MAX(AuthorId) as Max_Value 
FROM [Blog].[dbo].[Posts]

SELECT MAX(Id) as Max_Value 
FROM [Blog].[dbo].[Tags]

SELECT SUM(Id) AS Sum_Ids 
FROM [Blog].[dbo].[Tags]

SELECT SUM(Id) AS Sum_Users_With_Posts_Ids 
FROM [Blog].[dbo].[Users]
WHERE Id IN (SELECT AuthorId
			 FROM Posts)

