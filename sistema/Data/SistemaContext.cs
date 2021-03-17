using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sistema
{
    public class SistemaContext : DbContext
    {
        public DbSet<Noticia> noticias { get; set; }
        public DbSet<Comentario> comentarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=172.17.0.2;Database=my_db;Username=postgres;Password=mysecretpassword");
    }

    public class Noticia
    {
        public long NoticiaID { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }

    public class Comentario
    {
        public long ComentarioID { get; set; }
        public string ComentarioTexto { get; set; }
        public long NoticiaID { get; set; }
        public Noticia Noticia { get; set; }
    }
}