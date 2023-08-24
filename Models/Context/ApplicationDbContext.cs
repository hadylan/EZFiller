using Microsoft.EntityFrameworkCore;

namespace EZFiller.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Ajoutez vos DbSet pour chaque modèle ici
        public DbSet<UserModel> UserModel { get; set; }
    }
}
