CREATE PROCEDURE [dbo].[spMovie_Delete]
	@Id int
AS
BEGIN
	DELETE 
	FROM dbo.Movie
	WHERE Id = @Id; 
END

