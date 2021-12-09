IF NOT EXISTS (SELECT 1 FROM dbo.Movie)
BEGIN
	INSERT INTO dbo.Movie (MovieName, ReleaseYear)
	VALUES	('Shawshank Redemption', 1994),
			('The Godfather', 1972),
			('The Godfather: Part II',1974),
			('The Dark Knight', 2008);
END
