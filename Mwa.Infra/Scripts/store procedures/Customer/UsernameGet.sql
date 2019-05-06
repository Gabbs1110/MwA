CREATE PROCEDURE UsernameGet
        @UserName VARCHAR(40) 
AS
	
SELECT [Id], CONCAT([FirstName], ' ', [LastName]) AS [Name], [BirthDate], [Document],
        [UserName], [Password], [Active]

FROM [Customer]
WHERE [UserName] = @UserName