using System.Data.Entity;

namespace GameStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}