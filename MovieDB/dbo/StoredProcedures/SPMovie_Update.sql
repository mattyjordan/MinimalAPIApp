CREATE PROCEDURE [dbo].[spMovie_Update]
	@Id int,
	@MovieName nvarchar(50),
	@ReleaseYear smallint	
AS
BEGIN
	UPDATE dbo.Movie 
	SET MovieName = @MovieName, ReleaseYear = @ReleaseYear
	WHERE Id = @Id
END

