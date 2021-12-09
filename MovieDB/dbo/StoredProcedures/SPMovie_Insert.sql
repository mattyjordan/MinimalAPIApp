CREATE PROCEDURE [dbo].[spMovie_Insert]
	@MovieName nvarchar(50),
	@ReleaseYear smallint
AS
BEGIN
	INSERT INTO dbo.Movie (MovieName, ReleaseYear)
	VALUES (@MovieName, @ReleaseYear)
END

