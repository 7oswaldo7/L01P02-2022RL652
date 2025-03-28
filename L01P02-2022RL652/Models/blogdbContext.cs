using Microsoft.EntityFrameworkCore;

namespace L01P02_2022RL652.Models
{
    public class blogdbContext : DbContext
    {
        public blogdbContext(DbContextOptions<blogdbContext> options) : base(options)
        {
        }

        public DbSet<roles> roles { get; set; }

        public DbSet<usuarios> usuarios { get; set; }

        public DbSet<calificaciones> calificaciones { get; set; }

        public DbSet<comentarios> comentarios { get; set; }

        public DbSet<publicaciones> publicaciones { get; set; } 

    }
}
