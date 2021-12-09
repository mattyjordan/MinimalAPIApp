CREATE PROCEDURE [dbo].[spMovie_Get]
	@Id int
AS
BEGIN
	SELECT Id, MovieName, ReleaseYear  
	FROM dbo.Movie	
	WHERE Id = @Id; 
END

