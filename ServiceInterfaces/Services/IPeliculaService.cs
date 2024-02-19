using Entidades.Modelos;

namespace ServiceInterfaces.Services
{
    public interface IPeliculaService
    {
            Task<List<Pelicula>> GetAllMovies();
            Task<Pelicula> GetMovieById(int movieId);
            Task AddMovie(Pelicula movie);
            Task UpdateMovie(Pelicula movie);
            Task DeleteMovie(int movieId);
        
    }
}
