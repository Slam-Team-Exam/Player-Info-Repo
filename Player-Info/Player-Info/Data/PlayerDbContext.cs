using Microsoft.EntityFrameworkCore;
using Player_Info.Entities;

namespace Player_Info.Data
{
    public class PlayerDbContext(DbContextOptions<PlayerDbContext> options) : DbContext(options)
    {
        public DbSet<Player> Players { get; set; }
    }
}
