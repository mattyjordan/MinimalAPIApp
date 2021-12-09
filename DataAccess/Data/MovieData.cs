using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class MovieData : IMovieData
{
    private readonly ISqlDataAccess _db;

    public MovieData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<MovieModel>> GetMovies() =>
        _db.LoadData<MovieModel, dynamic>(storedProcedure: "dbo.spMovie_GetAll", new { });

    public async Task<MovieModel?> GetMovie(int id)
    {
        var results = await _db.LoadData<MovieModel, dynamic>(storedProcedure: "dbo.spMovie_Get",
                                                              new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertMovie(MovieModel movie) =>
        _db.SaveData(storedProcedure: "dbo.spMovie_Insert", parameters: new { movie.MovieName, movie.ReleaseYear });

    public Task UpdateMovie(MovieModel movie) =>
        _db.SaveData(storedProcedure: "dbo.spMovie_Update", movie);

    public Task DeleteMovie(int id) =>
        _db.SaveData(storedProcedure: "dbo.spMovie_Delete", new { Id = id });
}
