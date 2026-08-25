using Microsoft.EntityFrameworkCore;
using SistemaRodeio.Models;

namespace SistemaRodeio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TipoAnimal> TiposAnimais { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Competidor> Competidores { get; set; }
        public DbSet<Round> Rounds { get; set; }
    }
}