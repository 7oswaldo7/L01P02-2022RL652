using Microsoft.EntityFrameworkCore;

namespace L01P02_2022RL652.Models
{
    public class blogdbContext : DbContext
    {
        public blogdbContext(DbContextOptions<blogdbContext> options) : base(options)
        {
        }

        public DbSet<Roles> roles { get; set; }

        public DbSet<Usuarios> usuarios { get; set; }

        public DbSet<Calificaciones> calificaciones { get; set; }

        public DbSet<Comentarios> comentarios { get; set; }

        public DbSet<Publicaciones> publicaciones { get; set; } 

    }
}
