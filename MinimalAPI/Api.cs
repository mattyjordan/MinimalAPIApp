namespace MinimalAPI;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {        
        app.MapGet(pattern:"/Movies", GetMovies);
        app.MapGet(pattern: "/Movies/{id}", GetMovie);
        app.MapPost(pattern: "/Movies", InsertMovie);
        app.MapPut(pattern: "/Movies", UpdateMovie);
        app.MapDelete(pattern: "/Movies", DeleteMovie);
    }

    private static async Task<IResult> GetMovies(IMovieData data) 
    {
        try
        {
            return Results.Ok(await data.GetMovies());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetMovie(int id, IMovieData data)
    {
        try
        {
            var result = await data.GetMovie(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
            
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertMovie(MovieModel movie, IMovieData data)
    {
        try
        {
            await data.InsertMovie(movie);
            return Results.Ok();    


        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateMovie(MovieModel movie, IMovieData data)
    {
        try
        {
            await data.UpdateMovie(movie);
            return Results.Ok();

        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteMovie(int id, IMovieData data)
    {
        try
        {
            await data.DeleteMovie(id);
            return Results.Ok();

        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
