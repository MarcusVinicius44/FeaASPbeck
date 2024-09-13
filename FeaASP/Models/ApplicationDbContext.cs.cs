
using Microsoft.EntityFrameworkCore;

namespace FEAasp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<contatos> contato { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<contatos>()
                .HasKey(c => c.idContato); // Define a chave primária
        }
        internal bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}
