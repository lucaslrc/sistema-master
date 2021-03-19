using Microsoft.EntityFrameworkCore;
using sistema.Models;

namespace sistema.Data
{
    public class SistemaContext : DbContext
    {
        public DbSet<Noticia> noticias { get; set; }
        public DbSet<Comentario> comentarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=172.17.0.2;Database=my_db;Username=postgres;Password=mysecretpassword");
    }
}