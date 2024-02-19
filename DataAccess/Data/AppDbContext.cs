using Entidades.Modelos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace WebApi.Context
{
    public class AppDbContext: IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                 : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; } = default!;
    }
}
