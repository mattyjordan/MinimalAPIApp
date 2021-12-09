CREATE PROCEDURE [dbo].[spMovie_GetAll]
AS
BEGIN
	SELECT Id, MovieName, ReleaseYear  
	FROM dbo.Movie; 
END

