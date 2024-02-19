using Entidades.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Context;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PeliculasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pelicula>> GetAllMovies()
        {
            return await _context.Peliculas.ToListAsync();
        }

        public async Task<Pelicula> GetMovieById(int movieId)
        {
            return await _context.Peliculas.FindAsync(movieId);
        }

        public async Task AddMovie(Pelicula movie)
        {
            _context.Peliculas.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMovie(Pelicula movie)
        {
            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMovie(int movieId)
        {
            var movie = await _context.Peliculas.FindAsync(movieId);
            if (movie != null)
            {
                _context.Peliculas.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }
    }
}
